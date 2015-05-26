Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPaymentLimit
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentLimit))
            Me.Label5 = New System.Windows.Forms.Label()
            Me.pbLimit = New System.Windows.Forms.ProgressBar()
            Me.bwLimit = New System.ComponentModel.BackgroundWorker()
            Me.lblCalendar = New System.Windows.Forms.Label()
            Me.txtPaymentLimit = New System.Windows.Forms.TextBox()
            Me.gpbAboveLimit = New System.Windows.Forms.GroupBox()
            Me.btnUndo = New crsButton.cButton()
            Me.btnEdit = New crsButton.cButton()
            Me.btnSave = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.chkOverride = New System.Windows.Forms.CheckBox()
            Me.gpbAboveLimit.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Location = New System.Drawing.Point(18, 33)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(114, 14)
            Me.Label5.TabIndex = 137
            Me.Label5.Text = "Benefit Limit (Above) :"
            '
            'pbLimit
            '
            Me.pbLimit.BackColor = System.Drawing.Color.White
            Me.pbLimit.Location = New System.Drawing.Point(12, 14)
            Me.pbLimit.Name = "pbLimit"
            Me.pbLimit.Size = New System.Drawing.Size(413, 25)
            Me.pbLimit.Step = 1
            Me.pbLimit.TabIndex = 146
            '
            'bwLimit
            '
            Me.bwLimit.WorkerReportsProgress = True
            Me.bwLimit.WorkerSupportsCancellation = True
            '
            'lblCalendar
            '
            Me.lblCalendar.Location = New System.Drawing.Point(12, 80)
            Me.lblCalendar.Name = "lblCalendar"
            Me.lblCalendar.Size = New System.Drawing.Size(413, 19)
            Me.lblCalendar.TabIndex = 147
            '
            'txtPaymentLimit
            '
            Me.txtPaymentLimit.Location = New System.Drawing.Point(143, 30)
            Me.txtPaymentLimit.Name = "txtPaymentLimit"
            Me.txtPaymentLimit.Size = New System.Drawing.Size(287, 20)
            Me.txtPaymentLimit.TabIndex = 148
            '
            'gpbAboveLimit
            '
            Me.gpbAboveLimit.Controls.Add(Me.pbLimit)
            Me.gpbAboveLimit.Controls.Add(Me.lblCalendar)
            Me.gpbAboveLimit.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.gpbAboveLimit.Location = New System.Drawing.Point(6, 89)
            Me.gpbAboveLimit.Name = "gpbAboveLimit"
            Me.gpbAboveLimit.Size = New System.Drawing.Size(437, 46)
            Me.gpbAboveLimit.TabIndex = 149
            Me.gpbAboveLimit.TabStop = False
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
            Me.btnUndo.Location = New System.Drawing.Point(101, 148)
            Me.btnUndo.Name = "btnUndo"
            Me.btnUndo.Size = New System.Drawing.Size(85, 45)
            Me.btnUndo.TabIndex = 154
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
            Me.btnEdit.Location = New System.Drawing.Point(6, 148)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(85, 45)
            Me.btnEdit.TabIndex = 152
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
            Me.btnSave.Location = New System.Drawing.Point(196, 148)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(85, 45)
            Me.btnSave.TabIndex = 153
            Me.btnSave.TabStop = False
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.ButtonType = crsButton.cButton.btnType.close2
            Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(358, 148)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 151
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'chkOverride
            '
            Me.chkOverride.AutoSize = True
            Me.chkOverride.Location = New System.Drawing.Point(19, 70)
            Me.chkOverride.Name = "chkOverride"
            Me.chkOverride.Size = New System.Drawing.Size(146, 18)
            Me.chkOverride.TabIndex = 155
            Me.chkOverride.Text = "Override Existing Record"
            Me.chkOverride.UseVisualStyleBackColor = True
            '
            'frmPaymentLimit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.LightGray
            Me.ClientSize = New System.Drawing.Size(449, 214)
            Me.Controls.Add(Me.chkOverride)
            Me.Controls.Add(Me.btnUndo)
            Me.Controls.Add(Me.txtPaymentLimit)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.btnEdit)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.gpbAboveLimit)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmPaymentLimit"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Benefit Above Limit"
            Me.gpbAboveLimit.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents pbLimit As System.Windows.Forms.ProgressBar
        Friend WithEvents bwLimit As System.ComponentModel.BackgroundWorker
        Friend WithEvents lblCalendar As System.Windows.Forms.Label
        Friend WithEvents txtPaymentLimit As System.Windows.Forms.TextBox
        Friend WithEvents gpbAboveLimit As System.Windows.Forms.GroupBox
        Friend WithEvents btnUndo As crsButton.cButton
        Friend WithEvents btnEdit As crsButton.cButton
        Friend WithEvents btnSave As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents chkOverride As System.Windows.Forms.CheckBox
    End Class
End Namespace