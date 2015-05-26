Imports PENGRA.Connection.Classes
Imports PENGRA.Reports.Forms

Namespace Classes
    Public Class ReportForms
        'Private formBankList As frmBanklist
        'Private formEmployeeList As frmEmployeeList
        'Private formJournal As frmJournal
        'Private formPaySheet As frmPaysheet
        'Private formPaySlip As frmPayslip
        'Private formSchedule As frmSchedule
        'Private formSummary As frmSummary
        'Private formVariation As frmVariation
        'Private formEmail As frmEmail
        Private formReportBYM As frmReportBYM
        Private formReportLOB As frmReportLOB

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

        Public Sub setReportBYM(ByVal parent As Form, ByVal txt As String, ByVal rType As frmReportBYM.rType)

            formReportBYM = New frmReportBYM
            formReportBYM.Text = txt
            formReportBYM.ReportType = rType
            formReportBYM.MdiParent = parent
            formReportBYM.Show()

        End Sub

        Public Sub setReportLOB(ByVal parent As Form, ByVal txt As String, ByVal rType As frmReportBYM.rType)

            formReportLOB = New frmReportLOB
            formReportLOB.Text = txt
            formReportLOB.ReportType = rType
            formReportLOB.MdiParent = parent
            formReportLOB.Show()

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
