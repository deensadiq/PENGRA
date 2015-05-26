
Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmEmployee
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
            Me.pnlStudent = New System.Windows.Forms.Panel()
            Me.lblDeathPension = New System.Windows.Forms.Label()
            Me.lblPensionArrears = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.txtDeathPension = New System.Windows.Forms.TextBox()
            Me.btnDeathAmount = New crsButton.cButton()
            Me.txtPensionArrears = New System.Windows.Forms.TextBox()
            Me.btnPensionAmount = New crsButton.cButton()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.txtGratuity = New System.Windows.Forms.TextBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.btnGratuityAmount = New crsButton.cButton()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.dtpPensionWEF = New System.Windows.Forms.DateTimePicker()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.chkActive = New System.Windows.Forms.CheckBox()
            Me.txtPayThrough = New System.Windows.Forms.TextBox()
            Me.txtPensionPerc = New System.Windows.Forms.TextBox()
            Me.txtGratuityPerc = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.picPhoto = New System.Windows.Forms.PictureBox()
            Me.cmsProfile = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.RemovePhotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnSalary = New crsButton.cButton()
            Me.btnMinistry = New crsButton.cButton()
            Me.txtFullName = New System.Windows.Forms.TextBox()
            Me.txtRefNo = New System.Windows.Forms.TextBox()
            Me.dtpDOR = New System.Windows.Forms.DateTimePicker()
            Me.dtpDOAA = New System.Windows.Forms.DateTimePicker()
            Me.dtpDOD = New System.Windows.Forms.DateTimePicker()
            Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
            Me.dtpDOA = New System.Windows.Forms.DateTimePicker()
            Me.txtId = New System.Windows.Forms.TextBox()
            Me.cboSalary = New System.Windows.Forms.ComboBox()
            Me.cboMinistry = New System.Windows.Forms.ComboBox()
            Me.cboBenefitType = New System.Windows.Forms.ComboBox()
            Me.cboStep = New System.Windows.Forms.ComboBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.cboLevel = New System.Windows.Forms.ComboBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnAdd = New crsButton.cButton()
            Me.btnSearch = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.btnDelete = New crsButton.cButton()
            Me.btnUndo = New crsButton.cButton()
            Me.btnEdit = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.pnlStudent.SuspendLayout()
            CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.cmsProfile.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlStudent
            '
            Me.pnlStudent.BackColor = System.Drawing.Color.Transparent
            Me.pnlStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlStudent.Controls.Add(Me.lblDeathPension)
            Me.pnlStudent.Controls.Add(Me.lblPensionArrears)
            Me.pnlStudent.Controls.Add(Me.Label22)
            Me.pnlStudent.Controls.Add(Me.Label34)
            Me.pnlStudent.Controls.Add(Me.Label23)
            Me.pnlStudent.Controls.Add(Me.txtDeathPension)
            Me.pnlStudent.Controls.Add(Me.btnDeathAmount)
            Me.pnlStudent.Controls.Add(Me.txtPensionArrears)
            Me.pnlStudent.Controls.Add(Me.btnPensionAmount)
            Me.pnlStudent.Controls.Add(Me.Label24)
            Me.pnlStudent.Controls.Add(Me.txtGratuity)
            Me.pnlStudent.Controls.Add(Me.Label25)
            Me.pnlStudent.Controls.Add(Me.btnGratuityAmount)
            Me.pnlStudent.Controls.Add(Me.Label27)
            Me.pnlStudent.Controls.Add(Me.dtpPensionWEF)
            Me.pnlStudent.Controls.Add(Me.Label28)
            Me.pnlStudent.Controls.Add(Me.chkActive)
            Me.pnlStudent.Controls.Add(Me.txtPayThrough)
            Me.pnlStudent.Controls.Add(Me.txtPensionPerc)
            Me.pnlStudent.Controls.Add(Me.txtGratuityPerc)
            Me.pnlStudent.Controls.Add(Me.Label18)
            Me.pnlStudent.Controls.Add(Me.Label16)
            Me.pnlStudent.Controls.Add(Me.Label17)
            Me.pnlStudent.Controls.Add(Me.picPhoto)
            Me.pnlStudent.Controls.Add(Me.btnSalary)
            Me.pnlStudent.Controls.Add(Me.btnMinistry)
            Me.pnlStudent.Controls.Add(Me.txtFullName)
            Me.pnlStudent.Controls.Add(Me.txtRefNo)
            Me.pnlStudent.Controls.Add(Me.dtpDOR)
            Me.pnlStudent.Controls.Add(Me.dtpDOAA)
            Me.pnlStudent.Controls.Add(Me.dtpDOD)
            Me.pnlStudent.Controls.Add(Me.dtpDOB)
            Me.pnlStudent.Controls.Add(Me.dtpDOA)
            Me.pnlStudent.Controls.Add(Me.txtId)
            Me.pnlStudent.Controls.Add(Me.cboSalary)
            Me.pnlStudent.Controls.Add(Me.cboMinistry)
            Me.pnlStudent.Controls.Add(Me.cboBenefitType)
            Me.pnlStudent.Controls.Add(Me.cboStep)
            Me.pnlStudent.Controls.Add(Me.Label12)
            Me.pnlStudent.Controls.Add(Me.cboLevel)
            Me.pnlStudent.Controls.Add(Me.Label15)
            Me.pnlStudent.Controls.Add(Me.Label29)
            Me.pnlStudent.Controls.Add(Me.Label31)
            Me.pnlStudent.Controls.Add(Me.Label7)
            Me.pnlStudent.Controls.Add(Me.Label26)
            Me.pnlStudent.Controls.Add(Me.Label14)
            Me.pnlStudent.Controls.Add(Me.Label8)
            Me.pnlStudent.Controls.Add(Me.Label4)
            Me.pnlStudent.Controls.Add(Me.Label10)
            Me.pnlStudent.Controls.Add(Me.Label13)
            Me.pnlStudent.Controls.Add(Me.Label9)
            Me.pnlStudent.Controls.Add(Me.Label6)
            Me.pnlStudent.Controls.Add(Me.Label5)
            Me.pnlStudent.Controls.Add(Me.Label3)
            Me.pnlStudent.Controls.Add(Me.Label2)
            Me.pnlStudent.Controls.Add(Me.Label1)
            Me.pnlStudent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pnlStudent.Location = New System.Drawing.Point(7, 7)
            Me.pnlStudent.Name = "pnlStudent"
            Me.pnlStudent.Size = New System.Drawing.Size(903, 389)
            Me.pnlStudent.TabIndex = 0
            '
            'lblDeathPension
            '
            Me.lblDeathPension.AutoSize = True
            Me.lblDeathPension.ForeColor = System.Drawing.Color.Red
            Me.lblDeathPension.Location = New System.Drawing.Point(865, 358)
            Me.lblDeathPension.Name = "lblDeathPension"
            Me.lblDeathPension.Size = New System.Drawing.Size(11, 14)
            Me.lblDeathPension.TabIndex = 143
            Me.lblDeathPension.Text = "*"
            Me.lblDeathPension.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblPensionArrears
            '
            Me.lblPensionArrears.AutoSize = True
            Me.lblPensionArrears.ForeColor = System.Drawing.Color.Red
            Me.lblPensionArrears.Location = New System.Drawing.Point(865, 328)
            Me.lblPensionArrears.Name = "lblPensionArrears"
            Me.lblPensionArrears.Size = New System.Drawing.Size(11, 14)
            Me.lblPensionArrears.TabIndex = 142
            Me.lblPensionArrears.Text = "*"
            Me.lblPensionArrears.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.ForeColor = System.Drawing.Color.Red
            Me.Label22.Location = New System.Drawing.Point(865, 300)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(11, 14)
            Me.Label22.TabIndex = 144
            Me.Label22.Text = "*"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label34
            '
            Me.Label34.AutoSize = True
            Me.Label34.ForeColor = System.Drawing.Color.Red
            Me.Label34.Location = New System.Drawing.Point(865, 181)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(11, 14)
            Me.Label34.TabIndex = 145
            Me.Label34.Text = "*"
            Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.ForeColor = System.Drawing.Color.Red
            Me.Label23.Location = New System.Drawing.Point(865, 211)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(11, 14)
            Me.Label23.TabIndex = 145
            Me.Label23.Text = "*"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtDeathPension
            '
            Me.txtDeathPension.Location = New System.Drawing.Point(641, 355)
            Me.txtDeathPension.Name = "txtDeathPension"
            Me.txtDeathPension.Size = New System.Drawing.Size(221, 20)
            Me.txtDeathPension.TabIndex = 20
            '
            'btnDeathAmount
            '
            Me.btnDeathAmount.BackColor = System.Drawing.Color.Transparent
            Me.btnDeathAmount.ButtonType = crsButton.cButton.btnType.add_combo
            Me.btnDeathAmount.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnDeathAmount.FlatAppearance.BorderSize = 0
            Me.btnDeathAmount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnDeathAmount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnDeathAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDeathAmount.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDeathAmount.Image = CType(resources.GetObject("btnDeathAmount.Image"), System.Drawing.Image)
            Me.btnDeathAmount.Location = New System.Drawing.Point(876, 355)
            Me.btnDeathAmount.Name = "btnDeathAmount"
            Me.btnDeathAmount.Size = New System.Drawing.Size(20, 20)
            Me.btnDeathAmount.TabIndex = 137
            Me.btnDeathAmount.UseVisualStyleBackColor = False
            '
            'txtPensionArrears
            '
            Me.txtPensionArrears.Location = New System.Drawing.Point(641, 325)
            Me.txtPensionArrears.Name = "txtPensionArrears"
            Me.txtPensionArrears.Size = New System.Drawing.Size(221, 20)
            Me.txtPensionArrears.TabIndex = 19
            '
            'btnPensionAmount
            '
            Me.btnPensionAmount.BackColor = System.Drawing.Color.Transparent
            Me.btnPensionAmount.ButtonType = crsButton.cButton.btnType.add_combo
            Me.btnPensionAmount.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnPensionAmount.FlatAppearance.BorderSize = 0
            Me.btnPensionAmount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnPensionAmount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnPensionAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPensionAmount.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPensionAmount.Image = CType(resources.GetObject("btnPensionAmount.Image"), System.Drawing.Image)
            Me.btnPensionAmount.Location = New System.Drawing.Point(876, 325)
            Me.btnPensionAmount.Name = "btnPensionAmount"
            Me.btnPensionAmount.Size = New System.Drawing.Size(20, 20)
            Me.btnPensionAmount.TabIndex = 136
            Me.btnPensionAmount.UseVisualStyleBackColor = False
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.ForeColor = System.Drawing.Color.Black
            Me.Label24.Location = New System.Drawing.Point(502, 358)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(121, 14)
            Me.Label24.TabIndex = 141
            Me.Label24.Text = "Death Pension Amount :"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtGratuity
            '
            Me.txtGratuity.Location = New System.Drawing.Point(641, 297)
            Me.txtGratuity.Name = "txtGratuity"
            Me.txtGratuity.Size = New System.Drawing.Size(221, 20)
            Me.txtGratuity.TabIndex = 18
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.ForeColor = System.Drawing.Color.Black
            Me.Label25.Location = New System.Drawing.Point(502, 328)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(130, 14)
            Me.Label25.TabIndex = 140
            Me.Label25.Text = "Pension Arrears Amount :"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnGratuityAmount
            '
            Me.btnGratuityAmount.BackColor = System.Drawing.Color.Transparent
            Me.btnGratuityAmount.ButtonType = crsButton.cButton.btnType.add_combo
            Me.btnGratuityAmount.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnGratuityAmount.FlatAppearance.BorderSize = 0
            Me.btnGratuityAmount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnGratuityAmount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnGratuityAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGratuityAmount.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGratuityAmount.Image = CType(resources.GetObject("btnGratuityAmount.Image"), System.Drawing.Image)
            Me.btnGratuityAmount.Location = New System.Drawing.Point(876, 297)
            Me.btnGratuityAmount.Name = "btnGratuityAmount"
            Me.btnGratuityAmount.Size = New System.Drawing.Size(20, 20)
            Me.btnGratuityAmount.TabIndex = 135
            Me.btnGratuityAmount.UseVisualStyleBackColor = False
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.ForeColor = System.Drawing.Color.Black
            Me.Label27.Location = New System.Drawing.Point(502, 300)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(90, 14)
            Me.Label27.TabIndex = 139
            Me.Label27.Text = "Gratuity Amount :"
            Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpPensionWEF
            '
            Me.dtpPensionWEF.Location = New System.Drawing.Point(641, 208)
            Me.dtpPensionWEF.Name = "dtpPensionWEF"
            Me.dtpPensionWEF.Size = New System.Drawing.Size(221, 20)
            Me.dtpPensionWEF.TabIndex = 15
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.BackColor = System.Drawing.Color.Transparent
            Me.Label28.ForeColor = System.Drawing.Color.Black
            Me.Label28.Location = New System.Drawing.Point(502, 211)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(108, 14)
            Me.Label28.TabIndex = 138
            Me.Label28.Text = "Pension W.E.F. Date :"
            '
            'chkActive
            '
            Me.chkActive.AutoSize = True
            Me.chkActive.Checked = True
            Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkActive.Enabled = False
            Me.chkActive.Location = New System.Drawing.Point(127, 11)
            Me.chkActive.Name = "chkActive"
            Me.chkActive.Size = New System.Drawing.Size(57, 18)
            Me.chkActive.TabIndex = 0
            Me.chkActive.Text = "Active"
            Me.chkActive.UseVisualStyleBackColor = True
            '
            'txtPayThrough
            '
            Me.txtPayThrough.Location = New System.Drawing.Point(127, 355)
            Me.txtPayThrough.MaxLength = 63
            Me.txtPayThrough.Name = "txtPayThrough"
            Me.txtPayThrough.Size = New System.Drawing.Size(221, 20)
            Me.txtPayThrough.TabIndex = 12
            '
            'txtPensionPerc
            '
            Me.txtPensionPerc.Location = New System.Drawing.Point(641, 268)
            Me.txtPensionPerc.MaxLength = 63
            Me.txtPensionPerc.Name = "txtPensionPerc"
            Me.txtPensionPerc.Size = New System.Drawing.Size(221, 20)
            Me.txtPensionPerc.TabIndex = 17
            '
            'txtGratuityPerc
            '
            Me.txtGratuityPerc.Location = New System.Drawing.Point(641, 238)
            Me.txtGratuityPerc.MaxLength = 63
            Me.txtGratuityPerc.Name = "txtGratuityPerc"
            Me.txtGratuityPerc.Size = New System.Drawing.Size(221, 20)
            Me.txtGratuityPerc.TabIndex = 16
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.ForeColor = System.Drawing.Color.Black
            Me.Label18.Location = New System.Drawing.Point(6, 358)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(97, 14)
            Me.Label18.TabIndex = 100
            Me.Label18.Text = "Payment Through :"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.ForeColor = System.Drawing.Color.Black
            Me.Label16.Location = New System.Drawing.Point(502, 271)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(113, 14)
            Me.Label16.TabIndex = 100
            Me.Label16.Text = "Awarded Pension % :"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.ForeColor = System.Drawing.Color.Black
            Me.Label17.Location = New System.Drawing.Point(502, 241)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(113, 14)
            Me.Label17.TabIndex = 100
            Me.Label17.Text = "Awarded Gratuity % :"
            '
            'picPhoto
            '
            Me.picPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picPhoto.ContextMenuStrip = Me.cmsProfile
            Me.picPhoto.Location = New System.Drawing.Point(685, 9)
            Me.picPhoto.Name = "picPhoto"
            Me.picPhoto.Size = New System.Drawing.Size(132, 132)
            Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picPhoto.TabIndex = 130
            Me.picPhoto.TabStop = False
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
            'btnSalary
            '
            Me.btnSalary.BackColor = System.Drawing.Color.Transparent
            Me.btnSalary.ButtonType = crsButton.cButton.btnType.add_combo
            Me.btnSalary.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnSalary.FlatAppearance.BorderSize = 0
            Me.btnSalary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSalary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSalary.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalary.Image = CType(resources.GetObject("btnSalary.Image"), System.Drawing.Image)
            Me.btnSalary.Location = New System.Drawing.Point(355, 149)
            Me.btnSalary.Name = "btnSalary"
            Me.btnSalary.Size = New System.Drawing.Size(20, 20)
            Me.btnSalary.TabIndex = 25
            Me.btnSalary.UseVisualStyleBackColor = False
            '
            'btnMinistry
            '
            Me.btnMinistry.BackColor = System.Drawing.Color.Transparent
            Me.btnMinistry.ButtonType = crsButton.cButton.btnType.add_combo
            Me.btnMinistry.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnMinistry.FlatAppearance.BorderSize = 0
            Me.btnMinistry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnMinistry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnMinistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMinistry.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnMinistry.Image = CType(resources.GetObject("btnMinistry.Image"), System.Drawing.Image)
            Me.btnMinistry.Location = New System.Drawing.Point(463, 92)
            Me.btnMinistry.Name = "btnMinistry"
            Me.btnMinistry.Size = New System.Drawing.Size(20, 20)
            Me.btnMinistry.TabIndex = 24
            Me.btnMinistry.UseVisualStyleBackColor = False
            '
            'txtFullName
            '
            Me.txtFullName.Location = New System.Drawing.Point(127, 64)
            Me.txtFullName.MaxLength = 50
            Me.txtFullName.Name = "txtFullName"
            Me.txtFullName.Size = New System.Drawing.Size(319, 20)
            Me.txtFullName.TabIndex = 2
            '
            'txtRefNo
            '
            Me.txtRefNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRefNo.Location = New System.Drawing.Point(641, 149)
            Me.txtRefNo.MaxLength = 50
            Me.txtRefNo.Name = "txtRefNo"
            Me.txtRefNo.Size = New System.Drawing.Size(221, 20)
            Me.txtRefNo.TabIndex = 13
            '
            'dtpDOR
            '
            Me.dtpDOR.Location = New System.Drawing.Point(127, 297)
            Me.dtpDOR.Name = "dtpDOR"
            Me.dtpDOR.Size = New System.Drawing.Size(221, 20)
            Me.dtpDOR.TabIndex = 10
            '
            'dtpDOAA
            '
            Me.dtpDOAA.Location = New System.Drawing.Point(641, 178)
            Me.dtpDOAA.Name = "dtpDOAA"
            Me.dtpDOAA.Size = New System.Drawing.Size(221, 20)
            Me.dtpDOAA.TabIndex = 14
            '
            'dtpDOD
            '
            Me.dtpDOD.Location = New System.Drawing.Point(127, 325)
            Me.dtpDOD.Name = "dtpDOD"
            Me.dtpDOD.Size = New System.Drawing.Size(221, 20)
            Me.dtpDOD.TabIndex = 11
            '
            'dtpDOB
            '
            Me.dtpDOB.Location = New System.Drawing.Point(127, 238)
            Me.dtpDOB.Name = "dtpDOB"
            Me.dtpDOB.Size = New System.Drawing.Size(221, 20)
            Me.dtpDOB.TabIndex = 8
            '
            'dtpDOA
            '
            Me.dtpDOA.Location = New System.Drawing.Point(127, 268)
            Me.dtpDOA.Name = "dtpDOA"
            Me.dtpDOA.Size = New System.Drawing.Size(221, 20)
            Me.dtpDOA.TabIndex = 9
            '
            'txtId
            '
            Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtId.Location = New System.Drawing.Point(127, 38)
            Me.txtId.MaxLength = 50
            Me.txtId.Name = "txtId"
            Me.txtId.Size = New System.Drawing.Size(196, 20)
            Me.txtId.TabIndex = 1
            '
            'cboSalary
            '
            Me.cboSalary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboSalary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboSalary.FormattingEnabled = True
            Me.cboSalary.Location = New System.Drawing.Point(127, 148)
            Me.cboSalary.Name = "cboSalary"
            Me.cboSalary.Size = New System.Drawing.Size(221, 22)
            Me.cboSalary.TabIndex = 5
            '
            'cboMinistry
            '
            Me.cboMinistry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboMinistry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboMinistry.FormattingEnabled = True
            Me.cboMinistry.Location = New System.Drawing.Point(127, 91)
            Me.cboMinistry.Name = "cboMinistry"
            Me.cboMinistry.Size = New System.Drawing.Size(319, 22)
            Me.cboMinistry.TabIndex = 3
            '
            'cboBenefitType
            '
            Me.cboBenefitType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboBenefitType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboBenefitType.FormattingEnabled = True
            Me.cboBenefitType.Location = New System.Drawing.Point(127, 120)
            Me.cboBenefitType.Name = "cboBenefitType"
            Me.cboBenefitType.Size = New System.Drawing.Size(221, 22)
            Me.cboBenefitType.TabIndex = 4
            '
            'cboStep
            '
            Me.cboStep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboStep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboStep.FormattingEnabled = True
            Me.cboStep.Location = New System.Drawing.Point(127, 207)
            Me.cboStep.Name = "cboStep"
            Me.cboStep.Size = New System.Drawing.Size(221, 22)
            Me.cboStep.TabIndex = 7
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.ForeColor = System.Drawing.Color.Black
            Me.Label12.Location = New System.Drawing.Point(502, 152)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(49, 14)
            Me.Label12.TabIndex = 70
            Me.Label12.Text = "Ref No. :"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboLevel
            '
            Me.cboLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboLevel.FormattingEnabled = True
            Me.cboLevel.Location = New System.Drawing.Point(127, 177)
            Me.cboLevel.Name = "cboLevel"
            Me.cboLevel.Size = New System.Drawing.Size(221, 22)
            Me.cboLevel.TabIndex = 6
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.ForeColor = System.Drawing.Color.Black
            Me.Label15.Location = New System.Drawing.Point(8, 95)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(50, 14)
            Me.Label15.TabIndex = 67
            Me.Label15.Text = "Ministry :"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.ForeColor = System.Drawing.Color.Red
            Me.Label29.Location = New System.Drawing.Point(449, 64)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(11, 14)
            Me.Label29.TabIndex = 66
            Me.Label29.Text = "*"
            Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.ForeColor = System.Drawing.Color.Red
            Me.Label31.Location = New System.Drawing.Point(449, 91)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(11, 14)
            Me.Label31.TabIndex = 66
            Me.Label31.Text = "*"
            Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.ForeColor = System.Drawing.Color.Red
            Me.Label7.Location = New System.Drawing.Point(352, 120)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(11, 14)
            Me.Label7.TabIndex = 66
            Me.Label7.Text = "*"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.ForeColor = System.Drawing.Color.Red
            Me.Label26.Location = New System.Drawing.Point(329, 41)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(11, 14)
            Me.Label26.TabIndex = 66
            Me.Label26.Text = "*"
            Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.ForeColor = System.Drawing.Color.Black
            Me.Label14.Location = New System.Drawing.Point(8, 124)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(73, 14)
            Me.Label14.TabIndex = 66
            Me.Label14.Text = "Benefit Type :"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.ForeColor = System.Drawing.Color.Black
            Me.Label8.Location = New System.Drawing.Point(8, 211)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(35, 14)
            Me.Label8.TabIndex = 60
            Me.Label8.Text = "Step :"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(8, 300)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(102, 14)
            Me.Label4.TabIndex = 57
            Me.Label4.Text = "Date of Retirement :"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.ForeColor = System.Drawing.Color.Black
            Me.Label10.Location = New System.Drawing.Point(8, 330)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(79, 14)
            Me.Label10.TabIndex = 57
            Me.Label10.Text = "Date of Death :"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.ForeColor = System.Drawing.Color.Black
            Me.Label13.Location = New System.Drawing.Point(502, 181)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(109, 14)
            Me.Label13.TabIndex = 57
            Me.Label13.Text = "Audit Approval Date :"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.ForeColor = System.Drawing.Color.Black
            Me.Label9.Location = New System.Drawing.Point(8, 243)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(73, 14)
            Me.Label9.TabIndex = 57
            Me.Label9.Text = "Date of Birth :"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.Location = New System.Drawing.Point(8, 181)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(72, 14)
            Me.Label6.TabIndex = 58
            Me.Label6.Text = "Grade Level :"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.Location = New System.Drawing.Point(8, 271)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(110, 14)
            Me.Label5.TabIndex = 57
            Me.Label5.Text = "Date of Appointment :"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Location = New System.Drawing.Point(8, 152)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(74, 14)
            Me.Label3.TabIndex = 55
            Me.Label3.Text = "Salary Scale :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Location = New System.Drawing.Point(8, 67)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(59, 14)
            Me.Label2.TabIndex = 54
            Me.Label2.Text = "Full Name :"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(8, 41)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(79, 14)
            Me.Label1.TabIndex = 53
            Me.Label1.Text = "Pension/ID No :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnAdd
            '
            Me.btnAdd.BackColor = System.Drawing.Color.Transparent
            Me.btnAdd.ButtonType = crsButton.cButton.btnType.add
            Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnAdd.FlatAppearance.BorderSize = 0
            Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
            Me.btnAdd.Location = New System.Drawing.Point(18, 434)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(85, 45)
            Me.btnAdd.TabIndex = 37
            Me.btnAdd.UseVisualStyleBackColor = False
            '
            'btnSearch
            '
            Me.btnSearch.BackColor = System.Drawing.Color.Transparent
            Me.btnSearch.ButtonType = crsButton.cButton.btnType.search
            Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnSearch.FlatAppearance.BorderSize = 0
            Me.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
            Me.btnSearch.Location = New System.Drawing.Point(639, 434)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(89, 45)
            Me.btnSearch.TabIndex = 42
            Me.btnSearch.TabStop = False
            Me.btnSearch.UseVisualStyleBackColor = False
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
            Me.btnClose.Location = New System.Drawing.Point(816, 434)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 43
            Me.btnClose.TabStop = False
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnDelete
            '
            Me.btnDelete.BackColor = System.Drawing.Color.Transparent
            Me.btnDelete.ButtonType = crsButton.cButton.btnType.remove
            Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnDelete.FlatAppearance.BorderSize = 0
            Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.Location = New System.Drawing.Point(466, 434)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(85, 45)
            Me.btnDelete.TabIndex = 41
            Me.btnDelete.TabStop = False
            Me.btnDelete.UseVisualStyleBackColor = False
            '
            'btnUndo
            '
            Me.btnUndo.BackColor = System.Drawing.Color.Transparent
            Me.btnUndo.ButtonType = crsButton.cButton.btnType.cancel
            Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnUndo.FlatAppearance.BorderSize = 0
            Me.btnUndo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
            Me.btnUndo.Location = New System.Drawing.Point(354, 434)
            Me.btnUndo.Name = "btnUndo"
            Me.btnUndo.Size = New System.Drawing.Size(85, 45)
            Me.btnUndo.TabIndex = 40
            Me.btnUndo.TabStop = False
            Me.btnUndo.UseVisualStyleBackColor = False
            '
            'btnEdit
            '
            Me.btnEdit.BackColor = System.Drawing.Color.Transparent
            Me.btnEdit.ButtonType = crsButton.cButton.btnType.edit
            Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnEdit.FlatAppearance.BorderSize = 0
            Me.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
            Me.btnEdit.Location = New System.Drawing.Point(242, 434)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 45)
            Me.btnEdit.TabIndex = 39
            Me.btnEdit.TabStop = False
            Me.btnEdit.UseVisualStyleBackColor = False
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.Transparent
            Me.btnSave.ButtonType = crsButton.cButton.btnType.save
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.Location = New System.Drawing.Point(130, 434)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 38
            Me.btnSave.TabStop = False
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'frmEmployee
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.WhiteSmoke
            Me.ClientSize = New System.Drawing.Size(918, 506)
            Me.Controls.Add(Me.btnAdd)
            Me.Controls.Add(Me.btnSearch)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.btnUndo)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.pnlStudent)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimumSize = New System.Drawing.Size(785, 530)
            Me.Name = "frmEmployee"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Student Profile"
            Me.pnlStudent.ResumeLayout(False)
            Me.pnlStudent.PerformLayout()
            CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.cmsProfile.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlStudent As System.Windows.Forms.Panel
        Friend WithEvents txtGratuityPerc As System.Windows.Forms.TextBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents txtRefNo As System.Windows.Forms.TextBox
        Friend WithEvents dtpDOA As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtId As System.Windows.Forms.TextBox
        Friend WithEvents cboSalary As System.Windows.Forms.ComboBox
        Friend WithEvents cboMinistry As System.Windows.Forms.ComboBox
        Friend WithEvents cboBenefitType As System.Windows.Forms.ComboBox
        Friend WithEvents cboStep As System.Windows.Forms.ComboBox
        Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label

        Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
        Friend WithEvents btnSalary As crsButton.cButton
        Friend WithEvents btnMinistry As crsButton.cButton
        Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
        Friend WithEvents cmsProfile As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents RemovePhotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents chkActive As System.Windows.Forms.CheckBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpDOR As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtFullName As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpDOAA As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtPensionPerc As System.Windows.Forms.TextBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents txtPayThrough As System.Windows.Forms.TextBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpDOD As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents lblDeathPension As System.Windows.Forms.Label
        Friend WithEvents lblPensionArrears As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents txtDeathPension As System.Windows.Forms.TextBox
        Friend WithEvents btnDeathAmount As crsButton.cButton
        Friend WithEvents txtPensionArrears As System.Windows.Forms.TextBox
        Friend WithEvents btnPensionAmount As crsButton.cButton
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents txtGratuity As System.Windows.Forms.TextBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents btnGratuityAmount As crsButton.cButton
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents dtpPensionWEF As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label34 As System.Windows.Forms.Label
        Friend WithEvents btnAdd As crsButton.cButton
        Friend WithEvents btnSearch As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnDelete As crsButton.cButton
        Friend WithEvents btnUndo As crsButton.cButton
        Friend WithEvents btnEdit As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
    End Class
End Namespace