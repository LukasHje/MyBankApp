'
' This is a simpel (but fun) project I did during work-innovation week.
' It's a ATM / Investment estimation application - that replicates real life ATM's and banking websites
' All code is created by me, myself and I. As you more experianced developers probably can tell.. :)
'
' This class will give the user an estimation of investment growth 
' Using the users initial Account balance together with parameters such as: montly deposits and number of years
' The code will calculate the growth of the users investment.
' The user can clear a estimation and try another montly deposit, number of years or change both.
'
' The user may at any time return to their ATM - where they can withdraw or deposit more money into their account.
'
' The users Account-balance is unaffected by their "investment estimations".
' So this page is currently a sandbox, in the future this page might have more advanced functionalitys
'
' @author  Lukas Hjernquist
' @version 1.0, 2024/09/13
' @since   .NET Framework 4.7.2
'
Public Class MyBankSavings



    'Global variabels userinformation

    Private userAccount As String

    Private userAccountSavings As Double

    Private userinputMonthlySavings As Integer

    Private userinputYears As Integer



    'Global variables for calculations

    Private AnnualInterestRate As Double = 1.08

    Private StartSavings As Double = 0

    Private NumYears As Integer = 0

    Private ExpectedSavings As Double = 0

    Private MonthlySavings As Double = 0

    Private SavedMoney As Double = 0

    Private ValueGrowth As Double = 0



    'Global variables for application

    Private dblTimerCalcSavings As Double = 0

    Private BtnSavingsClicks As Integer = 0

    Private BtnCalcSavingsClicks As Integer = 0

    Private BtnSubmitClicks As Integer = 0

    Private BtnClearClicks As Integer = 0



    'Initialize GUIHandler

    Private guiHandlerSavings As GUIHandlerSavings = New GUIHandlerSavings()



    'Setting initial parameters for the application

    Private Sub SetApplicationVisability() Handles MyClass.Activated

        'savings calculation details
        guiHandlerSavings.HideCalcSaveAssets()



        'savings header & sum
        guiHandlerSavings.HideAccountsavingsAssets()



        'input assets
        guiHandlerSavings.HideInputAssets()



        'others
        guiHandlerSavings.HideProcessingAsset()
        guiHandlerSavings.HideErrorAssets()



        'Buttons
        guiHandlerSavings.HideButtons()



        'Reset app-variables on form-activision
        userAccount = MyBankATM.GetUserAccount()



        If IsNothing(userAccount) Then

            TxtUser.Text = "*Error: could not fetch user"

        Else

            TxtUser.Text = userAccount

        End If



        userAccountSavings = MyBankATM.GetUserAccountBalance()



        If IsNothing(userAccountSavings) Or userAccountSavings = 0 Then

            userAccountSavings = 0.0

        End If



        dblTimerCalcSavings = 0

        BtnCalcSavingsClicks = 0



    End Sub



    Private Sub MyBankSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.IsMdiContainer = True

    End Sub



    Private Sub BtnATM_Click(sender As Object, e As EventArgs) Handles BtnATM.Click

        MyBankATM.Show()

        Me.Hide()

    End Sub



    Private Sub BtnCalcSaving_Click(sender As Object, e As EventArgs) Handles BtnCalcSaving.Click

        BtnCalcSavingsClicks = BtnCalcSavingsClicks + 1



        If BtnCalcSavingsClicks > 0 Then



            'Show user input assets
            guiHandlerSavings.ShowInputAssets()
            guiHandlerSavings.ShowButtons()



            'Hides and clears calculations details (IF they have been activated before)

            If LblAssetHeader.Visible = True Then

                LblMonthDeposit.Text = "n/a"

                LblYears.Text = "n/a"

                LblInterestRate.Text = "n/a"

                LblSavedMoney.Text = "n/a"

                LblValueGrowth.Text = "n/a"



                guiHandlerSavings.HideCalcSaveAssets()

            End If

        End If



    End Sub



    Private Sub BtnCheckSavings_Click(sender As Object, e As EventArgs) Handles BtnCheckSavings.Click

        BtnSavingsClicks = BtnSavingsClicks + 1



        If BtnSavingsClicks = 1 Then

            guiHandlerSavings.ShowAccountsavingsAssets()

            LblSavingsHeader.Text = "You currently have a total of:"

            TxtSavingsAmount.Text = userAccountSavings & " sek"

        Else

            BtnSavingsClicks = 0

        End If

    End Sub



    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        BtnSubmitClicks = BtnSubmitClicks + 1



        If BtnSubmitClicks = 1 And BtnSavingsClicks > 0 Then

            If (InputMontlyDeposit.Text <> "" And IsNumeric(InputMontlyDeposit.Text) = True) And (InputYears.Text <> "" And IsNumeric(InputYears.Text) = True) Then



                If (TxtErrorDeposit.Visible = True Or TxtErrorYears.Visible = True) Then

                    TxtErrorDeposit.Text = ""

                    TxtErrorYears.Text = ""

                    guiHandlerSavings.HideErrorAssets()

                End If



                'Take input from user

                userinputMonthlySavings = CDbl(InputMontlyDeposit.Text)

                userinputYears = InputYears.Text



                'Assign values to variables

                StartSavings = userAccountSavings

                NumYears = userinputYears

                MonthlySavings = userinputMonthlySavings

                ExpectedSavings = (StartSavings + MonthlySavings * 12) * AnnualInterestRate ^ NumYears



                SavedMoney = Math.Round(((StartSavings + MonthlySavings * 12) ^ NumYears), 1)

                ValueGrowth = ExpectedSavings - SavedMoney



                'Save result - will later be shown to user

                userAccountSavings = ExpectedSavings



                guiHandlerSavings.ShowProcessingAsset()

                TimerCalcSavings.Start()



                'Handels blank inputs

            ElseIf InputMontlyDeposit.Text = "" Then

                TxtErrorDeposit.Text = "*Error: No savings amount was provided"

                guiHandlerSavings.ShowErrorDepositAsset()

            ElseIf InputYears.Text = "" Then

                TxtErrorYears.Text = "*Error: No year was provided"

                guiHandlerSavings.ShowErrorYearAsset()



                'Handels non-numeric inputs

            ElseIf Not IsNumeric(InputMontlyDeposit.Text) Then

                TxtErrorDeposit.Text = "*Error: Only numeric characters allowed"

                guiHandlerSavings.ShowErrorDepositAsset()

            ElseIf Not IsNumeric(InputYears.Text) Then

                TxtErrorYears.Text = "*Error: Only numeric characters allowed"

                guiHandlerSavings.ShowErrorYearAsset()



            End If

        End If

    End Sub



    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        BtnClearClicks = BtnClearClicks + 1



        If BtnClearClicks > 0 And BtnSubmitClicks = 0 Then

            BtnSubmitClicks = 0

            BtnClearClicks = 0

            BtnCalcSavingsClicks = 0



            InputMontlyDeposit.Text = ""

            InputYears.Text = ""

            TxtErrorDeposit.Text = ""

            TxtErrorYears.Text = ""

            guiHandlerSavings.HideErrorAssets()



        End If

        If BtnClearClicks >= 1 And BtnSubmitClicks >= 1 And LblSavingsHeader.Visible = True Then

            userAccountSavings = MyBankATM.GetUserAccountBalance()
            TxtSavingsAmount.Text = userAccountSavings & " sek"



            If IsNothing(userAccountSavings) Or userAccountSavings = 0 Then

                userAccountSavings = 0.0

                TxtSavingsAmount.Text = userAccountSavings & " sek"

            End If



            BtnSubmitClicks = 0

            BtnClearClicks = 0

            guiHandlerSavings.HideButtonClear()



            guiHandlerSavings.HideProcessingAsset()

            TimerCalcSavings.Stop()

            dblTimerCalcSavings = 0

        End If

    End Sub



    Private Sub TimerCalcSavings_Tick(sender As Object, e As EventArgs) Handles TimerCalcSavings.Tick

        dblTimerCalcSavings = dblTimerCalcSavings + 0.5



        'UserUI progress of calculation

        If dblTimerCalcSavings < 1.0 And dblTimerCalcSavings > 0.5 Then

            TxtProcessing.Text = "PROCESSING ."



        ElseIf dblTimerCalcSavings < 2.0 And dblTimerCalcSavings > 1.0 Then

            InputMontlyDeposit.Text = ""

            InputYears.Text = ""

            TxtProcessing.Text = "PROCESSING . ."

            BtnSubmit.Visible = False

            LblSavingsHeader.Text = "Expected savings in " & NumYears & " years"

            guiHandlerSavings.ShowAccountsavingsAssets()

            TxtSavingsAmount.Text = ". "

        ElseIf dblTimerCalcSavings < 3.0 And dblTimerCalcSavings > 2.0 Then

            TxtSavingsAmount.Text = ". . "

            TxtProcessing.Text = "PROCESSING . . ."

        ElseIf dblTimerCalcSavings > 3.0 Then

            TxtSavingsAmount.Text = ". . ."

            TxtProcessing.Text = ""

            guiHandlerSavings.HideInputAssets()

        End If



        'Calculations

        If dblTimerCalcSavings > 3.5 Then

            BtnCalcSavingsClicks = 0

            BtnSubmitClicks = 1

            BtnClearClicks = 0



            TxtSavingsAmount.Text = userAccountSavings & " sek"



            guiHandlerSavings.HideProcessingAsset()

            guiHandlerSavings.ShowCalcSaveAssets()



            LblMonthDeposit.Text = userinputMonthlySavings

            LblYears.Text = userinputYears

            LblInterestRate.Text = Math.Round(((AnnualInterestRate - 1) * 100), 1) & "%"

            LblSavedMoney.Text = SavedMoney & " sek"

            If ValueGrowth > 0 Then

                LblValueGrowth.Text = "+" & ValueGrowth & " sek"

            ElseIf ValueGrowth < 0 Then

                LblValueGrowth.Text = "-" & ValueGrowth & " sek"

            End If

        ElseIf dblTimerCalcSavings > 4.5 Then

            TimerCalcSavings.Stop()

            dblTimerCalcSavings = 0

        End If

    End Sub



    Private Sub ProgramClosing() Handles MyBase.FormClosing



        Application.Exit()



    End Sub



