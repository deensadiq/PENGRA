Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmComputation
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComputation))
            Me.pbStudent = New System.Windows.Forms.ProgressBar()
            Me.lblStudent = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.cboSession = New System.Windows.Forms.ComboBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cboSemester = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cboYeargroup = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cboCategory = New System.Windows.Forms.ComboBox()
            Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
            Me.btnStop = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.btnProcess = New crsButton.cButton()
            Me.SuspendLayout()
            '
            'pbStudent
            '
            Me.pbStudent.BackColor = System.Drawing.Color.White
            Me.pbStudent.Location = New System.Drawing.Point(10, 168)
            Me.pbStudent.Name = "pbStudent"
            Me.pbStudent.Size = New System.Drawing.Size(447, 25)
            Me.pbStudent.Step = 1
            Me.pbStudent.TabIndex = 4
            '
            'lblStudent
            '
            Me.lblStudent.Location = New System.Drawing.Point(12, 199)
            Me.lblStudent.Name = "lblStudent"
            Me.lblStudent.Size = New System.Drawing.Size(445, 19)
            Me.lblStudent.TabIndex = 8
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Location = New System.Drawing.Point(7, 72)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(49, 14)
            Me.Label5.TabIndex = 39
            Me.Label5.Text = "Session:"
            '
            'cboSession
            '
            Me.cboSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboSession.FormattingEnabled = True
            Me.cboSession.Location = New System.Drawing.Point(80, 69)
            Me.cboSession.Name = "cboSession"
            Me.cboSession.Size = New System.Drawing.Size(360, 22)
            Me.cboSession.TabIndex = 38
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(7, 101)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(33, 14)
            Me.Label6.TabIndex = 37
            Me.Label6.Text = "Term:"
            '
            'cboSemester
            '
            Me.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboSemester.FormattingEnabled = True
            Me.cboSemester.Location = New System.Drawing.Point(80, 97)
            Me.cboSemester.Name = "cboSemester"
            Me.cboSemester.Size = New System.Drawing.Size(360, 22)
            Me.cboSemester.TabIndex = 36
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Location = New System.Drawing.Point(7, 44)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(66, 14)
            Me.Label3.TabIndex = 59
            Me.Label3.Text = "Year Group:"
            '
            'cboYeargroup
            '
            Me.cboYeargroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboYeargroup.FormattingEnabled = True
            Me.cboYeargroup.Location = New System.Drawing.Point(80, 41)
            Me.cboYeargroup.Name = "cboYeargroup"
            Me.cboYeargroup.Size = New System.Drawing.Size(360, 22)
            Me.cboYeargroup.TabIndex = 58
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(7, 21)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 14)
            Me.Label2.TabIndex = 57
            Me.Label2.Text = "Section:"
            '
            'cboCategory
            '
            Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboCategory.FormattingEnabled = True
            Me.cboCategory.Location = New System.Drawing.Point(80, 13)
            Me.cboCategory.Name = "cboCategory"
            Me.cboCategory.Size = New System.Drawing.Size(360, 22)
            Me.cboCategory.TabIndex = 56
            '
            'BackgroundWorker
            '
            Me.BackgroundWorker.WorkerReportsProgress = True
            Me.BackgroundWorker.WorkerSupportsCancellation = True
            '
            'btnStop
            '
            Me.btnStop.BackColor = System.Drawing.Color.Transparent
            Me.btnStop.ButtonType = crsButton.cButton.btnType.stopprocessing
            Me.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnStop.FlatAppearance.BorderSize = 0
            Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
            Me.btnStop.Location = New System.Drawing.Point(189, 221)
            Me.btnStop.Name = "btnStop"
            Me.btnStop.Size = New System.Drawing.Size(168, 60)
            Me.btnStop.TabIndex = 63
            Me.btnStop.UseVisualStyleBackColor = False
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
            Me.btnClose.Location = New System.Drawing.Point(377, 236)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 62
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnProcess
            '
            Me.btnProcess.BackColor = System.Drawing.Color.Transparent
            Me.btnProcess.ButtonType = crsButton.cButton.btnType.startprocessing
            Me.btnProcess.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnProcess.FlatAppearance.BorderSize = 0
            Me.btnProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnProcess.Image = CType(resources.GetObject("btnProcess.Image"), System.Drawing.Image)
            Me.btnProcess.Location = New System.Drawing.Point(15, 221)
            Me.btnProcess.Name = "btnProcess"
            Me.btnProcess.Size = New System.Drawing.Size(168, 60)
            Me.btnProcess.TabIndex = 61
            Me.btnProcess.UseVisualStyleBackColor = False
            '
            'frmComputation
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Thistle
            Me.ClientSize = New System.Drawing.Size(467, 316)
            Me.Controls.Add(Me.btnStop)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnProcess)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.cboYeargroup)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboCategory)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.cboSession)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.cboSemester)
            Me.Controls.Add(Me.lblStudent)
            Me.Controls.Add(Me.pbStudent)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmComputation"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Computation"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents pbStudent As System.Windows.Forms.ProgressBar
        Friend WithEvents lblStudent As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cboSession As System.Windows.Forms.ComboBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cboSemester As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cboYeargroup As System.Windows.Forms.ComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cboCategory As System.Windows.Forms.ComboBox

        Public Sub New()

            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub
        Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
        Friend WithEvents btnStop As crsButton.cButton
        Private WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnProcess As crsButton.cButton
    End Class
End Namespace