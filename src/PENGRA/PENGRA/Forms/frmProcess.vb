Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes
Imports System.Threading
Imports PENGRA.Classes

Namespace Forms

    Public Class frmProcess
        Dim bolStop As Boolean

        Private Shared intBudget As Integer
        Private Shared intBudgetYear As Integer
        Private Shared intBudgetMonth As Integer
        Private Shared intSemester As Integer

        Public WithEvents Processor As New Computation
        Private ProgressLable As String

        Public Sub LoadEntryGrid()

            Populate.GetBudgetYear(cboYear)
            Populate.GetBudgetMonth(cboMonth)
            Populate.comboBoxBudget(cboBudget)

        End Sub

        Private Sub Enable()

            cboBudget.Enabled = True
            cboYear.Enabled = True
            cboMonth.Enabled = True

            btnStop.Enabled = False

        End Sub

        Private Sub Disable()

            cboBudget.Enabled = False
            cboYear.Enabled = False
            cboMonth.Enabled = False

            btnStop.Enabled = True

        End Sub


        Private Sub frmProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor

            'LoadEntryGrid()
            'cboYear.SelectedIndex = 1
            'cboMonth.SelectedIndex = 1
            'cboBudget.SelectedIndex = 1

        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Function IsValid() As Boolean
            Dim iBalance As Decimal
            Dim str As String
            Dim tbl As DataTable
            Dim da As FbDataAdapter

            str = "SELECT p.BALANCE FROM SP_BUDGET_BALANCE('1', '2014', '12') p"
            tbl = New DataTable

            iBalance = 0

            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            If Not IsDBNull(tbl.Rows(0).Item("BALANCE")) Then iBalance = tbl.Rows(0).Item("BALANCE")

            If iBalance > 0 Then
                MessageBox.Show("The Current Allocation Is Not Exhausted. Make Sure The Current Allocation Is Exhausted Before A New Allocation Is Added.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'dtpPensionWEF.Focus()
                Return False
            End If

            Return True
        End Function


        Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

            If cboBudget.Text = "" Or cboYear.Text = "" Or cboMonth.Text = "" Then Exit Sub

            If IsValid() = False Then Exit Sub

            If MessageBox.Show("Are You Sure You Want To Continue With The Current Process?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            intBudget = CInt(cboBudget.SelectedValue)
            intBudgetYear = CInt(cboYear.Text)
            intBudgetMonth = CInt(cboMonth.SelectedValue)

            btnStart.Enabled = False
            btnStop.Enabled = True

            BackgroundWorker.RunWorkerAsync()

        End Sub

        Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'Stop Salary Processing and abort the Salary Processing Thread
            BackgroundWorker.CancelAsync()

            lblProgress.Text = ""
            prgBar.Value = 0
            btnStart.Enabled = True
            btnStop.Enabled = False
        End Sub

        Private Sub BackgroundWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork

            'Processor.addWorker(BackgroundWorker, e)
            'Processor.ComputeDetails(intBudget, intBudgetYear, intBudgetMonth)
            Try
                Dim Adapter As FbDataAdapter
                Dim Table As DataTable
                Dim strSQL As String
                Dim Reader As FbDataReader
                Dim cmbBuilder As New FbCommandBuilder

                Dim intRecords As Integer
                Dim Percentage As Integer
                Dim intPos As Integer

                ProgressLable = "Started"

                Using Conn As New FbConnection
                    Conn.ConnectionString = DB.ConnectionString
                    If Conn.State = ConnectionState.Closed Then Conn.Open()

                    Using myTransaction = Conn.BeginTransaction
                        strSQL = "SELECT DISTINCT a.EMPLOYEE, b.IDNO FROM TRANSACTIONS a JOIN EMPLOYEEINFO b ON (a.EMPLOYEE = b.UKEY) WHERE a.BUDGET = '" & intBudget & "' AND a.BYEAR = '" & intBudgetYear & "' AND a.BMONTH = '" & intBudgetMonth & "' AND a.STATUS = '2'"

                        Using Command As New FbCommand(strSQL, Conn, myTransaction)
                            Command.CommandText = strSQL
                            Reader = Command.ExecuteReader


                            Using comm As New FbCommand(strSQL, Conn, myTransaction)
                                Table = New DataTable
                                Adapter = New FbDataAdapter(comm)
                                Adapter.Fill(Table)

                                intRecords = Table.Rows.Count
                            End Using

                            Try
                                ProgressLable = "Process Payment Details"
                                BackgroundWorker.ReportProgress(0)
                            Catch ex As Exception
                                Throw ex
                            End Try



                            While Reader.Read = True

                                'checks if the process is cancelled by the user 
                                If BackgroundWorker.CancellationPending = True Then
                                    ProgressLable = "Cancelled"
                                    e.Cancel = True
                                    Exit Sub
                                End If

                                ProgressLable = "Save Details For Employee ( " + Reader("IDNO").ToString + " )"

                                strSQL = "EXECUTE PROCEDURE SP_SAVE_PAYMENT('" & Reader("EMPLOYEE") & "', '" & intBudget & "', '" & intBudgetYear & "', '" & intBudgetMonth & "')"

                                Using command1 As New FbCommand(strSQL, Conn, myTransaction)
                                    command1.CommandText = strSQL
                                    command1.ExecuteScalar()
                                End Using

                                Thread.Sleep(500)

                                intPos += 1
                                Percentage = CInt((intPos / intRecords) * 100)
                                BackgroundWorker.ReportProgress(Percentage)

                            End While

                        End Using

                        strSQL = "UPDATE BUDGETING SET ACTVE = '0' WHERE BUDGET = '" & intBudget & "' AND BYEAR = '" & intBudgetYear & "' AND BMONTH = '" & intBudgetMonth & "' AND ACTVE = '1'"

                        Using command2 As New FbCommand(strSQL, Conn, myTransaction)
                            command2.CommandText = strSQL
                            command2.ExecuteScalar()
                        End Using

                        myTransaction.Commit()

                    End Using

                    Conn.Close()

                End Using
            Catch ex As Exception
                Throw ex
            End Try
            

        End Sub

        Private Sub BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged


            If e.ProgressPercentage = 0 Then
                prgBar.Step = 1
                prgBar.Minimum = 0
                prgBar.Maximum = 100

                If Processor.CurrentOperation = "loadSubjects" Then lblProgress.Text = "Loading Subjects"
                If Processor.CurrentOperation = "Details_Grades" Then lblProgress.Text = "Computing Grades"
                If Processor.CurrentOperation = "SCTP" Then lblProgress.Text = "Computing Subject Positions By Section"
                If Processor.CurrentOperation = "Details_YP" Then lblProgress.Text = "Computing Subject Positions By Year Group"
                If Processor.CurrentOperation = "ALLCLASS" Then lblProgress.Text = "Computing Subject Positions By All Classes"
                If Processor.CurrentOperation = "CLASSPOS" Then lblProgress.Text = "Computing Subject Positions By Class"
                If Processor.CurrentOperation = "STATUS" Then lblProgress.Text = "Computing Academic Status Details"
                If Processor.CurrentOperation = "STATUS_ALLCLASS" Then lblProgress.Text = "Computing Academic Status All Classes"
                If Processor.CurrentOperation = "STATUS_YP" Then lblProgress.Text = "Computing Academic Status Year Group"
                If Processor.CurrentOperation = "STATUS_CTP" Then lblProgress.Text = "Computing Academic Status By Section"
                If Processor.CurrentOperation = "STATUS_CLASSPOS" Then lblProgress.Text = "Computing Academic Status By Class"
                If Processor.CurrentOperation = "ProcessCalendar" Then lblProgress.Text = "Process Calendar"
                If Processor.CurrentOperation = "Cumulative_Scores" Then lblProgress.Text = "Computing Cumulative Scores"
                If Processor.CurrentOperation = "Subject Position Cumulative YG" Then lblProgress.Text = "Computing Cumulative Subject Year Group Positions"
                If Processor.CurrentOperation = "Subject Position Cumulative" Then lblProgress.Text = "Computing Cumulative Subject Positions"
                If Processor.CurrentOperation = "Subject Position Cumulative Class" Then lblProgress.Text = "Computing Cumulative Subject Class Positions"
                If Processor.CurrentOperation = "Subject Position Cumulative AllClass" Then lblProgress.Text = "Computing Cumulative Subject All Classes Positions"
                If Processor.CurrentOperation = "CUMULATIVE STATUS" Then lblProgress.Text = "Computing Cumulative Status"
                If Processor.CurrentOperation = "YP CUMULATIVE POSITION" Then lblProgress.Text = "Computing Cumulative Year Group Positions "
                If Processor.CurrentOperation = "CTP CUMULATIVE POSITION" Then lblProgress.Text = "Computing Cumulative Section Positions "
                If Processor.CurrentOperation = "CLASS CUMULATIVE POSITION" Then lblProgress.Text = "Computing Cumulative Class Positions "
                If Processor.CurrentOperation = "ALL CUMULATIVE CLASS POSITION" Then lblProgress.Text = "Computing Cumulative All Class Positions "
                If Processor.CurrentOperation = "Promotion" Then lblProgress.Text = "Computing Promotion"

                If Processor.CurrentOperation = "writeSchoolsettings" Then lblProgress.Text = "Writing School Settings"
                If Processor.CurrentOperation = "writeReports" Then lblProgress.Text = "Generating Reports"
                If Processor.CurrentOperation = "writeComments" Then lblProgress.Text = "Writing Comments"
                If Processor.CurrentOperation = "writeBroadSheet" Then lblProgress.Text = "Preparing Broadsheet"
                If Processor.CurrentOperation = "Finish" Then lblProgress.Text = "Finalising"
            End If

            If e.ProgressPercentage > 100 Or e.ProgressPercentage < 1 Then Exit Sub
            lblProgress.Text = ProgressLable
            prgBar.Value = e.ProgressPercentage

        End Sub

        Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted

            If Processor.CurrentOperation = "Cancelled" Then

                MessageBox.Show(Messages.Cancelled, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(Messages.Completed, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            lblProgress.Text = ""
            prgBar.Value = 0
            btnStart.Enabled = True
            btnStop.Enabled = False

        End Sub

    End Class
End Namespace