'
' This is a simpel (but fun) project I did during work-innovation week.
' It's a ATM / Investment estimation application - that replicates real life ATM's and banking websites
' All code is created by me, myself and I. As you more experianced developers probably can tell.. :)
'
' This class will give the user the option too withdraw or deposit money into their account.
' The user can press the cardslot-button to switch between users.
' Once a user is selected through the cardslot - withdraws and deposits will be saved to the account upon pressing the 'exit' - button and leaving the application 
' The code can handle some common user-input errors, and also constrain the users deposits and withdraws to logical rules.
' Such as a user can't withdraw more money than there is in their account.
'
' The user may at any time go to the Savings-form - where they can get an estimation of growth on their investments
' Finaly the user may exit the application - upon which their final accountbalance will be saved.
'
' @author  Lukas Hjernquist
' @version 1.0, 2024/09/13
' @since   .NET Framework 4.7.2
'
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class MyBankATM

    'Global variabels userinformation
    Private userAccountId As String

    Private userAccountBalance As Double

    Private userAccountRef As Integer

    Private userDeposit As Double = 0

    Private userWithdraw As Double = 0



    'Global variables for application

    Private intExitTimer As Integer = 5

    Private intSavefileTimer As Integer = 10

    Private dblDepositingTimer As Double = 0

    Private dblWithdrawTimer As Double = 0

    Private BtnDepositClicks As Integer = 0

    Private BtnWithdrawClicks As Integer = 0

    Private BtnBalanceClicks As Integer = 0

    Private BtnAccountRefClicks As Integer = 0



    'Initialize GUIHandler

    Private guiHandlerATM As GUIHandlerATM = New GUIHandlerATM()



    'Initialize SaveFileHandler

    Private sfh As SaveFileHandler = New SaveFileHandler()



    'Initialize userInformationClass

    Private uic As userInformationClass



    'Setting initial parameters for the application

    Private Sub SetApplicationVisability() Handles MyClass.Activated

        guiHandlerATM.HideAllFormAssets()

        'Reset app-variables on form-activision

        intExitTimer = 5

        intSavefileTimer = 10

        dblDepositingTimer = 0

        dblWithdrawTimer = 0

        BtnDepositClicks = 0

        BtnWithdrawClicks = 0

        BtnBalanceClicks = 0

    End Sub



    Private Sub MyBankATM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.IsMdiContainer = True

        'no user is logged-in on application startup

        userAccountRef = 0

        uic = New userInformationClass()

        uic.SetUserRef(userAccountRef)

        userAccountId = uic.GetUserId()

        userAccountBalance = uic.GetMoneyInAccount()

        sfh.SetFilePath(userAccountRef)

    End Sub



    Private Sub Deposit_Click(sender As Object, e As EventArgs) Handles BtnDeposit.Click

        BtnDepositClicks += 1



        If BtnDepositClicks = 1 Then

            If InputWithdraw.Visible = True Then

                guiHandlerATM.HideErrorWithdrawAsset()

            ElseIf TxtAccountBalance.Visible = True Then

                BtnBalanceClicks = 0

            End If



            guiHandlerATM.ShowInputDepositAsset()



        ElseIf BtnDepositClicks > 1 Then

            If InputDeposit.Text <> "" And IsNumeric(InputDeposit.Text) = True Then



                If TxtErrorDeposit.Visible = True Then

                    guiHandlerATM.HideErrorDepositAsset()

                    TxtErrorDeposit.Text = ""

                End If



                userDeposit = CDbl(InputDeposit.Text)

                guiHandlerATM.HideInputDepositAsset()

                guiHandlerATM.ShowProcessingAsset()

                TimerDeposit.Start()



            ElseIf InputDeposit.Text = "" Then

                TxtErrorDeposit.Text = "*No deposit amount was provided"

                guiHandlerATM.ShowErrorDepositAsset()



            ElseIf Not IsNumeric(InputDeposit.Text) Then

                TxtErrorDeposit.Text = "*Only numbers allowed"

                guiHandlerATM.ShowErrorDepositAsset()



            End If

        End If





    End Sub



    Private Sub Withdraw_Click(sender As Object, e As EventArgs) Handles BtnWithdraw.Click

        BtnWithdrawClicks += 1



        If BtnWithdrawClicks = 1 Then

            If InputDeposit.Visible = True Then

                guiHandlerATM.HideErrorDepositAsset()

            ElseIf TxtAccountBalance.Visible = True Then

                BtnBalanceClicks = 0

            End If



            guiHandlerATM.ShowInputWithdrawAsset()



        ElseIf BtnWithdrawClicks > 1 Then

            If InputWithdraw.Text <> "" And IsNumeric(InputWithdraw.Text) = True Then



                If TxtErrorWithdraw.Visible = True Then

                    guiHandlerATM.HideErrorWithdrawAsset()

                    TxtErrorWithdraw.Text = ""

                End If



                userWithdraw = CDbl(InputWithdraw.Text)



                If (userAccountBalance - userWithdraw) < 0 Then

                    InputWithdraw.Text = ""

                    TxtErrorWithdraw.Text = "*Insufficent funds on account"

                    guiHandlerATM.ShowErrorWithdrawAsset()

                Else

                    guiHandlerATM.HideInputWithdrawAsset()

                    guiHandlerATM.ShowProcessingAsset()

                    TimerWithdraw.Start()

                End If



            ElseIf InputWithdraw.Text = "" Then

                TxtErrorWithdraw.Text = "*No withdraw amount was provided"

                guiHandlerATM.ShowErrorWithdrawAsset()



            ElseIf Not IsNumeric(InputWithdraw.Text) Then

                TxtErrorWithdraw.Text = "*Only numbers allowed"

                guiHandlerATM.ShowErrorWithdrawAsset()



            End If

        End If





    End Sub



    Private Sub BtnCheckBalance_Click(sender As Object, e As EventArgs) Handles BtnCheckBalance.Click

        BtnBalanceClicks += 1



        If BtnBalanceClicks = 1 Then

            TxtAccountBalance.Text = userAccountBalance & " sek"

            guiHandlerATM.ShowAccountBalanceAssets()

        Else

            BtnBalanceClicks = 0

        End If





    End Sub



    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        guiHandlerATM.HideAccountBalanceAssets()

        guiHandlerATM.ShowExitText()

        TimerSavefile.Start()



    End Sub

    Private Sub BtnCancelExit_Click(sender As Object, e As EventArgs) Handles BtnCancelExit.Click



        If TxtExit.Visible = True Then

            guiHandlerATM.HideExitText()

            BtnBalanceClicks = 0

            TimerSavefile.Stop()

            TimerExit.Stop()

            intSavefileTimer = 10

            intExitTimer = 5

            TxtExit.Text = ""

        End If



    End Sub



    Private Sub TimerExit_Tick(sender As Object, e As EventArgs) Handles TimerExit.Tick

        intExitTimer -= 1

        If intExitTimer <= 5 And intExitTimer >= 2 Then

            TxtExit.Text = "Exiting in " & intExitTimer & "..."

        ElseIf intExitTimer < 2 And intExitTimer > 0 Then

            TxtExit.Text = "Exiting..."

        ElseIf intExitTimer < 0 Then

            TimerExit.Stop()

            intExitTimer = 5

            ProgramClosing()

        End If

    End Sub



    Private Sub TimerSavefile_Tick(sender As Object, e As EventArgs) Handles TimerSavefile.Tick

        intSavefileTimer -= 1

        TxtExit.Text = "Saving session details..." & intSavefileTimer

        SaveUserInformation()

        If intSavefileTimer < 6 Then

            TimerSavefile.Stop()

            intSavefileTimer = 10

            TimerExit.Start()

        End If

    End Sub



    Private Sub TimerDeposit_Tick(sender As Object, e As EventArgs) Handles TimerDeposit.Tick

        dblDepositingTimer += 0.5

        If dblDepositingTimer < 1.0 Then

            TxtProcessing.Text = "Depositing."

        ElseIf dblDepositingTimer < 2.0 And dblDepositingTimer > 1.0 Then

            InputDeposit.Text = ""

            TxtProcessing.Text = "Depositing.."

            guiHandlerATM.ShowAccountBalanceAssets()

            TxtAccountBalance.Text = ". . ."

        ElseIf dblDepositingTimer < 3.0 And dblDepositingTimer > 2.0 Then

            TxtProcessing.Text = "Depositing..."

        End If

        If dblDepositingTimer > 3.0 Then

            userAccountBalance = userAccountBalance + userDeposit

            TimerDeposit.Stop()

            dblDepositingTimer = 0

            BtnDepositClicks = 0

            TxtProcessing.Text = ""

            TxtAccountBalance.Text = userAccountBalance & " sek"

            uic.SetMoneyInAccount(userAccountBalance)

        End If

    End Sub



    Private Sub TimerWithdraw_Tick(sender As Object, e As EventArgs) Handles TimerWithdraw.Tick

        dblWithdrawTimer += 0.5



        If dblWithdrawTimer < 1.0 Then

            TxtProcessing.Text = "Withdrawing."

        ElseIf dblWithdrawTimer < 2.0 And dblWithdrawTimer > 1.0 Then

            InputWithdraw.Text = ""

            TxtProcessing.Text = "Withdrawing.."

            guiHandlerATM.ShowAccountBalanceAssets()

            TxtAccountBalance.Text = ". . ."

        ElseIf dblWithdrawTimer < 3.0 And dblWithdrawTimer > 2.0 Then

            TxtProcessing.Text = "Withdrawing..."

        End If

        If dblWithdrawTimer > 3.0 Then

            userAccountBalance = userAccountBalance - userWithdraw

            TimerWithdraw.Stop()

            dblWithdrawTimer = 0

            BtnWithdrawClicks = 0

            TxtProcessing.Text = ""

            TxtAccountBalance.Text = userAccountBalance & " sek"

            uic.SetMoneyInAccount(userAccountBalance)

        End If

    End Sub



    Private Sub ProgramClosing() Handles MyBase.FormClosing



        Application.Exit()



    End Sub



    Private Sub BtnCardslot_Click(sender As Object, e As EventArgs) Handles BtnCardslot.Click

        BtnAccountRefClicks += 1



        If BtnAccountRefClicks > 3 Then

            BtnAccountRefClicks = 0

        End If

        userAccountRef = BtnAccountRefClicks



        sfh.SetFilePath(userAccountRef)

        LoadUserInformation()

    End Sub



    Private Sub BtnSavings_Click(sender As Object, e As EventArgs) Handles BtnSavings.Click

        MyBankSavings.Show()

        Me.Hide()

    End Sub



    Public Function GetUserAccount() As String

        Return userAccountId

    End Function



    Public Function GetUserAccountBalance() As Double

        Return userAccountBalance

    End Function



    Public Function GetUserAccountRef() As Integer

        Return userAccountRef

    End Function



    Private Sub SaveUserInformation()

        Dim fs As FileStream

        fs = New FileStream(sfh.GetFilepath(), FileMode.Create)

        Dim bf As New BinaryFormatter()

        bf.Serialize(fs, uic)

        fs.Close()

    End Sub



    Private Sub LoadUserInformation()

        If My.Computer.FileSystem.FileExists(sfh.GetFilepath()) Then

            Dim fs As FileStream = New FileStream(sfh.GetFilepath(), FileMode.Open)

            Dim bf As New BinaryFormatter()

            Dim o As userInformationClass = CType(bf.Deserialize(fs), userInformationClass)

            userAccountId = o.GetUserId()

            userAccountBalance = o.GetMoneyInAccount()

            TxtUser.Text = userAccountId

            TxtAccountBalance.Text = userAccountBalance & " sek"

            fs.Close()

        Else

            'A user is initialized for the first time

            uic.SetUserRef(userAccountRef)

            userAccountId = uic.GetUserId()

            userAccountBalance = uic.GetMoneyInAccount()

            TxtUser.Text = userAccountId

            TxtAccountBalance.Text = userAccountBalance & " sek"

        End If

    End Sub



