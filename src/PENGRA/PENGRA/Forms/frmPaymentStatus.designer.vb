
Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPaymentStatus
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentStatus))
            Me.cmsProfile = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.RemovePhotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.txtBenefitType = New System.Windows.Forms.TextBox()
            Me.txtMinistry = New System.Windows.Forms.TextBox()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.txtBalance = New System.Windows.Forms.TextBox()
            Me.txtTotalBenefit = New System.Windows.Forms.TextBox()
            Me.txtDeathPension = New System.Windows.Forms.TextBox()
            Me.txtPension = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtBenefitPaid = New System.Windows.Forms.TextBox()
            Me.txtDeathPaid = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtPensionPaid = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtGratuityPaid = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtGratuity = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.dtpPensionWEF = New System.Windows.Forms.DateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.dtpAuditDate = New System.Windows.Forms.DateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.dgvGrid = New System.Windows.Forms.DataGridView()
            Me.btnPrint = New crsButton.cButton()
            Me.btnSearch = New crsButton.cButton()
            Me.CButton1 = New crsButton.cButton()
            Me.cmsProfile.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            Me.TabPage4.SuspendLayout()
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cmsProfile
            '
            Me.cmsProfile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemovePhotoToolStripMenuItem})
            Me.cmsProfile.Name = "cmsProfile"
            Me.cmsProfile.Size = New System.Drawing.Size(153, 26)
            '
            'RemovePhotoToolStripMenuItem
            '
            Me.RemovePhotoToolStripMenuItem.Name = "RemovePhotoToolStripMenuItem"
            Me.RemovePhotoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.RemovePhotoToolStripMenuItem.Text = "Remove Photo"
            '
            'txtBenefitType
            '
            Me.txtBenefitType.BackColor = System.Drawing.SystemColors.Window
            Me.txtBenefitType.Location = New System.Drawing.Point(92, 44)
            Me.txtBenefitType.Name = "txtBenefitType"
            Me.txtBenefitType.ReadOnly = True
            Me.txtBenefitType.Size = New System.Drawing.Size(174, 20)
            Me.txtBenefitType.TabIndex = 111
            '
            'txtMinistry
            '
            Me.txtMinistry.BackColor = System.Drawing.SystemColors.Window
            Me.txtMinistry.Location = New System.Drawing.Point(340, 44)
            Me.txtMinistry.Name = "txtMinistry"
            Me.txtMinistry.ReadOnly = True
            Me.txtMinistry.Size = New System.Drawing.Size(321, 20)
            Me.txtMinistry.TabIndex = 113
            '
            'txtName
            '
            Me.txtName.BackColor = System.Drawing.SystemColors.Window
            Me.txtName.Location = New System.Drawing.Point(340, 18)
            Me.txtName.Name = "txtName"
            Me.txtName.ReadOnly = True
            Me.txtName.Size = New System.Drawing.Size(321, 20)
            Me.txtName.TabIndex = 112
            '
            'txtID
            '
            Me.txtID.BackColor = System.Drawing.SystemColors.Window
            Me.txtID.Location = New System.Drawing.Point(92, 18)
            Me.txtID.Name = "txtID"
            Me.txtID.ReadOnly = True
            Me.txtID.Size = New System.Drawing.Size(174, 20)
            Me.txtID.TabIndex = 110
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(277, 47)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(50, 14)
            Me.Label3.TabIndex = 117
            Me.Label3.Text = "Ministry :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(277, 21)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(59, 14)
            Me.Label2.TabIndex = 119
            Me.Label2.Text = "Full Name :"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 21)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(62, 14)
            Me.Label1.TabIndex = 118
            Me.Label1.Text = "ID Number :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.BackColor = System.Drawing.Color.Transparent
            Me.Label16.Location = New System.Drawing.Point(10, 47)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(73, 14)
            Me.Label16.TabIndex = 116
            Me.Label16.Text = "Benefit Type :"
            '
            'TabPage3
            '
            Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.TabPage3.Controls.Add(Me.txtBalance)
            Me.TabPage3.Controls.Add(Me.txtTotalBenefit)
            Me.TabPage3.Controls.Add(Me.txtDeathPension)
            Me.TabPage3.Controls.Add(Me.txtPension)
            Me.TabPage3.Controls.Add(Me.Label11)
            Me.TabPage3.Controls.Add(Me.Label7)
            Me.TabPage3.Controls.Add(Me.txtBenefitPaid)
            Me.TabPage3.Controls.Add(Me.txtDeathPaid)
            Me.TabPage3.Controls.Add(Me.Label14)
            Me.TabPage3.Controls.Add(Me.txtPensionPaid)
            Me.TabPage3.Controls.Add(Me.Label13)
            Me.TabPage3.Controls.Add(Me.txtGratuityPaid)
            Me.TabPage3.Controls.Add(Me.Label10)
            Me.TabPage3.Controls.Add(Me.txtGratuity)
            Me.TabPage3.Controls.Add(Me.Label9)
            Me.TabPage3.Controls.Add(Me.Label6)
            Me.TabPage3.Controls.Add(Me.Label8)
            Me.TabPage3.Controls.Add(Me.Label15)
            Me.TabPage3.Controls.Add(Me.dtpPensionWEF)
            Me.TabPage3.Controls.Add(Me.Label5)
            Me.TabPage3.Controls.Add(Me.dtpAuditDate)
            Me.TabPage3.Controls.Add(Me.Label4)
            Me.TabPage3.Location = New System.Drawing.Point(4, 44)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(648, 191)
            Me.TabPage3.TabIndex = 0
            Me.TabPage3.Text = "Payment Profile"
            '
            'txtBalance
            '
            Me.txtBalance.BackColor = System.Drawing.SystemColors.Window
            Me.txtBalance.Location = New System.Drawing.Point(104, 166)
            Me.txtBalance.Name = "txtBalance"
            Me.txtBalance.ReadOnly = True
            Me.txtBalance.Size = New System.Drawing.Size(200, 20)
            Me.txtBalance.TabIndex = 9
            Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtTotalBenefit
            '
            Me.txtTotalBenefit.BackColor = System.Drawing.SystemColors.Window
            Me.txtTotalBenefit.Location = New System.Drawing.Point(104, 135)
            Me.txtTotalBenefit.Name = "txtTotalBenefit"
            Me.txtTotalBenefit.ReadOnly = True
            Me.txtTotalBenefit.Size = New System.Drawing.Size(200, 20)
            Me.txtTotalBenefit.TabIndex = 8
            Me.txtTotalBenefit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeathPension
            '
            Me.txtDeathPension.BackColor = System.Drawing.SystemColors.Window
            Me.txtDeathPension.Location = New System.Drawing.Point(104, 104)
            Me.txtDeathPension.Name = "txtDeathPension"
            Me.txtDeathPension.ReadOnly = True
            Me.txtDeathPension.Size = New System.Drawing.Size(200, 20)
            Me.txtDeathPension.TabIndex = 7
            Me.txtDeathPension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtPension
            '
            Me.txtPension.BackColor = System.Drawing.SystemColors.Window
            Me.txtPension.Location = New System.Drawing.Point(104, 73)
            Me.txtPension.Name = "txtPension"
            Me.txtPension.ReadOnly = True
            Me.txtPension.Size = New System.Drawing.Size(200, 20)
            Me.txtPension.TabIndex = 6
            Me.txtPension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(7, 138)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(73, 13)
            Me.Label11.TabIndex = 90
            Me.Label11.Text = "Total Benefit :"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(7, 107)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(83, 13)
            Me.Label7.TabIndex = 89
            Me.Label7.Text = "Death Pension :"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtBenefitPaid
            '
            Me.txtBenefitPaid.BackColor = System.Drawing.SystemColors.Window
            Me.txtBenefitPaid.Location = New System.Drawing.Point(439, 135)
            Me.txtBenefitPaid.Name = "txtBenefitPaid"
            Me.txtBenefitPaid.ReadOnly = True
            Me.txtBenefitPaid.Size = New System.Drawing.Size(200, 20)
            Me.txtBenefitPaid.TabIndex = 14
            Me.txtBenefitPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDeathPaid
            '
            Me.txtDeathPaid.BackColor = System.Drawing.SystemColors.Window
            Me.txtDeathPaid.Location = New System.Drawing.Point(439, 104)
            Me.txtDeathPaid.Name = "txtDeathPaid"
            Me.txtDeathPaid.ReadOnly = True
            Me.txtDeathPaid.Size = New System.Drawing.Size(200, 20)
            Me.txtDeathPaid.TabIndex = 13
            Me.txtDeathPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(7, 169)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(52, 13)
            Me.Label14.TabIndex = 88
            Me.Label14.Text = "Balance :"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtPensionPaid
            '
            Me.txtPensionPaid.BackColor = System.Drawing.SystemColors.Window
            Me.txtPensionPaid.Location = New System.Drawing.Point(439, 73)
            Me.txtPensionPaid.Name = "txtPensionPaid"
            Me.txtPensionPaid.ReadOnly = True
            Me.txtPensionPaid.Size = New System.Drawing.Size(200, 20)
            Me.txtPensionPaid.TabIndex = 12
            Me.txtPensionPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(320, 138)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(97, 13)
            Me.Label13.TabIndex = 84
            Me.Label13.Text = "Total Benefit Paid :"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtGratuityPaid
            '
            Me.txtGratuityPaid.BackColor = System.Drawing.SystemColors.Window
            Me.txtGratuityPaid.Location = New System.Drawing.Point(439, 42)
            Me.txtGratuityPaid.Name = "txtGratuityPaid"
            Me.txtGratuityPaid.ReadOnly = True
            Me.txtGratuityPaid.Size = New System.Drawing.Size(200, 20)
            Me.txtGratuityPaid.TabIndex = 11
            Me.txtGratuityPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(320, 107)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(107, 13)
            Me.Label10.TabIndex = 83
            Me.Label10.Text = "Death Pension Paid :"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtGratuity
            '
            Me.txtGratuity.BackColor = System.Drawing.SystemColors.Window
            Me.txtGratuity.Location = New System.Drawing.Point(104, 42)
            Me.txtGratuity.Name = "txtGratuity"
            Me.txtGratuity.ReadOnly = True
            Me.txtGratuity.Size = New System.Drawing.Size(200, 20)
            Me.txtGratuity.TabIndex = 5
            Me.txtGratuity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(320, 76)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(111, 13)
            Me.Label9.TabIndex = 82
            Me.Label9.Text = "Pension Arrears Paid :"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(7, 76)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(87, 13)
            Me.Label6.TabIndex = 87
            Me.Label6.Text = "Pension Arrears :"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(320, 45)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(73, 13)
            Me.Label8.TabIndex = 85
            Me.Label8.Text = "Gratuity Paid :"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(7, 45)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(49, 13)
            Me.Label15.TabIndex = 86
            Me.Label15.Text = "Gratuity :"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpPensionWEF
            '
            Me.dtpPensionWEF.Location = New System.Drawing.Point(439, 11)
            Me.dtpPensionWEF.Name = "dtpPensionWEF"
            Me.dtpPensionWEF.Size = New System.Drawing.Size(200, 20)
            Me.dtpPensionWEF.TabIndex = 10
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Location = New System.Drawing.Point(320, 14)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(113, 13)
            Me.Label5.TabIndex = 73
            Me.Label5.Text = "Pension W.E.F. Date :"
            '
            'dtpAuditDate
            '
            Me.dtpAuditDate.Location = New System.Drawing.Point(104, 11)
            Me.dtpAuditDate.Name = "dtpAuditDate"
            Me.dtpAuditDate.Size = New System.Drawing.Size(200, 20)
            Me.dtpAuditDate.TabIndex = 4
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Location = New System.Drawing.Point(7, 14)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(82, 13)
            Me.Label4.TabIndex = 75
            Me.Label4.Text = "Audit Approval :"
            '
            'TabPage4
            '
            Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.TabPage4.Controls.Add(Me.dgvGrid)
            Me.TabPage4.Location = New System.Drawing.Point(4, 44)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage4.Size = New System.Drawing.Size(648, 191)
            Me.TabPage4.TabIndex = 1
            Me.TabPage4.Text = "Payment History"
            '
            'dgvGrid
            '
            Me.dgvGrid.AllowUserToAddRows = False
            Me.dgvGrid.AllowUserToDeleteRows = False
            Me.dgvGrid.AllowUserToResizeColumns = False
            Me.dgvGrid.AllowUserToResizeRows = False
            Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvGrid.GridColor = System.Drawing.SystemColors.ControlLight
            Me.dgvGrid.Location = New System.Drawing.Point(3, 2)
            Me.dgvGrid.Name = "dgvGrid"
            Me.dgvGrid.RowHeadersVisible = False
            Me.dgvGrid.Size = New System.Drawing.Size(643, 181)
            Me.dgvGrid.TabIndex = 0
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
            Me.btnPrint.Location = New System.Drawing.Point(408, 335)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(85, 45)
            Me.btnPrint.TabIndex = 124
            Me.btnPrint.UseVisualStyleBackColor = False
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
            Me.btnSearch.Location = New System.Drawing.Point(13, 335)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(85, 45)
            Me.btnSearch.TabIndex = 123
            Me.btnSearch.UseVisualStyleBackColor = False
            '
            'CButton1
            '
            Me.CButton1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.CButton1.BackColor = System.Drawing.Color.Transparent
            Me.CButton1.ButtonType = crsButton.cButton.btnType.close2
            Me.CButton1.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.CButton1.FlatAppearance.BorderSize = 0
            Me.CButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.CButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.CButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.CButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.CButton1.Image = CType(resources.GetObject("CButton1.Image"), System.Drawing.Image)
            Me.CButton1.Location = New System.Drawing.Point(554, 334)
            Me.CButton1.Name = "CButton1"
            Me.CButton1.Size = New System.Drawing.Size(85, 47)
            Me.CButton1.TabIndex = 122
            Me.CButton1.UseVisualStyleBackColor = False
            '
            'frmPaymentStatus
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.WhiteSmoke
            Me.ClientSize = New System.Drawing.Size(670, 392)
            Me.Controls.Add(Me.btnPrint)
            Me.Controls.Add(Me.btnSearch)
            Me.Controls.Add(Me.CButton1)
            Me.Controls.Add(Me.txtBenefitType)
            Me.Controls.Add(Me.txtMinistry)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.txtID)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label16)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmPaymentStatus"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Student Profile"
            Me.cmsProfile.ResumeLayout(False)
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            Me.TabPage4.ResumeLayout(False)
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
        Friend WithEvents cmsProfile As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents RemovePhotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtBenefitType As System.Windows.Forms.TextBox
        Friend WithEvents newtabcontrol As PENGRA.crsTabControl
        Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents txtBalance As System.Windows.Forms.TextBox
        Friend WithEvents txtTotalBenefit As System.Windows.Forms.TextBox
        Friend WithEvents txtDeathPension As System.Windows.Forms.TextBox
        Friend WithEvents txtPension As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtBenefitPaid As System.Windows.Forms.TextBox
        Friend WithEvents txtDeathPaid As System.Windows.Forms.TextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents txtPensionPaid As System.Windows.Forms.TextBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtGratuityPaid As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtGratuity As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents dtpPensionWEF As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpAuditDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
        Friend WithEvents dgvGrid As System.Windows.Forms.DataGridView
        Friend WithEvents txtMinistry As System.Windows.Forms.TextBox
        Friend WithEvents txtName As System.Windows.Forms.TextBox
        Friend WithEvents txtID As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents btnPrint As crsButton.cButton
        Friend WithEvents btnSearch As crsButton.cButton
        Private WithEvents CButton1 As crsButton.cButton
    End Class
End Namespace