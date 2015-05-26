
Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmUsers
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
            Me.Grid = New System.Windows.Forms.DataGridView()
            Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.txtUsername = New System.Windows.Forms.TextBox()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cboRoles = New System.Windows.Forms.ComboBox()
            Me.chkActive = New System.Windows.Forms.CheckBox()
            Me.btnRole = New crsButton.cButton()
            Me.picPhoto = New System.Windows.Forms.PictureBox()
            Me.picSign = New System.Windows.Forms.PictureBox()
            Me.btnSearch = New crsButton.cButton()
            Me.btnDelete = New crsButton.cButton()
            Me.btnUndo = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.btnEdit = New crsButton.cButton()
            Me.btnAdd = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picSign, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Grid
            '
            Me.Grid.AllowUserToAddRows = False
            Me.Grid.AllowUserToDeleteRows = False
            Me.Grid.BackgroundColor = System.Drawing.SystemColors.Control
            Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Grid.Location = New System.Drawing.Point(9, 16)
            Me.Grid.Name = "Grid"
            Me.Grid.ReadOnly = True
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Grid.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.Grid.Size = New System.Drawing.Size(363, 356)
            Me.Grid.TabIndex = 139
            '
            'txtConfirmPassword
            '
            Me.txtConfirmPassword.HideSelection = False
            Me.txtConfirmPassword.Location = New System.Drawing.Point(488, 231)
            Me.txtConfirmPassword.MaxLength = 20
            Me.txtConfirmPassword.Name = "txtConfirmPassword"
            Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtConfirmPassword.Size = New System.Drawing.Size(275, 20)
            Me.txtConfirmPassword.TabIndex = 3
            '
            'txtPassword
            '
            Me.txtPassword.HideSelection = False
            Me.txtPassword.Location = New System.Drawing.Point(488, 207)
            Me.txtPassword.MaxLength = 20
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(275, 20)
            Me.txtPassword.TabIndex = 2
            '
            'txtUsername
            '
            Me.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.txtUsername.Location = New System.Drawing.Point(488, 183)
            Me.txtUsername.MaxLength = 20
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(275, 20)
            Me.txtUsername.TabIndex = 1
            '
            'txtName
            '
            Me.txtName.Location = New System.Drawing.Point(488, 159)
            Me.txtName.MaxLength = 40
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New System.Drawing.Size(275, 20)
            Me.txtName.TabIndex = 0
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(381, 234)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(103, 14)
            Me.Label5.TabIndex = 146
            Me.Label5.Text = "Confirm Password :"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(381, 210)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(63, 14)
            Me.Label3.TabIndex = 147
            Me.Label3.Text = "Password :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(381, 186)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(62, 14)
            Me.Label2.TabIndex = 145
            Me.Label2.Text = "Username :"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(381, 162)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(59, 14)
            Me.Label1.TabIndex = 144
            Me.Label1.Text = "Full Name :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(381, 295)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(59, 14)
            Me.Label4.TabIndex = 151
            Me.Label4.Text = "Signature :"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(381, 262)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(34, 14)
            Me.Label6.TabIndex = 153
            Me.Label6.Text = "Role :"
            '
            'cboRoles
            '
            Me.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRoles.FormattingEnabled = True
            Me.cboRoles.Location = New System.Drawing.Point(488, 258)
            Me.cboRoles.Name = "cboRoles"
            Me.cboRoles.Size = New System.Drawing.Size(248, 22)
            Me.cboRoles.TabIndex = 4
            '
            'chkActive
            '
            Me.chkActive.AutoSize = True
            Me.chkActive.Location = New System.Drawing.Point(488, 133)
            Me.chkActive.Name = "chkActive"
            Me.chkActive.Size = New System.Drawing.Size(57, 18)
            Me.chkActive.TabIndex = 155
            Me.chkActive.Text = "Active"
            Me.chkActive.UseVisualStyleBackColor = True
            '
            'btnRole
            '
            Me.btnRole.BackColor = System.Drawing.Color.Transparent
            Me.btnRole.ButtonType = crsButton.cButton.btnType.add_combo
            Me.btnRole.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnRole.FlatAppearance.BorderSize = 0
            Me.btnRole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnRole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRole.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRole.Image = CType(resources.GetObject("btnRole.Image"), System.Drawing.Image)
            Me.btnRole.Location = New System.Drawing.Point(742, 259)
            Me.btnRole.Name = "btnRole"
            Me.btnRole.Size = New System.Drawing.Size(20, 20)
            Me.btnRole.TabIndex = 154
            Me.btnRole.UseVisualStyleBackColor = False
            '
            'picPhoto
            '
            Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picPhoto.Location = New System.Drawing.Point(632, 15)
            Me.picPhoto.Name = "picPhoto"
            Me.picPhoto.Size = New System.Drawing.Size(132, 132)
            Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picPhoto.TabIndex = 150
            Me.picPhoto.TabStop = False
            '
            'picSign
            '
            Me.picSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picSign.Location = New System.Drawing.Point(488, 291)
            Me.picSign.Name = "picSign"
            Me.picSign.Size = New System.Drawing.Size(275, 72)
            Me.picSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picSign.TabIndex = 149
            Me.picSign.TabStop = False
            '
            'btnSearch
            '
            Me.btnSearch.BackColor = System.Drawing.Color.Transparent
            Me.btnSearch.ButtonType = crsButton.cButton.btnType.search
            Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnSearch.FlatAppearance.BorderSize = 0
            Me.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
            Me.btnSearch.Location = New System.Drawing.Point(8, 398)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(89, 45)
            Me.btnSearch.TabIndex = 148
            Me.btnSearch.TabStop = False
            Me.btnSearch.UseVisualStyleBackColor = False
            '
            'btnDelete
            '
            Me.btnDelete.BackColor = System.Drawing.Color.Transparent
            Me.btnDelete.ButtonType = crsButton.cButton.btnType.remove
            Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnDelete.FlatAppearance.BorderSize = 0
            Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.Location = New System.Drawing.Point(577, 398)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(85, 45)
            Me.btnDelete.TabIndex = 135
            Me.btnDelete.UseVisualStyleBackColor = False
            '
            'btnUndo
            '
            Me.btnUndo.BackColor = System.Drawing.Color.Transparent
            Me.btnUndo.ButtonType = crsButton.cButton.btnType.undo
            Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnUndo.FlatAppearance.BorderSize = 0
            Me.btnUndo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
            Me.btnUndo.Location = New System.Drawing.Point(478, 398)
            Me.btnUndo.Name = "btnUndo"
            Me.btnUndo.Size = New System.Drawing.Size(85, 45)
            Me.btnUndo.TabIndex = 134
            Me.btnUndo.UseVisualStyleBackColor = False
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
            Me.btnSave.Location = New System.Drawing.Point(379, 398)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 133
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnEdit
            '
            Me.btnEdit.BackColor = System.Drawing.Color.Transparent
            Me.btnEdit.ButtonType = crsButton.cButton.btnType.edit
            Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnEdit.FlatAppearance.BorderSize = 0
            Me.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
            Me.btnEdit.Location = New System.Drawing.Point(280, 398)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 45)
            Me.btnEdit.TabIndex = 132
            Me.btnEdit.UseVisualStyleBackColor = False
            '
            'btnAdd
            '
            Me.btnAdd.BackColor = System.Drawing.Color.Transparent
            Me.btnAdd.ButtonType = crsButton.cButton.btnType.add
            Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnAdd.FlatAppearance.BorderSize = 0
            Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
            Me.btnAdd.Location = New System.Drawing.Point(181, 398)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(85, 45)
            Me.btnAdd.TabIndex = 131
            Me.btnAdd.UseVisualStyleBackColor = False
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
            Me.btnClose.Location = New System.Drawing.Point(676, 398)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 130
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'frmUsers
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(774, 477)
            Me.Controls.Add(Me.chkActive)
            Me.Controls.Add(Me.btnRole)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.cboRoles)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.picPhoto)
            Me.Controls.Add(Me.picSign)
            Me.Controls.Add(Me.btnSearch)
            Me.Controls.Add(Me.txtConfirmPassword)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.txtUsername)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Grid)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.btnUndo)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.btnAdd)
            Me.Controls.Add(Me.btnClose)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmUsers"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "User Account"
            CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picSign, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Grid As System.Windows.Forms.DataGridView
        Friend WithEvents btnDelete As crsButton.cButton
        Friend WithEvents btnUndo As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnEdit As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnAdd As crsButton.cButton
        Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents txtName As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnSearch As crsButton.cButton
        Friend WithEvents picSign As System.Windows.Forms.PictureBox
        Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cboRoles As System.Windows.Forms.ComboBox
        Friend WithEvents btnRole As crsButton.cButton
        Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    End Class
End Namespace