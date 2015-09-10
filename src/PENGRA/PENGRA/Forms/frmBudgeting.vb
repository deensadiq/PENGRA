Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes
Imports PENGRA.Classes

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

            cboBudget.SelectedValue = 0
            txtAmount.Clear()
            txtBalance.Clear()
            txtDescription.Clear()
        End Sub
        Private Sub Enable()
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
        Private Sub Disable()
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

            If Budget.Rows.Count > 0 Then toForm(0)

        End Sub
        Private Sub LoadBudgetDate(ByVal Budget As Integer)

        End Sub
        Private Sub toForm(ByVal rowIndex As Integer)

            With tblAllocation.Rows(rowIndex)
                If Not IsDBNull(.Item("BYEAR")) Then cboYear.Text = .Item("BYEAR")
                If Not IsDBNull(.Item("BMONTH")) Then cboMonth.SelectedIndex = CInt(.Item("BMONTH"))
                If Not IsDBNull(.Item("BUDGET")) Then cboBudget.SelectedValue = .Item("BUDGET")
                If Not IsDBNull(.Item("DESCRIPTION")) Then txtDescription.Text = .Item("DESCRIPTION")
                If Not IsDBNull(.Item("AMOUNT")) Then txtAmount.Text = Format(.Item("AMOUNT"), "#,##0.00")
                txtBalance.Text = Format(Transactions.GetBudgetBalance(.Item("BUDGET"), .Item("BYEAR"), .Item("BMONTH")), "#,##0.00")
            End With
        End Sub
        Private Sub toTable(ByVal Ro As DataRow)

            With Ro
                .Item("ACTVE") = "1"
                .Item("BDATE") = Date.Now
                .Item("BUDGET") = cboBudget.SelectedValue
                .Item("DESCRIPTION") = txtDescription.Text.Trim
                .Item("BYEAR") = cboYear.Text
                .Item("BMONTH") = cboMonth.SelectedIndex
                .Item("AMOUNT") = txtAmount.Text.Trim
                .Item("STATUS") = Env.UserStatus
            End With

        End Sub
        Private Sub LoadAllocation()
            strAllocation = "SELECT * FROM BUDGETING ORDER BY UKEY"

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            tblAllocation = New DataTable
            daAllocation = New FbDataAdapter(strAllocation, DB.ConnObj)

            cmbAllocation = New FbCommandBuilder
            cmbAllocation.DataAdapter = daAllocation
            daAllocation.InsertCommand = cmbAllocation.GetInsertCommand
            daAllocation.DeleteCommand = cmbAllocation.GetDeleteCommand
            daAllocation.UpdateCommand = cmbAllocation.GetUpdateCommand

            daAllocation.Fill(tblAllocation)

        End Sub
        Public Sub LoadGrid(ByVal Grid As DataGridView)
            strAllocation = "SELECT * FROM BUDGETING ORDER BY UKEY"

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            tblAllocation = New DataTable
            daAllocation = New FbDataAdapter(strAllocation, DB.ConnObj)

            cmbAllocation = New FbCommandBuilder
            cmbAllocation.DataAdapter = daAllocation
            daAllocation.InsertCommand = cmbAllocation.GetInsertCommand
            daAllocation.DeleteCommand = cmbAllocation.GetDeleteCommand
            daAllocation.UpdateCommand = cmbAllocation.GetUpdateCommand

            daAllocation.Fill(tblAllocation)

            If tblAllocation.Rows.Count = 0 Then Exit Sub

            Grid.Rows.Clear()

            Grid.RowCount = tblAllocation.Rows.Count

            Dim I As Integer

            For I = 0 To tblAllocation.Rows.Count - 1
                With tblAllocation.Rows(I)
                    Grid.Item(0, I).Value = I + 1
                    Grid.Item("cName", I).Value = CInt(.Item("BUDGET"))
                    Grid.Item("cDescription", I).Value = .Item("DESCRIPTION").ToString
                    Grid.Item("cStatus", I).Value = .Item("ACTVE").ToString
                    Grid.Item("cYear", I).Value = .Item("BYEAR").ToString
                    Grid.Item("cMonth", I).Value = .Item("BMONTH")
                    Grid.Item("cAmount", I).Value = .Item("AMOUNT")
                End With
            Next
        End Sub
        Private Sub InitGrid()
            '-----------------------------------------------
            '   Allocation Name
            '-----------------------------------------------
            Dim str As String = "SELECT Name, Ukey FROM BUDGET"
            Dim da As New FbDataAdapter(str, DB.ConnObj)
            Dim dat As New DataTable
            da.Fill(dat)

            Dim int As Integer = dat.Rows.Count

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
            DrS.Item("UKEY") = "0"
            DtS.Rows.Add(DrS)
            DtS.AcceptChanges()

            '----------------------------------------------------
            '       Month
            '----------------------------------------------------
            Dim Dr As DataRow
            Dim DtStatus As New DataTable

            DtStatus.Columns.Add("NAME", GetType(String))
            DtStatus.Columns.Add("UKEY", GetType(Integer))

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "January"
            Dr.Item("UKEY") = 1
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "February"
            Dr.Item("UKEY") = 2
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "March"
            Dr.Item("UKEY") = 3
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "April"
            Dr.Item("UKEY") = 4
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "May"
            Dr.Item("UKEY") = 5
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "June"
            Dr.Item("UKEY") = 6
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "July"
            Dr.Item("UKEY") = 7
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "August"
            Dr.Item("UKEY") = 8
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "September"
            Dr.Item("UKEY") = 9
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "October"
            Dr.Item("UKEY") = 10
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "November"
            Dr.Item("UKEY") = 11
            DtStatus.Rows.Add(Dr)
            DtStatus.AcceptChanges()

            Dr = DtStatus.NewRow
            Dr.Item("NAME") = "December"
            Dr.Item("UKEY") = 12
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
                Populate.WriteColumn(dgvGrid, "cDescription", "DESCRIPTION", 180, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cYear", "YEAR", 60, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleCenter)
                Populate.WriteColumn(dgvGrid, "cAmount", "AMOUNT", 95, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)

                .Columns(0).ReadOnly = True
                .Columns("cDescription").ReadOnly = True
                .Columns("cDescription").DataPropertyName = "DESCRIPTION"

                .Columns("cYear").ReadOnly = True
                .Columns("cYear").DataPropertyName = "BYEAR"

                .Columns("cAmount").ReadOnly = True
                .Columns("cAmount").DataPropertyName = "AMOUNT"
                .Columns("cAmount").ValueType = GetType(Double)
                .Columns("cAmount").DefaultCellStyle.Format = "#,##0.00"

                Dim dgvcName As New DataGridViewComboBoxColumn
                dgvcName.Name = "cName"
                dgvcName.HeaderText = "NAME"
                dgvcName.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                dgvcName.FlatStyle = FlatStyle.Flat
                dgvcName.Width = 95
                dgvcName.DataPropertyName = "BUDGET"
                dgvcName.DataSource = dat.DefaultView
                dgvcName.DisplayMember = "Name"
                dgvcName.ValueMember = "Ukey"
                '.Columns.Add(dgvcName)
                .Columns.Insert(1, dgvcName)
                '.Columns("cStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Dim dgvcStatus As New DataGridViewComboBoxColumn
                dgvcStatus.Name = "cStatus"
                dgvcStatus.HeaderText = "STATUS"
                dgvcStatus.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                dgvcStatus.FlatStyle = FlatStyle.Flat
                dgvcStatus.Width = 65
                dgvcStatus.DataPropertyName = "ACTVE"
                dgvcStatus.DataSource = DtS.DefaultView
                dgvcStatus.DisplayMember = "Name"
                dgvcStatus.ValueMember = "Ukey"
                .Columns.Insert(3, dgvcStatus)
                '.Columns("cStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Dim dgvcMonth As New DataGridViewComboBoxColumn
                dgvcMonth.Name = "cMonth"
                dgvcMonth.HeaderText = "MONTH"
                dgvcMonth.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                dgvcMonth.FlatStyle = FlatStyle.Flat
                dgvcMonth.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvcMonth.Width = 85
                dgvcMonth.DataPropertyName = "BMONTH"
                dgvcMonth.DataSource = DtStatus.DefaultView
                dgvcMonth.DisplayMember = "Name"
                dgvcMonth.ValueMember = "Ukey"
                .Columns.Insert(4, dgvcMonth)
                '.Columns("cStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                '.DataSource = tblAllocation.DefaultView

                '.Columns("UKEY").Visible = False
                '.Columns("STATUS").Visible = False
                '.Columns("BDATE").Visible = False

                .Columns("cName").ReadOnly = True
                .Columns("cStatus").ReadOnly = True
                .Columns("cMonth").ReadOnly = True


                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable


            End With

            'WriteSerial(dgvGrid)

            'LoadGrid(dgvGrid)
        End Sub
        Private Sub WriteSerial(ByVal Grid As DataGridView)
            If Grid.Rows.Count > 0 Then
                Dim I As Integer
                For I = 0 To Grid.Rows.Count - 1
                    Grid.Rows(I).Cells("SN").Value = I + 1
                Next
            End If
        End Sub
        Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            With dgvGrid
                .BackgroundColor = Env.GirdBackgroundColor
                .RowsDefaultCellStyle.SelectionBackColor = Env.GirdSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Env.GirdSelectionForeColor
            End With

            LoadCombo()
            InitGrid()
            LoadGrid(dgvGrid)
            Disable()

        End Sub
        Private Function IsEditable() As Boolean
            'Dim str As String
            'Dim da As FbDataAdapter
            'Dim tbl As DataTable

            'Dim dBudget As Integer
            'Dim dYear As Integer
            'Dim dMonth As Integer

            'dBudget = cboBudget.SelectedValue
            'dYear = cboYear.SelectedIndex
            'dMonth = cboMonth.SelectedIndex

            'str = "SELECT * FROM TRANSACTIONS a WHERE a.BUDGET = '" & dBudget & "' AND a.BYEAR = '" & dYear & "' AND a.BMONTH = '" & dMonth & "'"
            'tbl = New DataTable

            'If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            'da = New FbDataAdapter(str, DB.ConnObj)
            'da.Fill(tbl)

            If tblAllocation.Rows.Count < 0 Or dgvGrid.CurrentRow.Index > tblAllocation.Rows.Count Then
                'MessageBox.Show("Transactions Has Been Made On This Budget. To Edit/Delete You Most Remove All Transactions.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            'Check if Row Is Selected
            If cboBudget.Text = "" Or cboYear.Text = "" Or cboMonth.Text = "" Then
                'MessageBox.Show("Please Select An Allocation Before You Delete.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            'Check if Row Is Selected
            If dgvGrid.CurrentRow.Index < 0 Then
                'MessageBox.Show("Please Select An Allocation Before You Delete.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            If tblAllocation.Rows(dgvGrid.CurrentRow.Index).Item("ACTVE") = "0" Then
                MessageBox.Show("This Allocation Has Been Processed. You Cannot Edit It.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            Return True
        End Function
        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            If Users.Privilege.EditAllocation = False Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If IsEditable() = False Then Exit Sub

            bolNewRec = False

            Enable()

        End Sub
        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            ClearRecord()
            tblAllocation.RejectChanges()
            LoadGrid(dgvGrid)
            Disable()
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

            Dim intYear As Integer
            Dim intMonth As Integer
            Dim intBudget As Integer
            Dim intRowIndex As Integer = dgvGrid.CurrentRow.Index
            Dim str As String
            Dim Comm As FbCommand

            If MessageBox.Show("Are You Sure You Want To Continue With The Current Transaction?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Try

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                If bolNewRec = True Then
                    Dim dr As DataRow
                    dr = tblAllocation.NewRow
                    toTable(dr)
                    tblAllocation.Rows.Add(dr)
                Else
                    intBudget = tblAllocation.Rows(intRowIndex).Item("BUDGET")
                    intYear = tblAllocation.Rows(intRowIndex).Item("BYEAR")
                    intMonth = tblAllocation.Rows(intRowIndex).Item("BMONTH")
                    toTable(tblAllocation.Rows(intRowIndex))
                End If

                'Budget.AcceptChanges()
                Dim RoIndex As Integer = dgvGrid.CurrentRow.Index
                daAllocation.Update(tblAllocation)

                str = "UPDATE TRANSACTIONS a SET a.BUDGET = '" & cboBudget.SelectedValue & "', a.BYEAR = '" & cboYear.Text & "', a.BMONTH = '" & cboMonth.SelectedIndex & "' WHERE a.BUDGET = '" & intBudget & "' AND a.BYEAR = '" & intYear & "' AND a.BMONTH = '" & intMonth & "'"
                Comm = New FbCommand
                Comm.Connection = DB.ConnObj
                Comm.CommandText = str
                Comm.ExecuteNonQuery()

                LoadGrid(dgvGrid)
                toForm(RoIndex)
                Disable()

                bolNewRec = False
            Catch ex As Exception
                'Tx.RollbackTransaction()
                'TransactionMgr.ThreadTransactionMgrReset()
                If ex.Message.Contains("UNQ") Then
                    MessageBox.Show(Messages.Duplicate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboBudget.Focus()
                ElseIf ex.Message.Contains("Check The Month") Then
                    MessageBox.Show("You Cannot Define Allocation That Is Earlier Than The Previous Allocations. Check The Month.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cboCategory.Focus()
                ElseIf ex.Message.Contains("Check The Year") Then
                    MessageBox.Show("You Cannot Define Allocation That Is Earlier Than The Previous Allocations. Check The Year.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cboYeargroup.Focus()
                Else
                    Throw ex
                End If

            End Try
        End Sub
        Private Function IsDeleteValid() As Boolean
            Dim str As String
            Dim da As FbDataAdapter
            Dim tbl As DataTable

            Dim dBudget As Integer
            Dim dYear As Integer
            Dim dMonth As Integer

            If cboBudget.Text <> "" Then dBudget = cboBudget.SelectedValue
            If cboYear.Text <> "" Then dYear = cboYear.Text
            If cboMonth.Text <> "" Then dMonth = cboMonth.SelectedIndex

            str = "SELECT * FROM TRANSACTIONS a WHERE a.BUDGET = '" & dBudget & "' AND a.BYEAR = '" & dYear & "' AND a.BMONTH = '" & dMonth & "'"
            tbl = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            'Check if Row Is Selected
            If cboBudget.Text = "" Then
                'MessageBox.Show("Please Select An Allocation Before You Delete.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            'Check if Row Is Selected
            If dgvGrid.CurrentRow.Index < 0 Then
                'MessageBox.Show("Please Select An Allocation Before You Delete.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            'Check If Payment Have Been Made With The
            If tbl.Rows.Count > 0 Then
                MessageBox.Show("Payment Has Been Made On This Allocation. You Cannot Delete This Allocation.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            Return True
        End Function
        Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
            If Users.Privilege.EditAllocation = False Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If IsDeleteValid() = False Then Exit Sub


            If MessageBox.Show(Messages.Delete, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub


            Try
  
                tblAllocation.Rows(dgvGrid.CurrentRow.Index).Delete()
                daAllocation.Update(tblAllocation)

                ClearRecord()
                LoadGrid(dgvGrid)
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
            'If cboBudget.Text <> "" Then Exit Sub

            ClearRecord()
            bolNewRec = True
            Enable()
        End Sub
        Private Sub dgvGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrid.CellClick
            If e.RowIndex = -1 Then Exit Sub
            ClearRecord()
            toForm(e.RowIndex)
        End Sub
    End Class
End Namespace