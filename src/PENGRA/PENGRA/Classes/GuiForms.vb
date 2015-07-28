Imports System.Windows.Forms
Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Forms

Namespace Classes
    Public Class GuiForms

        Private Shared Guiman As GuiForms

        Private formEmployee As frmEmployee
        Private formProcess As frmProcess
        'Private formSelect As frmSelect
        Private formSettings As frmSettings
        Private formPaymentLimit As frmPaymentLimit
        Private formSalaryTable As frmSalaryTable
        Private formCalculator As frmBenefitCalculator
        Private formStatus As frmPaymentProfile
        Private formMinistry As frmSettings
        Private formSalary As frmSettings
        Private formBeneficiaries As frmOutStanding
        Private formBudgeting As frmBudgeting
        Private formPaymentDetails As frmPaymentDetails
        Private formPaymentDetailsAL As frmPaymentDetailsAL
        Private formLimitDetails As frmPaymentLimitDetails
        Private formOutstandingSummary As frmOutstandingSummary
        Private formOutstandingSummaryAL As frmOutstandingSummaryAL
        Private formAboveLimit As frmOutStandingAL
        Private formProcessPayment As frmProcess
        Private formAllocation As frmAllocation
        Private formLogin As frmLogin
        Private formKnockoffPayment As frmKnockOff
        Private formMemo As frmMemo
        Private formBackupRestore As frmBackupRestore


        Private Sub New()
            'Private constructor to avoid directly creating an instance of this class
            'Use the getGuiManager function to get an instance
            'This is important to avoid creating multiple copies of this class in memory (Singleton Pattern)
        End Sub

        Public Shared Function getGuiManager() As GuiForms

            If Guiman Is Nothing Then Guiman = New GuiForms
            Return Guiman

        End Function

