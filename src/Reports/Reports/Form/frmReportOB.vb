Imports FirebirdSql.Data.FirebirdClient
Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports PENGRA.Reports.Classes
Namespace Forms
    Public Class frmReportOB
        'Dim Cbo As New cPopulateCombobox

        Public Enum rType
            OutstandingBeneficiaries
            BenefitPayment
            BenefitPaymentSummary
            RequestForFund
            PensionPayroll
            PensionPayrollSummary
            DeathPensionPayroll
            DeathPensionPayrollSummary
            'SecurityScheduleRetiree
            'SecurityScheduleDeceased
        End Enum
        Dim mBudgetYear As Integer
        Dim mBudgetMonth As Integer
        Dim mBudget As Integer
        Dim mLimit As Integer
        Dim mBenefitType As Integer
        Dim mMinistry As Integer

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
        Property Limi As Integer
            Get
                Return mLimit
            End Get
            Set(ByVal value As Integer)
                mLimit = value
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
        Property Ministry As Integer
            Get
                Return mMinistry
            End Get
            Set(ByVal value As Integer)
                mMinistry = value
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
            Populate.LimitCombo(cboLimitType)
            Populate.comboBox(cboBenefitType, "Select * from benefit")
            Populate.comboBox(cboMinistry, "SELECT * FROM MINISTRY")
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
                cboYear.Text = "" Or cboMonth.Text = "" Then
                MessageBox.Show(Messages.NoSelection, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Budget = CType(cboBudget.SelectedValue, Integer)
            BudgetYear = CType(cboYear.Text.Trim, Integer)
            BudgetMonth = CType(cboMonth.SelectedIndex, Integer)
            Limi = cboLimitType.SelectedValue
            BenefitType = cboBenefitType.SelectedValue
            Ministry = cboMinistry.SelectedValue

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
                    Case rType.OutstandingBeneficiaries
                        rSQl.ReportTitle = Me.Text
                        rSQl.OustandingBeneficiariesReport(rbPrint.Checked, getOutstandingBeneficiariesSQL)
                    Case rType.BenefitPaymentSummary
                        rSQl.ReportTitle = Me.Text
                        rSQl.BenefitPaymentSummaryReport(rbPrint.Checked, getSQL)
                    Case rType.RequestForFund
                        rSQl.ReportTitle = Me.Text
                        'rSQl.getClassProfileSQL(rbPrint.Checked)
                    Case rType.PensionPayroll
                        rSQl.ReportTitle = Me.Text
                        rSQl.PensionPayrollReport(rbPrint.Checked, getSQL)
                    Case rType.PensionPayrollSummary
                        rSQl.ReportTitle = Me.Text
                        rSQl.PensionPayrollSummaryReport(rbPrint.Checked, getSQL)
                    Case rType.DeathPensionPayroll
                        rSQl.ReportTitle = Me.Text
                        rSQl.DeathPensionPayrollReport(rbPrint.Checked, getSQL)
                    Case rType.DeathPensionPayrollSummary
                        rSQl.ReportTitle = Me.Text
                        rSQl.DeathPayrollSummaryReport(rbPrint.Checked, getSQL)
                        'Case rType.SecurityScheduleRetiree
                        '    rSQl.ReportTitle = Me.Text
                        '    rSQl.DeathPayrollSummaryReport(rbPrint.Checked, getSQL)
                        'Case rType.SecurityScheduleDeceased
                        '    rSQl.ReportTitle = Me.Text
                        '    rSQl.DeathPayrollSummaryReport(rbPrint.Checked, getSQL)
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
        Private Function getOutstandingBeneficiariesSQL() As String
            Dim strSQL As String = ""

            If cboLimitType.Text = "" And cboBenefitType.Text = "" And cboMinistry.Text = "" Then

                strSQL = "SELECT p.SN, p.IDNO, p.FULLNAME, p.MINISTRY, p.MINISTRYNAME, p.AYEAR, p.AMONTH, (p.AYEAR || ' ' || p.AMONTH) AS RESULT, p.DESCRIPTION, p.BENEFITTYPE, p.LIMITSTATUS, p.BUDGET, p.BYEAR, p.BMONTH, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PENSIONPAID, p.DEATHPENSIONPAID, p.TOTALBENEFITPAID, p.BALANCE "
                strSQL = strSQL & "FROM SP_REPORT_OUTSTANDINGRETIREE('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"

            ElseIf cboLimitType.Text <> "" And cboBenefitType.Text = "" And cboMinistry.Text = "" Then

                strSQL = "SELECT p.SN, p.IDNO, p.FULLNAME, p.MINISTRY, p.MINISTRYNAME, p.AYEAR, p.AMONTH, (p.AYEAR || ' ' || p.AMONTH) AS RESULT, p.DESCRIPTION, p.BENEFITTYPE, p.LIMITSTATUS, p.BUDGET, p.BYEAR, p.BMONTH, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PENSIONPAID, p.DEATHPENSIONPAID, p.TOTALBENEFITPAID, p.BALANCE "
                strSQL = strSQL & "FROM SP_REPORT_OUTSTANDINGRETIREE('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p WHERE p.LIMITSTATUS = '" & Limi & "'"

            ElseIf cboLimitType.Text = "" And cboBenefitType.Text <> "" And cboMinistry.Text = "" Then

                strSQL = "SELECT p.SN, p.IDNO, p.FULLNAME, p.MINISTRY, p.MINISTRYNAME, p.AYEAR, p.AMONTH, (p.AYEAR || ' ' || p.AMONTH) AS RESULT, p.DESCRIPTION, p.BENEFITTYPE, p.LIMITSTATUS, p.BUDGET, p.BYEAR, p.BMONTH, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PENSIONPAID, p.DEATHPENSIONPAID, p.TOTALBENEFITPAID, p.BALANCE "
                strSQL = strSQL & "FROM SP_REPORT_OUTSTANDINGRETIREE('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p WHERE p.BENEFITTYPE = '" & BenefitType & "'"

            ElseIf cboLimitType.Text = "" And cboBenefitType.Text = "" And cboMinistry.Text <> "" Then

                strSQL = "SELECT p.SN, p.IDNO, p.FULLNAME, p.MINISTRY, p.MINISTRYNAME, p.AYEAR, p.AMONTH, (p.AYEAR || ' ' || p.AMONTH) AS RESULT, p.DESCRIPTION, p.BENEFITTYPE, p.LIMITSTATUS, p.BUDGET, p.BYEAR, p.BMONTH, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PENSIONPAID, p.DEATHPENSIONPAID, p.TOTALBENEFITPAID, p.BALANCE "
                strSQL = strSQL & "FROM SP_REPORT_OUTSTANDINGRETIREE('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p WHERE p.MINISTRY = '" & Ministry & "'"

            ElseIf cboLimitType.Text <> "" And cboBenefitType.Text <> "" And cboMinistry.Text = "" Then

                strSQL = "SELECT p.SN, p.IDNO, p.FULLNAME, p.MINISTRY, p.MINISTRYNAME, p.AYEAR, p.AMONTH, (p.AYEAR || ' ' || p.AMONTH) AS RESULT, p.DESCRIPTION, p.BENEFITTYPE, p.LIMITSTATUS, p.BUDGET, p.BYEAR, p.BMONTH, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PENSIONPAID, p.DEATHPENSIONPAID, p.TOTALBENEFITPAID, p.BALANCE "
                strSQL = strSQL & "FROM SP_REPORT_OUTSTANDINGRETIREE('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p WHERE p.LIMITSTATUS = '" & Limi & "' AND p.BENEFITTYPE = '" & BenefitType & "'"

            ElseIf cboLimitType.Text <> "" And cboBenefitType.Text = "" And cboMinistry.Text <> "" Then

                strSQL = "SELECT p.SN, p.IDNO, p.FULLNAME, p.MINISTRY, p.MINISTRYNAME, p.AYEAR, p.AMONTH, (p.AYEAR || ' ' || p.AMONTH) AS RESULT, p.DESCRIPTION, p.BENEFITTYPE, p.LIMITSTATUS, p.BUDGET, p.BYEAR, p.BMONTH, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PENSIONPAID, p.DEATHPENSIONPAID, p.TOTALBENEFITPAID, p.BALANCE "
                strSQL = strSQL & "FROM SP_REPORT_OUTSTANDINGRETIREE('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p WHERE p.LIMITSTATUS = '" & Limi & "' AND p.MINISTRY = '" & Ministry & "'"

            ElseIf cboLimitType.Text = "" And cboBenefitType.Text <> "" And cboMinistry.Text <> "" Then

                strSQL = "SELECT p.SN, p.IDNO, p.FULLNAME, p.MINISTRY, p.MINISTRYNAME, p.AYEAR, p.AMONTH, (p.AYEAR || ' ' || p.AMONTH) AS RESULT, p.DESCRIPTION, p.BENEFITTYPE, p.LIMITSTATUS, p.BUDGET, p.BYEAR, p.BMONTH, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PENSIONPAID, p.DEATHPENSIONPAID, p.TOTALBENEFITPAID, p.BALANCE "
                strSQL = strSQL & "FROM SP_REPORT_OUTSTANDINGRETIREE('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p WHERE p.BENEFITTYPE = '" & BenefitType & "' AND p.MINISTRY = '" & Ministry & "'"

            ElseIf cboLimitType.Text <> "" And cboBenefitType.Text <> "" And cboMinistry.Text <> "" Then

                strSQL = "SELECT p.SN, p.IDNO, p.FULLNAME, p.MINISTRY, p.MINISTRYNAME, p.AYEAR, p.AMONTH, (p.AYEAR || ' ' || p.AMONTH) AS RESULT, p.DESCRIPTION, p.BENEFITTYPE, p.LIMITSTATUS, p.BUDGET, p.BYEAR, p.BMONTH, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PENSIONPAID, p.DEATHPENSIONPAID, p.TOTALBENEFITPAID, p.BALANCE "
                strSQL = strSQL & "FROM SP_REPORT_OUTSTANDINGRETIREE('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p WHERE p.LIMITSTATUS = '" & Limi & "' AND p.BENEFITTYPE = '" & BenefitType & "' AND p.MINISTRY = '" & Ministry & "'"

            End If

            Return strSQL
        End Function
        Private Function getSQL() As String
            Dim strSQL As String

            Select Case mReportType
                Case rType.BenefitPayment
                    strSQL = "SELECT p.SN, p.IDNO, p.FULLNAME, p.MINISTRY, p.MINISTRYNAME, p.AYEAR, p.AMONTH, (p.AYEAR || ' ' || p.AMONTH) AS RESULT, p.DESCRIPTION, p.BENEFITTYPE, p.LIMITSTATUS, p.BUDGET, p.BYEAR, p.BMONTH, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PENSIONPAID, p.DEATHPENSIONPAID, p.TOTALBENEFITPAID, p.BALANCE "
                    strSQL = strSQL & "FROM SP_REPORT_OUTSTANDINGRETIREE('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"
                Case rType.BenefitPaymentSummary
                    strSQL = "SELECT SUM(p.GRATUITYRETIREE) AS GRATUITYRETIREE, SUM(p.GRATUITYDECEASED) AS GRATUITYDECEASED, SUM(p.PENSIONARREARS) AS PENSIONARREARS, SUM(p.DEATHPENSION) AS DEATHPENSION, SUM(p.TOTALPAYMENT) AS TOTALPAYMENT FROM SP_REPORT_PAYMENTBENEFIT('" & Budget & "', '" & BudgetYear & "', '" & BudgetMonth & "') p"
                Case rType.RequestForFund
                    strSQL = "SELECT * FROM OUTSTANDINGDETAILS WHERE BUDGET = '" & Budget & "' AND BYEAR = '" & BudgetYear & "' AND BMONTH = '" & BudgetMonth & "'"
                Case rType.PensionPayroll
                    strSQL = "SELECT * FROM SP_REPORT_PENSIONPAYROLL('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "')"
                Case rType.PensionPayrollSummary
                    strSQL = "SELECT SUM( p.NETAMOUNT) as NETAMOUNTPAYABLE FROM SP_REPORT_PENSIONPAYROLL('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"
                Case rType.DeathPensionPayroll
                    strSQL = "SELECT p.SN, p.EMPLOYEENAME, p.DEATHPENSION, p.OTHERPAYMENT, p.GROSSPAYMENT, coalesce(p.OTHERDEDUCTION, 0) AS OTHERDEDUCTION, p.NETAMOUNT FROM SP_REPORT_DEATHPAYROLL('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"
                Case rType.DeathPensionPayrollSummary
                    strSQL = "SELECT SUM( p.NETAMOUNT) as NETAMOUNTPAYABLE FROM SP_REPORT_DEATHPAYROLL('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"
                Case Else
                    strSQL = ""
            End Select

            Return strSQL
        End Function
    End Class
End Namespace