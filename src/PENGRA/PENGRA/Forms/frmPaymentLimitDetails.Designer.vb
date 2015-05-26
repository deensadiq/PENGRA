Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPaymentLimitDetails
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentLimitDetails))
            Me.dgvGrid = New System.Windows.Forms.DataGridView()
            Me.lblProfileTitle = New System.Windows.Forms.Label()
            Me.dgvTotal = New System.Windows.Forms.DataGridView()
            Me.btnPrint = New crsButton.cButton()
            Me.btnRemove = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.btnUndo = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.btnEdit = New crsButton.cButton()
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvGrid
            '
            Me.dgvGrid.AllowUserToAddRows = False
            Me.dgvGrid.AllowUserToDeleteRows = False
            Me.dgvGrid.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.dgvGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
            Me.dgvGrid.Location = New System.Drawing.Point(8, 37)
            Me.dgvGrid.MinimumSize = New System.Drawing.Size(810, 325)
            Me.dgvGrid.Name = "dgvGrid"
            Me.dgvGrid.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.dgvGrid.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGrid.Size = New System.Drawing.Size(810, 325)
            Me.dgvGrid.TabIndex = 20
            '
            'lblProfileTitle
            '
            Me.lblProfileTitle.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProfileTitle.Location = New System.Drawing.Point(7, 9)
            Me.lblProfileTitle.Name = "lblProfileTitle"
            Me.lblProfileTitle.Size = New System.Drawing.Size(774, 20)
            Me.lblProfileTitle.TabIndex = 22
            Me.lblProfileTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dgvTotal
            '
            Me.dgvTotal.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.dgvTotal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTotal.Location = New System.Drawing.Point(8, 362)
            Me.dgvTotal.Name = "dgvTotal"
            Me.dgvTotal.Size = New System.Drawing.Size(810, 29)
            Me.dgvTotal.TabIndex = 24
            '
            'btnPrint
            '
            Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnPrint.BackColor = System.Drawing.Color.Transparent
            Me.btnPrint.ButtonType = crsButton.cButton.btnType.report
            Me.btnPrint.FlatAppearance.BorderSize = 0
            Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.Location = New System.Drawing.Point(530, 397)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(168, 60)
            Me.btnPrint.TabIndex = 31
            Me.btnPrint.UseVisualStyleBackColor = False
            '
            'btnRemove
            '
            Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnRemove.BackColor = System.Drawing.Color.Transparent
            Me.btnRemove.ButtonType = crsButton.cButton.btnType.remove
            Me.btnRemove.FlatAppearance.BorderSize = 0
            Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
            Me.btnRemove.Location = New System.Drawing.Point(335, 412)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(85, 45)
            Me.btnRemove.TabIndex = 30
            Me.btnRemove.UseVisualStyleBackColor = False
            '
            'btnClose
            '
            Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.ButtonType = crsButton.cButton.btnType.close
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(733, 412)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 29
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnUndo
            '
            Me.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnUndo.BackColor = System.Drawing.Color.Transparent
            Me.btnUndo.ButtonType = crsButton.cButton.btnType.undo
            Me.btnUndo.FlatAppearance.BorderSize = 0
            Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
            Me.btnUndo.Location = New System.Drawing.Point(226, 412)
            Me.btnUndo.Name = "btnUndo"
            Me.btnUndo.Size = New System.Drawing.Size(85, 45)
            Me.btnUndo.TabIndex = 26
            Me.btnUndo.UseVisualStyleBackColor = False
            '
            'btnSave
            '
            Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnSave.BackColor = System.Drawing.Color.Transparent
            Me.btnSave.ButtonType = crsButton.cButton.btnType.save
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.Location = New System.Drawing.Point(117, 412)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 27
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnEdit
            '
            Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnEdit.BackColor = System.Drawing.Color.Transparent
            Me.btnEdit.ButtonType = crsButton.cButton.btnType.edit
            Me.btnEdit.FlatAppearance.BorderSize = 0
            Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
            Me.btnEdit.Location = New System.Drawing.Point(8, 412)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 45)
            Me.btnEdit.TabIndex = 28
            Me.btnEdit.UseVisualStyleBackColor = False
            '
            'frmPaymentDetails
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(827, 469)
            Me.Controls.Add(Me.btnPrint)
            Me.Controls.Add(Me.btnRemove)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnUndo)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.dgvTotal)
            Me.Controls.Add(Me.lblProfileTitle)
            Me.Controls.Add(Me.dgvGrid)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmPaymentDetails"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Details of Outstanding Beneficiaries"
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvGrid As System.Windows.Forms.DataGridView
        Friend WithEvents lblProfileTitle As System.Windows.Forms.Label
        Friend WithEvents dgvTotal As System.Windows.Forms.DataGridView
        Friend WithEvents btnPrint As crsButton.cButton
        Friend WithEvents btnRemove As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnUndo As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnEdit As crsButton.cButton
    End Class
End Namespace