#Region "Connection"

        Public Sub setMinistry(ByVal parent As Form)

            If formMinistry Is Nothing Then formMinistry = New frmSettings("Set Ministry", "MINISTRY")
            If formMinistry.IsDisposed = True Then formMinistry = New frmSettings("Set Ministry", "MINISTRY")
            formMinistry.Owner = parent
            formMinistry.ShowDialog()
        End Sub
        Public Sub setSalary(ByVal parent As Form)
            If formSalary Is Nothing Then formSalary = New frmSettings("Set Salary Scale", "SALARYSCALE")
            If formSalary.IsDisposed = True Then formSalary = New frmSettings("Set Salary Scale", "SALARYSCALE")
            formSalary.Owner = parent
            formSalary.ShowDialog()
        End Sub
        Public Sub showEmployee(ByVal parent As Form)

            If formEmployee Is Nothing Then formEmployee = New frmEmployee
            If formEmployee.IsDisposed = True Then formEmployee = New frmEmployee
            formEmployee.Text = "Retiree Information"
            formEmployee.MdiParent = parent
            formEmployee.Show()
        End Sub
        Public Sub showSelect(ByVal parent As Form)

            'formSelect = New frmSelect
            'formSelect.Text = "Process Option"
            'formSelect.ShowDialog(parent)

        End Sub
        Public Sub showSettings(ByVal parent As Form, ByVal Caption As String, ByVal TableName As String)

            formSettings = New frmSettings(Caption, TableName)
            formSettings = New frmSettings(Caption, TableName)
            formSettings.Text = Caption
            formSettings.ShowDialog(parent)

        End Sub
        Public Sub showAllocation(ByVal parent As Form, ByVal Caption As String)

            If formAllocation Is Nothing Then formAllocation = New frmAllocation(Caption)
            If formAllocation.IsDisposed = True Then formAllocation = New frmAllocation(Caption)
            formAllocation.Text = Caption
            formAllocation.ShowDialog(parent)

        End Sub
        Public Sub showPaymentLimit(ByVal parent As Form)

            If formPaymentLimit Is Nothing Then formPaymentLimit = New frmPaymentLimit
            If formPaymentLimit.IsDisposed = True Then formPaymentLimit = New frmPaymentLimit
            formPaymentLimit.Text = "Set Payment Limit"
            formPaymentLimit.ShowDialog(parent)

        End Sub
        Public Sub showSalaryTable(ByVal parent As Form)

            If formSalaryTable Is Nothing Then formSalaryTable = New frmSalaryTable
            If formSalaryTable.IsDisposed = True Then formSalaryTable = New frmSalaryTable
            formSalaryTable.Text = "Set Salary Table"
            formSalaryTable.MdiParent = parent
            formSalaryTable.Show()

        End Sub
        Public Sub showCalculator(ByVal parent As Form)

            If formCalculator Is Nothing Then formCalculator = New frmBenefitCalculator
            If formCalculator.IsDisposed = True Then formCalculator = New frmBenefitCalculator
            formCalculator.Text = "Benefit Calculator"
            formCalculator.MdiParent = parent
            formCalculator.Show()

        End Sub
        Public Sub showBackupRestore(ByVal parent As Form)

            If formBackupRestore Is Nothing Then formBackupRestore = New frmBackupRestore
            If formBackupRestore.IsDisposed = True Then formBackupRestore = New frmBackupRestore
            formBackupRestore.Text = "Backup/Restore"
            formBackupRestore.MdiParent = parent
            formBackupRestore.Show()

        End Sub
        Public Sub showMemo(ByVal parent As Form)

            If formMemo Is Nothing Then formMemo = New frmMemo
            If formMemo.IsDisposed = True Then formMemo = New frmMemo
            formMemo.Text = "Prepare Memo"
            formMemo.MdiParent = parent
            formMemo.Show()

        End Sub
        Public Sub showBudgeting(ByVal parent As Form)

            If formBudgeting Is Nothing Then formBudgeting = New frmBudgeting
            If formBudgeting.IsDisposed = True Then formBudgeting = New frmBudgeting
            formBudgeting.Text = "Prepare Allocation"
            formBudgeting.MdiParent = parent
            formBudgeting.Show()

        End Sub
        Public Sub showStatus(ByVal parent As Form)

            If formStatus Is Nothing Then formStatus = New frmPaymentProfile
            If formStatus.IsDisposed = True Then formStatus = New frmPaymentProfile
            formStatus.Text = "Retiree Payment Benefits"
            formStatus.MdiParent = parent
            formStatus.Show()

        End Sub
        Public Sub showPaymentDetails(ByVal parent As Form)

            If formPaymentDetails Is Nothing Then formPaymentDetails = New frmPaymentDetails
            If formPaymentDetails.IsDisposed = True Then formPaymentDetails = New frmPaymentDetails
            formPaymentDetails.Text = "Retiree Payment Details"
            formPaymentDetails.MdiParent = parent
            formPaymentDetails.Show()

        End Sub
        Public Sub showPaymentDetailsAL(ByVal parent As Form)

            If formPaymentDetailsAL Is Nothing Then formPaymentDetailsAL = New frmPaymentDetailsAL
            If formPaymentDetailsAL.IsDisposed = True Then formPaymentDetailsAL = New frmPaymentDetailsAL
            formPaymentDetailsAL.Text = "Retiree Payment Details [Above Limit]"
            formPaymentDetailsAL.MdiParent = parent
            formPaymentDetailsAL.Show()

        End Sub
        Public Sub showPaymentLimitDetails(ByVal parent As Form)

            If formLimitDetails Is Nothing Then formLimitDetails = New frmPaymentLimitDetails
            If formLimitDetails.IsDisposed = True Then formLimitDetails = New frmPaymentLimitDetails
            formLimitDetails.Text = "Retiree Payment Details [Above Limit]"
            formLimitDetails.MdiParent = parent
            formLimitDetails.Show()

        End Sub
        Public Sub showOutStandingBeneficiaries(ByVal parent As Form)

            If formBeneficiaries Is Nothing Then formBeneficiaries = New frmOutStanding
            If formBeneficiaries.IsDisposed = True Then formBeneficiaries = New frmOutStanding
            formBeneficiaries.Text = "Retiree Outstanding Benefits"
            formBeneficiaries.MdiParent = parent
            formBeneficiaries.Show()

        End Sub
        Public Sub showAboveLimitBeneficiaries(ByVal parent As Form)

            If formAboveLimit Is Nothing Then formAboveLimit = New frmOutStandingAL
            If formAboveLimit.IsDisposed = True Then formAboveLimit = New frmOutStandingAL
            formAboveLimit.Text = "Retiree Outstanding Benefits [Above Limit]"
            formAboveLimit.MdiParent = parent
            formAboveLimit.Show()

        End Sub
        Public Sub showOutStandingSummary(ByVal parent As Form)

            If formOutstandingSummary Is Nothing Then formOutstandingSummary = New frmOutstandingSummary
            If formOutstandingSummary.IsDisposed = True Then formOutstandingSummary = New frmOutstandingSummary
            formOutstandingSummary.Text = "Outstanding Benefits Summary"
            formOutstandingSummary.MdiParent = parent
            formOutstandingSummary.Show()

        End Sub
        Public Sub showOutStandingSummaryAL(ByVal parent As Form)

            If formOutstandingSummaryAL Is Nothing Then formOutstandingSummaryAL = New frmOutstandingSummaryAL
            If formOutstandingSummaryAL.IsDisposed = True Then formOutstandingSummaryAL = New frmOutstandingSummaryAL
            formOutstandingSummaryAL.Text = "Outstanding Benefits Summary [Above Limit]"
            formOutstandingSummaryAL.MdiParent = parent
            formOutstandingSummaryAL.Show()

        End Sub
        Public Sub showProcessPayment(ByVal parent As Form)

            If formProcessPayment Is Nothing Then formProcessPayment = New frmProcess
            If formProcessPayment.IsDisposed = True Then formProcessPayment = New frmProcess
            formProcessPayment.Text = "Process Benefit Payment"
            formProcessPayment.ShowDialog(parent)

        End Sub
        Public Sub showLogin()

            If formLogin Is Nothing Then
                formLogin = New frmLogin
            Else
                formLogin.Close()
                formLogin = New frmLogin
            End If
            If formLogin.IsDisposed = True Then formLogin = New frmLogin
            'formLogin.Text = "Login"
            'formLogin.txtPassword.Clear()
            'formLogin.txtUsername.Clear()
            'formLogin.txtUsername.Focus()
            formLogin.ShowDialog()

        End Sub
        Public Sub showPaymentKnockoff(ByVal parent As Form)

            If formKnockoffPayment Is Nothing Then formKnockoffPayment = New frmKnockOff
            If formKnockoffPayment.IsDisposed = True Then formKnockoffPayment = New frmKnockOff
            formKnockoffPayment.Text = "Retiree Benefits Payment"
            formKnockoffPayment.MdiParent = parent
            formKnockoffPayment.Show()

        End Sub
#End Region

    End Class
End Namespace