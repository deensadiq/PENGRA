Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmGroupKnockOff
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroupKnockOff))
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtKnockoffAmount = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpTransDate = New System.Windows.Forms.DateTimePicker()
            Me.txtBudgetAmount = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtTransactionNo = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cboBudget = New System.Windows.Forms.ComboBox()
            Me.cboBudgetYear = New System.Windows.Forms.ComboBox()
            Me.cboBudgetMonth = New System.Windows.Forms.ComboBox()
            Me.txtBudgetBalance = New System.Windows.Forms.TextBox()
            Me.txtBalance = New System.Windows.Forms.TextBox()
            Me.txtAMonth = New System.Windows.Forms.TextBox()
            Me.txtAYear = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtMinistry = New System.Windows.Forms.TextBox()
            Me.btnEdit = New crsButton.cButton()
            Me.btnUndo = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(8, 148)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(100, 14)
            Me.Label4.TabIndex = 49
            Me.Label4.Text = "Knock-off Amount :"
            '
            'txtKnockoffAmount
            '
            Me.txtKnockoffAmount.BackColor = System.Drawing.Color.White
            Me.txtKnockoffAmount.Location = New System.Drawing.Point(114, 145)
            Me.txtKnockoffAmount.Name = "txtKnockoffAmount"
            Me.txtKnockoffAmount.ReadOnly = True
            Me.txtKnockoffAmount.Size = New System.Drawing.Size(191, 20)
            Me.txtKnockoffAmount.TabIndex = 7
            Me.txtKnockoffAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dtpTransDate)
            Me.GroupBox1.Controls.Add(Me.txtBudgetAmount)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.txtTransactionNo)
            Me.GroupBox1.Controls.Add(Me.txtKnockoffAmount)
            Me.GroupBox1.Controls.Add(Me.Label14)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.cboBudget)
            Me.GroupBox1.Controls.Add(Me.cboBudgetYear)
            Me.GroupBox1.Controls.Add(Me.cboBudgetMonth)
            Me.GroupBox1.Controls.Add(Me.txtBudgetBalance)
            Me.GroupBox1.Controls.Add(Me.txtBalance)
            Me.GroupBox1.Controls.Add(Me.txtAMonth)
            Me.GroupBox1.Controls.Add(Me.txtAYear)
            Me.GroupBox1.Location = New System.Drawing.Point(7, 45)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(634, 178)
            Me.GroupBox1.TabIndex = 72
            Me.GroupBox1.TabStop = False
            '
            'dtpTransDate
            '
            Me.dtpTransDate.Location = New System.Drawing.Point(114, 19)
            Me.dtpTransDate.Name = "dtpTransDate"
            Me.dtpTransDate.Size = New System.Drawing.Size(191, 20)
            Me.dtpTransDate.TabIndex = 6
            '
            'txtBudgetAmount
            '
            Me.txtBudgetAmount.BackColor = System.Drawing.Color.White
            Me.txtBudgetAmount.Location = New System.Drawing.Point(435, 95)
            Me.txtBudgetAmount.Name = "txtBudgetAmount"
            Me.txtBudgetAmount.ReadOnly = True
            Me.txtBudgetAmount.Size = New System.Drawing.Size(191, 20)
            Me.txtBudgetAmount.TabIndex = 11
            Me.txtBudgetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(326, 98)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(99, 14)
            Me.Label11.TabIndex = 49
            Me.Label11.Text = "Allocation Amount :"
            '
            'txtTransactionNo
            '
            Me.txtTransactionNo.BackColor = System.Drawing.Color.White
            Me.txtTransactionNo.Location = New System.Drawing.Point(114, 120)
            Me.txtTransactionNo.Name = "txtTransactionNo"
            Me.txtTransactionNo.ReadOnly = True
            Me.txtTransactionNo.Size = New System.Drawing.Size(191, 20)
            Me.txtTransactionNo.TabIndex = 7
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(8, 123)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(86, 14)
            Me.Label14.TabIndex = 49
            Me.Label14.Text = "Transaction No :"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(326, 123)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(102, 14)
            Me.Label10.TabIndex = 69
            Me.Label10.Text = "Allocation Balance :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(8, 22)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(95, 14)
            Me.Label7.TabIndex = 49
            Me.Label7.Text = "Transaction Date :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(8, 98)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(52, 14)
            Me.Label13.TabIndex = 49
            Me.Label13.Text = "Balance :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(326, 73)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(60, 14)
            Me.Label9.TabIndex = 49
            Me.Label9.Text = "Allocation :"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(326, 22)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(86, 14)
            Me.Label8.TabIndex = 49
            Me.Label8.Text = "Allocation Year :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(326, 48)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(92, 14)
            Me.Label5.TabIndex = 49
            Me.Label5.Text = "Allocation Month :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(8, 73)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(70, 14)
            Me.Label1.TabIndex = 49
            Me.Label1.Text = "Audit Month :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(8, 48)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(64, 14)
            Me.Label6.TabIndex = 49
            Me.Label6.Text = "Audit Year :"
            '
            'cboBudget
            '
            Me.cboBudget.FormattingEnabled = True
            Me.cboBudget.Location = New System.Drawing.Point(435, 69)
            Me.cboBudget.Name = "cboBudget"
            Me.cboBudget.Size = New System.Drawing.Size(191, 22)
            Me.cboBudget.TabIndex = 10
            '
            'cboBudgetYear
            '
            Me.cboBudgetYear.FormattingEnabled = True
            Me.cboBudgetYear.Location = New System.Drawing.Point(435, 18)
            Me.cboBudgetYear.Name = "cboBudgetYear"
            Me.cboBudgetYear.Size = New System.Drawing.Size(191, 22)
            Me.cboBudgetYear.TabIndex = 9
            '
            'cboBudgetMonth
            '
            Me.cboBudgetMonth.FormattingEnabled = True
            Me.cboBudgetMonth.Location = New System.Drawing.Point(435, 44)
            Me.cboBudgetMonth.Name = "cboBudgetMonth"
            Me.cboBudgetMonth.Size = New System.Drawing.Size(191, 22)
            Me.cboBudgetMonth.TabIndex = 8
            '
            'txtBudgetBalance
            '
            Me.txtBudgetBalance.BackColor = System.Drawing.Color.White
            Me.txtBudgetBalance.Location = New System.Drawing.Point(435, 120)
            Me.txtBudgetBalance.Name = "txtBudgetBalance"
            Me.txtBudgetBalance.ReadOnly = True
            Me.txtBudgetBalance.Size = New System.Drawing.Size(191, 20)
            Me.txtBudgetBalance.TabIndex = 12
            Me.txtBudgetBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtBalance
            '
            Me.txtBalance.BackColor = System.Drawing.Color.White
            Me.txtBalance.Location = New System.Drawing.Point(114, 95)
            Me.txtBalance.Name = "txtBalance"
            Me.txtBalance.ReadOnly = True
            Me.txtBalance.Size = New System.Drawing.Size(191, 20)
            Me.txtBalance.TabIndex = 4
            Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'txtAMonth
            '
            Me.txtAMonth.BackColor = System.Drawing.Color.White
            Me.txtAMonth.Location = New System.Drawing.Point(114, 70)
            Me.txtAMonth.Name = "txtAMonth"
            Me.txtAMonth.ReadOnly = True
            Me.txtAMonth.Size = New System.Drawing.Size(191, 20)
            Me.txtAMonth.TabIndex = 3
            '
            'txtAYear
            '
            Me.txtAYear.BackColor = System.Drawing.Color.White
            Me.txtAYear.Location = New System.Drawing.Point(114, 45)
            Me.txtAYear.Name = "txtAYear"
            Me.txtAYear.ReadOnly = True
            Me.txtAYear.Size = New System.Drawing.Size(191, 20)
            Me.txtAYear.TabIndex = 3
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(11, 19)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(67, 14)
            Me.Label3.TabIndex = 49
            Me.Label3.Text = "Description :"
            '
            'txtMinistry
            '
            Me.txtMinistry.BackColor = System.Drawing.Color.White
            Me.txtMinistry.Location = New System.Drawing.Point(96, 16)
            Me.txtMinistry.Name = "txtMinistry"
            Me.txtMinistry.ReadOnly = True
            Me.txtMinistry.Size = New System.Drawing.Size(542, 20)
            Me.txtMinistry.TabIndex = 3
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
            Me.btnEdit.Location = New System.Drawing.Point(27, 251)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 45)
            Me.btnEdit.TabIndex = 84
            Me.btnEdit.UseVisualStyleBackColor = False
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
            Me.btnUndo.Location = New System.Drawing.Point(273, 251)
            Me.btnUndo.Name = "btnUndo"
            Me.btnUndo.Size = New System.Drawing.Size(85, 45)
            Me.btnUndo.TabIndex = 83
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
            Me.btnSave.Location = New System.Drawing.Point(150, 251)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 82
            Me.btnSave.UseVisualStyleBackColor = False
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
            Me.btnClose.Location = New System.Drawing.Point(537, 248)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 48)
            Me.btnClose.TabIndex = 81
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'frmGroupKnockOff
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(649, 329)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.btnUndo)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.txtMinistry)
            Me.Controls.Add(Me.Label3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmGroupKnockOff"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Knock-Off Benefit"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtKnockoffAmount As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpTransDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtBudgetAmount As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cboBudget As System.Windows.Forms.ComboBox
        Friend WithEvents cboBudgetYear As System.Windows.Forms.ComboBox
        Friend WithEvents cboBudgetMonth As System.Windows.Forms.ComboBox
        Friend WithEvents txtBudgetBalance As System.Windows.Forms.TextBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtBalance As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtMinistry As System.Windows.Forms.TextBox
        Friend WithEvents txtTransactionNo As System.Windows.Forms.TextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtAMonth As System.Windows.Forms.TextBox
        Friend WithEvents txtAYear As System.Windows.Forms.TextBox
        Friend WithEvents btnEdit As crsButton.cButton
        Friend WithEvents btnUndo As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
    End Class
End Namespace