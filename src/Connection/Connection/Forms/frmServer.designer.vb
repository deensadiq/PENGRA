
Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmServer
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServer))
            Me.txtServer = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnClose = New crsButton.cButton()
            Me.btnAccept = New crsButton.cButton()
            Me.btnUndo = New crsButton.cButton()
            Me.btnChange = New crsButton.cButton()
            Me.btnTest = New crsButton.cButton()
            Me.SuspendLayout()
            '
            'txtServer
            '
            Me.txtServer.Location = New System.Drawing.Point(21, 95)
            Me.txtServer.Name = "txtServer"
            Me.txtServer.Size = New System.Drawing.Size(363, 20)
            Me.txtServer.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Location = New System.Drawing.Point(22, 74)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(104, 14)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Host Name/Address"
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
            Me.btnClose.Location = New System.Drawing.Point(297, 199)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 2
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnAccept
            '
            Me.btnAccept.BackColor = System.Drawing.Color.Transparent
            Me.btnAccept.ButtonType = crsButton.cButton.btnType.save
            Me.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnAccept.FlatAppearance.BorderSize = 0
            Me.btnAccept.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAccept.Image = CType(resources.GetObject("btnAccept.Image"), System.Drawing.Image)
            Me.btnAccept.Location = New System.Drawing.Point(12, 199)
            Me.btnAccept.Name = "btnAccept"
            Me.btnAccept.Size = New System.Drawing.Size(85, 45)
            Me.btnAccept.TabIndex = 3
            Me.btnAccept.UseVisualStyleBackColor = False
            '
            'btnUndo
            '
            Me.btnUndo.BackColor = System.Drawing.Color.Transparent
            Me.btnUndo.ButtonType = crsButton.cButton.btnType.undo
            Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnUndo.FlatAppearance.BorderSize = 0
            Me.btnUndo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
            Me.btnUndo.Location = New System.Drawing.Point(194, 199)
            Me.btnUndo.Name = "btnUndo"
            Me.btnUndo.Size = New System.Drawing.Size(85, 45)
            Me.btnUndo.TabIndex = 4
            Me.btnUndo.UseVisualStyleBackColor = False
            '
            'btnChange
            '
            Me.btnChange.BackColor = System.Drawing.Color.Transparent
            Me.btnChange.ButtonType = crsButton.cButton.btnType.edit
            Me.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnChange.FlatAppearance.BorderSize = 0
            Me.btnChange.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnChange.Image = CType(resources.GetObject("btnChange.Image"), System.Drawing.Image)
            Me.btnChange.Location = New System.Drawing.Point(103, 199)
            Me.btnChange.Name = "btnChange"
            Me.btnChange.Size = New System.Drawing.Size(85, 45)
            Me.btnChange.TabIndex = 5
            Me.btnChange.UseVisualStyleBackColor = False
            '
            'btnTest
            '
            Me.btnTest.BackColor = System.Drawing.Color.Transparent
            Me.btnTest.ButtonType = crsButton.cButton.btnType.test_connection
            Me.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnTest.FlatAppearance.BorderSize = 0
            Me.btnTest.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTest.Image = CType(resources.GetObject("btnTest.Image"), System.Drawing.Image)
            Me.btnTest.Location = New System.Drawing.Point(20, 123)
            Me.btnTest.Name = "btnTest"
            Me.btnTest.Size = New System.Drawing.Size(362, 61)
            Me.btnTest.TabIndex = 6
            Me.btnTest.UseVisualStyleBackColor = False
            '
            'frmServer
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Gainsboro
            Me.ClientSize = New System.Drawing.Size(403, 261)
            Me.Controls.Add(Me.btnTest)
            Me.Controls.Add(Me.btnChange)
            Me.Controls.Add(Me.btnUndo)
            Me.Controls.Add(Me.btnAccept)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtServer)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmServer"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Server"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtServer As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents btnAccept As crsButton.cButton
        Friend WithEvents btnUndo As crsButton.cButton
        Friend WithEvents btnChange As crsButton.cButton
        Friend WithEvents btnTest As crsButton.cButton
    End Class
End Namespace