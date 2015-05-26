Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmSalaryTable
        Inherits crsForm.cForms

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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalaryTable))
            Me.dgvGrid = New System.Windows.Forms.DataGridView()
            Me.cboAllowance = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cboSalaryScale = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ckbActive = New System.Windows.Forms.CheckBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cboType = New System.Windows.Forms.ComboBox()
            Me.btnClose = New crsButton.cButton()
            Me.btnCancel = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.btnEdit = New crsButton.cButton()
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvGrid
            '
            Me.dgvGrid.AllowUserToAddRows = False
            Me.dgvGrid.AllowUserToDeleteRows = False
            Me.dgvGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
            Me.dgvGrid.Location = New System.Drawing.Point(8, 94)
            Me.dgvGrid.Name = "dgvGrid"
            Me.dgvGrid.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.dgvGrid.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGrid.Size = New System.Drawing.Size(869, 379)
            Me.dgvGrid.TabIndex = 20
            '
            'cboAllowance
            '
            Me.cboAllowance.FormattingEnabled = True
            Me.cboAllowance.Location = New System.Drawing.Point(86, 66)
            Me.cboAllowance.Name = "cboAllowance"
            Me.cboAllowance.Size = New System.Drawing.Size(202, 22)
            Me.cboAllowance.TabIndex = 31
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(7, 43)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(36, 14)
            Me.Label2.TabIndex = 22
            Me.Label2.Text = "Type :"
            '
            'cboSalaryScale
            '
            Me.cboSalaryScale.FormattingEnabled = True
            Me.cboSalaryScale.Location = New System.Drawing.Point(86, 13)
            Me.cboSalaryScale.Name = "cboSalaryScale"
            Me.cboSalaryScale.Size = New System.Drawing.Size(202, 22)
            Me.cboSalaryScale.TabIndex = 31
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(7, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(74, 14)
            Me.Label1.TabIndex = 21
            Me.Label1.Text = "Salary Scale :"
            '
            'ckbActive
            '
            Me.ckbActive.AutoSize = True
            Me.ckbActive.Checked = True
            Me.ckbActive.CheckState = System.Windows.Forms.CheckState.Checked
            Me.ckbActive.Location = New System.Drawing.Point(786, 70)
            Me.ckbActive.Name = "ckbActive"
            Me.ckbActive.Size = New System.Drawing.Size(91, 18)
            Me.ckbActive.TabIndex = 32
            Me.ckbActive.Text = "Set As Active"
            Me.ckbActive.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Location = New System.Drawing.Point(7, 70)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(67, 14)
            Me.Label3.TabIndex = 22
            Me.Label3.Text = "Description :"
            '
            'cboType
            '
            Me.cboType.FormattingEnabled = True
            Me.cboType.Location = New System.Drawing.Point(86, 39)
            Me.cboType.Name = "cboType"
            Me.cboType.Size = New System.Drawing.Size(202, 22)
            Me.cboType.TabIndex = 31
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.ButtonType = crsButton.cButton.btnType.close
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(792, 487)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 48)
            Me.btnClose.TabIndex = 35
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.ButtonType = crsButton.cButton.btnType.undo
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
            Me.btnCancel.Location = New System.Drawing.Point(224, 487)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(85, 45)
            Me.btnCancel.TabIndex = 36
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnSave.BackColor = System.Drawing.Color.Transparent
            Me.btnSave.ButtonType = crsButton.cButton.btnType.save
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.Location = New System.Drawing.Point(116, 487)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 48)
            Me.btnSave.TabIndex = 33
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnEdit
            '
            Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnEdit.BackColor = System.Drawing.Color.Transparent
            Me.btnEdit.ButtonType = crsButton.cButton.btnType.edit
            Me.btnEdit.FlatAppearance.BorderSize = 0
            Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
            Me.btnEdit.Location = New System.Drawing.Point(8, 487)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 48)
            Me.btnEdit.TabIndex = 34
            Me.btnEdit.UseVisualStyleBackColor = False
            '
            'frmSalaryTable
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(885, 546)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.ckbActive)
            Me.Controls.Add(Me.cboType)
            Me.Controls.Add(Me.cboAllowance)
            Me.Controls.Add(Me.cboSalaryScale)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dgvGrid)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MinimizeBox = False
            Me.Name = "frmSalaryTable"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Salary Table"
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvGrid As System.Windows.Forms.DataGridView
        Friend WithEvents cboAllowance As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cboSalaryScale As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ckbActive As System.Windows.Forms.CheckBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboType As System.Windows.Forms.ComboBox
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnCancel As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnEdit As crsButton.cButton
    End Class
End Namespace