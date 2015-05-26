Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmProcess
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcess))
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.lblProgress = New System.Windows.Forms.Label()
            Me.prgBar = New System.Windows.Forms.ProgressBar()
            Me.cboBudget = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cboMonth = New System.Windows.Forms.ComboBox()
            Me.cboYear = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
            Me.btnClose = New crsButton.cButton()
            Me.btnStop = New crsButton.cButton()
            Me.btnStart = New crsButton.cButton()
            Me.GroupBox4.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.lblProgress)
            Me.GroupBox4.Controls.Add(Me.prgBar)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.GroupBox4.Location = New System.Drawing.Point(9, 111)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(563, 69)
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Progress"
            '
            'lblProgress
            '
            Me.lblProgress.AutoSize = True
            Me.lblProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProgress.ForeColor = System.Drawing.Color.Blue
            Me.lblProgress.Location = New System.Drawing.Point(149, 50)
            Me.lblProgress.Name = "lblProgress"
            Me.lblProgress.Size = New System.Drawing.Size(19, 13)
            Me.lblProgress.TabIndex = 2
            Me.lblProgress.Text = "...."
            '
            'prgBar
            '
            Me.prgBar.Location = New System.Drawing.Point(18, 19)
            Me.prgBar.Name = "prgBar"
            Me.prgBar.Size = New System.Drawing.Size(529, 27)
            Me.prgBar.TabIndex = 1
            '
            'cboBudget
            '
            Me.cboBudget.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cboBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboBudget.FormattingEnabled = True
            Me.cboBudget.Location = New System.Drawing.Point(103, 75)
            Me.cboBudget.Name = "cboBudget"
            Me.cboBudget.Size = New System.Drawing.Size(179, 21)
            Me.cboBudget.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(9, 46)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(92, 14)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "Allocation Month :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(86, 14)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "Allocation Year :"
            '
            'cboMonth
            '
            Me.cboMonth.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cboMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboMonth.FormattingEnabled = True
            Me.cboMonth.Location = New System.Drawing.Point(103, 46)
            Me.cboMonth.Name = "cboMonth"
            Me.cboMonth.Size = New System.Drawing.Size(179, 21)
            Me.cboMonth.TabIndex = 0
            '
            'cboYear
            '
            Me.cboYear.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboYear.FormattingEnabled = True
            Me.cboYear.Location = New System.Drawing.Point(103, 17)
            Me.cboYear.Name = "cboYear"
            Me.cboYear.Size = New System.Drawing.Size(179, 21)
            Me.cboYear.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(9, 78)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(60, 14)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Allocation :"
            '
            'BackgroundWorker
            '
            Me.BackgroundWorker.WorkerReportsProgress = True
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
            Me.btnClose.Location = New System.Drawing.Point(478, 219)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 11
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnStop
            '
            Me.btnStop.BackColor = System.Drawing.Color.Transparent
            Me.btnStop.ButtonType = crsButton.cButton.btnType.stopprocessing
            Me.btnStop.FlatAppearance.BorderSize = 0
            Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
            Me.btnStop.Location = New System.Drawing.Point(237, 202)
            Me.btnStop.Name = "btnStop"
            Me.btnStop.Size = New System.Drawing.Size(168, 65)
            Me.btnStop.TabIndex = 10
            Me.btnStop.UseVisualStyleBackColor = False
            '
            'btnStart
            '
            Me.btnStart.BackColor = System.Drawing.Color.Transparent
            Me.btnStart.ButtonType = crsButton.cButton.btnType.startprocessing
            Me.btnStart.FlatAppearance.BorderSize = 0
            Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
            Me.btnStart.Location = New System.Drawing.Point(11, 205)
            Me.btnStart.Name = "btnStart"
            Me.btnStart.Size = New System.Drawing.Size(168, 65)
            Me.btnStart.TabIndex = 9
            Me.btnStart.UseVisualStyleBackColor = False
            '
            'frmProcess
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(581, 294)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnStop)
            Me.Controls.Add(Me.btnStart)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.cboYear)
            Me.Controls.Add(Me.cboMonth)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboBudget)
            Me.Controls.Add(Me.GroupBox4)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmProcess"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Process Payment"
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents cboBudget As System.Windows.Forms.ComboBox
        Friend WithEvents prgBar As System.Windows.Forms.ProgressBar
        Friend WithEvents lblProgress As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
        Friend WithEvents cboYear As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnStop As crsButton.cButton
        Friend WithEvents btnStart As crsButton.cButton
    End Class
End Namespace