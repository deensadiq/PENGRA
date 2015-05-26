Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPaymentProfile
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentProfile))
            Me.btnPrint = New crsButton.cButton()
            Me.btnSearch = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.txtBenefitType = New System.Windows.Forms.TextBox()
            Me.txtMinistry = New System.Windows.Forms.TextBox()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.CrsTabControl1 = New PENGRA.crsTabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtTotalBenefit = New System.Windows.Forms.TextBox()
            Me.txtDeathPension = New System.Windows.Forms.TextBox()
            Me.txtPension = New System.Windows.Forms.TextBox()
            Me.txtBalance = New System.Windows.Forms.TextBox()
            Me.txtBenefitPaid = New System.Windows.Forms.TextBox()
            Me.txtDeathPaid = New System.Windows.Forms.TextBox()
            Me.txtPensionPaid = New System.Windows.Forms.TextBox()
            Me.txtGratuityPaid = New System.Windows.Forms.TextBox()
            Me.txtGratuity = New System.Windows.Forms.TextBox()
            Me.dtpPensionWEF = New System.Windows.Forms.DateTimePicker()
            Me.dtpAuditDate = New System.Windows.Forms.DateTimePicker()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.dgvGrid = New System.Windows.Forms.DataGridView()
            Me.CrsTabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnPrint
            '
            Me.btnPrint.BackColor = System.Drawing.Color.Transparent
            Me.btnPrint.ButtonType = crsButton.cButton.btnType.print
            Me.btnPrint.FlatAppearance.BorderSize = 0
            Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.Location = New System.Drawing.Point(408, 337)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(85, 45)
            Me.btnPrint.TabIndex = 135
            Me.btnPrint.UseVisualStyleBackColor = False
            Me.btnPrint.Visible = False
            '
            'btnSearch
            '
            Me.btnSearch.BackColor = System.Drawing.Color.Transparent
            Me.btnSearch.ButtonType = crsButton.cButton.btnType.search
            Me.btnSearch.FlatAppearance.BorderSize = 0
            Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
            Me.btnSearch.Location = New System.Drawing.Point(13, 337)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(85, 45)
            Me.btnSearch.TabIndex = 134
            Me.btnSearch.UseVisualStyleBackColor = False
            '
            'btnClose
            '
            Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.ButtonType = crsButton.cButton.btnType.close2
            Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(563, 336)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 47)
            Me.btnClose.TabIndex = 133
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'txtBenefitType
            '
            Me.txtBenefitType.BackColor = System.Drawing.SystemColors.Window
            Me.txtBenefitType.Location = New System.Drawing.Point(92, 41)
            Me.txtBenefitType.Name = "txtBenefitType"
            Me.txtBenefitType.ReadOnly = True
            Me.txtBenefitType.Size = New System.Drawing.Size(174, 20)
            Me.txtBenefitType.TabIndex = 126
            '
            'txtMinistry
            '
            Me.txtMinistry.BackColor = System.Drawing.SystemColors.Window
            Me.txtMinistry.Location = New System.Drawing.Point(340, 41)
            Me.txtMinistry.Name = "txtMinistry"
            Me.txtMinistry.ReadOnly = True
            Me.txtMinistry.Size = New System.Drawing.Size(321, 20)
            Me.txtMinistry.TabIndex = 128
            '
            'txtName
            '
            Me.txtName.BackColor = System.Drawing.SystemColors.Window
            Me.txtName.Location = New System.Drawing.Point(340, 15)
            Me.txtName.Name = "txtName"
            Me.txtName.ReadOnly = True
            Me.txtName.Size = New System.Drawing.Size(321, 20)
            Me.txtName.TabIndex = 127
            '
            'txtID
            '
            Me.txtID.BackColor = System.Drawing.SystemColors.Window
            Me.txtID.Location = New System.Drawing.Point(92, 15)
            Me.txtID.Name = "txtID"
            Me.txtID.Size = New System.Drawing.Size(174, 20)
            Me.txtID.TabIndex = 125
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(277, 44)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(50, 14)
            Me.Label3.TabIndex = 130
            Me.Label3.Text = "Ministry :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(277, 18)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(59, 14)
            Me.Label2.TabIndex = 132
            Me.Label2.Text = "Full Name :"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(62, 14)
            Me.Label1.TabIndex = 131
            Me.Label1.Text = "ID Number :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.BackColor = System.Drawing.Color.Transparent
            Me.Label16.Location = New System.Drawing.Point(10, 44)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(73, 14)
            Me.Label16.TabIndex = 129
            Me.Label16.Text = "Benefit Type :"
            '
            'CrsTabControl1
            '
            Me.CrsTabControl1.Controls.Add(Me.TabPage1)
            Me.CrsTabControl1.Controls.Add(Me.TabPage2)
            Me.CrsTabControl1.ItemSize = New System.Drawing.Size(136, 44)
            Me.CrsTabControl1.Location = New System.Drawing.Point(5, 69)
            Me.CrsTabControl1.Name = "CrsTabControl1"
            Me.CrsTabControl1.SelectedIndex = 0
            Me.CrsTabControl1.Size = New System.Drawing.Size(679, 260)
            Me.CrsTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
            Me.CrsTabControl1.TabIndex = 136
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.Label14)
            Me.TabPage1.Controls.Add(Me.Label13)
            Me.TabPage1.Controls.Add(Me.Label12)
            Me.TabPage1.Controls.Add(Me.Label11)
            Me.TabPage1.Controls.Add(Me.Label10)
            Me.TabPage1.Controls.Add(Me.Label9)
            Me.TabPage1.Controls.Add(Me.Label8)
            Me.TabPage1.Controls.Add(Me.Label7)
            Me.TabPage1.Controls.Add(Me.Label6)
            Me.TabPage1.Controls.Add(Me.Label5)
            Me.TabPage1.Controls.Add(Me.Label4)
            Me.TabPage1.Controls.Add(Me.txtTotalBenefit)
            Me.TabPage1.Controls.Add(Me.txtDeathPension)
            Me.TabPage1.Controls.Add(Me.txtPension)
            Me.TabPage1.Controls.Add(Me.txtBalance)
            Me.TabPage1.Controls.Add(Me.txtBenefitPaid)
            Me.TabPage1.Controls.Add(Me.txtDeathPaid)
            Me.TabPage1.Controls.Add(Me.txtPensionPaid)
            Me.TabPage1.Controls.Add(Me.txtGratuityPaid)
            Me.TabPage1.Controls.Add(Me.txtGratuity)
            Me.TabPage1.Controls.Add(Me.dtpPensionWEF)
            Me.TabPage1.Controls.Add(Me.dtpAuditDate)
            Me.TabPage1.Location = New System.Drawing.Point(4, 48)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(671, 208)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Payment Profile"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(16, 25)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(63, 14)
            Me.Label14.TabIndex = 2
            Me.Label14.Text = "Audit Date :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(16, 54)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(83, 14)
            Me.Label13.TabIndex = 2
            Me.Label13.Text = "Pension W.E.F. :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(16, 83)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(90, 14)
            Me.Label12.TabIndex = 2
            Me.Label12.Text = "Gratuity Amount :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(16, 112)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(91, 14)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Pension Arrears :"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(16, 141)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(82, 14)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Death Pension :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(11, 170)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(72, 14)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Total Benefit :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(349, 141)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(52, 14)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Balance :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(349, 112)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(95, 14)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "Total Benefit Paid :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(349, 83)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(105, 14)
            Me.Label6.TabIndex = 2
            Me.Label6.Text = "Death Pension Paid :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(349, 54)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(114, 14)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Pension Arrears Paid :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(349, 25)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(74, 14)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Gratuity Paid :"
            '
            'txtTotalBenefit
            '
            Me.txtTotalBenefit.Location = New System.Drawing.Point(112, 167)
            Me.txtTotalBenefit.Name = "txtTotalBenefit"
            Me.txtTotalBenefit.Size = New System.Drawing.Size(190, 20)
            Me.txtTotalBenefit.TabIndex = 1
            '
            'txtDeathPension
            '
            Me.txtDeathPension.Location = New System.Drawing.Point(112, 138)
            Me.txtDeathPension.Name = "txtDeathPension"
            Me.txtDeathPension.Size = New System.Drawing.Size(190, 20)
            Me.txtDeathPension.TabIndex = 1
            '
            'txtPension
            '
            Me.txtPension.Location = New System.Drawing.Point(112, 109)
            Me.txtPension.Name = "txtPension"
            Me.txtPension.Size = New System.Drawing.Size(190, 20)
            Me.txtPension.TabIndex = 1
            '
            'txtBalance
            '
            Me.txtBalance.Location = New System.Drawing.Point(469, 138)
            Me.txtBalance.Name = "txtBalance"
            Me.txtBalance.Size = New System.Drawing.Size(190, 20)
            Me.txtBalance.TabIndex = 1
            '
            'txtBenefitPaid
            '
            Me.txtBenefitPaid.Location = New System.Drawing.Point(469, 109)
            Me.txtBenefitPaid.Name = "txtBenefitPaid"
            Me.txtBenefitPaid.Size = New System.Drawing.Size(190, 20)
            Me.txtBenefitPaid.TabIndex = 1
            '
            'txtDeathPaid
            '
            Me.txtDeathPaid.Location = New System.Drawing.Point(469, 80)
            Me.txtDeathPaid.Name = "txtDeathPaid"
            Me.txtDeathPaid.Size = New System.Drawing.Size(190, 20)
            Me.txtDeathPaid.TabIndex = 1
            '
            'txtPensionPaid
            '
            Me.txtPensionPaid.Location = New System.Drawing.Point(469, 51)
            Me.txtPensionPaid.Name = "txtPensionPaid"
            Me.txtPensionPaid.Size = New System.Drawing.Size(190, 20)
            Me.txtPensionPaid.TabIndex = 1
            '
            'txtGratuityPaid
            '
            Me.txtGratuityPaid.Location = New System.Drawing.Point(469, 22)
            Me.txtGratuityPaid.Name = "txtGratuityPaid"
            Me.txtGratuityPaid.Size = New System.Drawing.Size(190, 20)
            Me.txtGratuityPaid.TabIndex = 1
            '
            'txtGratuity
            '
            Me.txtGratuity.Location = New System.Drawing.Point(112, 80)
            Me.txtGratuity.Name = "txtGratuity"
            Me.txtGratuity.Size = New System.Drawing.Size(190, 20)
            Me.txtGratuity.TabIndex = 1
            '
            'dtpPensionWEF
            '
            Me.dtpPensionWEF.Location = New System.Drawing.Point(112, 51)
            Me.dtpPensionWEF.Name = "dtpPensionWEF"
            Me.dtpPensionWEF.Size = New System.Drawing.Size(190, 20)
            Me.dtpPensionWEF.TabIndex = 0
            '
            'dtpAuditDate
            '
            Me.dtpAuditDate.Location = New System.Drawing.Point(112, 22)
            Me.dtpAuditDate.Name = "dtpAuditDate"
            Me.dtpAuditDate.Size = New System.Drawing.Size(190, 20)
            Me.dtpAuditDate.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.TabPage2.Controls.Add(Me.dgvGrid)
            Me.TabPage2.Location = New System.Drawing.Point(4, 48)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(671, 208)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Payment History"
            '
            'dgvGrid
            '
            Me.dgvGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvGrid.Location = New System.Drawing.Point(1, 1)
            Me.dgvGrid.Name = "dgvGrid"
            Me.dgvGrid.Size = New System.Drawing.Size(669, 206)
            Me.dgvGrid.TabIndex = 0
            '
            'frmPaymentProfile
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(688, 392)
            Me.Controls.Add(Me.CrsTabControl1)
            Me.Controls.Add(Me.btnPrint)
            Me.Controls.Add(Me.btnSearch)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.txtBenefitType)
            Me.Controls.Add(Me.txtMinistry)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.txtID)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label16)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "frmPaymentProfile"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmPaymentProfile"
            Me.CrsTabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnPrint As crsButton.cButton
        Friend WithEvents btnSearch As crsButton.cButton
        Private WithEvents btnClose As crsButton.cButton
        Friend WithEvents txtBenefitType As System.Windows.Forms.TextBox
        Friend WithEvents txtMinistry As System.Windows.Forms.TextBox
        Friend WithEvents txtName As System.Windows.Forms.TextBox
        Friend WithEvents txtID As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents CrsTabControl1 As PENGRA.crsTabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents dgvGrid As System.Windows.Forms.DataGridView
        Friend WithEvents txtTotalBenefit As System.Windows.Forms.TextBox
        Friend WithEvents txtDeathPension As System.Windows.Forms.TextBox
        Friend WithEvents txtPension As System.Windows.Forms.TextBox
        Friend WithEvents txtBalance As System.Windows.Forms.TextBox
        Friend WithEvents txtBenefitPaid As System.Windows.Forms.TextBox
        Friend WithEvents txtDeathPaid As System.Windows.Forms.TextBox
        Friend WithEvents txtPensionPaid As System.Windows.Forms.TextBox
        Friend WithEvents txtGratuityPaid As System.Windows.Forms.TextBox
        Friend WithEvents txtGratuity As System.Windows.Forms.TextBox
        Friend WithEvents dtpPensionWEF As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpAuditDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
    End Class
End Namespace