Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmOutstandingSummaryAL
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOutstandingSummaryAL))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgvTotal = New System.Windows.Forms.DataGridView()
            Me.btnClose = New crsButton.cButton()
            Me.btnPrint = New crsButton.cButton()
            Me.dgvGrid = New PENGRA.crsDataGridView()
            CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvTotal
            '
            Me.dgvTotal.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.dgvTotal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvTotal.Location = New System.Drawing.Point(7, 367)
            Me.dgvTotal.Name = "dgvTotal"
            Me.dgvTotal.Size = New System.Drawing.Size(833, 30)
            Me.dgvTotal.TabIndex = 24
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
            Me.btnClose.Location = New System.Drawing.Point(749, 418)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 25
            Me.btnClose.UseVisualStyleBackColor = False
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
            Me.btnPrint.Location = New System.Drawing.Point(557, 401)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(168, 60)
            Me.btnPrint.TabIndex = 26
            Me.btnPrint.UseVisualStyleBackColor = False
            '
            'dgvGrid
            '
            Me.dgvGrid.AllowUserToAddRows = False
            Me.dgvGrid.AllowUserToResizeColumns = False
            Me.dgvGrid.Anchor = System.Windows.Forms.AnchorStyles.None
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
            Me.dgvGrid.Location = New System.Drawing.Point(7, 16)
            Me.dgvGrid.Name = "dgvGrid"
            Me.dgvGrid.RowHeadersVisible = False
            Me.dgvGrid.Size = New System.Drawing.Size(833, 351)
            Me.dgvGrid.TabIndex = 27
            '
            'frmOutstandingSummary
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(846, 475)
            Me.Controls.Add(Me.dgvGrid)
            Me.Controls.Add(Me.btnPrint)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.dgvTotal)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmOutstandingSummary"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Details of Outstanding Beneficiaries"
            CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgvTotal As System.Windows.Forms.DataGridView
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnPrint As crsButton.cButton
        Friend WithEvents dgvGrid As PENGRA.crsDataGridView
    End Class
End Namespace