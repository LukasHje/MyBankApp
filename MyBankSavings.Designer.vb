'
' This is the designer page for MyBankSavings
' Here you will find the necessary components for the applications GUI and Functionality.
' 
' @author  Lukas Hjernquist
' @version 1.0, 2024/09/13
' @since   .NET Framework 4.7.2
'
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyBankSavings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        Me.BtnATM = New System.Windows.Forms.Button()

        Me.TxtUser = New System.Windows.Forms.Label()

        Me.UserdisplayAsset3 = New System.Windows.Forms.Button()

        Me.UserdisplayAsset2 = New System.Windows.Forms.Button()

        Me.UserdisplayAsset1 = New System.Windows.Forms.Button()

        Me.LogoAsset2 = New System.Windows.Forms.Label()

        Me.LblSavingsHeader = New System.Windows.Forms.Label()

        Me.Button2 = New System.Windows.Forms.Button()

        Me.Button1 = New System.Windows.Forms.Button()

        Me.Button9 = New System.Windows.Forms.Button()

        Me.Button8 = New System.Windows.Forms.Button()

        Me.LogoAsset1 = New System.Windows.Forms.Button()

        Me.Button3 = New System.Windows.Forms.Button()

        Me.BtnCalcSaving = New System.Windows.Forms.Button()

        Me.InputMontlyDeposit = New System.Windows.Forms.TextBox()

        Me.InputYears = New System.Windows.Forms.TextBox()

        Me.LblSubmitAsset2 = New System.Windows.Forms.Label()

        Me.LblSubmitAsset3 = New System.Windows.Forms.Label()

        Me.LblSubmitAsset1 = New System.Windows.Forms.Label()

        Me.BtnSubmit = New System.Windows.Forms.Button()

        Me.BtnClear = New System.Windows.Forms.Button()

        Me.BtnCheckSavings = New System.Windows.Forms.Button()

        Me.LblAssetHeader = New System.Windows.Forms.Label()

        Me.LblAsset1 = New System.Windows.Forms.Label()

        Me.LblAsset2 = New System.Windows.Forms.Label()

        Me.LblAsset3 = New System.Windows.Forms.Label()

        Me.LblMonthDeposit = New System.Windows.Forms.Label()

        Me.LblYears = New System.Windows.Forms.Label()

        Me.LblInterestRate = New System.Windows.Forms.Label()

        Me.TxtSavingsAmount = New System.Windows.Forms.TextBox()

        Me.TimerCalcSavings = New System.Windows.Forms.Timer(Me.components)

        Me.TxtErrorDeposit = New System.Windows.Forms.TextBox()

        Me.TxtProcessing = New System.Windows.Forms.TextBox()

        Me.TxtErrorYears = New System.Windows.Forms.TextBox()

        Me.LblSavedMoney = New System.Windows.Forms.Label()

        Me.LblAsset4 = New System.Windows.Forms.Label()

        Me.LblValueGrowth = New System.Windows.Forms.Label()

        Me.LblAsset5 = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        '

        'BtnATM

        '

        Me.BtnATM.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(170, Byte), Integer))

        Me.BtnATM.FlatAppearance.BorderSize = 0

        Me.BtnATM.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.BtnATM.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.BtnATM.ForeColor = System.Drawing.Color.DarkSlateGray

        Me.BtnATM.Location = New System.Drawing.Point(96, 910)

        Me.BtnATM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.BtnATM.Name = "BtnATM"

        Me.BtnATM.Size = New System.Drawing.Size(231, 56)

        Me.BtnATM.TabIndex = 46

        Me.BtnATM.Text = "ATM  ↩"

        Me.BtnATM.UseVisualStyleBackColor = False

        '

        'TxtUser

        '

        Me.TxtUser.AutoSize = True

        Me.TxtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(125, Byte), Integer))

        Me.TxtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.TxtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(90, Byte), Integer))

        Me.TxtUser.Location = New System.Drawing.Point(125, 200)

        Me.TxtUser.Name = "TxtUser"

        Me.TxtUser.Size = New System.Drawing.Size(32, 18)

        Me.TxtUser.TabIndex = 78

        Me.TxtUser.Text = "N/A"

        Me.TxtUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        '

        'UserdisplayAsset3

        '

        Me.UserdisplayAsset3.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(125, Byte), Integer))

        Me.UserdisplayAsset3.Enabled = False

        Me.UserdisplayAsset3.FlatAppearance.BorderSize = 0

        Me.UserdisplayAsset3.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.UserdisplayAsset3.Location = New System.Drawing.Point(114, 191)

        Me.UserdisplayAsset3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.UserdisplayAsset3.Name = "UserdisplayAsset3"

        Me.UserdisplayAsset3.Size = New System.Drawing.Size(293, 31)

        Me.UserdisplayAsset3.TabIndex = 77

        Me.UserdisplayAsset3.UseVisualStyleBackColor = False

        '

        'UserdisplayAsset2

        '

        Me.UserdisplayAsset2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(78, Byte), Integer))

        Me.UserdisplayAsset2.Enabled = False

        Me.UserdisplayAsset2.FlatAppearance.BorderSize = 0

        Me.UserdisplayAsset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.UserdisplayAsset2.Location = New System.Drawing.Point(105, 185)

        Me.UserdisplayAsset2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.UserdisplayAsset2.Name = "UserdisplayAsset2"

        Me.UserdisplayAsset2.Size = New System.Drawing.Size(313, 45)

        Me.UserdisplayAsset2.TabIndex = 76

        Me.UserdisplayAsset2.UseVisualStyleBackColor = False

        '

        'UserdisplayAsset1

        '

        Me.UserdisplayAsset1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(107, Byte), Integer))

        Me.UserdisplayAsset1.Enabled = False

        Me.UserdisplayAsset1.FlatAppearance.BorderSize = 0

        Me.UserdisplayAsset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.UserdisplayAsset1.Location = New System.Drawing.Point(96, 178)

        Me.UserdisplayAsset1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.UserdisplayAsset1.Name = "UserdisplayAsset1"

        Me.UserdisplayAsset1.Size = New System.Drawing.Size(339, 60)

        Me.UserdisplayAsset1.TabIndex = 75

        Me.UserdisplayAsset1.UseVisualStyleBackColor = False

        '

        'LogoAsset2

        '

        Me.LogoAsset2.AutoSize = True

        Me.LogoAsset2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(93, Byte), Integer))

        Me.LogoAsset2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LogoAsset2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(196, Byte), Integer))

        Me.LogoAsset2.Location = New System.Drawing.Point(116, 86)

        Me.LogoAsset2.Name = "LogoAsset2"

        Me.LogoAsset2.Padding = New System.Windows.Forms.Padding(27, 0, 27, 0)

        Me.LogoAsset2.Size = New System.Drawing.Size(285, 72)

        Me.LogoAsset2.TabIndex = 70

        Me.LogoAsset2.Text = "SAVINGS"

        Me.LogoAsset2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '

        'LblSavingsHeader

        '

        Me.LblSavingsHeader.AutoSize = True

        Me.LblSavingsHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblSavingsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblSavingsHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblSavingsHeader.Location = New System.Drawing.Point(739, 335)

        Me.LblSavingsHeader.Name = "LblSavingsHeader"

        Me.LblSavingsHeader.Size = New System.Drawing.Size(439, 36)

        Me.LblSavingsHeader.TabIndex = 51

        Me.LblSavingsHeader.Text = "Expected savings in n/a years"

        '

        'Button2

        '

        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.Button2.Enabled = False

        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))

        Me.Button2.FlatAppearance.BorderSize = 0

        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.Button2.Location = New System.Drawing.Point(520, 114)

        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.Button2.Name = "Button2"

        Me.Button2.Size = New System.Drawing.Size(909, 807)

        Me.Button2.TabIndex = 54

        Me.Button2.UseVisualStyleBackColor = False

        '

        'Button1

        '

        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer))

        Me.Button1.Enabled = False

        Me.Button1.FlatAppearance.BorderSize = 0

        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.Button1.Location = New System.Drawing.Point(503, 104)

        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.Button1.Name = "Button1"

        Me.Button1.Size = New System.Drawing.Size(940, 828)

        Me.Button1.TabIndex = 53

        Me.Button1.UseVisualStyleBackColor = False

        '

        'Button9

        '

        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(78, Byte), Integer))

        Me.Button9.Enabled = False

        Me.Button9.FlatAppearance.BorderSize = 0

        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.Button9.Location = New System.Drawing.Point(476, 86)

        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.Button9.Name = "Button9"

        Me.Button9.Size = New System.Drawing.Size(990, 863)

        Me.Button9.TabIndex = 69

        Me.Button9.UseVisualStyleBackColor = False

        '

        'Button8

        '

        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(107, Byte), Integer))

        Me.Button8.Enabled = False

        Me.Button8.FlatAppearance.BorderSize = 0

        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.Button8.Location = New System.Drawing.Point(454, 68)

        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.Button8.Name = "Button8"

        Me.Button8.Size = New System.Drawing.Size(1039, 898)

        Me.Button8.TabIndex = 68

        Me.Button8.UseVisualStyleBackColor = False

        '

        'LogoAsset1

        '

        Me.LogoAsset1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(107, Byte), Integer))

        Me.LogoAsset1.Enabled = False

        Me.LogoAsset1.FlatAppearance.BorderSize = 0

        Me.LogoAsset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.LogoAsset1.Location = New System.Drawing.Point(95, 68)

        Me.LogoAsset1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.LogoAsset1.Name = "LogoAsset1"

        Me.LogoAsset1.Size = New System.Drawing.Size(340, 106)

        Me.LogoAsset1.TabIndex = 64

        Me.LogoAsset1.UseVisualStyleBackColor = False

        '

        'Button3

        '

        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(119, Byte), Integer))

        Me.Button3.Enabled = False

        Me.Button3.FlatAppearance.BorderSize = 0

        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.Button3.Location = New System.Drawing.Point(22, 19)

        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.Button3.Name = "Button3"

        Me.Button3.Size = New System.Drawing.Size(1490, 965)

        Me.Button3.TabIndex = 63

        Me.Button3.UseVisualStyleBackColor = False

        '

        'BtnCalcSaving

        '

        Me.BtnCalcSaving.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(170, Byte), Integer))

        Me.BtnCalcSaving.FlatAppearance.BorderSize = 0

        Me.BtnCalcSaving.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.BtnCalcSaving.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.BtnCalcSaving.ForeColor = System.Drawing.Color.DarkSlateGray

        Me.BtnCalcSaving.Location = New System.Drawing.Point(96, 786)

        Me.BtnCalcSaving.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.BtnCalcSaving.Name = "BtnCalcSaving"

        Me.BtnCalcSaving.Size = New System.Drawing.Size(231, 56)

        Me.BtnCalcSaving.TabIndex = 79

        Me.BtnCalcSaving.Text = "INVEST           ➲"

        Me.BtnCalcSaving.UseVisualStyleBackColor = False

        '

        'InputMontlyDeposit

        '

        Me.InputMontlyDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.InputMontlyDeposit.Font = New System.Drawing.Font("Bahnschrift", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.InputMontlyDeposit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.InputMontlyDeposit.Location = New System.Drawing.Point(548, 798)

        Me.InputMontlyDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.InputMontlyDeposit.Name = "InputMontlyDeposit"

        Me.InputMontlyDeposit.Size = New System.Drawing.Size(217, 40)

        Me.InputMontlyDeposit.TabIndex = 80

        '

        'InputYears

        '

        Me.InputYears.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.InputYears.Font = New System.Drawing.Font("Bahnschrift", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.InputYears.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.InputYears.Location = New System.Drawing.Point(970, 798)

        Me.InputYears.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.InputYears.Name = "InputYears"

        Me.InputYears.Size = New System.Drawing.Size(55, 40)

        Me.InputYears.TabIndex = 81

        '

        'LblSubmitAsset2

        '

        Me.LblSubmitAsset2.AutoSize = True

        Me.LblSubmitAsset2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblSubmitAsset2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblSubmitAsset2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblSubmitAsset2.Location = New System.Drawing.Point(924, 808)

        Me.LblSubmitAsset2.Name = "LblSubmitAsset2"

        Me.LblSubmitAsset2.Size = New System.Drawing.Size(40, 25)

        Me.LblSubmitAsset2.TabIndex = 82

        Me.LblSubmitAsset2.Text = "for:"

        '

        'LblSubmitAsset3

        '

        Me.LblSubmitAsset3.AutoSize = True

        Me.LblSubmitAsset3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblSubmitAsset3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblSubmitAsset3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblSubmitAsset3.Location = New System.Drawing.Point(1031, 807)

        Me.LblSubmitAsset3.Name = "LblSubmitAsset3"

        Me.LblSubmitAsset3.Size = New System.Drawing.Size(60, 25)

        Me.LblSubmitAsset3.TabIndex = 83

        Me.LblSubmitAsset3.Text = "years"

        '

        'LblSubmitAsset1

        '

        Me.LblSubmitAsset1.AutoSize = True

        Me.LblSubmitAsset1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblSubmitAsset1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblSubmitAsset1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblSubmitAsset1.Location = New System.Drawing.Point(771, 808)

        Me.LblSubmitAsset1.Name = "LblSubmitAsset1"

        Me.LblSubmitAsset1.Size = New System.Drawing.Size(124, 25)

        Me.LblSubmitAsset1.TabIndex = 84

        Me.LblSubmitAsset1.Text = "SEK / Month"

        '

        'BtnSubmit

        '

        Me.BtnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(105, Byte), Integer))

        Me.BtnSubmit.FlatAppearance.BorderSize = 0

        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.BtnSubmit.Font = New System.Drawing.Font("Bahnschrift", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.BtnSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(135, Byte), Integer))

        Me.BtnSubmit.Location = New System.Drawing.Point(95, 458)

        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.BtnSubmit.Name = "BtnSubmit"

        Me.BtnSubmit.Size = New System.Drawing.Size(232, 62)

        Me.BtnSubmit.TabIndex = 85

        Me.BtnSubmit.Text = "✅ SUBMIT"

        Me.BtnSubmit.UseVisualStyleBackColor = False

        '

        'BtnClear

        '

        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))

        Me.BtnClear.FlatAppearance.BorderSize = 0

        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.BtnClear.Font = New System.Drawing.Font("Bahnschrift", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.BtnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))

        Me.BtnClear.Location = New System.Drawing.Point(95, 526)

        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.BtnClear.Name = "BtnClear"

        Me.BtnClear.Size = New System.Drawing.Size(232, 66)

        Me.BtnClear.TabIndex = 87

        Me.BtnClear.Text = "❎ CLEAR"

        Me.BtnClear.UseVisualStyleBackColor = False

        '

        'BtnCheckSavings

        '

        Me.BtnCheckSavings.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(170, Byte), Integer))

        Me.BtnCheckSavings.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen

        Me.BtnCheckSavings.FlatAppearance.BorderSize = 0

        Me.BtnCheckSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat

        Me.BtnCheckSavings.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.BtnCheckSavings.ForeColor = System.Drawing.Color.DarkSlateGray

        Me.BtnCheckSavings.Location = New System.Drawing.Point(96, 725)

        Me.BtnCheckSavings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.BtnCheckSavings.Name = "BtnCheckSavings"

        Me.BtnCheckSavings.Size = New System.Drawing.Size(231, 56)

        Me.BtnCheckSavings.TabIndex = 89

        Me.BtnCheckSavings.Text = "CHECK SAVINGS"

        Me.BtnCheckSavings.UseVisualStyleBackColor = False

        '

        'LblAssetHeader

        '

        Me.LblAssetHeader.AutoSize = True

        Me.LblAssetHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblAssetHeader.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblAssetHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblAssetHeader.Location = New System.Drawing.Point(543, 538)

        Me.LblAssetHeader.Name = "LblAssetHeader"

        Me.LblAssetHeader.Size = New System.Drawing.Size(298, 29)

        Me.LblAssetHeader.TabIndex = 90

        Me.LblAssetHeader.Text = "Investment growth details:"

        '

        'LblAsset1

        '

        Me.LblAsset1.AutoSize = True

        Me.LblAsset1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblAsset1.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblAsset1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblAsset1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight

        Me.LblAsset1.Location = New System.Drawing.Point(904, 598)

        Me.LblAsset1.Name = "LblAsset1"

        Me.LblAsset1.Size = New System.Drawing.Size(147, 24)

        Me.LblAsset1.TabIndex = 91

        Me.LblAsset1.Text = "Montly deposit:"

        '

        'LblAsset2

        '

        Me.LblAsset2.AutoSize = True

        Me.LblAsset2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblAsset2.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblAsset2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblAsset2.Location = New System.Drawing.Point(883, 621)

        Me.LblAsset2.Name = "LblAsset2"

        Me.LblAsset2.Size = New System.Drawing.Size(166, 24)

        Me.LblAsset2.TabIndex = 92

        Me.LblAsset2.Text = "Number of years:"

        '

        'LblAsset3

        '

        Me.LblAsset3.AutoSize = True

        Me.LblAsset3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblAsset3.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblAsset3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblAsset3.Location = New System.Drawing.Point(851, 644)

        Me.LblAsset3.Name = "LblAsset3"

        Me.LblAsset3.Size = New System.Drawing.Size(197, 24)

        Me.LblAsset3.TabIndex = 93

        Me.LblAsset3.Text = "Annual interest rate:"

        '

        'LblMonthDeposit

        '

        Me.LblMonthDeposit.AutoSize = True

        Me.LblMonthDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblMonthDeposit.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblMonthDeposit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblMonthDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight

        Me.LblMonthDeposit.Location = New System.Drawing.Point(1064, 598)

        Me.LblMonthDeposit.Name = "LblMonthDeposit"

        Me.LblMonthDeposit.Size = New System.Drawing.Size(40, 24)

        Me.LblMonthDeposit.TabIndex = 94

        Me.LblMonthDeposit.Text = "n/a"

        '

        'LblYears

        '

        Me.LblYears.AutoSize = True

        Me.LblYears.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblYears.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblYears.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblYears.ImageAlign = System.Drawing.ContentAlignment.MiddleRight

        Me.LblYears.Location = New System.Drawing.Point(1064, 622)

        Me.LblYears.Name = "LblYears"

        Me.LblYears.Size = New System.Drawing.Size(40, 24)

        Me.LblYears.TabIndex = 95

        Me.LblYears.Text = "n/a"

        '

        'LblInterestRate

        '

        Me.LblInterestRate.AutoSize = True

        Me.LblInterestRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblInterestRate.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblInterestRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblInterestRate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight

        Me.LblInterestRate.Location = New System.Drawing.Point(1064, 644)

        Me.LblInterestRate.Name = "LblInterestRate"

        Me.LblInterestRate.Size = New System.Drawing.Size(40, 24)

        Me.LblInterestRate.TabIndex = 96

        Me.LblInterestRate.Text = "n/a"

        '

        'TxtSavingsAmount

        '

        Me.TxtSavingsAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.TxtSavingsAmount.BorderStyle = System.Windows.Forms.BorderStyle.None

        Me.TxtSavingsAmount.Font = New System.Drawing.Font("Lucida Sans", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.TxtSavingsAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(0, Byte), Integer))

        Me.TxtSavingsAmount.Location = New System.Drawing.Point(796, 414)

        Me.TxtSavingsAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.TxtSavingsAmount.Multiline = True

        Me.TxtSavingsAmount.Name = "TxtSavingsAmount"

        Me.TxtSavingsAmount.ReadOnly = True

        Me.TxtSavingsAmount.Size = New System.Drawing.Size(307, 42)

        Me.TxtSavingsAmount.TabIndex = 97

        Me.TxtSavingsAmount.Text = "n/a kr"

        Me.TxtSavingsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center

        '

        'TimerCalcSavings

        '

        Me.TimerCalcSavings.Interval = 500

        '

        'TxtErrorDeposit

        '

        Me.TxtErrorDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.TxtErrorDeposit.BorderStyle = System.Windows.Forms.BorderStyle.None

        Me.TxtErrorDeposit.Cursor = System.Windows.Forms.Cursors.SizeAll

        Me.TxtErrorDeposit.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.TxtErrorDeposit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))

        Me.TxtErrorDeposit.ImeMode = System.Windows.Forms.ImeMode.NoControl

        Me.TxtErrorDeposit.Location = New System.Drawing.Point(548, 840)

        Me.TxtErrorDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.TxtErrorDeposit.Name = "TxtErrorDeposit"

        Me.TxtErrorDeposit.ReadOnly = True

        Me.TxtErrorDeposit.Size = New System.Drawing.Size(279, 19)

        Me.TxtErrorDeposit.TabIndex = 99

        Me.TxtErrorDeposit.Text = "*Error: only numeric characters allowed"

        '

        'TxtProcessing

        '

        Me.TxtProcessing.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.TxtProcessing.BorderStyle = System.Windows.Forms.BorderStyle.None

        Me.TxtProcessing.Cursor = System.Windows.Forms.Cursors.SizeAll

        Me.TxtProcessing.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.TxtProcessing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.TxtProcessing.Location = New System.Drawing.Point(844, 552)

        Me.TxtProcessing.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.TxtProcessing.Multiline = True

        Me.TxtProcessing.Name = "TxtProcessing"

        Me.TxtProcessing.ReadOnly = True

        Me.TxtProcessing.Size = New System.Drawing.Size(243, 36)

        Me.TxtProcessing.TabIndex = 98

        Me.TxtProcessing.Text = "PROCESSING . . ."

        '

        'TxtErrorYears

        '

        Me.TxtErrorYears.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.TxtErrorYears.BorderStyle = System.Windows.Forms.BorderStyle.None

        Me.TxtErrorYears.Cursor = System.Windows.Forms.Cursors.SizeAll

        Me.TxtErrorYears.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.TxtErrorYears.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))

        Me.TxtErrorYears.ImeMode = System.Windows.Forms.ImeMode.NoControl

        Me.TxtErrorYears.Location = New System.Drawing.Point(970, 840)

        Me.TxtErrorYears.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.TxtErrorYears.Name = "TxtErrorYears"

        Me.TxtErrorYears.ReadOnly = True

        Me.TxtErrorYears.Size = New System.Drawing.Size(279, 19)

        Me.TxtErrorYears.TabIndex = 100

        Me.TxtErrorYears.Text = "*Error: only numeric characters allowed"

        '

        'LblSavedMoney

        '

        Me.LblSavedMoney.AutoSize = True

        Me.LblSavedMoney.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblSavedMoney.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblSavedMoney.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblSavedMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleRight

        Me.LblSavedMoney.Location = New System.Drawing.Point(1061, 681)

        Me.LblSavedMoney.Name = "LblSavedMoney"

        Me.LblSavedMoney.Size = New System.Drawing.Size(40, 24)

        Me.LblSavedMoney.TabIndex = 102

        Me.LblSavedMoney.Text = "n/a"

        '

        'LblAsset4

        '

        Me.LblAsset4.AutoSize = True

        Me.LblAsset4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblAsset4.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblAsset4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblAsset4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight

        Me.LblAsset4.Location = New System.Drawing.Point(871, 681)

        Me.LblAsset4.Name = "LblAsset4"

        Me.LblAsset4.Size = New System.Drawing.Size(177, 24)

        Me.LblAsset4.TabIndex = 101

        Me.LblAsset4.Text = "Your saved money:"

        '

        'LblValueGrowth

        '

        Me.LblValueGrowth.AutoSize = True

        Me.LblValueGrowth.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblValueGrowth.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblValueGrowth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblValueGrowth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight

        Me.LblValueGrowth.Location = New System.Drawing.Point(1061, 705)

        Me.LblValueGrowth.Name = "LblValueGrowth"

        Me.LblValueGrowth.Size = New System.Drawing.Size(40, 24)

        Me.LblValueGrowth.TabIndex = 104

        Me.LblValueGrowth.Text = "n/a"

        '

        'LblAsset5

        '

        Me.LblAsset5.AutoSize = True

        Me.LblAsset5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))

        Me.LblAsset5.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LblAsset5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer))

        Me.LblAsset5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight

        Me.LblAsset5.Location = New System.Drawing.Point(913, 705)

        Me.LblAsset5.Name = "LblAsset5"

        Me.LblAsset5.Size = New System.Drawing.Size(135, 24)

        Me.LblAsset5.TabIndex = 103

        Me.LblAsset5.Text = "Value growth:"

        '

        'MyBankSavings

        '

        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)

        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.BackColor = System.Drawing.Color.Silver

        Me.ClientSize = New System.Drawing.Size(1561, 1022)

        Me.Controls.Add(Me.LblValueGrowth)

        Me.Controls.Add(Me.LblAsset5)

        Me.Controls.Add(Me.LblSavedMoney)

        Me.Controls.Add(Me.LblAsset4)

        Me.Controls.Add(Me.TxtErrorYears)

        Me.Controls.Add(Me.TxtErrorDeposit)

        Me.Controls.Add(Me.TxtProcessing)

        Me.Controls.Add(Me.TxtSavingsAmount)

        Me.Controls.Add(Me.LblInterestRate)

        Me.Controls.Add(Me.LblYears)

        Me.Controls.Add(Me.LblMonthDeposit)

        Me.Controls.Add(Me.LblAsset3)

        Me.Controls.Add(Me.LblAsset2)

        Me.Controls.Add(Me.LblAsset1)

        Me.Controls.Add(Me.LblAssetHeader)

        Me.Controls.Add(Me.BtnCheckSavings)

        Me.Controls.Add(Me.BtnClear)

        Me.Controls.Add(Me.BtnSubmit)

        Me.Controls.Add(Me.LblSubmitAsset1)

        Me.Controls.Add(Me.LblSubmitAsset3)

        Me.Controls.Add(Me.LblSubmitAsset2)

        Me.Controls.Add(Me.InputYears)

        Me.Controls.Add(Me.InputMontlyDeposit)

        Me.Controls.Add(Me.BtnCalcSaving)

        Me.Controls.Add(Me.BtnATM)

        Me.Controls.Add(Me.TxtUser)

        Me.Controls.Add(Me.UserdisplayAsset3)

        Me.Controls.Add(Me.UserdisplayAsset2)

        Me.Controls.Add(Me.UserdisplayAsset1)

        Me.Controls.Add(Me.LogoAsset2)

        Me.Controls.Add(Me.LblSavingsHeader)

        Me.Controls.Add(Me.Button2)

        Me.Controls.Add(Me.Button1)

        Me.Controls.Add(Me.Button9)

        Me.Controls.Add(Me.Button8)

        Me.Controls.Add(Me.LogoAsset1)

        Me.Controls.Add(Me.Button3)

        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)

        Me.Name = "MyBankSavings"

        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen

        Me.Text = "MyBank - Savings"

        Me.ResumeLayout(False)

        Me.PerformLayout()



    End Sub



    Friend WithEvents BtnATM As Button

    Friend WithEvents TxtUser As Label

    Friend WithEvents UserdisplayAsset3 As Button

    Friend WithEvents UserdisplayAsset2 As Button

    Friend WithEvents UserdisplayAsset1 As Button

    Friend WithEvents LogoAsset2 As Label

    Friend WithEvents LblSavingsHeader As Label

    Friend WithEvents Button2 As Button

    Friend WithEvents Button1 As Button

    Friend WithEvents Button9 As Button

    Friend WithEvents Button8 As Button

    Friend WithEvents LogoAsset1 As Button

    Friend WithEvents Button3 As Button

    Friend WithEvents BtnCalcSaving As Button

    Friend WithEvents InputMontlyDeposit As TextBox

    Friend WithEvents InputYears As TextBox

    Friend WithEvents LblSubmitAsset2 As Label

    Friend WithEvents LblSubmitAsset3 As Label

    Friend WithEvents LblSubmitAsset1 As Label

    Friend WithEvents BtnSubmit As Button

    Friend WithEvents BtnClear As Button

    Friend WithEvents BtnCheckSavings As Button

    Friend WithEvents LblAssetHeader As Label

    Friend WithEvents LblAsset1 As Label

    Friend WithEvents LblAsset2 As Label

    Friend WithEvents LblAsset3 As Label

    Friend WithEvents LblMonthDeposit As Label

    Friend WithEvents LblYears As Label

    Friend WithEvents LblInterestRate As Label

    Friend WithEvents TxtSavingsAmount As TextBox

    Friend WithEvents TimerCalcSavings As Timer

    Friend WithEvents TxtErrorDeposit As TextBox

    Friend WithEvents TxtProcessing As TextBox

    Friend WithEvents TxtErrorYears As TextBox

    Friend WithEvents LblSavedMoney As Label

    Friend WithEvents LblAsset4 As Label

    Friend WithEvents LblValueGrowth As Label

    Friend WithEvents LblAsset5 As Label
End Class
