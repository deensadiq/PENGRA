Imports FirebirdSql.Data.FirebirdClient
Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports PENGRA.Reports.Classes
Namespace Forms
    Public Class frmReportSS
        'Dim Cbo As New cPopulateCombobox

        Public Enum rType
            SecurityScheduleGratuity
            SecuritySchedulePension
        End Enum
        Dim mBudgetYear As Integer
        Dim mBudgetMonth As Integer
        Dim mBudget As Integer
        Dim mBenefit As Integer

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
        Property Beneficiary As Integer
            Get
                Return mBenefit
            End Get
            Set(ByVal value As Integer)
                mBenefit = value
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
            Populate.comboBox(cboBenefit, "SELECT * FROM BENEFIT")
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
                cboYear.Text = "" Or cboMonth.Text = "" Or cboBenefit.Text = "" Then
                MessageBox.Show(Messages.NoSelection, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Budget = CType(cboBudget.SelectedValue, Integer)
            BudgetYear = CType(cboYear.Text.Trim, Integer)
            BudgetMonth = CType(cboMonth.SelectedIndex, Integer)
            Beneficiary = cboBenefit.SelectedValue

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
                    Case rType.SecurityScheduleGratuity
                        rSQl.ReportTitle = Me.Text
                        rSQl.SecurityScheduleReport(rbPrint.Checked, getSQL)
                    Case rType.SecuritySchedulePension
                        rSQl.ReportTitle = Me.Text
                        rSQl.SecurityScheduleReport(rbPrint.Checked, getSQL)
                End Select

            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
        Private Function getTitle() As String

            getTitle = cboMonth.Text.Trim & " " & cboYear.Text.Trim

            Return getTitle
        End Function
        Private Function getSQL() As String
            Dim strSQL As String

            Select Case mReportType
                Case rType.SecurityScheduleGratuity
                    If Beneficiary = 1 Then
                        strSQL = "SELECT a.IDNO, a.FULLNAME, a.GRATUITY AS TOTALPAYMENT FROM PAYMENTDETAILS a WHERE a.BTYPE = 1 AND a.GRATUITY > 0 AND a.BUDGET = '" & Budget & "' AND a.BYEAR = '" & BudgetYear & "' AND a.BMONTH = '" & BudgetMonth & "'"
                    Else
                        strSQL = "SELECT a.IDNO, a.FULLNAME, a.GRATUITY AS TOTALPAYMENT FROM PAYMENTDETAILS a WHERE a.BTYPE = 2 AND a.GRATUITY > 0 AND a.BUDGET = '" & Budget & "' AND a.BYEAR = '" & BudgetYear & "' AND a.BMONTH = '" & BudgetMonth & "'"
                    End If
                Case rType.SecuritySchedulePension
                    If Beneficiary = 1 Then
                        strSQL = "SELECT a.IDNO, a.FULLNAME, a.PENSIONARREARS AS TOTALPAYMENT FROM PAYMENTDETAILS a WHERE a.BTYPE = 1 AND a.PENSIONARREARS > 0 AND a.GRATUITY > 0 AND a.BUDGET = '" & Budget & "' AND a.BYEAR = '" & BudgetYear & "' AND a.BMONTH = '" & BudgetMonth & "'"
                    Else
                        strSQL = "SELECT a.IDNO, a.FULLNAME, a.DEATHPENSION AS TOTALPAYMENT FROM PAYMENTDETAILS a WHERE a.BTYPE = 2 AND a.DEATHPENSION > 0 AND a.GRATUITY > 0 AND a.BUDGET = '" & Budget & "' AND a.BYEAR = '" & BudgetYear & "' AND a.BMONTH = '" & BudgetMonth & "'"
                    End If
                Case Else
                    strSQL = ""
            End Select

            Return strSQL
        End Function
    End Class
End Namespace