﻿Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes


Namespace Forms

    Public Class frmPaymentLimitDetails
        Dim I As Integer
        Dim mStruc As Integer
        Dim mType As Integer
        Dim mAllow As Integer
        Dim mAppt As Integer

        Dim iBenefit As Integer
        Dim iYear As Integer
        Dim iMonth As Integer

        Dim Budget As Integer
        Dim BYear As Integer
        Dim BMonth As Integer

        Dim Table As DataTable
        Dim Adapter As FbDataAdapter
        Dim CommandBuilder As New FbCommandBuilder

        Dim Transaction As DataTable
        Dim daTransaction As FbDataAdapter
        Dim cmbTransaction As New FbCommandBuilder

        Dim TableTotal As DataTable
        Dim AdapterTotal As FbDataAdapter
        Dim CommandBuilderTotal As New FbCommandBuilder

        Dim strSQL As String

        Private Sub LoadActiveBudget()
            Dim str As String
            Dim bTable As New DataTable
            Dim bda As FbDataAdapter

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Budget = 0
            BYear = 0
            BMonth = 0

            str = "SELECT * FROM BUDGETING WHERE ACTVE = '1'"
            bda = New FbDataAdapter(str, DB.ConnObj)
            bda.Fill(bTable)

            If bTable.Rows.Count = 0 Then Exit Sub

            If Not IsDBNull(bTable.Rows(0).Item("BUDGET")) Then Budget = bTable.Rows(0).Item("BUDGET")
            If Not IsDBNull(bTable.Rows(0).Item("BYEAR")) Then BYear = bTable.Rows(0).Item("BYEAR")
            If Not IsDBNull(bTable.Rows(0).Item("BMONTH")) Then BMonth = bTable.Rows(0).Item("BMONTH")

        End Sub

        Private Sub IsEditMode(ByVal bolEdit As Boolean)
            If bolEdit = True Then
                btnEdit.Enabled = False
                btnClose.Enabled = False

                btnSave.Enabled = True
                btnUndo.Enabled = True
                btnRemove.Enabled = False
                'ckbActive.Enabled = True
            ElseIf bolEdit = False Then
                btnEdit.Enabled = True
                btnClose.Enabled = True

                btnSave.Enabled = False
                btnUndo.Enabled = False
                btnRemove.Enabled = True
                'ckbActive.Enabled = False
            End If
        End Sub

        Private Sub InitComponent()
            LoadActiveBudget()
            InitGrid()
            InitTotal()
        End Sub

        Private Function CreateSQLString(ByVal str As String) As String
            iBenefit = 0
            iYear = 0
            iMonth = 0

            str = "SELECT b.IDNO, b.FULLNAME, c.NAME AS MINISTRYNAME, d.NAME AS BUDGETNAME, a.BMONTH || ' ' || a.BYEAR AS BDATE, e.NAME AS BENEFITTYPE, a.DEBIT, a.STATUS, a.UKEY"
            str = str + " FROM TRANSACTIONS a LEFT OUTER JOIN EMPLOYEEINFO b ON (a.EMPLOYEE = b.UKEY) LEFT OUTER JOIN MINISTRY c ON (a.MINISTRY = c.UKEY)"
            str = str + " LEFT OUTER JOIN BUDGET d ON (a.BUDGET = d.UKEY) LEFT OUTER JOIN BENEFITTYPE e ON (a.BTYPE = e.UKEY)"
            str = str + " WHERE a.BYEAR = '" & BYear & "' AND a.BMONTH = '" & BMonth & "' AND a.TTYPE = '0' ORDER BY a.BENEFICIARY, b.FULLNAME"

            Return str
        End Function

        Private Sub LoadGrid(ByVal Grid As DataGridView)
            Table = New DataTable
            Transaction = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            strSQL = CreateSQLString(strSQL)

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)

            Adapter.Fill(Table)

            strSQL = "SELECT * FROM TRANSACTIONS WHERE BYEAR = '" & BYear & "' AND BMONTH = '" & BMonth & "' AND TTYPE = '0'"
            daTransaction = New FbDataAdapter(strSQL, DB.ConnObj)
            cmbTransaction.DataAdapter = daTransaction
            daTransaction.InsertCommand = cmbTransaction.GetInsertCommand
            daTransaction.DeleteCommand = cmbTransaction.GetDeleteCommand
            daTransaction.UpdateCommand = cmbTransaction.GetUpdateCommand
            daTransaction.Fill(Transaction)

            If Table.Rows.Count = 0 Then Exit Sub

            dgvGrid.RowCount = Table.Rows.Count

            Dim I As Integer
            For I = 0 To Table.Rows.Count - 1

                dgvGrid.Rows(I).Cells("cId").Value = Table.Rows(I).Item("IDNO")
                dgvGrid.Rows(I).Cells("cName").Value = Table.Rows(I).Item("FULLNAME")
                dgvGrid.Rows(I).Cells("cMinistry").Value = Table.Rows(I).Item("MINISTRYNAME")
                'dgvGrid.Rows(I).Cells("cBudget").Value = Table.Rows(I).Item("BUDGETNAME")
                dgvGrid.Rows(I).Cells("cDate").Value = Table.Rows(I).Item("BDATE")
                dgvGrid.Rows(I).Cells("cBenefit").Value = Table.Rows(I).Item("BENEFITTYPE")
                dgvGrid.Rows(I).Cells("cAmount").Value = Table.Rows(I).Item("DEBIT")
                dgvGrid.Rows(I).Cells("cStatus").Value = Table.Rows(I).Item("STATUS")
                If Table.Rows(I).Item("STATUS") = Env.UserStatus Then dgvGrid.Rows(I).Cells("chk").Value = True Else dgvGrid.Rows(I).Cells("chk").Value = False

            Next

            WriteSerial(dgvGrid)

        End Sub

        Private Sub LoadTotal(ByVal Grid As DataGridView)
            TableTotal = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            strSQL = "SELECT SUM(a.DEBIT) FROM TRANSACTIONS a WHERE a.BYEAR = '" & BYear & "' AND a.BMONTH = '" & BMonth & "' AND a.TTYPE = '0'"

            AdapterTotal = New FbDataAdapter(strSQL, DB.ConnObj)

            AdapterTotal.Fill(TableTotal)

            If TableTotal.Rows.Count = 0 Then Exit Sub

            Grid.RowCount = TableTotal.Rows.Count

            Dim I As Integer
            For I = 0 To TableTotal.Rows.Count - 1
                Grid.Rows(I).Cells("cTotal").Value = "            Total Benefit To Be Paid"
                Grid.Rows(I).Cells("cAmount").Value = TableTotal.Rows(I).Item("SUM")
            Next


        End Sub

        Private Sub InitGrid()
            Dim Dr As DataRow
            Dim DtStatus As New DataTable

            DtStatus.Columns.Add("NAME", GetType(String))
            DtStatus.Columns.Add("UKEY", GetType(String))

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "Prepared"
            Dr.Item("UKEY") = "0"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "Checked"
            Dr.Item("UKEY") = "1"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "Approved"
            Dr.Item("UKEY") = "2"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "Closed"
            Dr.Item("UKEY") = "3"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            With dgvGrid

                .Columns.Clear()
                .ColumnHeadersHeight = 35
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 129, 207)
                .ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.Window
                .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                .AllowUserToOrderColumns = False
                .AllowUserToResizeColumns = False

                .EnableHeadersVisualStyles = False
                .BorderStyle = BorderStyle.FixedSingle
                .DefaultCellStyle.BackColor = Color.WhiteSmoke
                .CellBorderStyle = DataGridViewCellBorderStyle.Single
                .DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


                Populate.WriteSN(dgvGrid)
                Populate.WriteColumn(dgvGrid, "cId", "PN NO", 65, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cName", "NAME OF BENEFICIARY", 150, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cMinistry", "MINISTRY", 80, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                'Populate.WriteColumn(dgvGrid, "cBudget", "ALLOCATION", 80, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cDate", "DATE", 60, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleCenter)
                Populate.WriteColumn(dgvGrid, "cBenefit", "BENEFIT", 100, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cAmount", "AMOUNT", 110, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleRight)

                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True
                .Columns(4).ReadOnly = True
                .Columns(5).ReadOnly = True
                .Columns(6).ReadOnly = True
                '.Columns(7).ReadOnly = True

                .Columns(6).DataPropertyName = "AMOUNT"
                .Columns(6).ValueType = GetType(Double)
                .Columns(6).DefaultCellStyle.Format = "#,##0.00"

                Dim cbCol As New DataGridViewComboBoxColumn
                cbCol.Name = "cStatus"
                cbCol.HeaderText = "STATUS"
                cbCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                cbCol.Width = 65
                cbCol.DisplayMember = "Name"
                cbCol.ValueMember = "Ukey"
                cbCol.DataPropertyName = "STATUS"
                cbCol.DataSource = DtStatus.DefaultView
                .Columns.Add(cbCol)
                .Columns("cStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Populate.WriteCheckBox(dgvGrid, "chk", "", "", 25, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleCenter)

                .Columns(7).ReadOnly = True
                .Columns(8).ReadOnly = True
                '.Columns(14).DataPropertyName = "STATUS"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(12).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(13).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(14).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(15).SortMode = DataGridViewColumnSortMode.NotSortable

            End With

            LoadGrid(dgvGrid)
        End Sub

        Private Sub InitTotal()

            With dgvTotal

                .Columns.Clear()
                .ColumnHeadersHeight = 35
                .ColumnHeadersVisible = False
                .RowHeadersVisible = False
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 250)
                .ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.Window
                .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                .AllowUserToOrderColumns = False
                .AllowUserToResizeColumns = False

                .EnableHeadersVisualStyles = False
                .BorderStyle = BorderStyle.FixedSingle
                .DefaultCellStyle.BackColor = Color.WhiteSmoke
                .CellBorderStyle = DataGridViewCellBorderStyle.Single
                .DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


                Populate.WriteColumn(dgvTotal, "cTotal", "Total Benefit To Be Paid", 490, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvTotal, "cAmount", "AMOUNT", 110, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleRight)
                Populate.WriteColumn(dgvTotal, "cExtra", "", 90, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleRight)

                .Columns(1).DataPropertyName = "AMOUNT"
                .Columns(1).ValueType = GetType(Double)
                .Columns(1).DefaultCellStyle.Format = "#,##0.00"

                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True

                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(12).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(13).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(14).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(15).SortMode = DataGridViewColumnSortMode.NotSortable

            End With

            LoadTotal(dgvTotal)
        End Sub

        Private Sub WriteSerial(ByVal Grid As DataGridView)
            If Grid.Rows.Count > 0 Then
                Dim I As Integer
                For I = 0 To Grid.Rows.Count - 1
                    Grid.Rows(I).Cells("tSN").Value = I + 1
                Next
            End If
        End Sub

        Private Sub WriteStatus(ByVal Grid As DataGridView)
            Grid.VirtualMode = True
            If Grid.Rows.Count > 0 Then
                Dim I As Integer
                For I = 0 To Grid.Rows.Count - 1

                    Select Case Table.Rows(I).Item("STATUS")
                        Case "0"
                            Grid.Rows(I).Cells("cStatus").Style.ForeColor = Color.Red
                            'Grid.Item("cStatus", I).Style.ForeColor = Color.Red
                        Case "1"
                            Grid.Item("cStatus", I).Style.ForeColor = Color.Blue
                        Case "2"
                            Grid.Item("cStatus", I).Style.ForeColor = Color.Green
                        Case "3"
                            Grid.Item("cStatus", I).Style.ForeColor = Color.Black
                    End Select
                Next
            End If
        End Sub
        Public Sub displayInfo(ByVal struc As String, ByVal allow As String)
            'txtPaygroup.Text = struc
            'txtType.Text = allow
            'txtAppt.Text = appt
        End Sub

        Private Sub frmSalaryTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor

            With dgvGrid
                .BackgroundColor = Env.GirdBackgroundColor
                .RowsDefaultCellStyle.SelectionBackColor = Env.GirdSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Env.GirdSelectionForeColor
            End With

            With dgvTotal
                .BackgroundColor = Env.GirdBackgroundColor
                .RowsDefaultCellStyle.SelectionBackColor = Color.Transparent
                .RowsDefaultCellStyle.SelectionForeColor = Color.Transparent
            End With

            InitComponent()
            IsEditMode(False)

        End Sub

        Private Sub dgvGrid_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvGrid.CellPainting
            If e.RowIndex = -1 Then Exit Sub
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

            If e.ColumnIndex = dgvGrid.Columns("cStatus").Index Then

                Select Case Table.Rows(e.RowIndex).Item("STATUS")
                    Case "0"
                        dgvGrid.Rows(e.RowIndex).Cells("cStatus").Style.ForeColor = Color.Red
                    Case "1"
                        dgvGrid.Rows(e.RowIndex).Cells("cStatus").Style.ForeColor = Color.Blue
                    Case "2"
                        dgvGrid.Rows(e.RowIndex).Cells("cStatus").Style.ForeColor = Color.Green
                    Case "3"
                        dgvGrid.Rows(e.RowIndex).Cells("cStatus").Style.ForeColor = Color.Black
                End Select
            End If
        End Sub

        Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
            InitComponent()
            IsEditMode(False)
        End Sub

        Private Function IsValid() As Boolean
            Return True
        End Function

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

            If IsValid() = False Then Exit Sub

            If MessageBox.Show("Are You Sure You Want To Continue With The Current Process?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Try

                Dim I As Integer
                For I = 0 To dgvGrid.RowCount - 1
                    If dgvGrid.Rows(I).Cells("chk").Value = True Or dgvGrid.Rows(I).Cells("chk").Value = 1 Then
                        Transaction.Rows(I).Item("STATUS") = Env.UserStatus
                    Else
                        Transaction.Rows(I).Item("STATUS") = "0"
                    End If
                Next
                daTransaction.Update(Transaction)
                InitComponent()
                IsEditMode(False)

            Catch ex As Exception
                'Tx.RollbackTransaction()
                'TransactionMgr.ThreadTransactionMgrReset()
                If ex.Message.Contains("UNQ") Then
                    MessageBox.Show(Messages.Duplicate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'txtId.Focus()
                ElseIf ex.Message.Contains("FK_PERSDATA_5") Then
                    MessageBox.Show("Check Category And Select A Value Before Saving Student Record", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cboCategory.Focus()
                ElseIf ex.Message.Contains("FK_PERSDATA_6") Then
                    MessageBox.Show("Check Year Group And Select A Value Before Saving Student Record", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cboYeargroup.Focus()
                ElseIf ex.Message.Contains("FK_PERSDATA_7") Then
                    MessageBox.Show("Check Class And Select A Value Before Saving Student Record", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cboAdmClass.Focus()
                Else
                    Throw ex
                End If

            End Try
        End Sub
        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            If dgvGrid.Rows.Count = 0 Then Exit Sub

            dgvGrid.Columns("chk").ReadOnly = False
            IsEditMode(True)
        End Sub

        Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
            'If Env.UserPrivillege = Env.eUserPriv.User_2 Then
            '    MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Sub
            'End If

            If dgvGrid.RowCount = 0 Then Exit Sub

            If Not Table.Rows.Count > 0 Then Exit Sub

            'If Env.UserPrivillege <> Env.eUserPriv.User_2 Then
            '    MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Sub
            'End If

            If MessageBox.Show(Messages.Delete, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub


            Try

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                Dim strSql As String = "DELETE FROM TRANSACTIONS WHERE UKEY = " + CStr(Table.Rows(dgvGrid.CurrentRow.Index).Item("UKEY"))
                Dim cmd As New FirebirdSql.Data.FirebirdClient.FbCommand(strSql, DB.ConnObj)

                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()

                InitComponent()
                IsEditMode(False)
            Catch ex As Exception
                If ex.Message.Contains("FK_") Then
                    MessageBox.Show(Messages.ForeignKey, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Table.RejectChanges()
                Else
                    Throw ex
                End If
            End Try

        End Sub

        Private Sub lblProfileTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblProfileTitle.Click

        End Sub

        Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
            If dgvGrid.RowCount = 0 Then Exit Sub

            Dim Report As New PENGRA.Reports.Classes.myReport

            With Report
                .Budget = Budget
                .BudgetYear = BYear
                .BudgetMonth = BMonth
                .Title = BMonth.ToString + "/" + BYear.ToString
                .Parent = Me.MdiParent
                .ReportTitle = "Month Payment Details"
                .PaymentDetailsReport(False)
            End With
        End Sub
    End Class
End Namespace