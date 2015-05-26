Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBudgeting
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBudgeting))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cboYear = New System.Windows.Forms.ComboBox()
            Me.cboMonth = New System.Windows.Forms.ComboBox()
            Me.txtBalance = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtAmount = New System.Windows.Forms.TextBox()
            Me.txtDescription = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cboBudget = New System.Windows.Forms.ComboBox()
            Me.btnRemove = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.btnEdit = New crsButton.cButton()
            Me.btnCancel = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.btnAdd = New crsButton.cButton()
            Me.dgvGrid = New System.Windows.Forms.DataGridView()
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 44)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(42, 14)
            Me.Label1.TabIndex = 48
            Me.Label1.Text = "Month :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(10, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(36, 14)
            Me.Label2.TabIndex = 49
            Me.Label2.Text = "Year :"
            '
            'cboYear
            '
            Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboYear.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cboYear.FormattingEnabled = True
            Me.cboYear.Location = New System.Drawing.Point(76, 13)
            Me.cboYear.Name = "cboYear"
            Me.cboYear.Size = New System.Drawing.Size(185, 22)
            Me.cboYear.TabIndex = 1
            '
            'cboMonth
            '
            Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboMonth.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cboMonth.FormattingEnabled = True
            Me.cboMonth.Location = New System.Drawing.Point(76, 40)
            Me.cboMonth.Name = "cboMonth"
            Me.cboMonth.Size = New System.Drawing.Size(185, 22)
            Me.cboMonth.TabIndex = 2
            '
            'txtBalance
            '
            Me.txtBalance.BackColor = System.Drawing.Color.White
            Me.txtBalance.Location = New System.Drawing.Point(344, 41)
            Me.txtBalance.Name = "txtBalance"
            Me.txtBalance.ReadOnly = True
            Me.txtBalance.Size = New System.Drawing.Size(185, 20)
            Me.txtBalance.TabIndex = 6
            Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(271, 44)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(52, 14)
            Me.Label3.TabIndex = 69
            Me.Label3.Text = "Balance :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(271, 17)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(50, 14)
            Me.Label4.TabIndex = 49
            Me.Label4.Text = "Amount :"
            '
            'txtAmount
            '
            Me.txtAmount.BackColor = System.Drawing.Color.White
            Me.txtAmount.Location = New System.Drawing.Point(344, 14)
            Me.txtAmount.Name = "txtAmount"
            Me.txtAmount.Size = New System.Drawing.Size(185, 20)
            Me.txtAmount.TabIndex = 5
            Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtDescription
            '
            Me.txtDescription.BackColor = System.Drawing.Color.White
            Me.txtDescription.Location = New System.Drawing.Point(344, 68)
            Me.txtDescription.Name = "txtDescription"
            Me.txtDescription.Size = New System.Drawing.Size(276, 20)
            Me.txtDescription.TabIndex = 5
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(271, 71)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(67, 14)
            Me.Label5.TabIndex = 49
            Me.Label5.Text = "Description :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(10, 71)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(60, 14)
            Me.Label6.TabIndex = 49
            Me.Label6.Text = "Allocation :"
            '
            'cboBudget
            '
            Me.cboBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBudget.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cboBudget.FormattingEnabled = True
            Me.cboBudget.Location = New System.Drawing.Point(76, 67)
            Me.cboBudget.Name = "cboBudget"
            Me.cboBudget.Size = New System.Drawing.Size(185, 22)
            Me.cboBudget.TabIndex = 4
            '
            'btnRemove
            '
            Me.btnRemove.BackColor = System.Drawing.Color.Transparent
            Me.btnRemove.ButtonType = crsButton.cButton.btnType.remove
            Me.btnRemove.FlatAppearance.BorderSize = 0
            Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
            Me.btnRemove.Location = New System.Drawing.Point(432, 370)
            Me.btnRemove.Name = "btnRemove"
            Me.btnRemove.Size = New System.Drawing.Size(85, 45)
            Me.btnRemove.TabIndex = 86
            Me.btnRemove.UseVisualStyleBackColor = False
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
            Me.btnSave.Location = New System.Drawing.Point(220, 370)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 85
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
            Me.btnEdit.Location = New System.Drawing.Point(114, 370)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 45)
            Me.btnEdit.TabIndex = 84
            Me.btnEdit.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.ButtonType = crsButton.cButton.btnType.undo
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
            Me.btnCancel.Location = New System.Drawing.Point(326, 370)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(85, 45)
            Me.btnCancel.TabIndex = 83
            Me.btnCancel.UseVisualStyleBackColor = False
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
            Me.btnClose.Location = New System.Drawing.Point(538, 368)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 48)
            Me.btnClose.TabIndex = 82
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnAdd
            '
            Me.btnAdd.BackColor = System.Drawing.Color.Transparent
            Me.btnAdd.ButtonType = crsButton.cButton.btnType.add
            Me.btnAdd.FlatAppearance.BorderSize = 0
            Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
            Me.btnAdd.Location = New System.Drawing.Point(8, 370)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(85, 45)
            Me.btnAdd.TabIndex = 84
            Me.btnAdd.UseVisualStyleBackColor = False
            '
            'dgvGrid
            '
            Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvGrid.Location = New System.Drawing.Point(10, 104)
            Me.dgvGrid.Name = "dgvGrid"
            Me.dgvGrid.Size = New System.Drawing.Size(610, 246)
            Me.dgvGrid.TabIndex = 87
            '
            'frmBudgeting
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(631, 432)
            Me.Controls.Add(Me.txtDescription)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.dgvGrid)
            Me.Controls.Add(Me.btnRemove)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtAmount)
            Me.Controls.Add(Me.txtBalance)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnAdd)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.cboBudget)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboYear)
            Me.Controls.Add(Me.cboMonth)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmBudgeting"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Monthly Budgeting"
            CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cboYear As System.Windows.Forms.ComboBox
        Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
        Friend WithEvents txtBalance As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtAmount As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cboBudget As System.Windows.Forms.ComboBox
        Friend WithEvents btnRemove As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnEdit As crsButton.cButton
        Friend WithEvents btnCancel As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnAdd As crsButton.cButton
        Friend WithEvents txtDescription As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dgvGrid As System.Windows.Forms.DataGridView
    End Class
End Namespace