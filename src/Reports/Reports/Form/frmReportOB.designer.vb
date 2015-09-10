Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReportOB
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportOB))
            Me.Label5 = New System.Windows.Forms.Label()
            Me.cboLimitType = New System.Windows.Forms.ComboBox()
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
            Me.cboBenefitType = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cboMinistry = New System.Windows.Forms.ComboBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Location = New System.Drawing.Point(17, 111)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(34, 14)
            Me.Label5.TabIndex = 35
            Me.Label5.Text = "Limit :"
            '
            'cboLimitType
            '
            Me.cboLimitType.FormattingEnabled = True
            Me.cboLimitType.Location = New System.Drawing.Point(94, 107)
            Me.cboLimitType.Name = "cboLimitType"
            Me.cboLimitType.Size = New System.Drawing.Size(214, 22)
            Me.cboLimitType.TabIndex = 3
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Location = New System.Drawing.Point(17, 81)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(42, 14)
            Me.Label3.TabIndex = 31
            Me.Label3.Text = "Month :"
            '
            'cboMonth
            '
            Me.cboMonth.FormattingEnabled = True
            Me.cboMonth.Location = New System.Drawing.Point(94, 77)
            Me.cboMonth.Name = "cboMonth"
            Me.cboMonth.Size = New System.Drawing.Size(213, 22)
            Me.cboMonth.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(17, 21)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 14)
            Me.Label2.TabIndex = 29
            Me.Label2.Text = "Allocation :"
            '
            'cboBudget
            '
            Me.cboBudget.FormattingEnabled = True
            Me.cboBudget.Location = New System.Drawing.Point(94, 17)
            Me.cboBudget.Name = "cboBudget"
            Me.cboBudget.Size = New System.Drawing.Size(213, 22)
            Me.cboBudget.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbPreview)
            Me.GroupBox1.Controls.Add(Me.rbPrint)
            Me.GroupBox1.Location = New System.Drawing.Point(94, 209)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(214, 50)
            Me.GroupBox1.TabIndex = 44
            Me.GroupBox1.TabStop = False
            '
            'rbPreview
            '
            Me.rbPreview.AutoSize = True
            Me.rbPreview.Checked = True
            Me.rbPreview.Location = New System.Drawing.Point(130, 22)
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
            Me.rbPrint.Location = New System.Drawing.Point(19, 22)
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
            Me.Label1.Location = New System.Drawing.Point(17, 51)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(36, 14)
            Me.Label1.TabIndex = 48
            Me.Label1.Text = "Year :"
            '
            'cboYear
            '
            Me.cboYear.FormattingEnabled = True
            Me.cboYear.Location = New System.Drawing.Point(94, 47)
            Me.cboYear.Name = "cboYear"
            Me.cboYear.Size = New System.Drawing.Size(213, 22)
            Me.cboYear.TabIndex = 1
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
            Me.btnClose.Location = New System.Drawing.Point(199, 301)
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
            Me.btnOk.Location = New System.Drawing.Point(19, 286)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(168, 60)
            Me.btnOk.TabIndex = 45
            Me.btnOk.UseVisualStyleBackColor = False
            '
            'cboBenefitType
            '
            Me.cboBenefitType.FormattingEnabled = True
            Me.cboBenefitType.Location = New System.Drawing.Point(94, 135)
            Me.cboBenefitType.Name = "cboBenefitType"
            Me.cboBenefitType.Size = New System.Drawing.Size(213, 22)
            Me.cboBenefitType.TabIndex = 4
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Location = New System.Drawing.Point(17, 139)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(73, 14)
            Me.Label4.TabIndex = 31
            Me.Label4.Text = "Benefit Type :"
            '
            'cboMinistry
            '
            Me.cboMinistry.FormattingEnabled = True
            Me.cboMinistry.Location = New System.Drawing.Point(94, 165)
            Me.cboMinistry.Name = "cboMinistry"
            Me.cboMinistry.Size = New System.Drawing.Size(214, 22)
            Me.cboMinistry.TabIndex = 5
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(17, 169)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(50, 14)
            Me.Label6.TabIndex = 35
            Me.Label6.Text = "Ministry :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.ForeColor = System.Drawing.Color.Red
            Me.Label7.Location = New System.Drawing.Point(313, 17)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(11, 14)
            Me.Label7.TabIndex = 35
            Me.Label7.Text = "*"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.ForeColor = System.Drawing.Color.Red
            Me.Label8.Location = New System.Drawing.Point(313, 47)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(11, 14)
            Me.Label8.TabIndex = 35
            Me.Label8.Text = "*"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Red
            Me.Label9.Location = New System.Drawing.Point(313, 77)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(11, 14)
            Me.Label9.TabIndex = 35
            Me.Label9.Text = "*"
            '
            'frmReportOB
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.NavajoWhite
            Me.ClientSize = New System.Drawing.Size(343, 387)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cboYear)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.cboMinistry)
            Me.Controls.Add(Me.cboLimitType)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.cboBenefitType)
            Me.Controls.Add(Me.cboMonth)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboBudget)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmReportOB"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Report SCCS"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cboLimitType As System.Windows.Forms.ComboBox
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
        Friend WithEvents cboBenefitType As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cboMinistry As System.Windows.Forms.ComboBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
    End Class
End Namespace