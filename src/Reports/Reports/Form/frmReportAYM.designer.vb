Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReportAYM
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportAYM))
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cboMonth = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cboBudget = New System.Windows.Forms.ComboBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbPreview = New System.Windows.Forms.RadioButton()
            Me.rbPrint = New System.Windows.Forms.RadioButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cboYear = New System.Windows.Forms.ComboBox()
            Me.btnClose = New crsButton.cButton()
            Me.btnOk = New crsButton.cButton()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Location = New System.Drawing.Point(10, 93)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(42, 14)
            Me.Label3.TabIndex = 31
            Me.Label3.Text = "Month :"
            '
            'cboMonth
            '
            Me.cboMonth.FormattingEnabled = True
            Me.cboMonth.Location = New System.Drawing.Point(76, 89)
            Me.cboMonth.Name = "cboMonth"
            Me.cboMonth.Size = New System.Drawing.Size(213, 22)
            Me.cboMonth.TabIndex = 30
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(10, 21)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 14)
            Me.Label2.TabIndex = 29
            Me.Label2.Text = "Allocation :"
            '
            'cboBudget
            '
            Me.cboBudget.FormattingEnabled = True
            Me.cboBudget.Location = New System.Drawing.Point(76, 17)
            Me.cboBudget.Name = "cboBudget"
            Me.cboBudget.Size = New System.Drawing.Size(213, 22)
            Me.cboBudget.TabIndex = 28
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbPreview)
            Me.GroupBox1.Controls.Add(Me.rbPrint)
            Me.GroupBox1.Location = New System.Drawing.Point(76, 135)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(213, 50)
            Me.GroupBox1.TabIndex = 44
            Me.GroupBox1.TabStop = False
            '
            'rbPreview
            '
            Me.rbPreview.AutoSize = True
            Me.rbPreview.Checked = True
            Me.rbPreview.Location = New System.Drawing.Point(141, 22)
            Me.rbPreview.Name = "rbPreview"
            Me.rbPreview.Size = New System.Drawing.Size(65, 18)
            Me.rbPreview.TabIndex = 1
            Me.rbPreview.TabStop = True
            Me.rbPreview.Text = "Preview"
            Me.rbPreview.UseVisualStyleBackColor = True
            '
            'rbPrint
            '
            Me.rbPrint.AutoSize = True
            Me.rbPrint.Location = New System.Drawing.Point(21, 22)
            Me.rbPrint.Name = "rbPrint"
            Me.rbPrint.Size = New System.Drawing.Size(46, 18)
            Me.rbPrint.TabIndex = 0
            Me.rbPrint.Text = "Print"
            Me.rbPrint.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(10, 57)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(36, 14)
            Me.Label1.TabIndex = 48
            Me.Label1.Text = "Year :"
            '
            'cboYear
            '
            Me.cboYear.FormattingEnabled = True
            Me.cboYear.Location = New System.Drawing.Point(76, 53)
            Me.cboYear.Name = "cboYear"
            Me.cboYear.Size = New System.Drawing.Size(213, 22)
            Me.cboYear.TabIndex = 47
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
            Me.btnClose.Location = New System.Drawing.Point(199, 219)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 46
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnOk
            '
            Me.btnOk.BackColor = System.Drawing.Color.Transparent
            Me.btnOk.ButtonType = crsButton.cButton.btnType.report
            Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnOk.FlatAppearance.BorderSize = 0
            Me.btnOk.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
            Me.btnOk.Location = New System.Drawing.Point(19, 204)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(168, 60)
            Me.btnOk.TabIndex = 45
            Me.btnOk.UseVisualStyleBackColor = False
            '
            'frmReportAYM
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.NavajoWhite
            Me.ClientSize = New System.Drawing.Size(313, 298)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cboYear)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.cboMonth)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboBudget)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmReportAYM"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Report SCCS"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cboBudget As System.Windows.Forms.ComboBox
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnOk As crsButton.cButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbPreview As System.Windows.Forms.RadioButton
        Friend WithEvents rbPrint As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    End Class
End Namespace