Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmRolePrivilege
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRolePrivilege))
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cboRoles = New System.Windows.Forms.ComboBox()
            Me.Grid = New System.Windows.Forms.DataGridView()
            Me.btnRole = New crsButton.cButton()
            Me.btnUndo = New crsButton.cButton()
            Me.btnEdit = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(12, 12)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(31, 14)
            Me.Label6.TabIndex = 135
            Me.Label6.Text = "Role:"
            '
            'cboRoles
            '
            Me.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRoles.FormattingEnabled = True
            Me.cboRoles.Location = New System.Drawing.Point(52, 7)
            Me.cboRoles.Name = "cboRoles"
            Me.cboRoles.Size = New System.Drawing.Size(316, 22)
            Me.cboRoles.TabIndex = 134
            '
            'Grid
            '
            Me.Grid.AllowUserToAddRows = False
            Me.Grid.AllowUserToDeleteRows = False
            Me.Grid.AllowUserToResizeRows = False
            Me.Grid.BackgroundColor = System.Drawing.Color.LightGray
            Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.Grid.Location = New System.Drawing.Point(12, 40)
            Me.Grid.Name = "Grid"
            Me.Grid.RowHeadersVisible = False
            Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.Grid.Size = New System.Drawing.Size(416, 340)
            Me.Grid.TabIndex = 140
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
            Me.btnRole.Location = New System.Drawing.Point(376, 8)
            Me.btnRole.Name = "btnRole"
            Me.btnRole.Size = New System.Drawing.Size(20, 20)
            Me.btnRole.TabIndex = 155
            Me.btnRole.UseVisualStyleBackColor = False
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
            Me.btnUndo.Location = New System.Drawing.Point(243, 392)
            Me.btnUndo.Name = "btnUndo"
            Me.btnUndo.Size = New System.Drawing.Size(85, 45)
            Me.btnUndo.TabIndex = 144
            Me.btnUndo.TabStop = False
            Me.btnUndo.UseVisualStyleBackColor = False
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
            Me.btnEdit.Location = New System.Drawing.Point(149, 392)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 45)
            Me.btnEdit.TabIndex = 142
            Me.btnEdit.TabStop = False
            Me.btnEdit.UseVisualStyleBackColor = False
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
            Me.btnSave.Location = New System.Drawing.Point(55, 392)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 143
            Me.btnSave.TabStop = False
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.ButtonType = crsButton.cButton.btnType.close2
            Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(336, 392)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 130
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'frmRolePrivilege
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.LightGray
            Me.ClientSize = New System.Drawing.Size(435, 451)
            Me.Controls.Add(Me.btnRole)
            Me.Controls.Add(Me.btnUndo)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.Grid)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.cboRoles)
            Me.Controls.Add(Me.btnClose)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmRolePrivilege"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Role Privileges"
            CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cboRoles As System.Windows.Forms.ComboBox
        Friend WithEvents Grid As System.Windows.Forms.DataGridView
        Friend WithEvents btnUndo As crsButton.cButton
        Friend WithEvents btnEdit As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnRole As crsButton.cButton
    End Class
End Namespace