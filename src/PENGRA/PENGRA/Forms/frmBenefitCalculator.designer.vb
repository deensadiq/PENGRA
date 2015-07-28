Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBenefitCalculator
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBenefitCalculator))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtDeathPension = New System.Windows.Forms.TextBox()
            Me.txtPension = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtPensionArrears = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtGratuity = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtConsolidated = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.CButton1 = New crsButton.cButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cboSalaryScale = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cboLevel = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cboStep = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cboBenefitType = New System.Windows.Forms.ComboBox()
            Me.dtpDAA = New System.Windows.Forms.DateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpPensionWEF = New System.Windows.Forms.DateTimePicker()
            Me.txtGratuityPerc = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtPensionPerc = New System.Windows.Forms.TextBox()
            Me.btnClose = New crsButton.cButton()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtDeathPension)
            Me.GroupBox1.Controls.Add(Me.txtPension)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.txtPensionArrears)
            Me.GroupBox1.Controls.Add(Me.Label12)
            Me.GroupBox1.Controls.Add(Me.txtGratuity)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.txtConsolidated)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Location = New System.Drawing.Point(6, 144)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(612, 100)
            Me.GroupBox1.TabIndex = 22
            Me.GroupBox1.TabStop = False
            '
            'txtDeathPension
            '
            Me.txtDeathPension.BackColor = System.Drawing.Color.White
            Me.txtDeathPension.Enabled = False
            Me.txtDeathPension.Location = New System.Drawing.Point(400, 43)
            Me.txtDeathPension.Name = "txtDeathPension"
            Me.txtDeathPension.ReadOnly = True
            Me.txtDeathPension.Size = New System.Drawing.Size(200, 20)
            Me.txtDeathPension.TabIndex = 26
            Me.txtDeathPension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtPension
            '
            Me.txtPension.BackColor = System.Drawing.Color.White
            Me.txtPension.Enabled = False
            Me.txtPension.Location = New System.Drawing.Point(96, 69)
            Me.txtPension.Name = "txtPension"
            Me.txtPension.ReadOnly = True
            Me.txtPension.Size = New System.Drawing.Size(200, 20)
            Me.txtPension.TabIndex = 26
            Me.txtPension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(304, 46)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(82, 14)
            Me.Label13.TabIndex = 23
            Me.Label13.Text = "Death Pension :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(7, 72)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(51, 14)
            Me.Label11.TabIndex = 23
            Me.Label11.Text = "Pension :"
            '
            'txtPensionArrears
            '
            Me.txtPensionArrears.BackColor = System.Drawing.Color.White
            Me.txtPensionArrears.Enabled = False
            Me.txtPensionArrears.Location = New System.Drawing.Point(400, 17)
            Me.txtPensionArrears.Name = "txtPensionArrears"
            Me.txtPensionArrears.ReadOnly = True
            Me.txtPensionArrears.Size = New System.Drawing.Size(200, 20)
            Me.txtPensionArrears.TabIndex = 26
            Me.txtPensionArrears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(304, 20)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(91, 14)
            Me.Label12.TabIndex = 23
            Me.Label12.Text = "Pension Arrears :"
            '
            'txtGratuity
            '
            Me.txtGratuity.BackColor = System.Drawing.Color.White
            Me.txtGratuity.Enabled = False
            Me.txtGratuity.Location = New System.Drawing.Point(96, 43)
            Me.txtGratuity.Name = "txtGratuity"
            Me.txtGratuity.ReadOnly = True
            Me.txtGratuity.Size = New System.Drawing.Size(200, 20)
            Me.txtGratuity.TabIndex = 26
            Me.txtGratuity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(7, 46)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(51, 14)
            Me.Label10.TabIndex = 23
            Me.Label10.Text = "Gratuity :"
            '
            'txtConsolidated
            '
            Me.txtConsolidated.BackColor = System.Drawing.Color.White
            Me.txtConsolidated.Enabled = False
            Me.txtConsolidated.Location = New System.Drawing.Point(96, 17)
            Me.txtConsolidated.Name = "txtConsolidated"
            Me.txtConsolidated.ReadOnly = True
            Me.txtConsolidated.Size = New System.Drawing.Size(200, 20)
            Me.txtConsolidated.TabIndex = 26
            Me.txtConsolidated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(7, 20)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(75, 14)
            Me.Label9.TabIndex = 23
            Me.Label9.Text = "Consolidated :"
            '
            'CButton1
            '
            Me.CButton1.BackColor = System.Drawing.Color.Transparent
            Me.CButton1.ButtonType = crsButton.cButton.btnType.none
            Me.CButton1.FlatAppearance.BorderSize = 0
            Me.CButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.CButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.CButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.CButton1.Location = New System.Drawing.Point(20, 304)
            Me.CButton1.Name = "CButton1"
            Me.CButton1.Size = New System.Drawing.Size(191, 40)
            Me.CButton1.TabIndex = 27
            Me.CButton1.Text = "Compute Benefit"
            Me.CButton1.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(20, 40)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(74, 14)
            Me.Label1.TabIndex = 23
            Me.Label1.Text = "Salary Scale :"
            '
            'cboSalaryScale
            '
            Me.cboSalaryScale.FormattingEnabled = True
            Me.cboSalaryScale.Location = New System.Drawing.Point(102, 36)
            Me.cboSalaryScale.Name = "cboSalaryScale"
            Me.cboSalaryScale.Size = New System.Drawing.Size(200, 22)
            Me.cboSalaryScale.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(20, 68)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(72, 14)
            Me.Label2.TabIndex = 23
            Me.Label2.Text = "Grade Level :"
            '
            'cboLevel
            '
            Me.cboLevel.FormattingEnabled = True
            Me.cboLevel.Location = New System.Drawing.Point(102, 64)
            Me.cboLevel.Name = "cboLevel"
            Me.cboLevel.Size = New System.Drawing.Size(200, 22)
            Me.cboLevel.TabIndex = 1
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(20, 96)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(35, 14)
            Me.Label3.TabIndex = 23
            Me.Label3.Text = "Step :"
            '
            'cboStep
            '
            Me.cboStep.FormattingEnabled = True
            Me.cboStep.Location = New System.Drawing.Point(102, 92)
            Me.cboStep.Name = "cboStep"
            Me.cboStep.Size = New System.Drawing.Size(200, 22)
            Me.cboStep.TabIndex = 2
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(20, 124)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(73, 14)
            Me.Label4.TabIndex = 23
            Me.Label4.Text = "Benefit Type :"
            '
            'cboBenefitType
            '
            Me.cboBenefitType.FormattingEnabled = True
            Me.cboBenefitType.Location = New System.Drawing.Point(102, 120)
            Me.cboBenefitType.Name = "cboBenefitType"
            Me.cboBenefitType.Size = New System.Drawing.Size(200, 22)
            Me.cboBenefitType.TabIndex = 3
            '
            'dtpDAA
            '
            Me.dtpDAA.Location = New System.Drawing.Point(406, 121)
            Me.dtpDAA.Name = "dtpDAA"
            Me.dtpDAA.Size = New System.Drawing.Size(200, 20)
            Me.dtpDAA.TabIndex = 6
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(313, 124)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(84, 14)
            Me.Label5.TabIndex = 23
            Me.Label5.Text = "Audit Approval :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(313, 96)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(81, 14)
            Me.Label6.TabIndex = 23
            Me.Label6.Text = "Pension W.E.F :"
            '
            'dtpPensionWEF
            '
            Me.dtpPensionWEF.Location = New System.Drawing.Point(406, 93)
            Me.dtpPensionWEF.Name = "dtpPensionWEF"
            Me.dtpPensionWEF.Size = New System.Drawing.Size(200, 20)
            Me.dtpPensionWEF.TabIndex = 7
            '
            'txtGratuityPerc
            '
            Me.txtGratuityPerc.Location = New System.Drawing.Point(406, 37)
            Me.txtGratuityPerc.Name = "txtGratuityPerc"
            Me.txtGratuityPerc.Size = New System.Drawing.Size(200, 20)
            Me.txtGratuityPerc.TabIndex = 4
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(313, 40)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(72, 14)
            Me.Label7.TabIndex = 23
            Me.Label7.Text = "Gratuity (%) :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(314, 68)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(72, 14)
            Me.Label8.TabIndex = 23
            Me.Label8.Text = "Pension (%) :"
            '
            'txtPensionPerc
            '
            Me.txtPensionPerc.Location = New System.Drawing.Point(406, 65)
            Me.txtPensionPerc.Name = "txtPensionPerc"
            Me.txtPensionPerc.Size = New System.Drawing.Size(200, 20)
            Me.txtPensionPerc.TabIndex = 5
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
            Me.btnClose.Location = New System.Drawing.Point(503, 304)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 48)
            Me.btnClose.TabIndex = 27
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'frmBenefitCalculator
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(626, 364)
            Me.Controls.Add(Me.CButton1)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.txtPensionPerc)
            Me.Controls.Add(Me.txtGratuityPerc)
            Me.Controls.Add(Me.dtpPensionWEF)
            Me.Controls.Add(Me.dtpDAA)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.cboBenefitType)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.cboStep)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.cboLevel)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboSalaryScale)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmBenefitCalculator"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Employee Salary"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cboSalaryScale As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboStep As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cboBenefitType As System.Windows.Forms.ComboBox
        Friend WithEvents dtpDAA As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpPensionWEF As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtGratuityPerc As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtPensionPerc As System.Windows.Forms.TextBox
        Friend WithEvents txtPension As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtGratuity As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtConsolidated As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents CButton1 As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents txtDeathPension As System.Windows.Forms.TextBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtPensionArrears As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
    End Class
End Namespace