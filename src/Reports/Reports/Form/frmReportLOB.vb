Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports PENGRA.Reports.Classes

Namespace Forms
    Public Class frmReportLOB

        Public Enum rType
            ListOfBeneficiaries
            ListOfRetireBeneficiaries
            ListOfDeceasedBeneficiaries
            SummaryBreakDownOfBeneficiaries
            SummaryOfBeneficiaries
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
            'Populate.comboBox(cboBudget, "select * from budget")
            'Populate.GetYear(cboYear)
            'Populate.GetMonth(cboMonth)
        End Sub


        Private Sub frmReportSCCSS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            LoadCombo()
        End Sub


        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            'If cboBudget.Text = "" Or _
            '    cboYear.Text = "" Or cboMonth.Text = "" Then
            '    MessageBox.Show(Messages.NoSelection, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Sub
            'End If

            Dim rSQl As New myReport
            rSQl.Parent = Me.MdiParent

            Try

                If rbtListOfBeneficiaries.Checked = True Then
                    rSQl.ReportTitle = "List of Beneficiaries"
                    rSQl.ListofBeneficiariesReport(rbPrint.Checked)
                ElseIf rbtListRetire.Checked = True Then
                    rSQl.ReportTitle = "List of Retiree Beneficiaries"
                    rSQl.ListofRetireeBeneciarieasReport(rbPrint.Checked)
                ElseIf rbtListDeceased.Checked = True Then
                    rSQl.ReportTitle = "List Of Deceased Beneficiaries"
                    rSQl.ListofDeceasedBeneciariesReport(rbPrint.Checked)
                ElseIf rbtSummaryBK.Checked = True Then
                    rSQl.ReportTitle = "Summary Breakdown of Beneficiaries"
                    rSQl.SummaryBreakdownofBeneficiariesReport(rbPrint.Checked)
                ElseIf rbtSummary.Checked = True Then
                    rSQl.ReportTitle = "Summary Of Beneficiaries"
                    rSQl.SummaryofBeneficiariesReport(rbPrint.Checked)
                End If

                'Select Case mReportType
                '    Case rType.ListOfBeneficiaries
                '        rSQl.ReportTitle = Me.Text
                '        rSQl.ListofBeneficiariesReport(rbPrint.Checked)
                '    Case rType.ListOfRetireBeneficiaries
                '        rSQl.ReportTitle = Me.Text
                '        rSQl.ListofRetireeBeneciarieasReport(rbPrint.Checked)
                '    Case rType.ListOfDeceasedBeneficiaries
                '        rSQl.ReportTitle = Me.Text
                '        rSQl.ListofDeceasedBeneciariesReport(rbPrint.Checked)
                '    Case rType.SummaryBreakDownOfBeneficiaries
                '        rSQl.ReportTitle = Me.Text
                '        rSQl.SummaryBreakdownofBeneficiariesReport(rbPrint.Checked)
                '    Case rType.SummaryOfBeneficiaries
                '        rSQl.ReportTitle = Me.Text
                '        rSQl.SummaryofBeneficiariesReport(rbPrint.Checked)
                'End Select

            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub


        Private Sub cboYearGroup_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Try
                'Cbo.PopulateClass(cboClass, CType(1, Short), CType(cboCategory.SelectedValue, Short), CType(cboYearGroup.SelectedValue, Short), Env.UserID)
            Catch ex As Exception

            End Try
        End Sub

        Private Sub cboCategory_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Try
                'Cbo.PopulateYearGroup(cboYearGroup, CType(1, Short), CType(cboCategory.SelectedValue, Short))
            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace