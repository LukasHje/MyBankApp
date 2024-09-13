'
' This is the designer page for MyBankATM
' Here you will find the necessary components for the applications GUI and Functionality.
' 
' @author  Lukas Hjernquist
' @version 1.0, 2024/09/13
' @since   .NET Framework 4.7.2
'
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyBankATM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyBankATM))
        Me.BtnDeposit = New System.Windows.Forms.Button()
        Me.BtnWithdraw = New System.Windows.Forms.Button()
        Me.InputDeposit = New System.Windows.Forms.TextBox()
        Me.InputWithdraw = New System.Windows.Forms.TextBox()
        Me.TxtAccountBalanceHeader = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TimerSavefile = New System.Windows.Forms.Timer(Me.components)
        Me.TimerExit = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtAccountBalance = New System.Windows.Forms.TextBox()
        Me.TxtExit = New System.Windows.Forms.TextBox()
        Me.TxtProcessing = New System.Windows.Forms.TextBox()
        Me.TimerDeposit = New System.Windows.Forms.Timer(Me.components)
        Me.TimerWithdraw = New System.Windows.Forms.Timer(Me.components)
        Me.TxtErrorDeposit = New System.Windows.Forms.TextBox()
        Me.TxtErrorWithdraw = New System.Windows.Forms.TextBox()
        Me.BtnCancelExit = New System.Windows.Forms.Button()
        Me.BtnCheckBalance = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCardUser = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.TxtUser = New System.Windows.Forms.Label()
        Me.BtnSavings = New System.Windows.Forms.Button()
        Me.BtnCardslot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnDeposit
        '
        Me.BtnDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnDeposit.FlatAppearance.BorderSize = 0
        Me.BtnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeposit.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeposit.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BtnDeposit.Location = New System.Drawing.Point(338, 505)
        Me.BtnDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDeposit.Name = "BtnDeposit"
        Me.BtnDeposit.Size = New System.Drawing.Size(260, 80)
        Me.BtnDeposit.TabIndex = 3
        Me.BtnDeposit.Text = "DEPOSIT        ▶"
        Me.BtnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDeposit.UseVisualStyleBackColor = False
        '
        'BtnWithdraw
        '
        Me.BtnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnWithdraw.FlatAppearance.BorderSize = 0
        Me.BtnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWithdraw.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithdraw.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BtnWithdraw.Location = New System.Drawing.Point(338, 600)
        Me.BtnWithdraw.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnWithdraw.Name = "BtnWithdraw"
        Me.BtnWithdraw.Size = New System.Drawing.Size(260, 80)
        Me.BtnWithdraw.TabIndex = 4
        Me.BtnWithdraw.Text = "WITHDRAW    ▶"
        Me.BtnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnWithdraw.UseVisualStyleBackColor = False
        '
        'InputDeposit
        '
        Me.InputDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.InputDeposit.Font = New System.Drawing.Font("Bahnschrift", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputDeposit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.InputDeposit.Location = New System.Drawing.Point(701, 529)
        Me.InputDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InputDeposit.Name = "InputDeposit"
        Me.InputDeposit.Size = New System.Drawing.Size(244, 46)
        Me.InputDeposit.TabIndex = 5
        '
        'InputWithdraw
        '
        Me.InputWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.InputWithdraw.Font = New System.Drawing.Font("Bahnschrift", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputWithdraw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.InputWithdraw.Location = New System.Drawing.Point(701, 624)
        Me.InputWithdraw.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InputWithdraw.Name = "InputWithdraw"
        Me.InputWithdraw.Size = New System.Drawing.Size(244, 46)
        Me.InputWithdraw.TabIndex = 6
        '
        'TxtAccountBalanceHeader
        '
        Me.TxtAccountBalanceHeader.AutoSize = True
        Me.TxtAccountBalanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.TxtAccountBalanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccountBalanceHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TxtAccountBalanceHeader.Location = New System.Drawing.Point(812, 318)
        Me.TxtAccountBalanceHeader.Name = "TxtAccountBalanceHeader"
        Me.TxtAccountBalanceHeader.Size = New System.Drawing.Size(351, 52)
        Me.TxtAccountBalanceHeader.TabIndex = 8
        Me.TxtAccountBalanceHeader.Text = "Your balance is:"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExit.Location = New System.Drawing.Point(1028, 884)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Padding = New System.Windows.Forms.Padding(4, 0, 4, 5)
        Me.BtnExit.Size = New System.Drawing.Size(162, 54)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'TimerSavefile
        '
        Me.TimerSavefile.Interval = 1000
        '
        'TimerExit
        '
        Me.TimerExit.Interval = 1000
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(670, 198)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(631, 541)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(688, 210)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(597, 519)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TxtAccountBalance
        '
        Me.TxtAccountBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.TxtAccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAccountBalance.Font = New System.Drawing.Font("Lucida Sans", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccountBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TxtAccountBalance.Location = New System.Drawing.Point(821, 429)
        Me.TxtAccountBalance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAccountBalance.Multiline = True
        Me.TxtAccountBalance.Name = "TxtAccountBalance"
        Me.TxtAccountBalance.ReadOnly = True
        Me.TxtAccountBalance.Size = New System.Drawing.Size(345, 52)
        Me.TxtAccountBalance.TabIndex = 14
        Me.TxtAccountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtExit
        '
        Me.TxtExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.TxtExit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtExit.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.TxtExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxtExit.Location = New System.Drawing.Point(749, 440)
        Me.TxtExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtExit.Multiline = True
        Me.TxtExit.Name = "TxtExit"
        Me.TxtExit.ReadOnly = True
        Me.TxtExit.Size = New System.Drawing.Size(475, 38)
        Me.TxtExit.TabIndex = 15
        Me.TxtExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtProcessing
        '
        Me.TxtProcessing.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.TxtProcessing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtProcessing.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.TxtProcessing.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProcessing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TxtProcessing.Location = New System.Drawing.Point(890, 579)
        Me.TxtProcessing.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtProcessing.Multiline = True
        Me.TxtProcessing.Name = "TxtProcessing"
        Me.TxtProcessing.ReadOnly = True
        Me.TxtProcessing.Size = New System.Drawing.Size(273, 45)
        Me.TxtProcessing.TabIndex = 16
        '
        'TimerDeposit
        '
        Me.TimerDeposit.Interval = 500
        '
        'TimerWithdraw
        '
        Me.TimerWithdraw.Interval = 500
        '
        'TxtErrorDeposit
        '
        Me.TxtErrorDeposit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.TxtErrorDeposit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtErrorDeposit.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.TxtErrorDeposit.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtErrorDeposit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TxtErrorDeposit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtErrorDeposit.Location = New System.Drawing.Point(701, 579)
        Me.TxtErrorDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtErrorDeposit.Name = "TxtErrorDeposit"
        Me.TxtErrorDeposit.ReadOnly = True
        Me.TxtErrorDeposit.Size = New System.Drawing.Size(431, 22)
        Me.TxtErrorDeposit.TabIndex = 18
        '
        'TxtErrorWithdraw
        '
        Me.TxtErrorWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.TxtErrorWithdraw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtErrorWithdraw.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.TxtErrorWithdraw.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtErrorWithdraw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TxtErrorWithdraw.Location = New System.Drawing.Point(701, 674)
        Me.TxtErrorWithdraw.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtErrorWithdraw.Name = "TxtErrorWithdraw"
        Me.TxtErrorWithdraw.ReadOnly = True
        Me.TxtErrorWithdraw.Size = New System.Drawing.Size(431, 22)
        Me.TxtErrorWithdraw.TabIndex = 19
        '
        'BtnCancelExit
        '
        Me.BtnCancelExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnCancelExit.FlatAppearance.BorderSize = 0
        Me.BtnCancelExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelExit.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelExit.Location = New System.Drawing.Point(1196, 884)
        Me.BtnCancelExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancelExit.Name = "BtnCancelExit"
        Me.BtnCancelExit.Padding = New System.Windows.Forms.Padding(4, 0, 4, 5)
        Me.BtnCancelExit.Size = New System.Drawing.Size(162, 54)
        Me.BtnCancelExit.TabIndex = 20
        Me.BtnCancelExit.Text = "CANCEL"
        Me.BtnCancelExit.UseVisualStyleBackColor = False
        '
        'BtnCheckBalance
        '
        Me.BtnCheckBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnCheckBalance.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnCheckBalance.FlatAppearance.BorderSize = 0
        Me.BtnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheckBalance.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCheckBalance.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCheckBalance.Location = New System.Drawing.Point(338, 410)
        Me.BtnCheckBalance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCheckBalance.Name = "BtnCheckBalance"
        Me.BtnCheckBalance.Size = New System.Drawing.Size(260, 80)
        Me.BtnCheckBalance.TabIndex = 21
        Me.BtnCheckBalance.Text = "BALANCE"
        Me.BtnCheckBalance.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(255, 91)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(1225, 929)
        Me.Button3.TabIndex = 22
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(338, 152)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(260, 132)
        Me.Button4.TabIndex = 24
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(255, 1018)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(1225, 154)
        Me.Button5.TabIndex = 25
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Button6.Enabled = False
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(598, 1066)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(495, 60)
        Me.Button6.TabIndex = 26
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button7.Enabled = False
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(616, 1081)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(459, 31)
        Me.Button7.TabIndex = 27
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Button8.Enabled = False
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(615, 152)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(742, 629)
        Me.Button8.TabIndex = 28
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button9.Enabled = False
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(654, 184)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(659, 568)
        Me.Button9.TabIndex = 29
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(360, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.Label2.Size = New System.Drawing.Size(214, 87)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ATM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(745, 940)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "card"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(621, 940)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "▲"
        '
        'BtnCardUser
        '
        Me.BtnCardUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BtnCardUser.Enabled = False
        Me.BtnCardUser.FlatAppearance.BorderSize = 0
        Me.BtnCardUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCardUser.Location = New System.Drawing.Point(615, 938)
        Me.BtnCardUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCardUser.Name = "BtnCardUser"
        Me.BtnCardUser.Size = New System.Drawing.Size(190, 32)
        Me.BtnCardUser.TabIndex = 34
        Me.BtnCardUser.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Button11.Enabled = False
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(338, 290)
        Me.Button11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(259, 75)
        Me.Button11.TabIndex = 41
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button12.Enabled = False
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(348, 298)
        Me.Button12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(236, 56)
        Me.Button12.TabIndex = 42
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button13.Enabled = False
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(358, 306)
        Me.Button13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(216, 39)
        Me.Button13.TabIndex = 43
        Me.Button13.UseVisualStyleBackColor = False
        '
        'TxtUser
        '
        Me.TxtUser.AutoSize = True
        Me.TxtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TxtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TxtUser.Location = New System.Drawing.Point(360, 315)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(85, 22)
        Me.TxtUser.TabIndex = 44
        Me.TxtUser.Text = "user: N/A"
        Me.TxtUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSavings
        '
        Me.BtnSavings.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnSavings.FlatAppearance.BorderSize = 0
        Me.BtnSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSavings.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavings.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BtnSavings.Location = New System.Drawing.Point(338, 710)
        Me.BtnSavings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSavings.Name = "BtnSavings"
        Me.BtnSavings.Size = New System.Drawing.Size(260, 70)
        Me.BtnSavings.TabIndex = 45
        Me.BtnSavings.Text = "SAVINGS   ⛱︎"
        Me.BtnSavings.UseVisualStyleBackColor = False
        '
        'BtnCardslot
        '
        Me.BtnCardslot.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BtnCardslot.BackgroundImage = CType(resources.GetObject("BtnCardslot.BackgroundImage"), System.Drawing.Image)
        Me.BtnCardslot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCardslot.FlatAppearance.BorderSize = 0
        Me.BtnCardslot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCardslot.Location = New System.Drawing.Point(615, 815)
        Me.BtnCardslot.Name = "BtnCardslot"
        Me.BtnCardslot.Size = New System.Drawing.Size(190, 90)
        Me.BtnCardslot.TabIndex = 46
        Me.BtnCardslot.UseVisualStyleBackColor = False
        '
        'MyBankATM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1756, 1278)
        Me.Controls.Add(Me.BtnCardslot)
        Me.Controls.Add(Me.TxtProcessing)
        Me.Controls.Add(Me.BtnSavings)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCardUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtExit)
        Me.Controls.Add(Me.TxtErrorWithdraw)
        Me.Controls.Add(Me.TxtErrorDeposit)
        Me.Controls.Add(Me.InputWithdraw)
        Me.Controls.Add(Me.InputDeposit)
        Me.Controls.Add(Me.BtnDeposit)
        Me.Controls.Add(Me.BtnWithdraw)
        Me.Controls.Add(Me.TxtAccountBalance)
        Me.Controls.Add(Me.TxtAccountBalanceHeader)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.BtnCheckBalance)
        Me.Controls.Add(Me.BtnCancelExit)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Button3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MyBankATM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyBank - ATM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDeposit As Button

    Friend WithEvents BtnWithdraw As Button

    Friend WithEvents InputDeposit As TextBox

    Friend WithEvents InputWithdraw As TextBox

    Friend WithEvents TxtAccountBalanceHeader As Label

    Friend WithEvents BtnExit As Button

    Friend WithEvents TimerSavefile As Timer

    Friend WithEvents TimerExit As Timer

    Friend WithEvents Button1 As Button

    Friend WithEvents Button2 As Button

    Friend WithEvents TxtAccountBalance As TextBox

    Friend WithEvents TxtExit As TextBox

    Friend WithEvents TxtProcessing As TextBox

    Friend WithEvents TimerDeposit As Timer

    Friend WithEvents TimerWithdraw As Timer

    Friend WithEvents TxtErrorDeposit As TextBox

    Friend WithEvents TxtErrorWithdraw As TextBox

    Friend WithEvents BtnCancelExit As Button

    Friend WithEvents BtnCheckBalance As Button

    Friend WithEvents Button3 As Button

    Friend WithEvents Button4 As Button

    Friend WithEvents Button5 As Button

    Friend WithEvents Button6 As Button

    Friend WithEvents Button7 As Button

    Friend WithEvents Button8 As Button

    Friend WithEvents Button9 As Button

    Friend WithEvents Label2 As Label

    Friend WithEvents Label3 As Label

    Friend WithEvents Label1 As Label

    Friend WithEvents BtnCardUser As Button

    Friend WithEvents Button11 As Button

    Friend WithEvents Button12 As Button

    Friend WithEvents Button13 As Button

    Friend WithEvents TxtUser As Label

    Friend WithEvents BtnSavings As Button

    Friend WithEvents BtnCardslot As Button
End Class
