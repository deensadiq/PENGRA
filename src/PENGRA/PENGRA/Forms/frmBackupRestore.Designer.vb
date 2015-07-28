Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBackupRestore
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackupRestore))
            Me.btnBrowse = New crsButton.cButton()
            Me.btnProcessing = New crsButton.cButton()
            Me.btnClose = New crsButton.cButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtLocation = New System.Windows.Forms.TextBox()
            Me.rbRestore = New System.Windows.Forms.RadioButton()
            Me.rbBackup = New System.Windows.Forms.RadioButton()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.prgBar = New System.Windows.Forms.ProgressBar()
            Me.ofdMain = New System.Windows.Forms.OpenFileDialog()
            Me.sfdMain = New System.Windows.Forms.SaveFileDialog()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.GroupBox4.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnBrowse
            '
            Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
            Me.btnBrowse.ButtonType = crsButton.cButton.btnType.add_combo
            Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnBrowse.FlatAppearance.BorderSize = 0
            Me.btnBrowse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
            Me.btnBrowse.Location = New System.Drawing.Point(392, 57)
            Me.btnBrowse.Name = "btnBrowse"
            Me.btnBrowse.Size = New System.Drawing.Size(20, 20)
            Me.btnBrowse.TabIndex = 11
            Me.btnBrowse.UseVisualStyleBackColor = False
            '
            'btnProcessing
            '
            Me.btnProcessing.BackColor = System.Drawing.Color.Transparent
            Me.btnProcessing.ButtonType = crsButton.cButton.btnType.startprocessing
            Me.btnProcessing.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnProcessing.FlatAppearance.BorderSize = 0
            Me.btnProcessing.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnProcessing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnProcessing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnProcessing.Image = CType(resources.GetObject("btnProcessing.Image"), System.Drawing.Image)
            Me.btnProcessing.Location = New System.Drawing.Point(17, 191)
            Me.btnProcessing.Name = "btnProcessing"
            Me.btnProcessing.Size = New System.Drawing.Size(168, 60)
            Me.btnProcessing.TabIndex = 10
            Me.btnProcessing.UseVisualStyleBackColor = False
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
            Me.btnClose.Location = New System.Drawing.Point(327, 197)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 48)
            Me.btnClose.TabIndex = 8
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(6, 60)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(51, 14)
            Me.Label1.TabIndex = 16
            Me.Label1.Text = "Location:"
            '
            'txtLocation
            '
            Me.txtLocation.Location = New System.Drawing.Point(61, 57)
            Me.txtLocation.Name = "txtLocation"
            Me.txtLocation.Size = New System.Drawing.Size(330, 20)
            Me.txtLocation.TabIndex = 15
            '
            'rbRestore
            '
            Me.rbRestore.AutoSize = True
            Me.rbRestore.BackColor = System.Drawing.Color.Transparent
            Me.rbRestore.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbRestore.Location = New System.Drawing.Point(306, 20)
            Me.rbRestore.Name = "rbRestore"
            Me.rbRestore.Size = New System.Drawing.Size(63, 18)
            Me.rbRestore.TabIndex = 14
            Me.rbRestore.Text = "Restore"
            Me.rbRestore.UseVisualStyleBackColor = False
            '
            'rbBackup
            '
            Me.rbBackup.AutoSize = True
            Me.rbBackup.BackColor = System.Drawing.Color.Transparent
            Me.rbBackup.Checked = True
            Me.rbBackup.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbBackup.Location = New System.Drawing.Point(59, 20)
            Me.rbBackup.Name = "rbBackup"
            Me.rbBackup.Size = New System.Drawing.Size(61, 18)
            Me.rbBackup.TabIndex = 13
            Me.rbBackup.TabStop = True
            Me.rbBackup.Text = "Backup"
            Me.rbBackup.UseVisualStyleBackColor = False
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox4.Controls.Add(Me.prgBar)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.GroupBox4.Location = New System.Drawing.Point(13, 96)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(403, 85)
            Me.GroupBox4.TabIndex = 17
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Progress"
            '
            'prgBar
            '
            Me.prgBar.BackColor = System.Drawing.Color.White
            Me.prgBar.Location = New System.Drawing.Point(9, 20)
            Me.prgBar.Name = "prgBar"
            Me.prgBar.Size = New System.Drawing.Size(385, 55)
            Me.prgBar.TabIndex = 1
            '
            'Timer1
            '
            Me.Timer1.Interval = 10
            '
            'frmBackupRestore
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(428, 266)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtLocation)
            Me.Controls.Add(Me.rbRestore)
            Me.Controls.Add(Me.rbBackup)
            Me.Controls.Add(Me.btnBrowse)
            Me.Controls.Add(Me.btnProcessing)
            Me.Controls.Add(Me.btnClose)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmBackupRestore"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Backup/Restore Database"
            Me.GroupBox4.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnBrowse As crsButton.cButton
        Friend WithEvents btnProcessing As crsButton.cButton
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtLocation As System.Windows.Forms.TextBox
        Friend WithEvents rbRestore As System.Windows.Forms.RadioButton
        Friend WithEvents rbBackup As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents prgBar As System.Windows.Forms.ProgressBar
        Friend WithEvents ofdMain As System.Windows.Forms.OpenFileDialog
        Friend WithEvents sfdMain As System.Windows.Forms.SaveFileDialog
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
    End Class
End Namespace