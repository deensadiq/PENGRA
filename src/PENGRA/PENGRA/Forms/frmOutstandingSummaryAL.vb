Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes


Namespace Forms

    Public Class frmOutstandingSummaryAL

        Dim Table As DataTable
        Dim Adapter As FbDataAdapter
        Dim strSQL As String

        Dim TableTotal As DataTable
        Dim daTotal As FbDataAdapter
        Dim strSQLTotal As String

        Private Sub IsEditMode(ByVal bolEdit As Boolean)
            If bolEdit = True Then
                'btnEdit.Enabled = False
                btnClose.Enabled = False

                'btnSave.Enabled = True
                'btnUndo.Enabled = True
                'ckbActive.Enabled = True

            ElseIf bolEdit = False Then
                'btnEdit.Enabled = True
                btnClose.Enabled = True

                'btnSave.Enabled = False
                'btnUndo.Enabled = False
                'ckbActive.Enabled = False
            End If
        End Sub

        Private Sub InitComponents()
            CreateSQLString()
            InitGrid()
            InitTotal()
        End Sub

        Private Sub CreateSQLString()
            strSQL = "SELECT p.AMONTH, p.AYEAR, (SUM(p.GRATUITY) - SUM(p.GRATUITYPAID)) AS GRATUITY, (SUM(p.PENSIONARREARS) - SUM(p.PEANSIONPAID)) AS PENSIONARREARS, "
            strSQL = strSQL + " (SUM(p.DEATHPENSION) - SUM(p.DEATHPAID)) AS DEATHPENSION, SUM(p.BALANCE) AS BALANCE"
            strSQL = strSQL + " FROM SP_BENEFICIARIES_ABOVELIMIT p WHERE p.STATUS = '2' GROUP BY p.AYEAR, p.AMONTH ORDER BY p.AYEAR, p.AMONTH"

            strSQLTotal = "SELECT (SUM(p.GRATUITY) - SUM(p.GRATUITYPAID)) AS GRATUITY, (SUM(p.PENSIONARREARS) - SUM(p.PEANSIONPAID)) AS PENSIONARREARS, "
            strSQLTotal = strSQLTotal + " (SUM(p.DEATHPENSION) - SUM(p.DEATHPAID)) AS DEATHPENSION, SUM(p.BALANCE) AS BALANCE"
            strSQLTotal = strSQLTotal + " FROM SP_BENEFICIARIES_ABOVELIMIT p WHERE p.STATUS = '2'"
        End Sub

        Public Sub LoadGrid(ByVal Grid As DataGridView)
            Dim iMonth As New Hashtable
            Table = New DataTable

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

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)

            Adapter.Fill(Table)

            If Table.Rows.Count = 0 Then Exit Sub

            Grid.RowCount = Table.Rows.Count

            Dim I As Integer



            For I = 0 To Table.Rows.Count - 1

                With Table.Rows(I)
                    Grid.Rows(I).Cells("cName").Value = iMonth.Item(CInt(.Item("AMONTH"))) & " " & .Item("AYEAR")
                    Grid.Rows(I).Cells("cGratuity").Value = .Item("GRATUITY")
                    Grid.Rows(I).Cells("cPension").Value = .Item("PENSIONARREARS")
                    Grid.Rows(I).Cells("cDeath").Value = .Item("DEATHPENSION")
                    Grid.Rows(I).Cells("cBalance").Value = .Item("BALANCE")
                End With
            Next

            With Grid

                'If Users.Privilege.KnockoffPayment = False Then .Columns("cEdit").Visible = False
                .Columns("cEdit").Visible = False
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
                Grid.Rows(I).Cells("cBalance").Value = TableTotal.Rows(I).Item("BALANCE")
            Next

            With Grid

                'If Users.Privilege.KnockoffPayment = False Then .Columns("cExtra").Visible = False
                .Columns("cExtra").Visible = False
            End With

        End Sub

        Private Sub InitGrid()
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
                .DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


                Populate.WriteSN(dgvGrid)
                Populate.WriteColumn(dgvGrid, "cName", "DESCRIPTION", 150, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cGratuity", "GRATUITY", 135, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cPension", "PENSION ARREARS", 135, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cDeath", "DEATH PENSION", 135, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvGrid, "cBalance", "BALANCE", 135, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)

                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True

                .Columns(2).ReadOnly = True
                .Columns(2).ValueType = GetType(Double)
                .Columns(2).DefaultCellStyle.Format = "#,##0.00"

                .Columns(3).ReadOnly = True
                .Columns(3).ValueType = GetType(Double)
                .Columns(3).DefaultCellStyle.Format = "#,##0.00"

                .Columns(4).ReadOnly = True
                .Columns(4).ValueType = GetType(Double)
                .Columns(4).DefaultCellStyle.Format = "#,##0.00"

                .Columns(5).ReadOnly = True
                .Columns(5).ValueType = GetType(Double)
                .Columns(5).DefaultCellStyle.Format = "#,##0.00"

                Dim bColEdit As New DataGridViewButtonColumn
                bColEdit.Name = "cEdit"
                bColEdit.HeaderText = ""
                bColEdit.ToolTipText = "Knock-Off Benefit"
                bColEdit.Width = 25
                bColEdit.FlatStyle = FlatStyle.System
                .Columns.Add(bColEdit)


                .Columns(6).ReadOnly = True
                '.Columns(7).ReadOnly = True
                '.Columns(14).DataPropertyName = "STATUS"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
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
                .DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


                Populate.WriteColumn(dgvTotal, "cTotal", "Total Benefit To Be Paid", 185, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvTotal, "cGratuity", "GRATUITY", 135, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cPension", "PENSION ARREARS", 135, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cDeath", "DEATH PENSION", 135, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cBalance", "BALANCE", 135, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)
                Populate.WriteColumn(dgvTotal, "cExtra", "", 25, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)

                .Columns(1).ValueType = GetType(Double)
                .Columns(1).DefaultCellStyle.Format = "#,##0.00"
                .Columns(2).ValueType = GetType(Double)
                .Columns(2).DefaultCellStyle.Format = "#,##0.00"
                .Columns(3).ValueType = GetType(Double)
                .Columns(3).DefaultCellStyle.Format = "#,##0.00"
                .Columns(4).ValueType = GetType(Double)
                .Columns(4).DefaultCellStyle.Format = "#,##0.00"

                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True
                .Columns(4).ReadOnly = True

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
        Private Sub setPrivilege()
            If Users.Privilege.GenerateSummaryReportAL = False Then
                btnPrint.Visible = False
            End If
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
                .RowsDefaultCellStyle.SelectionBackColor = Env.GirdSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Env.GirdSelectionForeColor
            End With

            InitComponents()

            IsEditMode(False)
            setPrivilege()

        End Sub

        Private Sub dgvGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrid.CellClick

            If e.RowIndex = -1 Then Exit Sub

            'Ignor clicks that are not on button cell
            If e.ColumnIndex > 0 And e.ColumnIndex = dgvGrid.Columns("cEdit").Index Then
                Dim rowNo As Integer = e.RowIndex
                Dim iYear As Integer = CInt(Table.Rows(rowNo).Item("AYEAR"))
                Dim iMonth As Integer = CInt(Table.Rows(rowNo).Item("AMONTH"))

                Dim form As New frmGroupKnockOff
                form.txtMinistry.Text = dgvGrid.Rows(rowNo).Cells("cName").Value
                form.txtAYear.Text = iYear
                form.txtAMonth.Text = iMonth
                form.txtBalance.Text = Format(CDbl(Table.Rows(rowNo).Item("BALANCE")), "#,##0.00")
                'form.txtTransactionNo.Text = dgvGrid.Rows(rowNo).Cells("cName").Value
                form.txtKnockoffAmount.Text = Format(CDbl(Table.Rows(rowNo).Item("BALANCE")), "#,##0.00")
                form.LoadData(iYear, iMonth)
                form.ShowDialog(Me)
                InitGrid()
            End If

        End Sub

        Private Sub dgvGrid_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvGrid.CellPainting
            If e.RowIndex = -1 Or e.ColumnIndex < 0 Then Return

            Dim img As Image
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            'Ignor clicks that are not on button cell
            If e.ColumnIndex = dgvGrid.Columns("cEdit").Index Then


                'img = Image.FromFile("E:\Projects\PENGRA\graphics\edit.png")
                img = CType(My.Resources.edit, Image)
                e.Graphics.DrawImage(img, e.CellBounds.Left + 3, e.CellBounds.Top + 2, 17, 17)
                e.Handled = True
            End If

        End Sub

        Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
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
                .SummaryofBeneficiariesReport(False)
            End With
        End Sub
    End Class
End Namespace