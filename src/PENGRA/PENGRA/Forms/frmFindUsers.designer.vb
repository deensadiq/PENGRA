Namespace cForm
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmFindUsers
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindUsers))
            Me.lvStudent = New System.Windows.Forms.ListView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblName = New System.Windows.Forms.Label()
            Me.txtFind = New System.Windows.Forms.TextBox()
            Me.rbFullName = New System.Windows.Forms.RadioButton()
            Me.rbUsername = New System.Windows.Forms.RadioButton()
            Me.btnOk = New crsButton.cButton()
            Me.lblCount = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnCancel = New crsButton.cButton()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lvStudent
            '
            Me.lvStudent.Location = New System.Drawing.Point(3, 84)
            Me.lvStudent.Name = "lvStudent"
            Me.lvStudent.Size = New System.Drawing.Size(534, 189)
            Me.lvStudent.TabIndex = 0
            Me.lvStudent.UseCompatibleStateImageBehavior = False
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.lblName)
            Me.GroupBox1.Controls.Add(Me.txtFind)
            Me.GroupBox1.Controls.Add(Me.rbFullName)
            Me.GroupBox1.Controls.Add(Me.rbUsername)
            Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(534, 75)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            '
            'lblName
            '
            Me.lblName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.Location = New System.Drawing.Point(6, 19)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New System.Drawing.Size(523, 25)
            Me.lblName.TabIndex = 3
            Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'txtFind
            '
            Me.txtFind.Location = New System.Drawing.Point(212, 50)
            Me.txtFind.Name = "txtFind"
            Me.txtFind.Size = New System.Drawing.Size(317, 20)
            Me.txtFind.TabIndex = 2
            '
            'rbFullName
            '
            Me.rbFullName.AutoSize = True
            Me.rbFullName.Location = New System.Drawing.Point(106, 51)
            Me.rbFullName.Name = "rbFullName"
            Me.rbFullName.Size = New System.Drawing.Size(71, 18)
            Me.rbFullName.TabIndex = 1
            Me.rbFullName.Text = "Full Name"
            Me.rbFullName.UseVisualStyleBackColor = True
            '
            'rbUsername
            '
            Me.rbUsername.AutoSize = True
            Me.rbUsername.Checked = True
            Me.rbUsername.Location = New System.Drawing.Point(6, 51)
            Me.rbUsername.Name = "rbUsername"
            Me.rbUsername.Size = New System.Drawing.Size(74, 18)
            Me.rbUsername.TabIndex = 0
            Me.rbUsername.TabStop = True
            Me.rbUsername.Text = "Username"
            Me.rbUsername.UseVisualStyleBackColor = True
            '
            'btnOk
            '
            Me.btnOk.BackColor = System.Drawing.Color.Transparent
            Me.btnOk.ButtonType = crsButton.cButton.btnType.ok
            Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnOk.FlatAppearance.BorderSize = 0
            Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
            Me.btnOk.Location = New System.Drawing.Point(318, 282)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(85, 45)
            Me.btnOk.TabIndex = 42
            Me.btnOk.UseVisualStyleBackColor = False
            '
            'lblCount
            '
            Me.lblCount.BackColor = System.Drawing.Color.White
            Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblCount.Location = New System.Drawing.Point(94, 282)
            Me.lblCount.Name = "lblCount"
            Me.lblCount.Size = New System.Drawing.Size(70, 25)
            Me.lblCount.TabIndex = 44
            Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(7, 286)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(83, 14)
            Me.Label1.TabIndex = 45
            Me.Label1.Text = "No. of Records:"
            '
            'btnCancel
            '
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.ButtonType = crsButton.cButton.btnType.cancel
            Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
            Me.btnCancel.Location = New System.Drawing.Point(444, 286)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(85, 45)
            Me.btnCancel.TabIndex = 46
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'frmFindUsers
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(541, 350)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblCount)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.lvStudent)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmFindUsers"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Find User"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lvStudent As System.Windows.Forms.ListView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rbFullName As System.Windows.Forms.RadioButton
        Friend WithEvents rbUsername As System.Windows.Forms.RadioButton
        Friend WithEvents txtFind As System.Windows.Forms.TextBox
        Friend WithEvents btnOk As crsButton.cButton
        Friend WithEvents lblCount As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblName As System.Windows.Forms.Label
        Friend WithEvents btnCancel As crsButton.cButton
    End Class
End Namespace