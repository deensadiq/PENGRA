
Namespace cForm
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmRegisterUser
        Inherits crsForm.cForms

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterUser))
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtUsername = New System.Windows.Forms.TextBox()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnSave = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cboRoles = New System.Windows.Forms.ComboBox()
            Me.SuspendLayout()
            '
            'txtName
            '
            Me.txtName.Location = New System.Drawing.Point(116, 11)
            Me.txtName.MaxLength = 40
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New System.Drawing.Size(276, 20)
            Me.txtName.TabIndex = 0
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(46, 60)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(63, 14)
            Me.Label3.TabIndex = 124
            Me.Label3.Text = "Password :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(47, 36)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(62, 14)
            Me.Label2.TabIndex = 123
            Me.Label2.Text = "Username :"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(50, 12)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(59, 14)
            Me.Label1.TabIndex = 122
            Me.Label1.Text = "Full Name :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtUsername
            '
            Me.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.txtUsername.Location = New System.Drawing.Point(116, 35)
            Me.txtUsername.MaxLength = 20
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(276, 20)
            Me.txtUsername.TabIndex = 1
            '
            'txtPassword
            '
            Me.txtPassword.HideSelection = False
            Me.txtPassword.Location = New System.Drawing.Point(116, 59)
            Me.txtPassword.MaxLength = 20
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(276, 20)
            Me.txtPassword.TabIndex = 3
            '
            'txtConfirmPassword
            '
            Me.txtConfirmPassword.HideSelection = False
            Me.txtConfirmPassword.Location = New System.Drawing.Point(116, 83)
            Me.txtConfirmPassword.MaxLength = 20
            Me.txtConfirmPassword.Name = "txtConfirmPassword"
            Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtConfirmPassword.Size = New System.Drawing.Size(276, 20)
            Me.txtConfirmPassword.TabIndex = 4
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 84)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(103, 14)
            Me.Label5.TabIndex = 124
            Me.Label5.Text = "Confirm Password :"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.Transparent
            Me.btnSave.ButtonType = crsButton.cButton.btnType.save
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.Location = New System.Drawing.Point(208, 164)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 133
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.ButtonType = crsButton.cButton.btnType.close2
            Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(304, 164)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 130
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(75, 115)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(34, 14)
            Me.Label6.TabIndex = 155
            Me.Label6.Text = "Role :"
            '
            'cboRoles
            '
            Me.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRoles.FormattingEnabled = True
            Me.cboRoles.Location = New System.Drawing.Point(116, 112)
            Me.cboRoles.Name = "cboRoles"
            Me.cboRoles.Size = New System.Drawing.Size(276, 22)
            Me.cboRoles.TabIndex = 154
            '
            'frmRegisterUser
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(409, 220)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.cboRoles)
            Me.Controls.Add(Me.txtConfirmPassword)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.txtUsername)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmRegisterUser"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "User Registration"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents txtName As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cboRoles As System.Windows.Forms.ComboBox
    End Class
End Namespace