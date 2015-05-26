Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes
Imports PENGRA.crsDataGridView

Namespace Forms
    Public Class frmAboveLimit
        Dim I As Integer
        Dim mStruc As Integer
        Dim mType As Integer
        Dim mAllow As Integer
        Dim mAppt As Integer

        Dim iBenefit As Integer
        Dim iYear As Integer
        Dim iMonth As Integer

        Dim Employee As DataTable
        Dim daEmployee As FbDataAdapter
        Dim cmdEmployee As New FbCommandBuilder
        Dim strEmployee As String

        Dim Table As DataTable
        Dim Adapter As FbDataAdapter
        Dim strSQL As String

        Dim TableTotal As DataTable
        Dim daTotal As FbDataAdapter
        Dim strSQLTotal As String

        Private Sub LoadCombo()
            Populate.comboBox(cboBenefit, "SELECT * FROM BENEFIT")
            Populate.GetYear(cboYear)
            Populate.GetMonth(cboMonth)
        End Sub

        Private Sub IsEditMode(ByVal bolEdit As Boolean)
            If bolEdit = True Then
                btnEdit.Enabled = False
                btnClose.Enabled = False

                btnSave.Enabled = True
                btnUndo.Enabled = True
                'ckbActive.Enabled = True

            ElseIf bolEdit = False Then
                btnEdit.Enabled = True
                btnClose.Enabled = True

                btnSave.Enabled = False
                btnUndo.Enabled = False
                'ckbActive.Enabled = False
            End If
        End Sub

        Private Sub InitComponents()
            CreateSQLString()
            InitGrid()
            InitTotal()
        End Sub

        Private Sub CreateSQLString()
            iBenefit = 0
            iYear = 0
            iMonth = 0

            If Not cboBenefit.Text = "" Then iBenefit = cboBenefit.SelectedValue
            If Not cboYear.Text = "" Then iYear = CInt(cboYear.Text.Trim)
            If Not cboMonth.Text = "" Then iMonth = cboMonth.SelectedIndex

            If iBenefit = 0 And iYear = 0 And iMonth = 0 Then
                'No Filter Attribute: Load All Data From Table
                strSQL = "SELECT p.SN, p.ID, p.EMPLOYEE, p.EMPLOYEENAME, p.MINISTRYNAME, p.BTYPE, p.TRANSTYPE, p.AYEAR, p.AMONTH, "
                strSQL = strSQL + " p.MONTHNAME || ' ' || P.AYEAR AS DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT,"
                strSQL = strSQL + " p.GRATUITYPAID, p.PEANSIONPAID, p.DEATHPAID, p.TOTALPAID, p.BALANCE, p.STATUS FROM SP_BENEFICIARIES_ABOVELIMIT p "
                strSQL = strSQL + " ORDER BY p.AYEAR DESC, p.AMONTH DESC, p.EMPLOYEENAME"

                strSQLTotal = "SELECT SUM(p.GRATUITY) AS GRATUITY, SUM(p.PENSIONARREARS) AS PENSIONARREARS, SUM(p.DEATHPENSION) AS DEATHPENSION, SUM(p.TOTALBENEFIT) AS TOTALBENEFIT, "
                strSQLTotal = strSQLTotal + " SUM(p.GRATUITYPAID) AS GRATUITYPAID, SUM(p.PEANSIONPAID) AS PEANSIONPAID, SUM(p.DEATHPAID) AS DEATHPAID, SUM(p.TOTALPAID) AS TOTALPAID, SUM(p.BALANCE) AS BALANCE"
                strSQLTotal = strSQLTotal + " FROM SP_BENEFICIARIES_ABOVELIMIT p"

                strEmployee = "SELECT * FROM EMPLOYEEINFO WHERE LIMIT = '0' AND ACTVE = '1' ORDER BY EXTRACT(YEAR FROM DOAA) DESC, EXTRACT(MONTH FROM DOAA) DESC"

            ElseIf iBenefit <> 0 And iYear = 0 And iMonth = 0 Then
                'Apply Benefit Type Filter
                strSQL = "SELECT p.SN, p.ID, p.EMPLOYEE, p.EMPLOYEENAME, p.MINISTRYNAME, p.BTYPE, p.TRANSTYPE, p.AYEAR, p.AMONTH, "
                strSQL = strSQL + " p.MONTHNAME || ' ' || P.AYEAR AS DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT,"
                strSQL = strSQL + " p.GRATUITYPAID, p.PEANSIONPAID, p.DEATHPAID, p.TOTALPAID, p.BALANCE, p.STATUS FROM SP_BENEFICIARIES_ABOVELIMIT p "
                strSQL = strSQL + " WHERE p.BTYPE = '" & iBenefit & "' ORDER BY p.AYEAR DESC, p.AMONTH DESC, p.EMPLOYEENAME"

                strSQLTotal = "SELECT SUM(p.GRATUITY) AS GRATUITY, SUM(p.PENSIONARREARS) AS PENSIONARREARS, SUM(p.DEATHPENSION) AS DEATHPENSION, SUM(p.TOTALBENEFIT) AS TOTALBENEFIT, "
                strSQLTotal = strSQLTotal + " SUM(p.GRATUITYPAID) AS GRATUITYPAID, SUM(p.PEANSIONPAID) AS PEANSIONPAID, SUM(p.DEATHPAID) AS DEATHPAID, SUM(p.TOTALPAID) AS TOTALPAID, SUM(p.BALANCE) AS BALANCE"
                strSQLTotal = strSQLTotal + " FROM SP_BENEFICIARIES_ABOVELIMIT p WHERE p.BTYPE = '" & iBenefit & "'"

                strEmployee = "SELECT * FROM EMPLOYEEINFO WHERE LIMIT = '0' AND ACTVE = '1' AND BENEFITTYPE = '" & iBenefit & "'"

            ElseIf iBenefit = 0 And iYear <> 0 And iMonth = 0 Then

                strSQL = "SELECT p.SN, p.ID, p.EMPLOYEE, p.EMPLOYEENAME, p.MINISTRYNAME, p.BTYPE, p.TRANSTYPE, p.AYEAR, p.AMONTH, "
                strSQL = strSQL + " p.MONTHNAME || ' ' || P.AYEAR AS DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT,"
                strSQL = strSQL + " p.GRATUITYPAID, p.PEANSIONPAID, p.DEATHPAID, p.TOTALPAID, p.BALANCE, p.STATUS FROM SP_BENEFICIARIES_ABOVELIMIT p "
                strSQL = strSQL + " WHERE p.AYEAR = '" & iYear & "' ORDER BY p.AYEAR DESC, p.AMONTH DESC, p.EMPLOYEENAME"

                strSQLTotal = "SELECT SUM(p.GRATUITY) AS GRATUITY, SUM(p.PENSIONARREARS) AS PENSIONARREARS, SUM(p.DEATHPENSION) AS DEATHPENSION, SUM(p.TOTALBENEFIT) AS TOTALBENEFIT, "
                strSQLTotal = strSQLTotal + " SUM(p.GRATUITYPAID) AS GRATUITYPAID, SUM(p.PEANSIONPAID) AS PEANSIONPAID, SUM(p.DEATHPAID) AS DEATHPAID, SUM(p.TOTALPAID) AS TOTALPAID, SUM(p.BALANCE) AS BALANCE"
                strSQLTotal = strSQLTotal + " FROM SP_BENEFICIARIES_ABOVELIMIT p WHERE p.AYEAR = '" & iYear & "'"

                strEmployee = "SELECT * FROM EMPLOYEEINFO WHERE LIMIT = '0' AND ACTVE = '1' AND EXTRACT(YEAR FROM DOAA) = '" & iYear & "'"

            ElseIf iBenefit <> 0 And iYear <> 0 And iMonth = 0 Then

                strSQL = "SELECT p.SN, p.ID, p.EMPLOYEE, p.EMPLOYEENAME, p.MINISTRYNAME, p.BTYPE, p.TRANSTYPE, p.AYEAR, p.AMONTH, "
                strSQL = strSQL + " p.MONTHNAME || ' ' || P.AYEAR AS DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT,"
                strSQL = strSQL + " p.GRATUITYPAID, p.PEANSIONPAID, p.DEATHPAID, p.TOTALPAID, p.BALANCE, p.STATUS FROM SP_BENEFICIARIES_ABOVELIMIT p "
                strSQL = strSQL + " WHERE p.BTYPE = '" & iBenefit & "' AND p.AYEAR = '" & iYear & "' ORDER BY p.AYEAR DESC, p.AMONTH DESC, p.EMPLOYEENAME"

                strSQLTotal = "SELECT SUM(p.GRATUITY) AS GRATUITY, SUM(p.PENSIONARREARS) AS PENSIONARREARS, SUM(p.DEATHPENSION) AS DEATHPENSION, SUM(p.TOTALBENEFIT) AS TOTALBENEFIT, "
                strSQLTotal = strSQLTotal + " SUM(p.GRATUITYPAID) AS GRATUITYPAID, SUM(p.PEANSIONPAID) AS PEANSIONPAID, SUM(p.DEATHPAID) AS DEATHPAID, SUM(p.TOTALPAID) AS TOTALPAID, SUM(p.BALANCE) AS BALANCE"
                strSQLTotal = strSQLTotal + " FROM SP_BENEFICIARIES_ABOVELIMIT p WHERE p.BTYPE = '" & iBenefit & "' AND p.AYEAR = '" & iYear & "'"

                strEmployee = "SELECT * FROM EMPLOYEEINFO WHERE LIMIT = '0' AND ACTVE = '1' AND BENEFITTYPE = '" & iBenefit & "' AND EXTRACT(YEAR FROM DOAA) = '" & iYear & "'"

            ElseIf iBenefit = 0 And iYear <> 0 And iMonth <> 0 Then

                strSQL = "SELECT p.SN, p.ID, p.EMPLOYEE, p.EMPLOYEENAME, p.MINISTRYNAME, p.BTYPE, p.TRANSTYPE, p.AYEAR, p.AMONTH, "
                strSQL = strSQL + " p.MONTHNAME || ' ' || P.AYEAR AS DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT,"
                strSQL = strSQL + " p.GRATUITYPAID, p.PEANSIONPAID, p.DEATHPAID, p.TOTALPAID, p.BALANCE, p.STATUS FROM SP_BENEFICIARIES_ABOVELIMIT p "
                strSQL = strSQL + " WHERE p.AYEAR = '" & iYear & "' AND p.AMONTH = '" & iMonth & "' ORDER BY p.AYEAR DESC, p.AMONTH DESC, p.EMPLOYEENAME"

                strSQLTotal = "SELECT SUM(p.GRATUITY) AS GRATUITY, SUM(p.PENSIONARREARS) AS PENSIONARREARS, SUM(p.DEATHPENSION) AS DEATHPENSION, SUM(p.TOTALBENEFIT) AS TOTALBENEFIT, "
                strSQLTotal = strSQLTotal + " SUM(p.GRATUITYPAID) AS GRATUITYPAID, SUM(p.PEANSIONPAID) AS PEANSIONPAID, SUM(p.DEATHPAID) AS DEATHPAID, SUM(p.TOTALPAID) AS TOTALPAID, SUM(p.BALANCE) AS BALANCE"
                strSQLTotal = strSQLTotal + " FROM SP_BENEFICIARIES_ABOVELIMIT p WHERE p.AYEAR = '" & iYear & "' AND p.AMONTH = '" & iMonth & "'"

                strEmployee = "SELECT * FROM EMPLOYEEINFO WHERE LIMIT = '0' AND ACTVE = '1' AND EXTRACT(YEAR FROM DOAA) = '" & iYear & "' AND EXTRACT(MONTH FROM DOAA) = '" & iMonth & "'"

            ElseIf iBenefit <> 0 And iYear <> 0 And iMonth <> 0 Then

                strSQL = "SELECT p.SN, p.ID, p.EMPLOYEE, p.EMPLOYEENAME, p.MINISTRYNAME, p.BTYPE, p.TRANSTYPE, p.AYEAR, p.AMONTH, "
                strSQL = strSQL + " p.MONTHNAME || ' ' || P.AYEAR AS DESCRIPTION, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT,"
                strSQL = strSQL + " p.GRATUITYPAID, p.PEANSIONPAID, p.DEATHPAID, p.TOTALPAID, p.BALANCE, p.STATUS FROM SP_BENEFICIARIES_ABOVELIMIT p "
                strSQL = strSQL + " WHERE p.BTYPE = '" & iBenefit & "' AND p.AYEAR = '" & iYear & "' AND p.AMONTH = '" & iMonth & "' ORDER BY p.AYEAR DESC, p.AMONTH DESC, p.EMPLOYEENAME"

                strSQLTotal = "SELECT SUM(p.GRATUITY) AS GRATUITY, SUM(p.PENSIONARREARS) AS PENSIONARREARS, SUM(p.DEATHPENSION) AS DEATHPENSION, SUM(p.TOTALBENEFIT) AS TOTALBENEFIT, "
                strSQLTotal = strSQLTotal + " SUM(p.GRATUITYPAID) AS GRATUITYPAID, SUM(p.PEANSIONPAID) AS PEANSIONPAID, SUM(p.DEATHPAID) AS DEATHPAID, SUM(p.TOTALPAID) AS TOTALPAID, SUM(p.BALANCE) AS BALANCE"
                strSQLTotal = strSQLTotal + " FROM SP_BENEFICIARIES_ABOVELIMIT p WHERE p.BTYPE = '" & iBenefit & "' AND p.AYEAR = '" & iYear & "' AND p.AMONTH = '" & iMonth & "'"

                strEmployee = "SELECT * FROM EMPLOYEEINFO WHERE LIMIT = '0' AND ACTVE = '1' AND BENEFITTYPE = '" & iBenefit & "' AND EXTRACT(YEAR FROM DOAA) = '" & iYear & "' AND EXTRACT(MONTH FROM DOAA) = '" & iMonth & "'"

            End If

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
                    If .Item("STATUS") = Env.GetStatus Then Grid.Rows(I).Cells("chk").Value = True Else Grid.Rows(I).Cells("chk").Value = False

                End With
            Next

            With Grid

                If iBenefit = 1 Then
                    .Columns("cDeath").Visible = False
                    .Columns("cDPP").Visible = False
                End If
                If iBenefit = 2 Then
                    .Columns("cPension").Visible = False
                    .Columns("cPAP").Visible = False
                End If

            End With

            WriteSerial(Grid)

        End Sub

        Private Sub LoadTotal(ByVal Grid As DataGridView)
            TableTotal = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            daTotal = New FbDataAdapter(strSQLTotal, DB.ConnObj)

            daTotal.Fill(TableTotal)

            If TableTotal.Rows.Count = 0 Then Exit Sub

            Grid.RowCount = TableTotal.Rows.Count

            Dim I As Integer
            For I = 0 To TableTotal.Rows.Count - 1
                Grid.Rows(I).Cells("cTotal").Value = "              Total"
                Grid.Rows(I).Cells("cGratuity").Value = TableTotal.Rows(I).Item("GRATUITY")
                Grid.Rows(I).Cells("cPension").Value = TableTotal.Rows(I).Item("PENSIONARREARS")
                Grid.Rows(I).Cells("cDeath").Value = TableTotal.Rows(I).Item("DEATHPENSION")
                Grid.Rows(I).Cells("cBenefit").Value = TableTotal.Rows(I).Item("TOTALBENEFIT")
                Grid.Rows(I).Cells("cGP").Value = TableTotal.Rows(I).Item("GRATUITYPAID")
                Grid.Rows(I).Cells("cPAP").Value = TableTotal.Rows(I).Item("PEANSIONPAID")
                Grid.Rows(I).Cells("cDPP").Value = TableTotal.Rows(I).Item("DEATHPAID")
                Grid.Rows(I).Cells("cPAID").Value = TableTotal.Rows(I).Item("TOTALPAID")
                Grid.Rows(I).Cells("cBalance").Value = TableTotal.Rows(I).Item("BALANCE")
            Next

            With Grid

                If iBenefit = 1 Then
                    .Columns("cDeath").Visible = False
                    .Columns("cDPP").Visible = False
                End If
                If iBenefit = 2 Then
                    .Columns("cPension").Visible = False
                    .Columns("cPAP").Visible = False
                End If

            End With

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
                .Rows.Clear()
                .Columns.Clear()
                .ColumnHeadersHeight = 35
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 129, 207)
                .ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.Window
                .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToOrderColumns = False
                .AllowUserToResizeColumns = False

                .EnableHeadersVisualStyles = False
                .BorderStyle = BorderStyle.FixedSingle
                .DefaultCellStyle.BackColor = Color.WhiteSmoke
                .CellBorderStyle = DataGridViewCellBorderStyle.Single
                .DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


                Populate.WriteSN(dgvGrid)
                Populate.WriteColumn(dgvGrid, "cId", "PN No", 65, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cName", "NAME OF BENEFICIARY", 150, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cMinistry", "MINISTRY", 80, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cDate", "DATE", 60, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleCenter)
                Populate.WriteColumn(dgvGrid, "cGratuity", "GRATUITY", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cPension", "PENSION ARREARS", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cDeath", "DEATH PENSION", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cBenefit", "TOTAL BANEFIT", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cGP", "GRATUITY PAID", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cPAP", "PENSION ARREARS PAID", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cDPP", "DEATH PENSION PAID", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cPAID", "TOTAL BANEFIT PAID", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cBalance", "BALANCE", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                'Populate.WriteColumn(dgvGrid, "cStatus", "STATUS", 50, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                'Populate.WriteColumn(dgvGrid, "cGL", "GRADE LEVEL", 75, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)

                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True
                .Columns(4).ReadOnly = True

                .Columns(5).ReadOnly = True
                .Columns(5).ValueType = GetType(Double)
                .Columns(5).DefaultCellStyle.Format = "#,##0.00"

                .Columns(6).ReadOnly = True
                .Columns(6).ValueType = GetType(Double)
                .Columns(6).DefaultCellStyle.Format = "#,##0.00"

                .Columns(7).ReadOnly = True
                .Columns(7).ValueType = GetType(Double)
                .Columns(7).DefaultCellStyle.Format = "#,##0.00"

                .Columns(8).ReadOnly = True
                .Columns(8).ValueType = GetType(Double)
                .Columns(8).DefaultCellStyle.Format = "#,##0.00"

                .Columns(9).ReadOnly = True
                .Columns(9).ValueType = GetType(Double)
                .Columns(9).DefaultCellStyle.Format = "#,##0.00"

                .Columns(10).ReadOnly = True
                .Columns(10).ValueType = GetType(Double)
                .Columns(10).DefaultCellStyle.Format = "#,##0.00"

                .Columns(11).ReadOnly = True
                .Columns(11).ValueType = GetType(Double)
                .Columns(11).DefaultCellStyle.Format = "#,##0.00"

                .Columns(12).ReadOnly = True
                .Columns(12).ValueType = GetType(Double)
                .Columns(12).DefaultCellStyle.Format = "#,##0.00"

                .Columns(13).ReadOnly = True
                .Columns(13).ValueType = GetType(Double)
                .Columns(13).DefaultCellStyle.Format = "#,##0.00"

                Dim cbCol As New DataGridViewComboBoxColumn
                cbCol.Name = "cStatus"
                cbCol.HeaderText = "STATUS"
                cbCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                cbCol.FlatStyle = FlatStyle.Flat
                cbCol.Width = 65
                cbCol.DisplayMember = "Name"
                cbCol.ValueMember = "Ukey"
                cbCol.DataPropertyName = "STATUS"
                cbCol.DataSource = DtStatus.DefaultView
                .Columns.Add(cbCol)
                .Columns("cStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Populate.WriteCheckBox(dgvGrid, "chk", "", "", 25, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleCenter)

                Dim bCol As New DataGridViewButtonColumn
                bCol.Name = "cDetails"
                bCol.HeaderText = ""
                bCol.ToolTipText = "View Details"
                bCol.Width = 25
                bCol.FlatStyle = FlatStyle.System
                .Columns.Add(bCol)

                Dim bColEdit As New DataGridViewButtonColumn
                bColEdit.Name = "cEdit"
                bColEdit.HeaderText = ""
                bColEdit.ToolTipText = "Knock-Off Benefit"
                bColEdit.Width = 25
                bColEdit.FlatStyle = FlatStyle.System
                .Columns.Add(bColEdit)


                .Columns(14).ReadOnly = True
                .Columns(15).ReadOnly = True
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
                .Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(12).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(13).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(14).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(15).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(16).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(17).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(18).SortMode = DataGridViewColumnSortMode.NotSortable
                '.Columns(18).SortMode = DataGridViewColumnSortMode.NotSortable

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
                .DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


                Populate.WriteColumn(dgvTotal, "cTotal", "Total Benefit To Be Paid", 390, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvTotal, "cGratuity", "GRATUITY", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cPension", "PENSION ARREARS", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cDeath", "DEATH PENSION", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cBenefit", "TOTAL BANEFIT", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cGP", "GRATUITY PAID", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cPAP", "PENSION ARREARS PAID", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cDPP", "DEATH PENSION PAID", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cPAID", "TOTAL BANEFIT PAID", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cBalance", "BALANCE", 85, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cAppend", "", 140, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)

                .Columns(1).ValueType = GetType(Double)
                .Columns(1).DefaultCellStyle.Format = "#,##0.00"
                .Columns(2).ValueType = GetType(Double)
                .Columns(2).DefaultCellStyle.Format = "#,##0.00"
                .Columns(3).ValueType = GetType(Double)
                .Columns(3).DefaultCellStyle.Format = "#,##0.00"
                .Columns(4).ValueType = GetType(Double)
                .Columns(4).DefaultCellStyle.Format = "#,##0.00"
                .Columns(5).ValueType = GetType(Double)
                .Columns(5).DefaultCellStyle.Format = "#,##0.00"
                .Columns(6).ValueType = GetType(Double)
                .Columns(6).DefaultCellStyle.Format = "#,##0.00"
                .Columns(7).ValueType = GetType(Double)
                .Columns(7).DefaultCellStyle.Format = "#,##0.00"
                .Columns(8).ValueType = GetType(Double)
                .Columns(8).DefaultCellStyle.Format = "#,##0.00"
                .Columns(9).ValueType = GetType(Double)
                .Columns(9).DefaultCellStyle.Format = "#,##0.00"

                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True
                .Columns(4).ReadOnly = True
                .Columns(5).ReadOnly = True
                .Columns(6).ReadOnly = True
                .Columns(7).ReadOnly = True
                .Columns(8).ReadOnly = True
                .Columns(9).ReadOnly = True
                .Columns(10).ReadOnly = True

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

                    Select Case Table.Rows(I).Item("STATUS").ToString
                        Case "0"
                            Grid.Rows(I).Cells("cStatus").Style.ForeColor = Color.Red
                        Case "1"
                            Grid.Rows(I).Cells("cStatus").Style.ForeColor = Color.Blue
                        Case "2"
                            Grid.Rows(I).Cells("cStatus").Style.ForeColor = Color.Green
                        Case "3"
                            Grid.Rows(I).Cells("cStatus").Style.ForeColor = Color.Black
                    End Select
                    Grid.UpdateCellValue(14, I)
                Next
            End If
        End Sub
        Public Sub displayInfo(ByVal struc As String, ByVal allow As String)
            'txtPaygroup.Text = struc
            'txtType.Text = allow
            'txtAppt.Text = appt
        End Sub
        Private Sub setPrivilege()
            If Users.Privilege.EditRetireeStatus = False Then
                btnEdit.Visible = False
                btnSave.Visible = False
                btnUndo.Visible = False
            End If

            If Users.Privilege.GenerateOustandingReport = False Then
                btnPrint.Visible = False
            End If
        End Sub

        Private Sub frmSalaryTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor

            'Me.Icon = Nothing
            With dgvGrid
                .BackgroundColor = Env.GirdBackgroundColor
                '.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent
                '.RowsDefaultCellStyle.SelectionForeColor = Color.Transparent
            End With

            With dgvTotal
                .BackgroundColor = Env.GirdBackgroundColor
                .RowsDefaultCellStyle.SelectionBackColor = Color.Transparent
                .RowsDefaultCellStyle.SelectionForeColor = Color.Transparent
            End With

            LoadCombo()

            InitComponents()

            IsEditMode(False)
            setPrivilege()

            'WriteStatus(dgvGrid)
        End Sub

        Private Sub dgvGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrid.CellClick
            If e.RowIndex = -1 Then Exit Sub
            If Table.Rows.Count = 0 Then Exit Sub

            'Ignor clicks that are not on button cell
            If e.RowIndex >= 0 And e.ColumnIndex = dgvGrid.Columns("cEdit").Index Then
                Dim rowNo As Integer = e.RowIndex + 1

                'MsgBox("Inside Action Button " & rowNo.ToString)

                'If status Has Not Been Approve Knock-off Cannot Not Be Process
                If CInt(Table.Rows(e.RowIndex).Item("STATUS")) < 2 Then
                    MessageBox.Show("This Transaction Has To Be Approved Before Any Forther Transaction Can Be Performed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                Dim Employee As Integer = Table.Rows(e.RowIndex).Item("EMPLOYEE")
                Dim form As New frmLimitKnockOff
                form.btnSearch.Visible = False
                form.LoadData(Employee)
                form.ShowDialog(Me)
                InitGrid()
            End If

            'Ignor clicks that are not on button cell
            If e.RowIndex >= 0 And e.ColumnIndex = dgvGrid.Columns("cDetails").Index Then
                Dim rowNo As Integer = e.RowIndex + 1

                'MsgBox("Inside Action Button " & rowNo.ToString)

                'If status Has Not Been Approve Knock-off Cannot Not Be Process
                If CInt(Table.Rows(e.RowIndex).Item("STATUS")) < 2 Then
                    MessageBox.Show("This Transaction Has To Be Approved Before Any Forther Transaction Can Be Performed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                Dim Employee As Integer = Table.Rows(e.RowIndex).Item("EMPLOYEE")
                Dim form As New frmPaymentProfile
                form.btnSearch.Visible = False
                form.LoadRecord(Employee)
                form.ShowDialog(Me)
            End If

        End Sub

        Private Sub dgvGrid_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvGrid.CellPainting

            If e.ColumnIndex < 0 Or e.RowIndex = -1 Then Return

            Dim img As Image
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            If e.RowIndex >= 0 And e.ColumnIndex = dgvGrid.Columns("cStatus").Index Then

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


            'Ignor clicks that are not on button cell
            If e.ColumnIndex = dgvGrid.Columns("cEdit").Index Then


                'img = Image.FromFile("E:\Projects\PENGRA\graphics\edit.png")
                img = CType(My.Resources.edit, Image)
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 2, 17, 17)
                e.Handled = True
            End If

            If e.ColumnIndex = dgvGrid.Columns("cDetails").Index Then

                'img = Image.FromFile("E:\Projects\PENGRA\graphics\details.png")
                img = CType(My.Resources.details, Image)
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 2, 17, 17)
                e.Handled = True
            End If


        End Sub

        Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub cboBenefit_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBenefit.SelectedValueChanged
            'If cboBenefit.Text = "" Then Exit Sub
            'If Table.Rows.Count = 0 Then Exit Sub

            Try
                InitComponents()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub cboYear_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboYear.SelectedValueChanged
            'If cboBenefit.Text = "" Then Exit Sub
            'If Table.Rows.Count = 0 Then Exit Sub

            Try
                InitComponents()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub cboMonth_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedValueChanged
            If cboYear.Text = "" Then Exit Sub
            'If Table.Rows.Count = 0 Then Exit Sub

            Try
                InitComponents()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            If dgvGrid.Rows.Count = 0 Then Exit Sub
            dgvGrid.Columns("chk").ReadOnly = False
            IsEditMode(True)
        End Sub

        Private Function IsValid() As Boolean
            Return True
        End Function

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            If IsValid() = False Then Exit Sub

            If MessageBox.Show("Are You Sure You Want To Continue With The Current Process?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Try

                Dim I As Integer
                Dim k As Integer
                For I = 0 To dgvGrid.RowCount - 1
                    If dgvGrid.Rows(I).Cells("chk").Value = True Or dgvGrid.Rows(I).Cells("chk").Value = 1 Then
                        'Employee.Rows(I).Item("STATUS") = Env.GetStatus
                        For k = 0 To Employee.Rows.Count - 1
                            If (Employee.Rows(k).Item("UKEY") = Table.Rows(I).Item("Employee")) Then
                                Employee.Rows(k).Item("STATUS") = Env.GetStatus
                                Exit For
                            End If
                        Next
                    Else
                        'Employee.Rows(I).Item("STATUS") = "0"
                        For k = 0 To Employee.Rows.Count - 1
                            If (Employee.Rows(k).Item("UKEY") = Table.Rows(I).Item("Employee")) Then
                                Employee.Rows(k).Item("STATUS") = "0"
                                Exit For
                            End If
                        Next
                    End If
                Next
                daEmployee.Update(Employee)
                InitComponents()
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

        Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
            InitComponents()
            IsEditMode(False)
        End Sub

        Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
            If dgvGrid.RowCount = 0 Then Exit Sub

            Dim Report As New PENGRA.Reports.Classes.myReport

            With Report
                '.Budget = Budget
                '.BudgetYear = BYear
                '.BudgetMonth = BMonth
                '.Title = BMonth.ToString + "/" + BYear.ToString
                .Parent = Me.MdiParent
                .ReportTitle = "Month Payment Details"
                .OutstandingBeneficiariesReport(False, strSQL)
            End With
        End Sub
    End Class
End Namespace