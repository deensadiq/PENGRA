Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReportLOB
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportLOB))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbPreview = New System.Windows.Forms.RadioButton()
            Me.rbPrint = New System.Windows.Forms.RadioButton()
            Me.rbtListOfBeneficiaries = New System.Windows.Forms.RadioButton()
            Me.rbtListRetire = New System.Windows.Forms.RadioButton()
            Me.rbtListDeceased = New System.Windows.Forms.RadioButton()
            Me.rbtSummaryBK = New System.Windows.Forms.RadioButton()
            Me.rbtSummary = New System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnClose = New crsButton.cButton()
            Me.btnOk = New crsButton.cButton()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbPreview)
            Me.GroupBox1.Controls.Add(Me.rbPrint)
            Me.GroupBox1.Location = New System.Drawing.Point(31, 193)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(233, 50)
            Me.GroupBox1.TabIndex = 44
            Me.GroupBox1.TabStop = False
            '
            'rbPreview
            '
            Me.rbPreview.AutoSize = True
            Me.rbPreview.Checked = True
            Me.rbPreview.Location = New System.Drawing.Point(144, 22)
            Me.rbPreview.Name = "rbPreview"
            Me.rbPreview.Size = New System.Drawing.Size(63, 17)
            Me.rbPreview.TabIndex = 1
            Me.rbPreview.TabStop = True
            Me.rbPreview.Text = "Preview"
            Me.rbPreview.UseVisualStyleBackColor = True
            '
            'rbPrint
            '
            Me.rbPrint.AutoSize = True
            Me.rbPrint.Location = New System.Drawing.Point(24, 22)
            Me.rbPrint.Name = "rbPrint"
            Me.rbPrint.Size = New System.Drawing.Size(46, 17)
            Me.rbPrint.TabIndex = 0
            Me.rbPrint.Text = "Print"
            Me.rbPrint.UseVisualStyleBackColor = True
            '
            'rbtListOfBeneficiaries
            '
            Me.rbtListOfBeneficiaries.AutoSize = True
            Me.rbtListOfBeneficiaries.Checked = True
            Me.rbtListOfBeneficiaries.Location = New System.Drawing.Point(11, 18)
            Me.rbtListOfBeneficiaries.Name = "rbtListOfBeneficiaries"
            Me.rbtListOfBeneficiaries.Size = New System.Drawing.Size(118, 17)
            Me.rbtListOfBeneficiaries.TabIndex = 47
            Me.rbtListOfBeneficiaries.TabStop = True
            Me.rbtListOfBeneficiaries.Text = "List Of Beneficiaries"
            Me.rbtListOfBeneficiaries.UseVisualStyleBackColor = True
            '
            'rbtListRetire
            '
            Me.rbtListRetire.AutoSize = True
            Me.rbtListRetire.Location = New System.Drawing.Point(11, 50)
            Me.rbtListRetire.Name = "rbtListRetire"
            Me.rbtListRetire.Size = New System.Drawing.Size(155, 17)
            Me.rbtListRetire.TabIndex = 47
            Me.rbtListRetire.TabStop = True
            Me.rbtListRetire.Text = "List Of Retiree Beneficiaries"
            Me.rbtListRetire.UseVisualStyleBackColor = True
            '
            'rbtListDeceased
            '
            Me.rbtListDeceased.AutoSize = True
            Me.rbtListDeceased.Location = New System.Drawing.Point(11, 82)
            Me.rbtListDeceased.Name = "rbtListDeceased"
            Me.rbtListDeceased.Size = New System.Drawing.Size(170, 17)
            Me.rbtListDeceased.TabIndex = 47
            Me.rbtListDeceased.TabStop = True
            Me.rbtListDeceased.Text = "List Of Deceased Beneficiaries"
            Me.rbtListDeceased.UseVisualStyleBackColor = True
            '
            'rbtSummaryBK
            '
            Me.rbtSummaryBK.AutoSize = True
            Me.rbtSummaryBK.Location = New System.Drawing.Point(11, 114)
            Me.rbtSummaryBK.Name = "rbtSummaryBK"
            Me.rbtSummaryBK.Size = New System.Drawing.Size(202, 17)
            Me.rbtSummaryBK.TabIndex = 47
            Me.rbtSummaryBK.TabStop = True
            Me.rbtSummaryBK.Text = "Summary Breakdown Of Beneficiaries"
            Me.rbtSummaryBK.UseVisualStyleBackColor = True
            '
            'rbtSummary
            '
            Me.rbtSummary.AutoSize = True
            Me.rbtSummary.Location = New System.Drawing.Point(11, 146)
            Me.rbtSummary.Name = "rbtSummary"
            Me.rbtSummary.Size = New System.Drawing.Size(145, 17)
            Me.rbtSummary.TabIndex = 47
            Me.rbtSummary.TabStop = True
            Me.rbtSummary.Text = "Summary Of Beneficiaries"
            Me.rbtSummary.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rbtListDeceased)
            Me.GroupBox2.Controls.Add(Me.rbtSummary)
            Me.GroupBox2.Controls.Add(Me.rbtListOfBeneficiaries)
            Me.GroupBox2.Controls.Add(Me.rbtSummaryBK)
            Me.GroupBox2.Controls.Add(Me.rbtListRetire)
            Me.GroupBox2.Location = New System.Drawing.Point(31, 7)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(233, 181)
            Me.GroupBox2.TabIndex = 48
            Me.GroupBox2.TabStop = False
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
            Me.btnClose.Location = New System.Drawing.Point(195, 273)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 53
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
            Me.btnOk.Location = New System.Drawing.Point(15, 258)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(168, 60)
            Me.btnOk.TabIndex = 52
            Me.btnOk.UseVisualStyleBackColor = False
            '
            'frmReportLOB
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.NavajoWhite
            Me.ClientSize = New System.Drawing.Size(294, 329)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmReportLOB"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Report BYM"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbPreview As System.Windows.Forms.RadioButton
        Friend WithEvents rbPrint As System.Windows.Forms.RadioButton
        Friend WithEvents rbtListOfBeneficiaries As System.Windows.Forms.RadioButton
        Friend WithEvents rbtListRetire As System.Windows.Forms.RadioButton
        Friend WithEvents rbtListDeceased As System.Windows.Forms.RadioButton
        Friend WithEvents rbtSummaryBK As System.Windows.Forms.RadioButton
        Friend WithEvents rbtSummary As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnOk As crsButton.cButton
    End Class
End Namespace