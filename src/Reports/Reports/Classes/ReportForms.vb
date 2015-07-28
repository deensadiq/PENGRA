Imports PENGRA.Connection.Classes
Imports PENGRA.Reports.Forms

Namespace Classes
    Public Class ReportForms
        'Private formReportLOB As frmReportLOB
        Private formReportOB As frmReportOB
        Private formReportSUM As frmReportSUM
        Private formReportSB As frmReportSB
        Private formReportAYM As frmReportAYM
        Private formReportSS As frmReportSS

        Private Shared Guiman As ReportForms
        Private Sub New()
            'Private constructor to avoid directly creating an instance of this class
            'Use the getGuiManager function to get an instance
            'This is important to avoid creating multiple copies of this class in memory (Singleton Pattern)
        End Sub
        Public Shared Function getGuiManager() As ReportForms

            If Guiman Is Nothing Then Guiman = New ReportForms
            Return Guiman

        End Function
        Public Sub setReportOB(ByVal parent As Form, ByVal txt As String, ByVal rType As frmReportOB.rType)

            If formReportOB Is Nothing Then formReportOB = New frmReportOB
            If formReportOB.IsDisposed = True Then formReportOB = New frmReportOB
            formReportOB.Text = txt
            formReportOB.ReportType = rType
            formReportOB.MdiParent = parent
            formReportOB.Show()

        End Sub
        Public Sub setReportSUM(ByVal parent As Form, ByVal txt As String, ByVal rType As frmReportSUM.rType)

            If formReportSUM Is Nothing Then formReportSUM = New frmReportSUM
            If formReportSUM.IsDisposed = True Then formReportSUM = New frmReportSUM
            formReportSUM.Text = txt
            formReportSUM.ReportType = rType
            formReportSUM.MdiParent = parent
            formReportSUM.Show()

        End Sub
        Public Sub setReportSB(ByVal parent As Form, ByVal txt As String, ByVal rType As frmReportSB.rType)

            If formReportSB Is Nothing Then formReportSB = New frmReportSB
            If formReportSB.IsDisposed = True Then formReportSB = New frmReportSB
            formReportSB.Text = txt
            formReportSB.ReportType = rType
            formReportSB.MdiParent = parent
            formReportSB.Show()

        End Sub
        Public Sub setReportAYM(ByVal parent As Form, ByVal txt As String, ByVal rType As frmReportAYM.rType)

            If formReportAYM Is Nothing Then formReportAYM = New frmReportAYM
            If formReportAYM.IsDisposed = True Then formReportAYM = New frmReportAYM
            formReportAYM.Text = txt
            formReportAYM.ReportType = rType
            formReportAYM.MdiParent = parent
            formReportAYM.Show()

        End Sub
        Public Sub setReportSS(ByVal parent As Form, ByVal txt As String, ByVal rType As frmReportSS.rType)

            If formReportSS Is Nothing Then formReportSS = New frmReportSS
            If formReportSS.IsDisposed = True Then formReportSS = New frmReportSS
            formReportSS.Text = txt
            formReportSS.ReportType = rType
            formReportSS.MdiParent = parent
            formReportSS.Show()

        End Sub
        'Public Sub showBankList(ByVal parent As Form)
        '    formBankList = New frmBanklist
        '    formBankList.Text = "Bank List"
        '    formBankList.MdiParent = parent
        '    formBankList.Show()
        'End Sub

        'Public Sub showEmployeeList(ByVal parent As Form)
        '    formEmployeeList = New frmEmployeeList
        '    formEmployeeList.Text = "Employee List"
        '    formEmployeeList.MdiParent = parent
        '    formEmployeeList.Show()
        'End Sub

        'Public Sub showJournal(ByVal parent As Form)
        '    formJournal = New frmJournal
        '    formJournal.Text = "Journal"
        '    formJournal.MdiParent = parent
        '    formJournal.Show()
        'End Sub

        'Public Sub showPaySheet(ByVal parent As Form)
        '    formPaySheet = New frmPaysheet
        '    formPaySheet.Text = "Paysheet"
        '    formPaySheet.MdiParent = parent
        '    formPaySheet.Show()
        'End Sub

        'Public Sub showPayslip(ByVal parent As Form)
        '    formPaySlip = New frmPayslip
        '    formPaySlip.Text = "Payslip"
        '    formPaySlip.MdiParent = parent
        '    formPaySlip.Show()
        'End Sub

        'Public Sub showSchedule(ByVal parent As Form)
        '    formSchedule = New frmSchedule
        '    formSchedule.Text = "Schedule"
        '    formSchedule.MdiParent = parent
        '    formSchedule.Show()
        'End Sub

        'Public Sub showSummary(ByVal parent As Form)
        '    formSummary = New frmSummary
        '    formSummary.Text = "Summary"
        '    formSummary.MdiParent = parent
        '    formSummary.Show()
        'End Sub

        'Public Sub showVariation(ByVal parent As Form)
        '    formVariation = New frmVariation
        '    formVariation.Text = "Salary Variation"
        '    formVariation.MdiParent = parent
        '    formVariation.Show()
        'End Sub
    End Class
End Namespace
