Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports PENGRA.Reports.Classes

Namespace Forms
    Public Class frmReportBYM

        Public Enum rType
            PaymentDetails
            BenefitPayment
            PaymentSummary
            PensionPayroll
            DeathPensionPayroll
            PensionPayrollSummary
            DeathPensionPayrollSummary
        End Enum

        Private mReportType As rType

        Property ReportType() As rType
            Get
                Return mReportType
            End Get
            Set(ByVal value As rType)
                mReportType = value
            End Set
        End Property

        Private Sub LoadCombo()
            Populate.comboBox(cboBudget, "select * from budget")
            Populate.GetYear(cboYear)
            Populate.GetMonth(cboMonth)
        End Sub


        Private Sub frmReportSCCSS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            LoadCombo()
        End Sub


        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            If cboBudget.Text = "" Or _
                cboYear.Text = "" Or cboMonth.Text = "" Then
                MessageBox.Show(Messages.NoSelection, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Dim rSQl As New myReport

            With rSQl
                .Budget = CType(cboBudget.SelectedValue, Integer)
                .BudgetYear = CType(cboYear.Text.Trim, Integer)
                .BudgetMonth = CType(cboMonth.SelectedIndex, Integer)
                .Parent = Me.MdiParent
            End With

            Try



                Select Case mReportType
                    Case rType.PaymentDetails
                        rSQl.ReportTitle = Me.Text
                        rSQl.PaymentDetailsReport(rbPrint.Checked)
                    Case rType.BenefitPayment
                        rSQl.ReportTitle = Me.Text
                        rSQl.BenefitPaymentReport(rbPrint.Checked)
                    Case rType.PaymentSummary
                        rSQl.ReportTitle = Me.Text
                        rSQl.PaymentSummaryReport(rbPrint.Checked)
                    Case rType.PensionPayroll
                        rSQl.ReportTitle = Me.Text
                        rSQl.PensionPayrollReport(rbPrint.Checked)
                    Case rType.DeathPensionPayroll
                        rSQl.ReportTitle = Me.Text
                        rSQl.DeathPensionPayrollReport(rbPrint.Checked)
                    Case rType.PensionPayrollSummary
                        rSQl.ReportTitle = Me.Text
                        rSQl.DeathPensionPayrollSummary(rbPrint.Checked)
                    Case rType.DeathPensionPayrollSummary
                        rSQl.ReportTitle = Me.Text
                        rSQl.DeathPensionPayrollSummary(rbPrint.Checked)
                End Select

            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub


        Private Sub cboYearGroup_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboYear.SelectedValueChanged
            Try
                'Cbo.PopulateClass(cboClass, CType(1, Short), CType(cboCategory.SelectedValue, Short), CType(cboYearGroup.SelectedValue, Short), Env.UserID)
            Catch ex As Exception

            End Try
        End Sub

        Private Sub cboCategory_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBudget.SelectedValueChanged
            Try
                'Cbo.PopulateYearGroup(cboYearGroup, CType(1, Short), CType(cboCategory.SelectedValue, Short))
            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace