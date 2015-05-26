<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cComboBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.cbo = New System.Windows.Forms.ComboBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.tm = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'cbo
        '
        Me.cbo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo.FormattingEnabled = True
        Me.cbo.IntegralHeight = False
        Me.cbo.Location = New System.Drawing.Point(4, 4)
        Me.cbo.Name = "cbo"
        Me.cbo.Size = New System.Drawing.Size(180, 21)
        Me.cbo.TabIndex = 1
        '
        'btn
        '
        Me.btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn.BackColor = System.Drawing.Color.Transparent
        Me.btn.FlatAppearance.BorderSize = 0
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Image = Global.crsComboBox.My.Resources.Resources.add_combo
        Me.btn.Location = New System.Drawing.Point(190, 4)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(20, 20)
        Me.btn.TabIndex = 2
        Me.btn.UseVisualStyleBackColor = False
        '
        'tm
        '
        Me.tm.Interval = 1000
        '
        'cComboBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.cbo)
        Me.MinimumSize = New System.Drawing.Size(80, 30)
        Me.Name = "cComboBox"
        Me.Size = New System.Drawing.Size(216, 30)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbo As System.Windows.Forms.ComboBox
    Friend WithEvents btn As System.Windows.Forms.Button

    Friend WithEvents tm As System.Windows.Forms.Timer
End Class
