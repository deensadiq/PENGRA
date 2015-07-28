Imports FirebirdSql.Data.FirebirdClient

Namespace Classes

    Public Class Populate
        Shared Adapter As FbDataAdapter
        Shared Table As DataTable

        Public Shared RoleName As Hashtable

        Public Shared Sub comboBox(ByVal cbo As ComboBox, ByVal strSQL As String)
            Table = New DataTable

            cbo.DataSource = Nothing

            Dim Dr As DataRow

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Adapter.Fill(Table)

            Dr = Table.NewRow
            Dr.Item("NAME") = ""
            Dr.Item("UKEY") = "0"
            Table.Rows.InsertAt(Dr, 0)

            'If Not Table.Rows.Count > 0 Then Exit Sub
            replaceDoubleApostrophe(Table, "NAME")

            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "UKEY"
            cbo.DropDownStyle = ComboBoxStyle.DropDownList
            cbo.DataSource = Table.DefaultView
        End Sub

        Public Shared Sub comboBoxBudget(ByVal cbo As ComboBox)
            Dim strSQL As String

            Table = New DataTable

            cbo.DataSource = Nothing

            Dim Dr As DataRow

            strSQL = "SELECT * FROM BUDGET a WHERE a.UKEY IN (SELECT a.BUDGET FROM BUDGETING a where a.ACTVE = '1')"

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Adapter.Fill(Table)

            Dr = Table.NewRow
            Dr.Item("NAME") = ""
            Dr.Item("UKEY") = "0"
            Table.Rows.InsertAt(Dr, 0)

            'If Not Table.Rows.Count > 0 Then Exit Sub
            replaceDoubleApostrophe(Table, "NAME")

            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "UKEY"
            cbo.DropDownStyle = ComboBoxStyle.DropDownList
            cbo.DataSource = Table.DefaultView
        End Sub

        Public Shared Sub WeekDays(ByVal cbo As ComboBox)

            cbo.DataSource = Nothing

            Dim Dr As DataRow
            Dim Dt As New DataTable

            Dt.Columns.Add("NAME", GetType(String))
            Dt.Columns.Add("UKEY", GetType(Short))

            Dr = Dt.NewRow
            Dr.Item("NAME") = ""
            Dr.Item("UKEY") = "-1"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Monday"
            Dr.Item("UKEY") = "1"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Tuesday"
            Dr.Item("UKEY") = "2"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Wednesday"
            Dr.Item("UKEY") = "3"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Thursday"
            Dr.Item("UKEY") = "4"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Friday"
            Dr.Item("UKEY") = "5"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Saturday"
            Dr.Item("UKEY") = "6"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Sunday"
            Dr.Item("UKEY") = "0"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "UKEY"
            cbo.DropDownStyle = ComboBoxStyle.DropDownList
            cbo.DataSource = Dt.DefaultView
        End Sub

        Public Shared Sub WeekDays(ByRef cbo As DataGridViewComboBoxColumn)

            cbo.DataSource = Nothing

            Dim Dr As DataRow
            Dim Dt As New DataTable

            Dt.Columns.Add("NAME", GetType(String))
            Dt.Columns.Add("UKEY", GetType(Short))

            Dr = Dt.NewRow
            Dr.Item("NAME") = ""
            Dr.Item("UKEY") = "-1"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Monday"
            Dr.Item("UKEY") = "1"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Tuesday"
            Dr.Item("UKEY") = "2"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Wednesday"
            Dr.Item("UKEY") = "3"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Thursday"
            Dr.Item("UKEY") = "4"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Friday"
            Dr.Item("UKEY") = "5"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Saturday"
            Dr.Item("UKEY") = "6"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Sunday"
            Dr.Item("UKEY") = "0"
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "UKEY"
            cbo.DataSource = Dt.DefaultView
        End Sub

        Public Shared Sub GetYear(ByVal cbo As ComboBox)
            Dim I As Integer
            cbo.Items.Clear()
            cbo.Items.Add("")
            For I = 2014 To Now.Year + 1
                cbo.Items.Add(I.ToString)
            Next

            cbo.DropDownStyle = ComboBoxStyle.DropDownList
            cbo.Text = cbo.Items(0)
        End Sub

        Public Shared Sub GetBudgetYear(ByVal cbo As ComboBox)
            Dim strSQL As String

            Table = New DataTable

            strSQL = "SELECT a.BYEAR FROM BUDGETING a where a.ACTVE = '1'"

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

            cbo.DropDownStyle = ComboBoxStyle.DropDownList
            cbo.Text = cbo.Items(0)
        End Sub

        Public Shared Sub GetMonth(ByVal cbo As ComboBox)

            cbo.Items.Clear()
            cbo.Items.Add("")
            cbo.Items.Add("January")
            cbo.Items.Add("February")
            cbo.Items.Add("March")
            cbo.Items.Add("April")
            cbo.Items.Add("May")
            cbo.Items.Add("June")
            cbo.Items.Add("July")
            cbo.Items.Add("August")
            cbo.Items.Add("September")
            cbo.Items.Add("October")
            cbo.Items.Add("November")
            cbo.Items.Add("December")
            cbo.Text = cbo.Items(0)
            cbo.DropDownStyle = ComboBoxStyle.DropDownList

        End Sub

        Public Shared Sub GetBudgetMonth(ByVal cbo As ComboBox)
            Dim iMonth As New Hashtable
            Dim strSQL As String
            Dim tbl = New DataTable

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

            strSQL = "SELECT a.BMONTH FROM BUDGETING a where a.ACTVE = '1'"

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
            cbo.DropDownStyle = ComboBoxStyle.DropDownList
            cbo.DataSource = Dt.DefaultView

            'cbo.Text = cbo.Items(0)
        End Sub

       Public Shared Sub GetGradeLevel(ByVal cbo As ComboBox)

            cbo.Items.Clear()
            cbo.Items.Add("")
            cbo.Items.Add("Level 1")
            cbo.Items.Add("Level 2")
            cbo.Items.Add("Level 3")
            cbo.Items.Add("Level 4")
            cbo.Items.Add("Level 5")
            cbo.Items.Add("Level 6")
            cbo.Items.Add("Level 7")
            cbo.Items.Add("Level 8")
            cbo.Items.Add("Level 9")
            cbo.Items.Add("Level 10")
            cbo.Items.Add("Level 11")
            cbo.Items.Add("Level 12")
            cbo.Items.Add("Level 13")
            cbo.Items.Add("Level 14")
            cbo.Items.Add("Level 15")
            cbo.Items.Add("Level 16")
            cbo.Items.Add("Level 17")
            cbo.Text = cbo.Items(0)

            cbo.DropDownStyle = ComboBoxStyle.DropDownList

        End Sub

        Public Shared Sub GetSalaryStep(ByVal cbo As ComboBox)

            cbo.Items.Clear()
            cbo.Items.Add("")
            cbo.Items.Add("Step 1")
            cbo.Items.Add("Step 2")
            cbo.Items.Add("Step 3")
            cbo.Items.Add("Step 4")
            cbo.Items.Add("Step 5")
            cbo.Items.Add("Step 6")
            cbo.Items.Add("Step 7")
            cbo.Items.Add("Step 8")
            cbo.Items.Add("Step 9")
            cbo.Items.Add("Step 10")
            cbo.Items.Add("Step 11")
            cbo.Items.Add("Step 12")
            cbo.Items.Add("Step 13")
            cbo.Items.Add("Step 14")
            cbo.Items.Add("Step 15")
            cbo.Text = cbo.Items(0)

            cbo.DropDownStyle = ComboBoxStyle.DropDownList

        End Sub

        Public Shared Sub GetRenumerationType(ByVal cbo As ComboBox)

            cbo.Items.Clear()
            cbo.Items.Add("")
            cbo.Items.Add("Allowance")
            cbo.Items.Add("Deductions")
            'cbo.Items.Add("Loans")
            'cbo.Items.Add("Contributions")
            cbo.Text = cbo.Items(0)
            cbo.DropDownStyle = ComboBoxStyle.DropDownList

        End Sub

        Public Shared Sub PopulateCombo(ByVal strSQL As String, ByVal dCol As DataGridViewComboBoxColumn)
            Dim da As FbDataAdapter
            Dim tbl As DataTable

            Try

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                da = New FirebirdSql.Data.FirebirdClient.FbDataAdapter(strSQL, DB.ConnObj)
                tbl = New DataTable
                dCol.DataSource = Nothing
                da.Fill(tbl)
                If tbl.Rows.Count = 0 Then Exit Sub
                With dCol
                    .AutoComplete = True
                    .DisplayMember = "name"
                    .ValueMember = "ukey"
                    .DataSource = tbl.DefaultView
                End With

            Catch ex As Exception

            End Try

        End Sub
        Public Shared Sub PopulateRoles(ByVal cbo As ComboBox, Optional ByVal includeAdministrator As Boolean = True)

            cbo.DataSource = Nothing


            Dim Dr As DataRow
            Dim Dt As New DataTable

            RoleName = New Hashtable

            Dt.Columns.Add("NAME", GetType(String))
            Dt.Columns.Add("UKEY", GetType(Short))


            Dim Adapter As FirebirdSql.Data.FirebirdClient.FbDataAdapter
            Dim Table As New DataTable
            Dim I As Integer
            Dim str As String = "SELECT NAME, UKEY FROM USERROLE ORDER BY NAME"

            If includeAdministrator = True Then
                Dr = Dt.NewRow
                Dr.Item("NAME") = "Administrator"
                Dr.Item("UKEY") = "1"
                RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
                Dt.Rows.Add(Dr)
                Dt.AcceptChanges()
            End If

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Viewer"
            Dr.Item("UKEY") = "2"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Voucher Operator"
            Dr.Item("UKEY") = "3"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Schedule Operator"
            Dr.Item("UKEY") = "4"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Operator"
            Dr.Item("UKEY") = "5"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Officer"
            Dr.Item("UKEY") = "6"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Director"
            Dr.Item("UKEY") = "7"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Director General"
            Dr.Item("UKEY") = "8"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Commissioner"
            Dr.Item("UKEY") = "9"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()
            
            Adapter = New FirebirdSql.Data.FirebirdClient.FbDataAdapter(str, Env.ConStr)
            Adapter.Fill(Table)

            If Table.Rows.Count > 0 Then
                For I = 0 To Table.Rows.Count - 1
                    Dr = Dt.NewRow
                    Dr.Item("NAME") = Table.Rows(I).Item("NAME")
                    Dr.Item("UKEY") = Table.Rows(I).Item("UKEY")
                    RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
                    Dt.Rows.Add(Dr)
                    Dt.AcceptChanges()
                Next
            End If

            cbo.Items.Clear()
            cbo.DropDownStyle = ComboBoxStyle.DropDownList
            cbo.DataSource = Dt
            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "UKEY"

        End Sub
        Public Shared Sub LimitCombo(ByVal cbo As ComboBox)

            cbo.DataSource = Nothing


            Dim Dr As DataRow
            Dim Dt As New DataTable

            RoleName = New Hashtable

            Dt.Columns.Add("NAME", GetType(String))
            Dt.Columns.Add("UKEY", GetType(Short))

            Dr = Dt.NewRow
            Dr.Item("NAME") = ""
            Dr.Item("UKEY") = "-1"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Below Limit"
            Dr.Item("UKEY") = "1"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Above Limit"
            Dr.Item("UKEY") = "0"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            cbo.Items.Clear()
            cbo.DropDownStyle = ComboBoxStyle.DropDownList
            cbo.DataSource = Dt
            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "UKEY"

        End Sub
        Public Shared Sub Status(ByVal cbo As ComboBox)

            cbo.DataSource = Nothing


            Dim Dr As DataRow
            Dim Dt As New DataTable

            RoleName = New Hashtable

            Dt.Columns.Add("NAME", GetType(String))
            Dt.Columns.Add("UKEY", GetType(Short))

            Dr = Dt.NewRow
            Dr.Item("NAME") = ""
            Dr.Item("UKEY") = "-1"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Prepared"
            Dr.Item("UKEY") = "0"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Checked"
            Dr.Item("UKEY") = "1"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Approved"
            Dr.Item("UKEY") = "2"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            cbo.Items.Clear()
            cbo.DropDownStyle = ComboBoxStyle.DropDownList
            cbo.DataSource = Dt
            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "UKEY"

        End Sub
        Public Shared Sub SummaryCombo(ByVal cbo As ComboBox)

            cbo.DataSource = Nothing


            Dim Dr As DataRow
            Dim Dt As New DataTable

            RoleName = New Hashtable

            Dt.Columns.Add("NAME", GetType(String))
            Dt.Columns.Add("UKEY", GetType(Short))

            Dr = Dt.NewRow
            Dr.Item("NAME") = ""
            Dr.Item("UKEY") = "0"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Audit Date"
            Dr.Item("UKEY") = "1"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            Dr = Dt.NewRow
            Dr.Item("NAME") = "Ministry"
            Dr.Item("UKEY") = "2"
            RoleName.Add(Dr.Item("UKEY"), Dr.Item("NAME"))
            Dt.Rows.Add(Dr)
            Dt.AcceptChanges()

            cbo.Items.Clear()
            cbo.DropDownStyle = ComboBoxStyle.DropDownList
            cbo.DataSource = Dt
            cbo.DisplayMember = "NAME"
            cbo.ValueMember = "UKEY"

        End Sub
        Public Shared Sub WriteComboButton(ByVal dgv As DataGridView, ByVal SQL As String, ByVal cName As String, ByVal hName As String, Optional ByVal useButton As Boolean = False)
            Dim dg As New DataGridViewComboBoxColumn
            With dg
                .Name = cName
                .HeaderText = hName
                PopulateCombo(SQL, dg)
                .DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                .AutoComplete = True
                '.ReadOnly = False
                .MinimumWidth = 300
                .Width = 300
                .Resizable = DataGridViewTriState.False
                dgv.Columns.Add(dg)
            End With

            If useButton = False Then Exit Sub

            Dim it1 As New DataGridViewButtonColumn
            it1.HeaderText = ""
            it1.DefaultCellStyle.NullValue = "A"
            'it1.Name = "bPort"
            it1.Width = 25
            it1.MinimumWidth = 25
            it1.Resizable = DataGridViewTriState.False
            dgv.Columns.Add(it1)
            
        End Sub
        Public Shared Sub WriteButton(ByVal dgv As DataGridView, ByVal cName As String)
            Dim dg As New DataGridViewButtonColumn

            With dg
                .HeaderText = ""
                .DefaultCellStyle.NullValue = "A"
                .Name = cName
                .Width = 25
                .MinimumWidth = 25
                .Resizable = DataGridViewTriState.False
                dgv.Columns.Add(dg)
            End With

        End Sub
        Public Shared Sub WriteColumn(ByVal dgv As DataGridView, ByVal cName As String, ByVal hName As String, ByVal cWidth As Integer, ByVal cResize As DataGridViewTriState, ByVal cAlign As DataGridViewContentAlignment, Optional ByVal cFormat As String = "")
            Dim dg As New DataGridViewTextBoxColumn

            With dg
                .Name = cName
                .HeaderText = hName

                .MinimumWidth = cWidth
                .Width = cWidth
                .Resizable = cResize
                .DefaultCellStyle.Alignment = cAlign
                .DefaultCellStyle.Format = cFormat
                dgv.Columns.Add(dg)
            End With

        End Sub
        Public Shared Sub WriteCheckBox(ByRef dgv As DataGridView, ByRef cName As String, ByRef hName As String, ByRef dpName As String, ByVal cWidth As Integer, ByVal cResize As DataGridViewTriState, ByVal cAlign As DataGridViewContentAlignment, Optional ByVal cFormat As String = "")
            Dim dg As New DataGridViewCheckBoxColumn

            With dg
                .Name = cName
                .HeaderText = hName
                .MinimumWidth = cWidth
                .Width = cWidth
                .Resizable = cResize
                .TrueValue = 1
                .FalseValue = 0
                .DefaultCellStyle.Alignment = cAlign
                .DataPropertyName = dpName
                dgv.Columns.Add(dg)
            End With

        End Sub
        Public Shared Sub WriteSN(ByVal dgv As DataGridView)

            Dim it1 As New DataGridViewTextBoxColumn
            it1.HeaderText = "S/N"
            it1.Name = "tSN"
            it1.Width = 35
            it1.MinimumWidth = 35
            it1.Resizable = DataGridViewTriState.False
            it1.ReadOnly = True
            it1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns.Add(it1)
        End Sub
        Public Shared Sub ListSerials(ByVal dgv As DataGridView)
            If dgv.Rows.Count > 0 Then
                Dim I As Integer
                For I = 0 To dgv.Rows.Count - 1
                    dgv.Item(0, I).Value = I + 1
                Next
            End If
        End Sub
        Public Shared Sub LoadComboBox(ByVal strSQL As String, ByVal C As String, ByVal cbo As ComboBox, Optional ByVal Coltn As Collection = Nothing)
            Dim I As Integer
            Dim da As FbDataAdapter
            Dim tbl As DataTable

            Try

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                da = New FirebirdSql.Data.FirebirdClient.FbDataAdapter(strSQL, DB.ConnObj)
                tbl = New DataTable
                da.Fill(tbl)
                cbo.DataSource = Nothing
                If tbl.Rows.Count = 0 Then Exit Sub
                With cbo
                    .DataSource = tbl.DefaultView
                    .DisplayMember = "name"
                    .ValueMember = "ukey"
                    .DropDownStyle = ComboBoxStyle.DropDownList
                End With

                If Coltn Is Nothing Then Exit Sub
                Coltn.Clear()
                With tbl
                    For I = 0 To .Rows.Count - 1
                        Coltn.Add(.Rows(I).Item(0), .Rows(I).Item(1).ToString)
                    Next I
                End With
            Catch ex As Exception

            End Try

        End Sub
        Public Shared Sub LoadBankComboBox(ByVal strSQL As String, ByVal C As String, ByVal cbo As ComboBox, Optional ByVal Coltn As Collection = Nothing)
            Dim I As Integer
            Dim da As FbDataAdapter
            Dim tbl As DataTable

            Try

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                da = New FirebirdSql.Data.FirebirdClient.FbDataAdapter(strSQL, DB.ConnObj)
                tbl = New DataTable
                da.Fill(tbl)
                cbo.DataSource = Nothing
                If tbl.Rows.Count = 0 Then Exit Sub
                With cbo
                    .DataSource = tbl.DefaultView
                    .DisplayMember = "name"
                    .ValueMember = "ukey"
                    .DropDownStyle = ComboBoxStyle.DropDownList

                End With

                If Coltn Is Nothing Then Exit Sub
                Coltn.Clear()
                With tbl
                    For I = 0 To .Rows.Count - 1
                        Coltn.Add(.Rows(I).Item(0), .Rows(I).Item(1).ToString)
                    Next I
                End With
            Catch ex As Exception

            End Try

        End Sub
        Public Shared Sub LoadGrid(ByVal strSQL As String, ByVal C As String, ByVal dgv As DataGridView)
            Dim I As Integer
            Dim da As FbDataAdapter
            Dim tbl As DataTable

            Try

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                da = New FirebirdSql.Data.FirebirdClient.FbDataAdapter(strSQL, DB.ConnObj)
                tbl = New DataTable
                da.Fill(tbl)
                dgv.Rows.Clear()
                If tbl.Rows.Count = 0 Then Exit Sub
                dgv.Rows.Add(tbl.Rows.Count)

                For I = 0 To dgv.Rows.Count - 1
                    dgv.Rows(I).Cells("name").Value = tbl.Rows(I).Item("name").ToString
                    dgv.Rows(I).Tag = tbl.Rows(I).Item("ukey").ToString
                Next
                ListSerials(dgv)
            Catch ex As Exception

            End Try

        End Sub
        Public Shared Function getPicture(ByVal dbfield As Object) As Image

            Dim binary As Byte()
            Dim str As New System.IO.MemoryStream
            Dim Img As Image
            Try
                binary = CType(dbfield, Byte())
                str.Write(binary, 0, binary.Length)
                Img = Image.FromStream(str)
                Return Img

            Catch ex As Exception
                Return Nothing
            End Try


        End Function
        Public Shared Sub savePicture(ByRef dbfield As Object, ByVal picture As Image)

            Dim binary As Byte()

            Dim mStream As New System.IO.MemoryStream
            Dim len As Integer
            Try
                picture.Save(mStream, picture.RawFormat)
                mStream.Position = 0
                len = CInt(mStream.Length)
                ReDim binary(len)
                mStream.Read(binary, 0, len)

                dbfield = binary
            Catch ex As Exception

            End Try


        End Sub
        Public Shared Sub checkForApostrophe(ByVal tbl As DataTable, ByVal ColName As String)
            Dim description As String

            If tbl.Rows.Count <= 0 Then Exit Sub

            For I As Integer = 0 To tbl.Rows.Count - 1
                description = tbl.Rows(I).Item(ColName).ToString()
                tbl.Rows(I).Item(ColName) = description.Replace("'", "''")
            Next

        End Sub
        Public Shared Sub replaceDoubleApostrophe(ByVal tbl As DataTable, ByVal ColName As String)
            Dim description As String

            If tbl.Rows.Count <= 0 Then Exit Sub

            For I As Integer = 0 To tbl.Rows.Count - 1
                description = tbl.Rows(I).Item(ColName).ToString()
                tbl.Rows(I).Item(ColName) = description.Replace("''", "'")
            Next

        End Sub
    End Class
End Namespace