End Class



Public Class GUIHandlerATM

    Public Sub HideAllFormAssets()

        MyBankATM.TxtErrorDeposit.Visible = False

        MyBankATM.TxtErrorWithdraw.Visible = False

        MyBankATM.TxtExit.Visible = False

        MyBankATM.TxtAccountBalance.Visible = False

        MyBankATM.TxtAccountBalanceHeader.Visible = False

        MyBankATM.TxtProcessing.Visible = False

        MyBankATM.InputDeposit.Visible = False

        MyBankATM.InputWithdraw.Visible = False

    End Sub



    Public Sub HideAccountBalanceAssets()

        MyBankATM.TxtAccountBalance.Visible = False

        MyBankATM.TxtAccountBalanceHeader.Visible = False

    End Sub



    Public Sub ShowAccountBalanceAssets()

        MyBankATM.TxtAccountBalance.Visible = True

        MyBankATM.TxtAccountBalanceHeader.Visible = True

    End Sub



    Public Sub HideInputWithdrawAsset()

        MyBankATM.InputWithdraw.Visible = False

    End Sub



    Public Sub ShowInputWithdrawAsset()

        MyBankATM.InputWithdraw.Visible = True

    End Sub



    Public Sub HideInputDepositAsset()

        MyBankATM.InputDeposit.Visible = False

    End Sub



    Public Sub ShowInputDepositAsset()

        MyBankATM.InputDeposit.Visible = True

    End Sub



    Public Sub HideExitText()

        MyBankATM.TxtExit.Visible = False

    End Sub



    Public Sub ShowExitText()

        MyBankATM.TxtExit.Visible = True

    End Sub



    Public Sub ShowProcessingAsset()

        MyBankATM.TxtProcessing.Visible = True

    End Sub



    Public Sub HideProcessingAsset()

        MyBankATM.TxtProcessing.Visible = False

    End Sub



    Public Sub ShowErrorAssets()

        MyBankATM.TxtErrorDeposit.Visible = True

        MyBankATM.TxtErrorWithdraw.Visible = True

    End Sub



    Public Sub HideErrorAssets()

        MyBankATM.TxtErrorDeposit.Visible = False

        MyBankATM.TxtErrorWithdraw.Visible = False

    End Sub



    Public Sub ShowErrorWithdrawAsset()

        MyBankATM.TxtErrorWithdraw.Visible = True

    End Sub



    Public Sub HideErrorWithdrawAsset()

        MyBankATM.TxtErrorWithdraw.Visible = False

    End Sub



    Public Sub ShowErrorDepositAsset()

        MyBankATM.TxtErrorDeposit.Visible = True

    End Sub



    Public Sub HideErrorDepositAsset()

        MyBankATM.TxtErrorDeposit.Visible = False

    End Sub



    Public Sub ShowUserId()

        MyBankATM.TxtUser.Visible = True

    End Sub



    Public Sub HideUserId()

        MyBankATM.TxtUser.Visible = False

    End Sub



