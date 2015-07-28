Imports FirebirdSql.Data.FirebirdClient
Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports PENGRA.Reports.Classes
Namespace Forms
    Public Class frmReportSB
        'Dim Cbo As New cPopulateCombobox

        Public Enum rType
            SummaryBreakdown
            
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
        Property Limit As Integer
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
            'Populate.comboBox(cboBenefitType, "Select * from benefit")
            'Populate.comboBox(cboMinistry, "SELECT * FROM MINISTRY")
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
                cboYear.Text = "" Or cboMonth.Text = "" Or cboLimitType.Text = "" Then
                MessageBox.Show(Messages.NoSelection, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Budget = CType(cboBudget.SelectedValue, Integer)
            BudgetYear = CType(cboYear.Text.Trim, Integer)
            BudgetMonth = CType(cboMonth.SelectedIndex, Integer)
            Limit = cboLimitType.SelectedValue
            'BenefitType = cboBenefitType.SelectedValue
            'Ministry = cboMinistry.SelectedValue


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
                    Case rType.SummaryBreakdown
                        rSQl.ReportTitle = Me.Text
                        rSQl.SummaryBreakdownReport(rbPrint.Checked, getSQL)

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
        Private Function getSQL() As String
            Dim strSQL As String

            If cboLimitType.Text = "Below Limit" Then

                strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITYRETIREE, p.GRATUITYDECEASED, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALPAYMENT FROM SP_REPORT_SUMMARYBREAKDOWN('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"

            ElseIf cboLimitType.Text = "Above Limit" Then

                strSQL = "SELECT p.SN, p.DESCRIPTION, p.GRATUITYRETIREE, p.GRATUITYDECEASED, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALPAYMENT FROM SP_REPORT_SUMMARYBREAKDOWN_AL('" & Budget & "','" & BudgetYear & "','" & BudgetMonth & "') p"

            Else
                strSQL = ""
            End If

            Return strSQL
        End Function
    End Class
End Namespace