Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMemo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMemo))
            Me.btnSearch = New crsButton.cButton()
            Me.btnUndo = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.btnEdit = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.cboMonth = New System.Windows.Forms.ComboBox()
            Me.cboYear = New System.Windows.Forms.ComboBox()
            Me.chkSubmitted = New System.Windows.Forms.CheckBox()
            Me.txtAmountInWord = New System.Windows.Forms.TextBox()
            Me.txtDesignation = New System.Windows.Forms.TextBox()
            Me.txtMinistry = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtTotalBenefit = New System.Windows.Forms.TextBox()
            Me.txtDeathPension = New System.Windows.Forms.TextBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtPensionArears = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtGratuity = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtBenefitType = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.btnPreview = New crsButton.cButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
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
            Me.btnSearch.Location = New System.Drawing.Point(445, 341)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(85, 45)
            Me.btnSearch.TabIndex = 82
            Me.btnSearch.UseVisualStyleBackColor = False
            '
            'btnUndo
            '
            Me.btnUndo.BackColor = System.Drawing.Color.Transparent
            Me.btnUndo.ButtonType = crsButton.cButton.btnType.undo
            Me.btnUndo.FlatAppearance.BorderSize = 0
            Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
            Me.btnUndo.Location = New System.Drawing.Point(203, 349)
            Me.btnUndo.Name = "btnUndo"
            Me.btnUndo.Size = New System.Drawing.Size(85, 45)
            Me.btnUndo.TabIndex = 80
            Me.btnUndo.UseVisualStyleBackColor = False
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.Transparent
            Me.btnSave.ButtonType = crsButton.cButton.btnType.save
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.Location = New System.Drawing.Point(106, 346)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 81
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnEdit
            '
            Me.btnEdit.BackColor = System.Drawing.Color.Transparent
            Me.btnEdit.ButtonType = crsButton.cButton.btnType.edit
            Me.btnEdit.FlatAppearance.BorderSize = 0
            Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
            Me.btnEdit.Location = New System.Drawing.Point(9, 344)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 45)
            Me.btnEdit.TabIndex = 79
            Me.btnEdit.UseVisualStyleBackColor = False
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
            Me.btnClose.Location = New System.Drawing.Point(576, 342)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 48)
            Me.btnClose.TabIndex = 83
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'cboMonth
            '
            Me.cboMonth.FormattingEnabled = True
            Me.cboMonth.Location = New System.Drawing.Point(434, 81)
            Me.cboMonth.Name = "cboMonth"
            Me.cboMonth.Size = New System.Drawing.Size(215, 22)
            Me.cboMonth.TabIndex = 122
            '
            'cboYear
            '
            Me.cboYear.FormattingEnabled = True
            Me.cboYear.Location = New System.Drawing.Point(434, 53)
            Me.cboYear.Name = "cboYear"
            Me.cboYear.Size = New System.Drawing.Size(215, 22)
            Me.cboYear.TabIndex = 122
            '
            'chkSubmitted
            '
            Me.chkSubmitted.AutoSize = True
            Me.chkSubmitted.Location = New System.Drawing.Point(434, 27)
            Me.chkSubmitted.Name = "chkSubmitted"
            Me.chkSubmitted.Size = New System.Drawing.Size(73, 18)
            Me.chkSubmitted.TabIndex = 121
            Me.chkSubmitted.Text = "Submitted"
            Me.chkSubmitted.UseVisualStyleBackColor = True
            '
            'txtAmountInWord
            '
            Me.txtAmountInWord.Location = New System.Drawing.Point(434, 138)
            Me.txtAmountInWord.Multiline = True
            Me.txtAmountInWord.Name = "txtAmountInWord"
            Me.txtAmountInWord.Size = New System.Drawing.Size(215, 53)
            Me.txtAmountInWord.TabIndex = 120
            '
            'txtDesignation
            '
            Me.txtDesignation.BackColor = System.Drawing.SystemColors.Window
            Me.txtDesignation.Location = New System.Drawing.Point(434, 110)
            Me.txtDesignation.Name = "txtDesignation"
            Me.txtDesignation.Size = New System.Drawing.Size(215, 20)
            Me.txtDesignation.TabIndex = 113
            '
            'txtMinistry
            '
            Me.txtMinistry.BackColor = System.Drawing.SystemColors.Window
            Me.txtMinistry.Location = New System.Drawing.Point(110, 82)
            Me.txtMinistry.Name = "txtMinistry"
            Me.txtMinistry.ReadOnly = True
            Me.txtMinistry.Size = New System.Drawing.Size(215, 20)
            Me.txtMinistry.TabIndex = 113
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(333, 85)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(42, 14)
            Me.Label5.TabIndex = 117
            Me.Label5.Text = "Month :"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(333, 57)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(36, 14)
            Me.Label4.TabIndex = 117
            Me.Label4.Text = "Year :"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(333, 113)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(69, 14)
            Me.Label12.TabIndex = 117
            Me.Label12.Text = "Designation :"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(18, 57)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(77, 14)
            Me.Label2.TabIndex = 119
            Me.Label2.Text = "Retiree Name :"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(18, 85)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(50, 14)
            Me.Label3.TabIndex = 117
            Me.Label3.Text = "Ministry :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtID
            '
            Me.txtID.BackColor = System.Drawing.SystemColors.Window
            Me.txtID.Location = New System.Drawing.Point(110, 26)
            Me.txtID.Name = "txtID"
            Me.txtID.ReadOnly = True
            Me.txtID.Size = New System.Drawing.Size(146, 20)
            Me.txtID.TabIndex = 110
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(18, 29)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(75, 14)
            Me.Label1.TabIndex = 118
            Me.Label1.Text = "Computer No :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtTotalBenefit
            '
            Me.txtTotalBenefit.BackColor = System.Drawing.SystemColors.Window
            Me.txtTotalBenefit.Location = New System.Drawing.Point(110, 222)
            Me.txtTotalBenefit.Name = "txtTotalBenefit"
            Me.txtTotalBenefit.ReadOnly = True
            Me.txtTotalBenefit.Size = New System.Drawing.Size(215, 20)
            Me.txtTotalBenefit.TabIndex = 111
            '
            'txtDeathPension
            '
            Me.txtDeathPension.BackColor = System.Drawing.SystemColors.Window
            Me.txtDeathPension.Location = New System.Drawing.Point(110, 194)
            Me.txtDeathPension.Name = "txtDeathPension"
            Me.txtDeathPension.ReadOnly = True
            Me.txtDeathPension.Size = New System.Drawing.Size(215, 20)
            Me.txtDeathPension.TabIndex = 111
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.BackColor = System.Drawing.Color.Transparent
            Me.Label21.Location = New System.Drawing.Point(333, 141)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(96, 14)
            Me.Label21.TabIndex = 116
            Me.Label21.Text = "Amount In Words :"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.BackColor = System.Drawing.Color.Transparent
            Me.Label20.Location = New System.Drawing.Point(18, 225)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(72, 14)
            Me.Label20.TabIndex = 116
            Me.Label20.Text = "Total Benefit :"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtPensionArears
            '
            Me.txtPensionArears.BackColor = System.Drawing.SystemColors.Window
            Me.txtPensionArears.Location = New System.Drawing.Point(110, 166)
            Me.txtPensionArears.Name = "txtPensionArears"
            Me.txtPensionArears.ReadOnly = True
            Me.txtPensionArears.Size = New System.Drawing.Size(215, 20)
            Me.txtPensionArears.TabIndex = 111
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.BackColor = System.Drawing.Color.Transparent
            Me.Label19.Location = New System.Drawing.Point(18, 197)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(82, 14)
            Me.Label19.TabIndex = 116
            Me.Label19.Text = "Death Pension :"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtGratuity
            '
            Me.txtGratuity.BackColor = System.Drawing.SystemColors.Window
            Me.txtGratuity.Location = New System.Drawing.Point(110, 138)
            Me.txtGratuity.Name = "txtGratuity"
            Me.txtGratuity.ReadOnly = True
            Me.txtGratuity.Size = New System.Drawing.Size(215, 20)
            Me.txtGratuity.TabIndex = 111
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.BackColor = System.Drawing.Color.Transparent
            Me.Label18.Location = New System.Drawing.Point(18, 169)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(87, 14)
            Me.Label18.TabIndex = 116
            Me.Label18.Text = "Pension Arears :"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtBenefitType
            '
            Me.txtBenefitType.BackColor = System.Drawing.SystemColors.Window
            Me.txtBenefitType.Location = New System.Drawing.Point(110, 110)
            Me.txtBenefitType.Name = "txtBenefitType"
            Me.txtBenefitType.ReadOnly = True
            Me.txtBenefitType.Size = New System.Drawing.Size(215, 20)
            Me.txtBenefitType.TabIndex = 111
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.BackColor = System.Drawing.Color.Transparent
            Me.Label17.Location = New System.Drawing.Point(18, 141)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(51, 14)
            Me.Label17.TabIndex = 116
            Me.Label17.Text = "Gratuity :"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtName
            '
            Me.txtName.BackColor = System.Drawing.SystemColors.Window
            Me.txtName.Location = New System.Drawing.Point(110, 54)
            Me.txtName.Name = "txtName"
            Me.txtName.ReadOnly = True
            Me.txtName.Size = New System.Drawing.Size(215, 20)
            Me.txtName.TabIndex = 112
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.BackColor = System.Drawing.Color.Transparent
            Me.Label16.Location = New System.Drawing.Point(18, 113)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(73, 14)
            Me.Label16.TabIndex = 116
            Me.Label16.Text = "Benefit Type :"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnPreview
            '
            Me.btnPreview.BackColor = System.Drawing.Color.Transparent
            Me.btnPreview.ButtonType = crsButton.cButton.btnType.print_preview
            Me.btnPreview.FlatAppearance.BorderSize = 0
            Me.btnPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
            Me.btnPreview.Location = New System.Drawing.Point(472, 204)
            Me.btnPreview.Name = "btnPreview"
            Me.btnPreview.Size = New System.Drawing.Size(139, 45)
            Me.btnPreview.TabIndex = 82
            Me.btnPreview.UseVisualStyleBackColor = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cboMonth)
            Me.GroupBox1.Controls.Add(Me.txtGratuity)
            Me.GroupBox1.Controls.Add(Me.cboYear)
            Me.GroupBox1.Controls.Add(Me.Label16)
            Me.GroupBox1.Controls.Add(Me.chkSubmitted)
            Me.GroupBox1.Controls.Add(Me.txtName)
            Me.GroupBox1.Controls.Add(Me.txtAmountInWord)
            Me.GroupBox1.Controls.Add(Me.Label17)
            Me.GroupBox1.Controls.Add(Me.txtDesignation)
            Me.GroupBox1.Controls.Add(Me.txtBenefitType)
            Me.GroupBox1.Controls.Add(Me.btnPreview)
            Me.GroupBox1.Controls.Add(Me.Label18)
            Me.GroupBox1.Controls.Add(Me.txtMinistry)
            Me.GroupBox1.Controls.Add(Me.Label19)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtPensionArears)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label20)
            Me.GroupBox1.Controls.Add(Me.Label12)
            Me.GroupBox1.Controls.Add(Me.Label21)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtDeathPension)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtTotalBenefit)
            Me.GroupBox1.Controls.Add(Me.txtID)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(666, 265)
            Me.GroupBox1.TabIndex = 127
            Me.GroupBox1.TabStop = False
            '
            'frmMemo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(685, 415)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.btnUndo)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnSearch)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmMemo"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Knock-Off Benefit"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnSearch As crsButton.cButton
        Friend WithEvents btnUndo As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnEdit As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents chkSubmitted As System.Windows.Forms.CheckBox
        Friend WithEvents txtAmountInWord As System.Windows.Forms.TextBox
        Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
        Friend WithEvents txtMinistry As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtID As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtTotalBenefit As System.Windows.Forms.TextBox
        Friend WithEvents txtDeathPension As System.Windows.Forms.TextBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtPensionArears As System.Windows.Forms.TextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents txtGratuity As System.Windows.Forms.TextBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents txtBenefitType As System.Windows.Forms.TextBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents txtName As System.Windows.Forms.TextBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents btnPreview As crsButton.cButton
        Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
        Friend WithEvents cboYear As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    End Class
End Namespace