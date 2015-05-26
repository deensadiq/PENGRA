Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes

Namespace Forms
    Public Class frmBudgeting

        Private stm As String
        Private strM As String
        Private strName As String
        Private strCode As String

        Private Adapter As FbDataAdapter
        Private Budget As DataTable
        Private Builder As New FbCommandBuilder
        Private strSQL As String

        Private BudgetDate As Hashtable

        Private intMonth As Integer
        Private intYear As Integer
        Private ministry As Integer

        Private bolNewRec As Boolean

        Private daAllocation As FbDataAdapter
        Private cmbAllocation As FbCommandBuilder
        Private tblAllocation As DataTable
        Private strAllocation As String
        Private Sub ClearRecord()
            cboYear.Text = ""
            cboMonth.SelectedIndex = 0

            'dtpBudget.Value = Date.Now
            cboBudget.SelectedValue = 0
            txtAmount.Clear()
            txtBalance.Clear()
        End Sub
        Private Sub Enable()
            'dtpBudget.Enabled = True
            cboYear.Enabled = True
            cboMonth.Enabled = True
            cboBudget.Enabled = True
            txtAmount.Enabled = True
            txtBalance.Enabled = True
            txtDescription.Enabled = True


            btnEdit.Enabled = False
            btnSave.Enabled = True
            btnCancel.Enabled = True
            btnRemove.Enabled = False

            btnClose.Enabled = False
        End Sub
        Private Sub EnableEdit()
            'dtpBudget.Enabled = True
            cboYear.Enabled = False
            cboMonth.Enabled = False
            'cboBudget.Enabled = True
            txtAmount.Enabled = True
            txtBalance.Enabled = True
            txtDescription.Enabled = True

            cboYear.Enabled = False
            cboMonth.Enabled = False

            btnEdit.Enabled = False
            btnSave.Enabled = True
            btnCancel.Enabled = True
            btnRemove.Enabled = False

            btnClose.Enabled = False
        End Sub
        Private Sub Disable()
            'dtpBudget.Enabled = Fals
            cboYear.Enabled = False
            cboMonth.Enabled = False
            cboBudget.Enabled = False
            txtDescription.Enabled = False
            txtAmount.Enabled = False
            txtBalance.Enabled = False
            txtDescription.Enabled = False

            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnRemove.Enabled = True

            btnClose.Enabled = True
        End Sub
        Private Sub LoadCombo()
            'Dim iBalance As Decimal
            'Dim str As String
            'Dim tbl As DataTable
            'Dim da As FbDataAdapter

            'str = "SELECT p.BALANCE FROM SP_BUDGET_BALANCE('1', '2014', '12') p"
            'tbl = New DataTable

            'iBalance = 0

            'da = New FbDataAdapter(Str, DB.ConnObj)
            'da.Fill(tbl)

            'If Not IsDBNull(tbl.Rows(0).Item("BALANCE")) Then iBalance = tbl.Rows(0).Item("BALANCE")

            'If iBalance > 0 Then
            '    Populate.comboBox(cboBudget, "SELECT * FROM BUDGET")
            'Else
            '    Populate.comboBox(cboBudget, "SELECT * FROM BUDGET WHERE UKEY > 1")
            'End If

            Populate.comboBox(cboBudget, "SELECT * FROM BUDGET")
            Populate.GetYear(cboYear)
            Populate.GetMonth(cboMonth)
        End Sub
        Private Sub LoadRecord()

            If cboYear.Text = "" Or cboMonth.Text = "" Then Exit Sub

            intYear = cboYear.SelectedItem
            intMonth = cboMonth.SelectedIndex

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Budget = New DataTable
            strSQL = "SELECT * FROM BUDGETING a where a.ACTVE = '1' AND a.BYEAR = '" & intYear & "' AND a.BMONTH = '" & intMonth & "' ORDER BY a.UKEY DESC"

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)

            Builder.DataAdapter = Adapter
            Adapter.InsertCommand = Builder.GetInsertCommand
            Adapter.DeleteCommand = Builder.GetDeleteCommand
            Adapter.UpdateCommand = Builder.GetUpdateCommand

            Adapter.Fill(Budget)

            If Budget.Rows.Count > 0 Then toForm()

        End Sub
        Private Sub LoadBudgetDate(ByVal Budget As Integer)

        End Sub
        Private Sub toForm()

            With Budget.Rows(0)
                'If Not IsDBNull(.Item("BDATE")) Then dtpBudget.Text = CStr(.Item("BDATE"))
                If Not IsDBNull(.Item("BUDGET")) Then cboBudget.SelectedValue = .Item("BUDGET")
                If Not IsDBNull(.Item("DESCRIPTION")) Then txtDescription.Text = .Item("DESCRIPTION")
                If Not IsDBNull(.Item("AMOUNT")) Then txtAmount.Text = Format(.Item("AMOUNT"), "#,##0.00")
                txtBalance.Text = Format(Populate.GetBudgetBalance(cboBudget.SelectedValue, cboYear.Text, cboMonth.SelectedIndex), "#,##0.00")
            End With
        End Sub
        Private Sub toTable(ByVal Ro As DataRow)

            With Ro
                .Item("ACTVE") = "1"
                '.Item("BDATE") = CType(dtpBudget.Text, Date)
                .Item("BUDGET") = cboBudget.SelectedValue
                .Item("DESCRIPTION") = txtDescription.Text.Trim
                .Item("BYEAR") = cboYear.Text
                .Item("BMONTH") = cboMonth.SelectedIndex
                .Item("AMOUNT") = txtAmount.Text.Trim
                .Item("STATUS") = Env.GetStatus
            End With

        End Sub
        Private Function GetBudgetBalance(ByVal iBudget As Integer, ByVal iYear As Integer, ByVal iMonth As Integer) As Double
            Dim budgetAmount As Double
            Dim budgetUse As Double
            Dim str As String
            Dim da As FbDataAdapter
            Dim tbl As DataTable

            GetBudgetBalance = 0
            budgetAmount = 0
            budgetUse = 0

            str = "SELECT SUM(a.DEBIT) FROM TRANSACTIONS a WHERE a.BUDGET = '" & iBudget & "' AND a.BYEAR = '" & iYear & "' AND a.BMONTH = '" & iMonth & "'"
            tbl = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 And IsDBNull(tbl.Rows(0).Item("SUM")) = False Then budgetUse = tbl.Rows(0).Item("SUM")
            If Budget.Rows.Count > 0 And IsDBNull(Budget.Rows(0).Item("AMOUNT")) = False Then budgetAmount = Budget.Rows(0).Item("AMOUNT")

            'Calculate the Budget Balance
            GetBudgetBalance = budgetAmount - budgetUse

            Return GetBudgetBalance
        End Function
       Private Function IsEditable() As Boolean
            Dim str As String
            Dim da As FbDataAdapter
            Dim tbl As DataTable

            Dim dBudget As Integer
            Dim dYear As Integer
            Dim dMonth As Integer

            dBudget = cboBudget.SelectedValue
            dYear = cboYear.SelectedIndex
            dMonth = cboMonth.SelectedIndex

            str = "SELECT * FROM TRANSACTIONS a WHERE a.BUDGET = '" & dBudget & "' AND a.BYEAR = '" & dYear & "' AND a.BMONTH = '" & dMonth & "'"
            tbl = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then
                MessageBox.Show("Transactions Has Been Made On This Budget. To Edit/Delete You Most Remove All Transactions.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            Return True
        End Function
        Private Sub LoadAllocation()
            strAllocation = "SELECT * FROM BUDGETING ORDER BY UKEY"

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            tblAllocation = New DataTable
            daAllocation = New FbDataAdapter(strAllocation, DB.ConnObj)
            daAllocation.Fill(tblAllocation)

        End Sub
        Public Sub LoadGrid(ByVal Grid As DataGridView)
            Table = New DataTable
            Employee = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)

            Adapter.Fill(Table)

            daEmployee = New FbDataAdapter(strEmployee, DB.ConnObj)
            cmdEmployee.DataAdapter = daEmployee
            daEmployee.InsertCommand = cmdEmployee.GetInsertCommand
            daEmployee.DeleteCommand = cmdEmployee.GetDeleteCommand
            daEmployee.UpdateCommand = cmdEmployee.GetUpdateCommand
            daEmployee.Fill(Employee)

            If Table.Rows.Count = 0 Then Exit Sub

            Grid.RowCount = Table.Rows.Count

            Dim I As Integer

            For I = 0 To Table.Rows.Count - 1

                Grid.Item("cID", I).Value = Table.Rows(I).Item("ID").ToString

                With Table.Rows(I)
                    Grid.Rows(I).Cells("cName").Value = .Item("EMPLOYEENAME")
                    Grid.Rows(I).Cells("cMinistry").Value = .Item("MINISTRYNAME")
                    Grid.Rows(I).Cells("cDate").Value = .Item("DESCRIPTION")
                    Grid.Rows(I).Cells("cGratuity").Value = .Item("GRATUITY")
                    Grid.Rows(I).Cells("cPension").Value = .Item("PENSIONARREARS")
                    Grid.Rows(I).Cells("cDeath").Value = .Item("DEATHPENSION")
                    Grid.Rows(I).Cells("cBenefit").Value = .Item("TOTALBENEFIT")
                    Grid.Rows(I).Cells("cGP").Value = .Item("GRATUITYPAID")
                    Grid.Rows(I).Cells("cPAP").Value = .Item("PEANSIONPAID")
                    Grid.Rows(I).Cells("cDPP").Value = .Item("DEATHPAID")
                    Grid.Rows(I).Cells("cPAID").Value = .Item("TOTALPAID")
                    Grid.Rows(I).Cells("cBalance").Value = .Item("BALANCE")
                    Grid.Rows(I).Cells("cStatus").Value = .Item("STATUS")
                    If .Item("STATUS") >= Users.getStatus(Env.RoleID) Then Grid.Rows(I).Cells("chk").Value = True Else Grid.Rows(I).Cells("chk").Value = False

                End With
            Next

            WriteSerial(Grid)

        End Sub
        Private Sub InitGrid()
            '-----------------------------------------------
            '   Allocation Name
            '-----------------------------------------------
            Dim str As String = "SELECT * FROM BUDGET"
            Dim da As New FbDataAdapter(str, DB.ConnObj)
            Dim dat As New DataTable
            da.Fill(dat)

            '----------------------------------------------
            '   Status
            '----------------------------------------------
            Dim DrS As DataRow
            Dim DtS As New DataTable

            DtS.Columns.Add("NAME", GetType(String))
            DtS.Columns.Add("UKEY", GetType(String))

            DrS = DtS.NewRow
            DrS.Item("NAME") = "Active"
            DrS.Item("UKEY") = "1"
            DtS.Rows.Add(DrS)
            DtS.AcceptChanges()

            DrS = DtS.NewRow
            DrS.Item("NAME") = "Processed"
            DrS.Item("UKEY") = "2"
            DtS.Rows.Add(DrS)
            DtS.AcceptChanges()

            '----------------------------------------------------
            '       Month
            '----------------------------------------------------
            Dim Dr As DataRow
            Dim DtStatus As New DataTable

            DtStatus.Columns.Add("NAME", GetType(String))
            DtStatus.Columns.Add("UKEY", GetType(String))

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "January"
            Dr.Item("UKEY") = "1"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "February"
            Dr.Item("UKEY") = "2"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "March"
            Dr.Item("UKEY") = "3"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "April"
            Dr.Item("UKEY") = "4"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "May"
            Dr.Item("UKEY") = "4"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "June"
            Dr.Item("UKEY") = "4"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "July"
            Dr.Item("UKEY") = "4"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "August"
            Dr.Item("UKEY") = "4"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "September"
            Dr.Item("UKEY") = "4"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "October"
            Dr.Item("UKEY") = "4"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "November"
            Dr.Item("UKEY") = "4"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "December"
            Dr.Item("UKEY") = "4"
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            With dgvGrid
                .Rows.Clear()
                .Columns.Clear()
                .ColumnHeadersHeight = 35
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 129, 207)
                .ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.Window
                .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToOrderColumns = False
                .AllowUserToResizeColumns = False
                .AllowUserToAddRows = False
                .RowHeadersVisible = False
                .CausesValidation = False

                .EnableHeadersVisualStyles = False
                .BorderStyle = BorderStyle.FixedSingle
                .CellBorderStyle = DataGridViewCellBorderStyle.Single


                Populate.WriteSN(dgvGrid)
                'Populate.WriteColumn(dgvGrid, "cName", "NAME", 65, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cDescription", "DESCRIPTION", 150, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                'Populate.WriteColumn(dgvGrid, "cStatus", "STATUS", 80, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cYear", "YEAR", 60, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleCenter)
                'Populate.WriteColumn(dgvGrid, "cMonth", "MONTH", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cAmount", "AMOUNT", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cBalance", "BALANCE", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)

                .Columns(0).ReadOnly = True
                .Columns("cDescription").ReadOnly = True
                .Columns("cDescription").DataPropertyName = "DESCRIPTION"
                .Columns("cYear").ReadOnly = True
                .Columns("cYear").DataPropertyName = "BYEAR"
                .Columns("cAmount").ReadOnly = True
                .Columns("cAmount").DataPropertyName = "AMOUNT"
                .Columns("cAmount").ValueType = GetType(Double)
                .Columns("cAmount").DefaultCellStyle.Format = "#,##0.00"

                .Columns(5).ReadOnly = True
                '.Columns(5).ValueType = GetType(Double)
                '.Columns(5).DefaultCellStyle.Format = "#,##0.00"

                .Columns(6).ReadOnly = True
                .Columns(6).ValueType = GetType(Double)
                .Columns(6).DefaultCellStyle.Format = "#,##0.00"

                .Columns(7).ReadOnly = True
                .Columns(7).ValueType = GetType(Double)
                .Columns(7).DefaultCellStyle.Format = "#,##0.00"

                '.Columns(8).ReadOnly = True
                '.Columns(8).ValueType = GetType(Double)
                '.Columns(8).DefaultCellStyle.Format = "#,##0.00"

                '.Columns(9).ReadOnly = True
                '.Columns(9).ValueType = GetType(Double)
                '.Columns(9).DefaultCellStyle.Format = "#,##0.00"

                '.Columns(10).ReadOnly = True
                '.Columns(10).ValueType = GetType(Double)
                '.Columns(10).DefaultCellStyle.Format = "#,##0.00"

                '.Columns(11).ReadOnly = True
                '.Columns(11).ValueType = GetType(Double)
                '.Columns(11).DefaultCellStyle.Format = "#,##0.00"

                '.Columns(12).ReadOnly = True
                '.Columns(12).ValueType = GetType(Double)
                '.Columns(12).DefaultCellStyle.Format = "#,##0.00"

                '.Columns(13).ReadOnly = True
                '.Columns(13).ValueType = GetType(Double)
                '.Columns(13).DefaultCellStyle.Format = "#,##0.00"

                Dim dgvcName As New DataGridViewComboBoxColumn
                dgvcName.Name = "cName"
                dgvcName.HeaderText = "STATUS"
                dgvcName.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                dgvcName.FlatStyle = FlatStyle.Flat
                dgvcName.Width = 65
                dgvcName.DisplayMember = "Name"
                dgvcName.ValueMember = "Ukey"
                dgvcName.DataPropertyName = "STATUS"
                dgvcName.DataSource = dat.DefaultView
                '.Columns.Add(dgvcName)
                .Columns.Insert(1, dgvcName)
                .Columns("cStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Dim dgvcStatus As New DataGridViewComboBoxColumn
                dgvcStatus.Name = "cStatus"
                dgvcStatus.HeaderText = "STATUS"
                dgvcStatus.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                dgvcStatus.FlatStyle = FlatStyle.Flat
                dgvcStatus.Width = 65
                dgvcStatus.DisplayMember = "Name"
                dgvcStatus.ValueMember = "Ukey"
                dgvcStatus.DataPropertyName = "STATUS"
                dgvcStatus.DataSource = DtS.DefaultView
                .Columns.Insert(3, dgvcStatus)
                .Columns("cStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Dim dgvcMonth As New DataGridViewComboBoxColumn
                dgvcMonth.Name = "cStatus"
                dgvcMonth.HeaderText = "STATUS"
                dgvcMonth.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                dgvcMonth.FlatStyle = FlatStyle.Flat
                dgvcMonth.Width = 65
                dgvcMonth.DisplayMember = "Name"
                dgvcMonth.ValueMember = "Ukey"
                dgvcMonth.DataPropertyName = "STATUS"
                dgvcMonth.DataSource = DtS.DefaultView
                .Columns.Insert(5, dgvcMonth)
                .Columns("cStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                '.Columns(14).ReadOnly = True
                '.Columns(15).ReadOnly = True
                '.Columns(14).DataPropertyName = "STATUS"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable


            End With

            'LoadGrid(dgvGrid)
        End Sub
        Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            With dgvGrid
                .BackgroundColor = Env.GirdBackgroundColor
                .RowsDefaultCellStyle.SelectionBackColor = Env.GirdSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Env.GirdSelectionForeColor
            End With

            LoadCombo()
            Disable()

        End Sub
        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            If Users.Privilege.EditAllocation = False Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            If cboYear.Text = "" Or cboMonth.Text = "" Then Exit Sub

            If cboBudget.Text = "" Then bolNewRec = True Else bolNewRec = False

            If IsEditable() = False Then Exit Sub

            EnableEdit()

        End Sub
        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            ClearRecord()
            Disable()
        End Sub
        Private Sub cboYear_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboYear.SelectedValueChanged
            Try
                LoadRecord()
            Catch ex As Exception

            End Try
        End Sub
        Private Sub cboMonth_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedValueChanged
            Try
                LoadRecord()
            Catch ex As Exception

            End Try
        End Sub
        Private Function IsValid() As Boolean
            Dim str As String
            Dim da As FbDataAdapter
            Dim tbl As DataTable

            If cboYear.Text = "" Then
                MessageBox.Show("Please Select A Year Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboYear.Focus()
                Return False
            End If

            If cboMonth.Text = "" Then
                MessageBox.Show("Please Select A Month You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboMonth.Focus()
                Return False
            End If

            If cboBudget.Text = "" Then
                MessageBox.Show("Please Select A Valid Budget Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboBudget.Focus()
                Return False
            End If

            If txtAmount.Text = "" OrElse IsNumeric(txtAmount.Text) = False Then
                MessageBox.Show("Only Numerical Value Are Allowed As Budget. Please Enter A Valid Value Before Proceeding.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtAmount.Focus()
                Return False
            End If

            'Find If There is an Active Budget that is not Exhausted
            If bolNewRec = True Then
                Dim iBalance As Decimal
                str = "SELECT p.BALANCE FROM SP_ACTIVE_BUDGET_BALANCE p"
                tbl = New DataTable

                iBalance = 0

                da = New FbDataAdapter(str, DB.ConnObj)
                da.Fill(tbl)

                If Not IsDBNull(tbl.Rows(0).Item("BALANCE")) Then iBalance = tbl.Rows(0).Item("BALANCE")

                If iBalance > 0 Then
                    MessageBox.Show("The Current Allocation Is Not Exhausted. Make Sure The Current Allocation Is Exhausted Before A New Allocation Is Added.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Return False
                End If
            End If

            'Find If There is an Active Budget that is not Exhausted
            If bolNewRec = True Then
                str = "SELECT * FROM BUDGETING a WHERE a.ACTVE = '1'"
                tbl = New DataTable

                da = New FbDataAdapter(Str, DB.ConnObj)
                da.Fill(tbl)

                If tbl.Rows.Count > 0 Then
                    MessageBox.Show("Payment Have To Be Process Before New Allocation Is Added.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Return False
                End If
            End If

            Return True
        End Function
        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

            If IsValid() = False Then Exit Sub

            If MessageBox.Show("Are You Sure You Want To Continue With The Current Transaction?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Try

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                If bolNewRec = True Then
                    Dim dr As DataRow
                    dr = Budget.NewRow
                    toTable(dr)
                    Budget.Rows.Add(dr)
                Else
                    toTable(Budget.Rows(0))
                End If

                'Budget.AcceptChanges()

                Adapter.Update(Budget)
                LoadRecord()
                Disable()

                bolNewRec = False
            Catch ex As Exception
                'Tx.RollbackTransaction()
                'TransactionMgr.ThreadTransactionMgrReset()
                If ex.Message.Contains("UNQ") Then
                    MessageBox.Show(Messages.Duplicate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboBudget.Focus()
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
        Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
            If Users.Privilege.EditAllocation = False Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If cboBudget.Text = "" Or cboYear.Text = "" Or cboMonth.Text = "" Then Exit Sub

            If IsEditable() = False Then Exit Sub

            If Not Budget.Rows.Count > 0 Then Exit Sub

            If Env.UserPrivillege <> Env.eUserPriv.User_2 Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If MessageBox.Show(Messages.Delete, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub


            Try

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                Dim str As String = "DELETE FROM TRANSACTIONS WHERE BUDGET = '" + cboBudget.SelectedValue + "' AND BYEAR = '" + cboYear.SelectedIndex + "' AND BMONTH = '" + cboMonth.SelectedIndex + "'"
                Dim cmd As New FirebirdSql.Data.FirebirdClient.FbCommand(str, DB.ConnObj)

                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()

                ClearRecord()
                Disable()
            Catch ex As Exception
                If ex.Message.Contains("FK_") Then
                    MessageBox.Show(Messages.ForeignKey, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Budget.RejectChanges()
                Else
                    Throw ex
                End If
            End Try
        End Sub

        Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
            If Users.Privilege.EditAllocation = False Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End Sub
    End Class
End Namespace