End Class



Public Class GUIHandlerSavings



    Public Sub ShowCalcSaveAssets()

        MyBankSavings.LblAssetHeader.Visible = True

        MyBankSavings.LblAsset1.Visible = True

        MyBankSavings.LblAsset2.Visible = True

        MyBankSavings.LblAsset3.Visible = True

        MyBankSavings.LblAsset4.Visible = True

        MyBankSavings.LblAsset5.Visible = True

        MyBankSavings.LblMonthDeposit.Visible = True

        MyBankSavings.LblYears.Visible = True

        MyBankSavings.LblInterestRate.Visible = True

        MyBankSavings.LblSavedMoney.Visible = True

        MyBankSavings.LblValueGrowth.Visible = True

    End Sub



    Public Sub HideCalcSaveAssets()

        MyBankSavings.LblAssetHeader.Visible = False

        MyBankSavings.LblAsset1.Visible = False

        MyBankSavings.LblAsset2.Visible = False

        MyBankSavings.LblAsset3.Visible = False

        MyBankSavings.LblAsset4.Visible = False

        MyBankSavings.LblAsset5.Visible = False

        MyBankSavings.LblMonthDeposit.Visible = False

        MyBankSavings.LblYears.Visible = False

        MyBankSavings.LblInterestRate.Visible = False

        MyBankSavings.LblSavedMoney.Visible = False

        MyBankSavings.LblValueGrowth.Visible = False

    End Sub



    Public Sub ShowAccountsavingsAssets()

        MyBankSavings.LblSavingsHeader.Visible = True

        MyBankSavings.TxtSavingsAmount.Visible = True

    End Sub



    Public Sub HideAccountsavingsAssets()

        MyBankSavings.LblSavingsHeader.Visible = False

        MyBankSavings.TxtSavingsAmount.Visible = False

    End Sub



    Public Sub ShowInputAssets()

        MyBankSavings.InputMontlyDeposit.Visible = True

        MyBankSavings.InputYears.Visible = True

        MyBankSavings.LblSubmitAsset1.Visible = True

        MyBankSavings.LblSubmitAsset2.Visible = True

        MyBankSavings.LblSubmitAsset3.Visible = True

    End Sub



    Public Sub HideInputAssets()

        MyBankSavings.InputMontlyDeposit.Visible = False

        MyBankSavings.InputYears.Visible = False

        MyBankSavings.LblSubmitAsset1.Visible = False

        MyBankSavings.LblSubmitAsset2.Visible = False

        MyBankSavings.LblSubmitAsset3.Visible = False

    End Sub



    Public Sub ShowProcessingAsset()

        MyBankSavings.TxtProcessing.Visible = True

    End Sub



    Public Sub HideProcessingAsset()

        MyBankSavings.TxtProcessing.Visible = False

    End Sub



    Public Sub ShowErrorAssets()

        MyBankSavings.TxtErrorDeposit.Visible = True

        MyBankSavings.TxtErrorYears.Visible = True

    End Sub



    Public Sub HideErrorAssets()

        MyBankSavings.TxtErrorDeposit.Visible = False

        MyBankSavings.TxtErrorYears.Visible = False

    End Sub



    Public Sub ShowErrorYearAsset()

        MyBankSavings.TxtErrorYears.Visible = True

    End Sub



    Public Sub HideErrorYearAsset()

        MyBankSavings.TxtErrorYears.Visible = False

    End Sub



    Public Sub ShowErrorDepositAsset()

        MyBankSavings.TxtErrorDeposit.Visible = True

    End Sub



    Public Sub HideErrorDepositAsset()

        MyBankSavings.TxtErrorDeposit.Visible = False

    End Sub



    Public Sub ShowButtons()

        MyBankSavings.BtnSubmit.Visible = True

        MyBankSavings.BtnClear.Visible = True

    End Sub



    Public Sub HideButtons()

        MyBankSavings.BtnSubmit.Visible = False

        MyBankSavings.BtnClear.Visible = False

    End Sub



    Public Sub ShowButtonSubmit()

        MyBankSavings.BtnSubmit.Visible = True

    End Sub



    Public Sub HideButtonSubmit()

        MyBankSavings.BtnSubmit.Visible = False

    End Sub



    Public Sub ShowButtonClear()

        MyBankSavings.BtnClear.Visible = True

    End Sub



    Public Sub HideButtonClear()

        MyBankSavings.BtnClear.Visible = False

    End Sub



End Class