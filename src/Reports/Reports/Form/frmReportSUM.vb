Imports FirebirdSql.Data.FirebirdClient
Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports PENGRA.Reports.Classes
Namespace Forms
    Public Class frmReportSUM
        'Dim Cbo As New cPopulateCombobox

        Public Enum rType
            SummaryDetails
            SummaryGraphs
        End Enum

        Dim mBudgetYear As Integer
        Dim mBudgetMonth As Integer
        Dim mBudget As Integer
        Dim mBenefitType As Integer
        Dim mSummaryType As Integer
        Dim mLimit As Integer

        Private mReportType As rType

        Property Budget() As Integer
            Get
                Return mBudget
            End Get
            Set(ByVal value As Integer)
                mBudget = value
            End Set
        End Property
        Property BudgetYear() As Integer
            Get
                Return mBudgetYear
            End Get
            Set(ByVal value As Integer)
                mBudgetYear = value
            End Set
        End Property
        Property BudgetMonth() As Integer
            Get
                Return mBudgetMonth
            End Get
            Set(ByVal value As Integer)
                mBudgetMonth = value
            End Set
        End Property
        Property BenefitType As Integer
            Get
                Return mBenefitType
            End Get
            Set(ByVal value As Integer)
                mBenefitType = value
            End Set
        End Property
        Property SummaryType As Integer
            Get
                Return mSummaryType
            End Get
            Set(ByVal value As Integer)
                mSummaryType = value
            End Set
        End Property
        Property Limit As Integer
            Get
                Return mLimit
            End Get
            Set(ByVal value As Integer)
                mLimit = value
            End Set
        End Property

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
            Populate.SummaryCombo(cboSummaryType)
            Populate.LimitCombo(cboLimitType)
            Populate.comboBox(cboBenefitType, "SELECT * FROM BENEFIT")
        End Sub
        Private Sub frmReportSCCSS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            LoadCombo()
            'With Cbo
            '    .PopulateCategory(cboCategory, Env.UserID)
            '    .PopulateReportSession(cboSession)
            'End With
        End Sub


        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            If cboBudget.Text = "" Or _
                cboYear.Text = "" Or cboMonth.Text = "" And cboSummaryType.Text = "" Then
                MessageBox.Show(Messages.NoSelection, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Budget = CType(cboBudget.SelectedValue, Integer)
            BudgetYear = CType(cboYear.Text.Trim, Integer)
            BudgetMonth = CType(cboMonth.SelectedIndex, Integer)
            BenefitType = cboBenefitType.SelectedValue
            SummaryType = CInt(cboSummaryType.SelectedValue)
            Limit = CInt(cboLimitType.SelectedValue)

            Dim rSQl As New myReport

            With rSQl
                .Budget = CType(cboBudget.SelectedValue, Integer)
                .BudgetYear = CType(cboYear.Text.Trim, Integer)
                .BudgetMonth = CType(cboMonth.SelectedIndex, Integer)
                .Parent = Me.MdiParent
                .Title = getTitle()
            End With

            Try

                Select Case mReportType
                    Case rType.SummaryDetails
                        rSQl.ReportTitle = Me.Text
                        rSQl.SummaryDetailedReport(rbPrint.Checked, getSummaryDetailedSQL)
                    Case rType.SummaryGraphs
                        rSQl.ReportTitle = Me.Text
                        rSQl.SummaryDetailedReport(rbPrint.Checked, getSummaryGraphSQL)
                End Select

            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
        Private Function getTitle() As String

            getTitle = cboMonth.Text.Trim & " " & cboYear.Text.Trim & " [" & cboBudget.Text.Trim & " Allocation] "

            Return getTitle
        End Function
        Private Function getSummaryDetailedSQL() As String
            Dim strSQL As String

            If SummaryType = 1 Then
                'If cboBenefitType.Text = "" Then
                '    strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.BALANCE FROM SP_REPORT_SUMMARY('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"
                'Else
                '    strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.BALANCE FROM SP_REPORT_SUMMARY('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"
                'End If
                If cboLimitType.Text = "" And cboBenefitType.Text = "" Then

                    strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.BALANCE FROM SP_REPORT_SUMMARY('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"

                ElseIf cboLimitType.Text <> "" And cboBenefitType.Text = "" Then

                    strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.BALANCE FROM SP_REPORT_SUMMARY_LIMIT('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "','" & Limit & "') p"

                ElseIf cboLimitType.Text = "" And cboBenefitType.Text <> "" Then

                    strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.BALANCE FROM SP_REPORT_SUMMARY_BENEFIT('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "','" & BenefitType & "') p"

                Else

                    strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.BALANCE FROM SP_REPORT_SUMMARY_BL('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "','" & BenefitType & "','" & Limit & "') p"

                End If
            Else
                If cboLimitType.Text = "" And cboBenefitType.Text = "" Then

                    strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.BALANCE FROM SP_REPORT_MINISTRYSUMMARY('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"

                ElseIf cboLimitType.Text <> "" And cboBenefitType.Text = "" Then

                    strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.BALANCE FROM SP_REPORT_MINISTRYSUMMARY_L('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "', '" & Limit & "') p"

                ElseIf cboLimitType.Text = "" And cboBenefitType.Text <> "" Then

                    strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.BALANCE FROM SP_REPORT_MINISTRYSUMMARY_B('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "','" & BenefitType & "') p"

                Else

                    strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.BALANCE FROM SP_REPORT_MINISTRYSUMMARY_BL('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "','" & BenefitType & "','" & Limit & "') p"

                End If
                'strSQL = ""
            End If


            Return strSQL
        End Function
        Private Function getSummaryGraphSQL() As String
            Dim strSQL As String

            Select Case mReportType
                Case rType.SummaryDetails
                    strSQL = "SELECT * FROM SP_REPORT_PAYMENTBENEFIT('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "')"
                Case rType.SummaryGraphs
                    strSQL = "SELECT SUM(p.GRATUITYRETIREE) AS GRATUITYRETIREE, SUM(p.GRATUITYDECEASED) AS GRATUITYDECEASED, SUM(p.PENSIONARREARS) AS PENSIONARREARS, SUM(p.DEATHPENSION) AS DEATHPENSION, SUM(p.TOTALPAYMENT) AS TOTALPAYMENT FROM SP_REPORT_PAYMENTBENEFIT('" & Budget & "', '" & BudgetYear & "', '" & BudgetMonth & "') p"
                Case Else
                    strSQL = ""
            End Select

            Return strSQL
        End Function
    End Class
End Namespace