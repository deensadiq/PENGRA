Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Namespace Forms
    Public Class frmReport

        Private Sub savePDF()

            Dim strFile As String
            Dim dialog As New SaveFileDialog

            dialog.Filter = "PDF Documents(*.pdf)|*.pdf| All Files(*.*)|*.* "
            dialog.ShowDialog(Me)
            strFile = dialog.FileName
            If strFile.Trim = "" Then Exit Sub
            RdlV.SaveAs(strFile, "PDF")

        End Sub

        Private Sub saveCSV()

            Dim strFile As String
            Dim dialog As New SaveFileDialog

            dialog.Filter = "CSV Files(*.csv)|*.csv| All Files(*.*)|*.* "
            dialog.ShowDialog(Me)
            strFile = dialog.FileName
            If strFile.Trim = "" Then Exit Sub
            RdlV.SaveAs(strFile, "CSV")

        End Sub

        Private Sub saveHTM()

            Dim strFile As String
            Dim dialog As New SaveFileDialog

            dialog.Filter = "Web Pages(*.htm)|*.htm| All Files(*.*)|*.* "
            dialog.ShowDialog(Me)
            strFile = dialog.FileName
            If strFile.Trim = "" Then Exit Sub
            RdlV.SaveAs(strFile, "HTML")


        End Sub

        Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
            savePDF()
        End Sub

        Private Sub cboZoom_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboZoom.SelectedValueChanged

            Dim strZoom As String

            If cboZoom.Text = "" Then Exit Sub
            strZoom = cboZoom.Text

            Select Case strZoom
                Case "Fit Page"
                    RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitPage
                Case "Fit Width"
                    RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth
                Case "800%"
                    RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.UseZoom
                    RdlV.Zoom = 8
                Case "400%"
                    RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.UseZoom
                    RdlV.Zoom = 4
                Case "200%"
                    RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.UseZoom
                    RdlV.Zoom = 2
                Case "150%"
                    RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.UseZoom
                    RdlV.Zoom = 1.5
                Case "125%"
                    RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.UseZoom
                    RdlV.Zoom = 1.25
                Case "100%"
                    RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.UseZoom
                    RdlV.Zoom = 1
                Case "75%"
                    RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.UseZoom
                    RdlV.Zoom = 0.75
            End Select


        End Sub

        Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

            Dim pDoc As New System.Drawing.Printing.PrintDocument
            Dim pDialog As New PrintDialog()
            pDialog.AllowCurrentPage = True
            pDialog.AllowSomePages = True
            pDialog.UseEXDialog = True
            pDialog.Document = pDoc
            If pDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then RdlV.Print(pDoc)

        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            cboZoom.Text = "Fit Width"
            RdlV.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth

            'If Env.Print_Records = False Then
            '    btnPrint.Visible = False
            '    btnPDF.Visible = False
            'End If


        End Sub


        Public Sub New()

            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

    End Class
End Namespace