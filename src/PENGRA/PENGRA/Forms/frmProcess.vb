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

        Public WithEvents Processor As New Payment
        Private ProgressLable As String
        Public Sub LoadCombo()
            LoadComboAllocation(cboBudget)
            LoadComboMonth(cboMonth)
            LoadComboYear(cboYear)
        End Sub
        Private Sub LoadComboAllocation(ByVal cbo As ComboBox)
            Dim strSQL As String
            Dim Table As DataTable
            Dim Adapter As FbDataAdapter

            Table = New DataTable

            cbo.DataSource = Nothing

            Dim Dr As DataRow

            strSQL = "SELECT * FROM BUDGET a WHERE a.UKEY IN (SELECT first 1 a.BUDGET FROM BUDGETING a order by a.UKEY desc)"

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Adapter.Fill(Table)

            Dr = Table.NewRow
            Dr.Item("NAME") = ""
            Dr.Item("UKEY") = "0"
            Table.Rows.InsertAt(Dr, 0)

            'If Not Table.Rows.Count > 0 Then Exit Sub
            'replaceDoubleApostrophe(Table, "NAME")

            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "UKEY"
            cbo.DataSource = Table.DefaultView
        End Sub
        Private Sub LoadComboYear(ByVal cbo As ComboBox)
            Dim strSQL As String
            Dim Table As DataTable
            Dim Adapter As FbDataAdapter

            Table = New DataTable

            strSQL = "SELECT first 1 a.BYEAR FROM BUDGETING a order by a.UKEY desc "

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Adapter.Fill(Table)


            Dim I As Integer
            cbo.Items.Clear()
            cbo.Items.Add("")
            If Table.Rows.Count > 0 Then
                For I = 0 To Table.Rows.Count - 1
                    cbo.Items.Add(Table.Rows(I).Item("BYEAR").ToString)
                Next
            End If
            cbo.Text = cbo.Items(0)
        End Sub
        Private Sub LoadComboMonth(ByVal cbo As ComboBox)
            Dim iMonth As New Hashtable
            Dim strSQL As String
            Dim tbl = New DataTable
            Dim Table As DataTable
            Dim Adapter As FbDataAdapter

            iMonth.Add(1, "January")
            iMonth.Add(2, "February")
            iMonth.Add(3, "March")
            iMonth.Add(4, "April")
            iMonth.Add(5, "May")
            iMonth.Add(6, "June")
            iMonth.Add(7, "July")
            iMonth.Add(8, "August")
            iMonth.Add(9, "September")
            iMonth.Add(10, "October")
            iMonth.Add(11, "November")
            iMonth.Add(12, "December")

            Table = New DataTable

            cbo.DataSource = Nothing

            strSQL = "SELECT first 1 a.BMONTH FROM BUDGETING a order by a.UKEY desc "

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Adapter.Fill(tbl)


            Dim Dr As DataRow
            Dim Dt As New DataTable

            Dt.Columns.Add("NAME", GetType(String))
            Dt.Columns.Add("UKEY", GetType(Short))

            Dr = Dt.NewRow
            Dr.Item("NAME") = ""
            Dr.Item("UKEY") = "-1"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dim I As Integer
            cbo.Items.Clear()
            cbo.Items.Add("")
            If tbl.Rows.Count > 0 Then
                For I = 0 To tbl.Rows.Count - 1
                    Dr = Dt.NewRow
                    Dr.Item("NAME") = iMonth.Item(CInt(tbl.Rows(I).Item("BMONTH")))
                    Dr.Item("UKEY") = tbl.Rows(I).Item("BMONTH")
                    Dt.Rows.Add(Dr)
                    Dt.AcceptChanges()
                    'cbo.Items.Add(iMonth.Item(CInt(tbl.Rows(I).Item("BMONTH"))))
                Next
            End If

            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "UKEY"
            cbo.DataSource = Dt.DefaultView
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
            LoadCombo()
            'LoadEntryGrid()
            'cboYear.SelectedIndex = 1
            'cboMonth.SelectedIndex = 1
            'cboBudget.SelectedIndex = 1

        End Sub
        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
        Private Function IsValid() As Boolean

            If Transactions.IsAllPaymentApproved(intBudget, intBudgetYear, intBudgetMonth) = False Then
                MessageBox.Show("All Transactions Most Be Approved Before Processing.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If Transactions.GetBudgetBalance(intBudget, intBudgetYear, intBudgetMonth) > 0 Then
                MessageBox.Show("The Current Allocation Is Not Exhausted. Make Sure The Current Allocation Is Exhausted Before A New Allocation Is Added.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If chkOverwrite.Checked = False And Transactions.IsPaymentMade(intBudget, intBudgetYear, intBudgetMonth) = True Then
                MessageBox.Show("Cannot Continue Payment For This Allocation Has Been Processed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Return True
        End Function
        Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

            If cboBudget.Text = "" Or cboYear.Text = "" Or cboMonth.Text = "" Then Exit Sub

            intBudget = CInt(cboBudget.SelectedValue)
            intBudgetYear = CInt(cboYear.Text)
            intBudgetMonth = CInt(cboMonth.SelectedValue)

            If IsValid() = False Then Exit Sub

            If MessageBox.Show("Are You Sure You Want To Continue With The Current Process?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            If chkOverwrite.Checked = False And Transactions.IsPaymentMade(intBudget, intBudgetYear, intBudgetMonth) = True Then
                Payment.clearMemo(intBudget, intBudgetYear, intBudgetMonth)
                Payment.ClearOutstandingDetails(intBudget, intBudgetYear, intBudgetMonth)
                Payment.ClearPaymentDetails(intBudget, intBudgetYear, intBudgetMonth)
            End If

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

            Processor.addWorker(BackgroundWorker, e)
            Processor.ProcessPayment(intBudget, intBudgetYear, intBudgetMonth)

        End Sub
        Private Sub BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged


            If e.ProgressPercentage = 0 Then
                prgBar.Step = 1
                prgBar.Minimum = 0
                prgBar.Maximum = 100
                lblProgress.Text = Processor.CurrentOperation

            End If

            If e.ProgressPercentage > 100 Or e.ProgressPercentage < 1 Then Exit Sub
            lblProgress.Text = Processor.CurrentOperation
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