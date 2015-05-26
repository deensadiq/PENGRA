Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes

Namespace Forms
    Public Class frmGroupKnockOff

        Private stm As String
        Private strM As String
        Private strName As String
        Private strCode As String

        Private Table As DataTable
        Private Adapter As FbDataAdapter
        Private strSQL As String

        Private strPath As String = Application.StartupPath
        Private intMonth As Integer
        Private intYear As Integer
        Private ConnStr As String
        Private ministry As Integer

        Private Sub LoadCombo()
            Populate.comboBoxBudget(cboBudget)
            Populate.GetBudgetYear(cboBudgetYear)
            Populate.GetBudgetMonth(cboBudgetMonth)
        End Sub

        Sub LoadData(ByVal AuditYear As Integer, ByVal AuditMonth As Integer)
            Table = New DataTable
            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            strSQL = "SELECT p.EMPLOYEE, (p.GRATUITY - p.GRATUITYPAID) AS GRATUITY, (p.PENSIONARREARS - p.PEANSIONPAID) AS PENSIONARREARS, (p.DEATHPENSION - p.DEATHPAID) AS DEATHPENSION"
            strSQL = strSQL + " FROM SP_BENEFICIARIES_OUTSTANDING p where P.AYEAR = '" & AuditYear & "' AND p.AMONTH = '" & AuditMonth & "'"
            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Adapter.Fill(Table)

            'If tbl.Rows.Count > 0 Then
            '    txtID.Text = tbl.Rows(0).Item("IDNO")
            '    txtID.Tag = Employee
            '    txtFullName.Text = tbl.Rows(0).Item("FULLNAME")
            '    txtMinistry.Text = GetMinistryName(tbl.Rows(0).Item("MINISTRY"))
            'End If
            'LoadBudget()
        End Sub

        Private Sub LoadBudget()
            Dim da As FbDataAdapter
            Dim tbl As New DataTable
            Dim str As String

            Dim iBudget As Integer = 0
            Dim iYear As Integer = 0
            Dim iMonth As Integer = 0

            'LoadCombo()

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            str = "SELECT * FROM BUDGETING WHERE ACTVE = '1'"
            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then

                If Not IsDBNull(tbl.Rows(0).Item("BUDGET")) Then iBudget = tbl.Rows(0).Item("BUDGET")
                If Not IsDBNull(tbl.Rows(0).Item("BYEAR")) Then iYear = tbl.Rows(0).Item("BYEAR")
                If Not IsDBNull(tbl.Rows(0).Item("BMONTH")) Then iMonth = tbl.Rows(0).Item("BMONTH")

                cboBudgetYear.SelectedIndex = 1
                cboBudgetMonth.SelectedIndex = 1
                cboBudget.SelectedIndex = 1
                txtBudgetAmount.Text = Format(tbl.Rows(0).Item("AMOUNT"), "#,##0.00")
                txtBudgetBalance.Text = Format(Populate.GetBudgetBalance(iBudget, iYear, iMonth), "#,##0.00")
                'txtMinistry.Text = GetMinistryName(tbl.Rows(0).Item("MINISTRY"))
            End If
        End Sub

        Private Sub SetBenefitDetails(ByVal Employee As Integer, ByVal Benefit As Integer)
            Dim benefitAmount As Double
            Dim benefitPaid As Double
            Dim benefitBalance As Double
            Dim str As String
            Dim da As FbDataAdapter
            Dim tbl As DataTable

            benefitBalance = 0
            benefitAmount = 0
            benefitPaid = 0

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            str = "SELECT SUM(a.DEBIT) AS PAID, SUM(a.CREDIT) AS AMOUNT FROM TRANSACTIONS a WHERE a.EMPLOYEE = '" & Employee & "' and a.BTYPE = '" & Benefit & "'"

            tbl = New DataTable
            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then
                If Not IsDBNull(tbl.Rows(0).Item("PAID")) Then benefitPaid = tbl.Rows(0).Item("PAID")
                If Not IsDBNull(tbl.Rows(0).Item("AMOUNT")) Then benefitAmount = tbl.Rows(0).Item("AMOUNT")
            End If

            'Calculate the Budget Balance
            benefitBalance = benefitAmount - benefitPaid

            'txtAmount.Text = Format(benefitAmount, "#,##0.00")
            txtBalance.Text = Format(benefitBalance, "#,##0.00")
        End Sub

        Private Sub Enable()
            'txtAmount.Enabled = True
            txtBalance.Enabled = True
            txtTransactionNo.Enabled = True
            dtpTransDate.Enabled = True
            txtKnockoffAmount.Enabled = True
            txtAYear.Enabled = True
            txtAMonth.Enabled = True

            cboBudgetYear.Enabled = True
            cboBudgetMonth.Enabled = True
            cboBudget.Enabled = True
            txtBudgetAmount.Enabled = True
            txtBudgetBalance.Enabled = True

            btnSave.Enabled = True
            btnUndo.Enabled = True

            btnClose.Enabled = False
        End Sub

        Private Sub Disable()
            'txtAmount.Enabled = False
            txtBalance.Enabled = False
            txtTransactionNo.Enabled = False
            dtpTransDate.Enabled = False
            txtKnockoffAmount.Enabled = False
            txtAYear.Enabled = False
            txtAMonth.Enabled = False

            cboBudgetYear.Enabled = False
            cboBudgetMonth.Enabled = False
            cboBudget.Enabled = False
            txtBudgetAmount.Enabled = False
            txtBudgetBalance.Enabled = False

            btnSave.Enabled = False
            btnUndo.Enabled = False

            btnClose.Enabled = True

            'txtID.BackColor = System.Drawing.SystemColors.Window
            'txtFullName.BackColor = System.Drawing.SystemColors.Window
            txtMinistry.BackColor = System.Drawing.SystemColors.Window
        End Sub

        Private Sub clearRecord()
            'txtAmount.Clear()
            'txtBalance.Clear()
            txtTransactionNo.Clear()
            dtpTransDate.Value = Date.Now
            'txtKnockoffAmount.Clear()

            cboBudgetYear.SelectedIndex = 0
            cboBudgetMonth.SelectedIndex = 0
            If cboBudget.Text <> "" Then cboBudget.SelectedValue = 0
            txtBudgetAmount.Clear()
            txtBudgetBalance.Clear()
        End Sub

        Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            Me.BackColor = Color.FromArgb(246, 248, 252)

            Disable()
            LoadCombo()
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            If txtMinistry.Text = "" Then Exit Sub

            txtTransactionNo.Text = TransactionNo()
            LoadBudget()

            Enable()
        End Sub

        Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
            clearRecord()
            Disable()
        End Sub

        Private Sub cboBenefitType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Try
                'txtAmount.Clear()
                txtBalance.Clear()
                txtTransactionNo.Clear()

                'Dim ibenefit As Integer = cboBenefitType.SelectedValue
                'SetBenefitDetails(txtID.Tag, ibenefit)
                'If CDbl(txtBalance.Text) > 0 Then txtTransactionNo.Text = Populate.GetTransactionNo(ibenefit)
            Catch ex As Exception

            End Try
        End Sub

        Private Function IsValid() As Boolean

            If txtMinistry.Text.Trim = "" Then
                MessageBox.Show("Please Select A Ministry Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMinistry.Focus()
                Return False
            End If

            If IsNumeric(txtKnockoffAmount.Text) = False OrElse CDbl(txtKnockoffAmount.Text) <= 0 Then
                MessageBox.Show("Only A Number Is Allowed Or A Value Greater Than Zero(0). Please Enter A Valid Value Before Proceeding.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtKnockoffAmount.Focus()
                Return False
            End If

            If CDbl(txtKnockoffAmount.Text) > CDbl(txtBalance.Text) Then
                MessageBox.Show("Knock-Off Amount Cannot Be Greater Than Benefit Banlance. Please Enter A Valid Value Before Proceeding.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtKnockoffAmount.Focus()
                Return False
            End If

            If CDbl(txtKnockoffAmount.Text) > CDbl(txtBudgetBalance.Text) Then
                MessageBox.Show("Knock-Off Amount Cannot Be Greater Than Budget Banlance. Please Enter A Valid Value Before Proceeding.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtKnockoffAmount.Focus()
                Return False
            End If

            Return True
        End Function

        Private Function SaveRecord() As Boolean
            Dim strSQLS As String
            'Dim command As New FirebirdSql.Data.FirebirdClient.FbCommand

            Dim iBuget As Integer = cboBudget.SelectedValue
            Dim iBYear As Integer = CInt(cboBudgetYear.Text)
            Dim iBMonth As Integer = cboBudgetMonth.SelectedValue
            Dim iTxn As String = txtTransactionNo.Text.Trim
            Dim iTDate As String = CType(dtpTransDate.Text, Date)

            SaveRecord = False

            Try

                Using conn As New FbConnection
                    conn.ConnectionString = DB.ConnectionString
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    Using myTransaction = conn.BeginTransaction
                        'Dim command As FbCommand
                        'Dim strSql As String = ""

                        If Table.Rows.Count > 0 Then
                            Dim I As Integer
                            For I = 0 To Table.Rows.Count - 1

                                Dim iGratuity As Double = Table.Rows(I).Item("GRATUITY")
                                Dim iPension As Double = Table.Rows(I).Item("PENSIONARREARS")
                                Dim iDeathPension As Double = Table.Rows(I).Item("DEATHPENSION")
                                Dim iEmployee = Table.Rows(I).Item("EMPLOYEE")

                                If iGratuity > 0 Then
                                    'Knock-off Gratuity Benefit

                                    'EXECUTE PROCEDURE SP_BENEFIT_KNOCKOFF(TDATE, EMPLOYEE, TNUMBER, TBENEFIT, AMOUNT, BUDGET, BYEAR, BMONTH, STATUS)
                                    strSQLS = "EXECUTE PROCEDURE SP_BENEFIT_KNOCKOFF('" & iTDate & "', '" & iEmployee & "', '" & iTxn & "', '" & 1 & "', '" & iGratuity & "', '" & iBuget & "', '" & iBYear & "', '" & iBMonth & "', '" & Env.GetStatus & "')"

                                    Using command1 = New FbCommand(strSQLS, conn, myTransaction)
                                        command1.CommandText = strSQLS
                                        command1.ExecuteScalar()
                                    End Using

                                End If

                                If iPension > 0 Then
                                    'Knock-off Pension Arrears Benefit

                                    strSQLS = "EXECUTE PROCEDURE SP_BENEFIT_KNOCKOFF('" & iTDate & "', '" & iEmployee & "', '" & iTxn & "', '" & 2 & "', '" & iPension & "', '" & iBuget & "', '" & iBYear & "', '" & iBMonth & "', '" & Env.GetStatus & "')"

                                    Using command2 = New FbCommand(strSQLS, conn, myTransaction)
                                        command2.CommandText = strSQLS
                                        command2.ExecuteScalar()
                                    End Using

                                End If

                                If iDeathPension > 0 Then
                                    'Knock-off Death Pension Benefit

                                    strSQLS = "EXECUTE PROCEDURE SP_BENEFIT_KNOCKOFF('" & iTDate & "', '" & iEmployee & "', '" & iTxn & "', '" & 3 & "', '" & iDeathPension & "', '" & iBuget & "', '" & iBYear & "', '" & iBMonth & "', '" & Env.GetStatus & "')"

                                    Using command3 = New FbCommand(strSQLS, conn, myTransaction)
                                        command3.CommandText = strSQLS
                                        command3.ExecuteScalar()
                                    End Using

                                End If

                                strSQLS = "UPDATE EMPLOYEEINFO SET ACTVE = '0' WHERE UKEY = '" & iEmployee & "'"

                                Using command4 = New FbCommand(strSQLS, conn, myTransaction)
                                    command4.CommandText = strSQLS
                                    command4.ExecuteScalar()
                                End Using

                            Next
                        End If

                        myTransaction.Commit()
                    End Using

                    conn.Close()
                End Using


                SaveRecord = True

            Catch ex As Exception
                Throw ex
            End Try

            Return SaveRecord
        End Function

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            If txtMinistry.Text = "" Then Exit Sub

            If IsValid() = False Then Exit Sub

            If MessageBox.Show("Are You Sure You Want To Continue With The Current Transaction?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Try
                If SaveRecord() = True Then clearRecord()
                LoadBudget()
                Disable()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Shared Function TransactionNo() As String
            Dim str As String
            Dim tbl As DataTable
            Dim da As FbDataAdapter

            TransactionNo = ""

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            str = "SELECT GEN_ID(GEN_GTRANSACTION, 1) from RDB$DATABASE"

            tbl = New DataTable
            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            TransactionNo = "GRPT/" + Format(tbl.Rows(0).Item("GEN_ID"), "000000")

            Return TransactionNo
        End Function
    End Class
End Namespace