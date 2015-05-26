Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmConnect
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnect))
            Me.btnSave = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.btnTest = New crsButton.cButton()
            Me.txtUsername = New System.Windows.Forms.TextBox()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.Transparent
            Me.btnSave.ButtonType = crsButton.cButton.btnType.save
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.Location = New System.Drawing.Point(38, 230)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 0
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.ButtonType = crsButton.cButton.btnType.cancel
            Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(208, 230)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 1
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnTest
            '
            Me.btnTest.BackColor = System.Drawing.Color.Transparent
            Me.btnTest.ButtonType = crsButton.cButton.btnType.test_connection
            Me.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnTest.FlatAppearance.BorderSize = 0
            Me.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTest.Image = CType(resources.GetObject("btnTest.Image"), System.Drawing.Image)
            Me.btnTest.Location = New System.Drawing.Point(38, 159)
            Me.btnTest.Name = "btnTest"
            Me.btnTest.Size = New System.Drawing.Size(259, 60)
            Me.btnTest.TabIndex = 1
            Me.btnTest.UseVisualStyleBackColor = False
            '
            'txtUsername
            '
            Me.txtUsername.Location = New System.Drawing.Point(109, 94)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(191, 20)
            Me.txtUsername.TabIndex = 2
            '
            'txtPassword
            '
            Me.txtPassword.Location = New System.Drawing.Point(110, 128)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(190, 20)
            Me.txtPassword.TabIndex = 3
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(38, 98)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(62, 14)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Username :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(38, 132)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(63, 14)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Password :"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Location = New System.Drawing.Point(38, 32)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(263, 48)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Opal is unable to login to it's database server. Please enter the login informati" & _
                "on(Admin) below"
            '
            'frmConnect
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(331, 298)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.txtUsername)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnTest)
            Me.Controls.Add(Me.btnClose)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmConnect"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Connect"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnTest As crsButton.cButton
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label

    End Class
End Namespace