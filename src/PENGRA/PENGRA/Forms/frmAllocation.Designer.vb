Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmAllocation
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllocation))
            Me.dgvGrid = New System.Windows.Forms.DataGridView()
            Me.btnClose = New crsButton.cButton()
            Me.btnRemove = New crsButton.cButton()
            Me.btnCancel = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.btnEdit = New crsButton.cButton()
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvGrid
            '
            Me.dgvGrid.AllowUserToResizeColumns = False
            Me.dgvGrid.AllowUserToResizeRows = False
            Me.dgvGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
            Me.dgvGrid.EnableHeadersVisualStyles = False
            Me.dgvGrid.Location = New System.Drawing.Point(9, 22)
            Me.dgvGrid.Name = "dgvGrid"
            Me.dgvGrid.RowHeadersVisible = False
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.dgvGrid.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGrid.Size = New System.Drawing.Size(460, 337)
            Me.dgvGrid.TabIndex = 0
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.ButtonType = crsButton.cButton.btnType.close
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(384, 383)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 48)
            Me.btnClose.TabIndex = 5
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnRemove
            '
            Me.btnRemove.BackColor = System.Drawing.Color.Transparent
            Me.btnRemove.ButtonType = crsButton.cButton.btnType.remove
            Me.btnRemove.FlatAppearance.BorderSize = 0
            Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
            Me.btnRemove.Location = New System.Drawing.Point(291, 383)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(85, 48)
            Me.btnRemove.TabIndex = 6
            Me.btnRemove.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.ButtonType = crsButton.cButton.btnType.undo
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
            Me.btnCancel.Location = New System.Drawing.Point(198, 383)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(85, 45)
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.Transparent
            Me.btnSave.ButtonType = crsButton.cButton.btnType.save
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.Location = New System.Drawing.Point(105, 383)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 48)
            Me.btnSave.TabIndex = 2
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnEdit
            '
            Me.btnEdit.BackColor = System.Drawing.Color.Transparent
            Me.btnEdit.ButtonType = crsButton.cButton.btnType.edit
            Me.btnEdit.FlatAppearance.BorderSize = 0
            Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
            Me.btnEdit.Location = New System.Drawing.Point(12, 383)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 48)
            Me.btnEdit.TabIndex = 3
            Me.btnEdit.UseVisualStyleBackColor = False
            '
            'frmSettings
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(479, 452)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnRemove)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.dgvGrid)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmSettings"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Settings"
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvGrid As System.Windows.Forms.DataGridView
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnRemove As crsButton.cButton
        Friend WithEvents btnCancel As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnEdit As crsButton.cButton
    End Class
End Namespace