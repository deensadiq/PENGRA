
Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmChangePassword
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtOPassword = New System.Windows.Forms.TextBox()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnSave = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(20, 54)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(89, 14)
            Me.Label3.TabIndex = 124
            Me.Label3.Text = "New Password :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(30, 30)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(79, 14)
            Me.Label2.TabIndex = 123
            Me.Label2.Text = "Old Password:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtOPassword
            '
            Me.txtOPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.txtOPassword.Location = New System.Drawing.Point(116, 29)
            Me.txtOPassword.MaxLength = 20
            Me.txtOPassword.Name = "txtOPassword"
            Me.txtOPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtOPassword.Size = New System.Drawing.Size(276, 20)
            Me.txtOPassword.TabIndex = 1
            '
            'txtPassword
            '
            Me.txtPassword.HideSelection = False
            Me.txtPassword.Location = New System.Drawing.Point(116, 53)
            Me.txtPassword.MaxLength = 20
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(276, 20)
            Me.txtPassword.TabIndex = 3
            '
            'txtConfirmPassword
            '
            Me.txtConfirmPassword.HideSelection = False
            Me.txtConfirmPassword.Location = New System.Drawing.Point(116, 77)
            Me.txtConfirmPassword.MaxLength = 20
            Me.txtConfirmPassword.Name = "txtConfirmPassword"
            Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtConfirmPassword.Size = New System.Drawing.Size(276, 20)
            Me.txtConfirmPassword.TabIndex = 4
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 78)
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
            Me.btnSave.Location = New System.Drawing.Point(208, 116)
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
            Me.btnClose.Location = New System.Drawing.Point(304, 116)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 130
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'frmChangePassword
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(409, 183)
            Me.Controls.Add(Me.txtConfirmPassword)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.txtOPassword)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmChangePassword"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Change Password"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtOPassword As System.Windows.Forms.TextBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
    End Class
End Namespace