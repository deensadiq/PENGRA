Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReport
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
            Me.RdlV = New fyiReporting.RdlViewer.RdlViewer()
            Me.btnPrint = New crsButton.cButton()
            Me.cboZoom = New System.Windows.Forms.ComboBox()
            Me.btnPDF = New System.Windows.Forms.Button()
            Me.btnClose = New crsButton.cButton()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'RdlV
            '
            Me.RdlV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.RdlV.Cursor = System.Windows.Forms.Cursors.Default
            Me.RdlV.Folder = Nothing
            Me.RdlV.HighlightAll = False
            Me.RdlV.HighlightAllColor = System.Drawing.Color.Fuchsia
            Me.RdlV.HighlightCaseSensitive = False
            Me.RdlV.HighlightItemColor = System.Drawing.Color.Aqua
            Me.RdlV.HighlightPageItem = Nothing
            Me.RdlV.HighlightText = Nothing
            Me.RdlV.Location = New System.Drawing.Point(2, 6)
            Me.RdlV.Name = "RdlV"
            Me.RdlV.PageCurrent = 1
            Me.RdlV.Parameters = Nothing
            Me.RdlV.ReportName = Nothing
            Me.RdlV.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.SinglePage
            Me.RdlV.ShowFindPanel = False
            Me.RdlV.ShowParameterPanel = False
            Me.RdlV.Size = New System.Drawing.Size(615, 445)
            Me.RdlV.SourceFile = Nothing
            Me.RdlV.SourceRdl = Nothing
            Me.RdlV.TabIndex = 47
            Me.RdlV.Text = "RdlV"
            Me.RdlV.UseTrueMargins = True
            Me.RdlV.Zoom = 0.7097358!
            Me.RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth
            '
            'btnPrint
            '
            Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnPrint.BackColor = System.Drawing.Color.Transparent
            Me.btnPrint.ButtonType = crsButton.cButton.btnType.print
            Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnPrint.FlatAppearance.BorderSize = 0
            Me.btnPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.Location = New System.Drawing.Point(420, 460)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(85, 45)
            Me.btnPrint.TabIndex = 57
            Me.btnPrint.UseVisualStyleBackColor = False
            '
            'cboZoom
            '
            Me.cboZoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cboZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboZoom.FormattingEnabled = True
            Me.cboZoom.Items.AddRange(New Object() {"Fit Page", "Fit Width", "800%", "400%", "200%", "150%", "125%", "100%", "75%"})
            Me.cboZoom.Location = New System.Drawing.Point(141, 472)
            Me.cboZoom.MaxDropDownItems = 9
            Me.cboZoom.Name = "cboZoom"
            Me.cboZoom.Size = New System.Drawing.Size(138, 22)
            Me.cboZoom.TabIndex = 55
            '
            'btnPDF
            '
            Me.btnPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnPDF.Location = New System.Drawing.Point(9, 472)
            Me.btnPDF.Name = "btnPDF"
            Me.btnPDF.Size = New System.Drawing.Size(72, 29)
            Me.btnPDF.TabIndex = 54
            Me.btnPDF.Text = "PDF"
            Me.btnPDF.UseVisualStyleBackColor = True
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.ButtonType = crsButton.cButton.btnType.close2
            Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.Location = New System.Drawing.Point(526, 460)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(85, 45)
            Me.btnClose.TabIndex = 53
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(95, 477)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(40, 14)
            Me.Label2.TabIndex = 56
            Me.Label2.Text = "Zoom :"
            '
            'frmReport
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.NavajoWhite
            Me.ClientSize = New System.Drawing.Size(621, 510)
            Me.Controls.Add(Me.btnPrint)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboZoom)
            Me.Controls.Add(Me.btnPDF)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.RdlV)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MinimumSize = New System.Drawing.Size(627, 538)
            Me.Name = "frmReport"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Report"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents RdlV As fyiReporting.RdlViewer.RdlViewer
        Friend WithEvents btnPrint As crsButton.cButton
        Friend WithEvents cboZoom As System.Windows.Forms.ComboBox
        Friend WithEvents btnPDF As System.Windows.Forms.Button
        Friend WithEvents btnClose As crsButton.cButton
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace