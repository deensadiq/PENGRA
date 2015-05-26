Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmAboveLimit
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAboveLimit))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvTotal = New System.Windows.Forms.DataGridView()
            Me.btnClose = New crsButton.cButton()
            Me.btnUndo = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.btnEdit = New crsButton.cButton()
            Me.cboMonth = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cboYear = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cboBenefit = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnPrint = New crsButton.cButton()
            Me.dgvGrid = New PENGRA.crsDataGridView()
            CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvTotal
            '
            Me.dgvTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvTotal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTotal.Location = New System.Drawing.Point(3, 480)
            Me.dgvTotal.Name = "dgvTotal"
            Me.dgvTotal.Size = New System.Drawing.Size(1111, 45)
            Me.dgvTotal.TabIndex = 51
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
            Me.btnClose.Location = New System.Drawing.Point(1029, 543)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 48
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnUndo
            '
            Me.btnUndo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnUndo.BackColor = System.Drawing.Color.Transparent
            Me.btnUndo.ButtonType = crsButton.cButton.btnType.undo
            Me.btnUndo.FlatAppearance.BorderSize = 0
            Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
            Me.btnUndo.Location = New System.Drawing.Point(275, 543)
            Me.btnUndo.Name = "btnUndo"
            Me.btnUndo.Size = New System.Drawing.Size(85, 45)
            Me.btnUndo.TabIndex = 49
            Me.btnUndo.UseVisualStyleBackColor = False
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
            Me.btnSave.Location = New System.Drawing.Point(141, 543)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 46
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
            Me.btnEdit.Location = New System.Drawing.Point(7, 543)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 45)
            Me.btnEdit.TabIndex = 47
            Me.btnEdit.UseVisualStyleBackColor = False
            '
            'cboMonth
            '
            Me.cboMonth.FormattingEnabled = True
            Me.cboMonth.Location = New System.Drawing.Point(80, 62)
            Me.cboMonth.Name = "cboMonth"
            Me.cboMonth.Size = New System.Drawing.Size(204, 22)
            Me.cboMonth.TabIndex = 42
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(3, 66)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(70, 14)
            Me.Label3.TabIndex = 43
            Me.Label3.Text = "Audit Month :"
            '
            'cboYear
            '
            Me.cboYear.FormattingEnabled = True
            Me.cboYear.Location = New System.Drawing.Point(80, 33)
            Me.cboYear.Name = "cboYear"
            Me.cboYear.Size = New System.Drawing.Size(204, 22)
            Me.cboYear.TabIndex = 41
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(3, 37)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(64, 14)
            Me.Label2.TabIndex = 44
            Me.Label2.Text = "Audit Year :"
            '
            'cboBenefit
            '
            Me.cboBenefit.FormattingEnabled = True
            Me.cboBenefit.Location = New System.Drawing.Point(80, 4)
            Me.cboBenefit.Name = "cboBenefit"
            Me.cboBenefit.Size = New System.Drawing.Size(204, 22)
            Me.cboBenefit.TabIndex = 40
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(3, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(73, 14)
            Me.Label1.TabIndex = 45
            Me.Label1.Text = "Benefit Type :"
            '
            'btnPrint
            '
            Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnPrint.BackColor = System.Drawing.Color.Transparent
            Me.btnPrint.ButtonType = crsButton.cButton.btnType.report
            Me.btnPrint.FlatAppearance.BorderSize = 0
            Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.Location = New System.Drawing.Point(839, 526)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(168, 60)
            Me.btnPrint.TabIndex = 52
            Me.btnPrint.UseVisualStyleBackColor = False
            '
            'dgvGrid
            '
            Me.dgvGrid.AllowUserToAddRows = False
            Me.dgvGrid.AllowUserToResizeColumns = False
            Me.dgvGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGrid.CausesValidation = False
            Me.dgvGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(250, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvGrid.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvGrid.EnableHeadersVisualStyles = False
            Me.dgvGrid.Location = New System.Drawing.Point(3, 87)
            Me.dgvGrid.Name = "dgvGrid"
            Me.dgvGrid.RowHeadersVisible = False
            Me.dgvGrid.Size = New System.Drawing.Size(1111, 393)
            Me.dgvGrid.TabIndex = 50
            '
            'frmAboveLimit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1117, 592)
            Me.Controls.Add(Me.btnPrint)
            Me.Controls.Add(Me.dgvTotal)
            Me.Controls.Add(Me.dgvGrid)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnUndo)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.cboMonth)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.cboYear)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboBenefit)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "frmAboveLimit"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmAboveLimit"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvTotal As System.Windows.Forms.DataGridView
        Friend WithEvents dgvGrid As PENGRA.crsDataGridView
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnUndo As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnEdit As crsButton.cButton
        Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboYear As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cboBenefit As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnPrint As crsButton.cButton
    End Class
End Namespace