End Class



<Serializable()> Class userInformationClass

    Private userId As String

    Private userRef As Integer

    Private moneyInAccount As Double



    Public Sub New()

        userId = userId

        userRef = userRef

        moneyInAccount = moneyInAccount

    End Sub



    Public Function GetUserId() As String

        Return userId

    End Function



    Public Function GetMoneyInAccount() As Double

        Return moneyInAccount

    End Function



    Public Sub SetMoneyInAccount(userAccountBalance As Double)

        moneyInAccount = userAccountBalance

    End Sub



    Public Function GetUserRef() As Integer

        Return userRef

    End Function



    'will be used first time a user accesses their account.

    'After user is created and saved SetUserRef() and CreateUserId() won't be used

    Public Sub SetUserRef(intUserRef As Integer)

        userRef = intUserRef

        CreateUserId()

    End Sub



    Private Sub CreateUserId()

        If userRef = 1 Then

            userId = "user: " & " 19761017-4567"

            moneyInAccount = 0.0

        ElseIf userRef = 2 Then

            userId = "user: " & " 20070302-1234"

            moneyInAccount = 0.0

        ElseIf userRef = 3 Then

            userId = "user: " & " 19840723-9854"

            moneyInAccount = 0.0

        ElseIf userRef = 0 Then

            userId = "user: N/A"

            moneyInAccount = 0.0

        End If

    End Sub



End Class



Public Class SaveFileHandler

    Private filePath As String

    Private userRef As Integer = 0



    Public Function GetFilepath() As String

        If userRef = 0 Then

            CreateFilePath()

        End If

        Return filePath

    End Function



    Public Sub SetFilePath(intUserRef As Integer)

        userRef = intUserRef

        CreateFilePath()

    End Sub



    Private Sub CreateFilePath()

        If userRef > 0 And userRef <= 3 Then

            filePath = "user" & userRef & ".dat"

        ElseIf userRef = 0 Then

            filePath = "userNA.dat"

        End If

    End Sub



End Class
