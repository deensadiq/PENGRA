Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReportV
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportV))
            Me.Label4 = New System.Windows.Forms.Label
            Me.cboAssessment = New System.Windows.Forms.ComboBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.cboSession = New System.Windows.Forms.ComboBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.cboSemester = New System.Windows.Forms.ComboBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.cboClass = New System.Windows.Forms.ComboBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.cboCategory = New System.Windows.Forms.ComboBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.cboYeargroup = New System.Windows.Forms.ComboBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.rbPreview = New System.Windows.Forms.RadioButton
            Me.rbPrint = New System.Windows.Forms.RadioButton
            Me.btnClose = New crsButton.cButton
            Me.btnOk = New crsButton.cButton
            Me.Label7 = New System.Windows.Forms.Label
            Me.cboSubject = New System.Windows.Forms.ComboBox
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Location = New System.Drawing.Point(26, 195)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(71, 14)
            Me.Label4.TabIndex = 37
            Me.Label4.Text = "Assessment:"
            '
            'cboAssessment
            '
            Me.cboAssessment.FormattingEnabled = True
            Me.cboAssessment.Location = New System.Drawing.Point(103, 191)
            Me.cboAssessment.Name = "cboAssessment"
            Me.cboAssessment.Size = New System.Drawing.Size(214, 22)
            Me.cboAssessment.TabIndex = 36
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Location = New System.Drawing.Point(48, 106)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(49, 14)
            Me.Label5.TabIndex = 35
            Me.Label5.Text = "Session:"
            '
            'cboSession
            '
            Me.cboSession.FormattingEnabled = True
            Me.cboSession.Location = New System.Drawing.Point(103, 102)
            Me.cboSession.Name = "cboSession"
            Me.cboSession.Size = New System.Drawing.Size(214, 22)
            Me.cboSession.TabIndex = 34
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(63, 136)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(34, 14)
            Me.Label6.TabIndex = 33
            Me.Label6.Text = "Term:"
            '
            'cboSemester
            '
            Me.cboSemester.FormattingEnabled = True
            Me.cboSemester.Location = New System.Drawing.Point(103, 132)
            Me.cboSemester.Name = "cboSemester"
            Me.cboSemester.Size = New System.Drawing.Size(214, 22)
            Me.cboSemester.TabIndex = 32
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Location = New System.Drawing.Point(60, 77)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(37, 14)
            Me.Label3.TabIndex = 31
            Me.Label3.Text = "Class:"
            '
            'cboClass
            '
            Me.cboClass.FormattingEnabled = True
            Me.cboClass.Location = New System.Drawing.Point(103, 73)
            Me.cboClass.Name = "cboClass"
            Me.cboClass.Size = New System.Drawing.Size(213, 22)
            Me.cboClass.TabIndex = 30
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(51, 19)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 14)
            Me.Label2.TabIndex = 29
            Me.Label2.Text = "Section:"
            '
            'cboCategory
            '
            Me.cboCategory.FormattingEnabled = True
            Me.cboCategory.Location = New System.Drawing.Point(103, 15)
            Me.cboCategory.Name = "cboCategory"
            Me.cboCategory.Size = New System.Drawing.Size(213, 22)
            Me.cboCategory.TabIndex = 28
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(35, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(67, 14)
            Me.Label1.TabIndex = 27
            Me.Label1.Text = "Year Group:"
            '
            'cboYeargroup
            '
            Me.cboYeargroup.FormattingEnabled = True
            Me.cboYeargroup.Location = New System.Drawing.Point(103, 44)
            Me.cboYeargroup.Name = "cboYeargroup"
            Me.cboYeargroup.Size = New System.Drawing.Size(213, 22)
            Me.cboYeargroup.TabIndex = 26
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbPreview)
            Me.GroupBox1.Controls.Add(Me.rbPrint)
            Me.GroupBox1.Location = New System.Drawing.Point(99, 224)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(225, 50)
            Me.GroupBox1.TabIndex = 38
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
            Me.btnClose.Location = New System.Drawing.Point(240, 307)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 40
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
            Me.btnOk.Location = New System.Drawing.Point(59, 292)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(168, 60)
            Me.btnOk.TabIndex = 39
            Me.btnOk.UseVisualStyleBackColor = False
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Location = New System.Drawing.Point(51, 165)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(46, 14)
            Me.Label7.TabIndex = 42
            Me.Label7.Text = "Subject:"
            '
            'cboSubject
            '
            Me.cboSubject.FormattingEnabled = True
            Me.cboSubject.Location = New System.Drawing.Point(103, 161)
            Me.cboSubject.Name = "cboSubject"
            Me.cboSubject.Size = New System.Drawing.Size(214, 22)
            Me.cboSubject.TabIndex = 41
            '
            'frmReportSCCSSSA
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.NavajoWhite
            Me.ClientSize = New System.Drawing.Size(340, 360)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.cboSubject)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.cboAssessment)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.cboSession)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.cboSemester)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.cboClass)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboCategory)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cboYeargroup)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmReportSCCSSSA"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Report SCCSSSA"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cboAssessment As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cboSession As System.Windows.Forms.ComboBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cboSemester As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboClass As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cboYeargroup As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbPreview As System.Windows.Forms.RadioButton
        Friend WithEvents rbPrint As System.Windows.Forms.RadioButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnOk As crsButton.cButton
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cboSubject As System.Windows.Forms.ComboBox
    End Class
End Namespace