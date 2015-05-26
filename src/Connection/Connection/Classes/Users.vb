Imports System.Windows.Forms
Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes

Namespace Classes

    Public Class Users

        Private Shared bolLockGrid As Boolean
        Public Shared Privilege As Privileges

        Private Shared Sub ListSerials(ByVal dgv As DataGridView)
            Dim I As Integer

            If dgv.Rows.Count > 0 Then
                For I = 0 To dgv.Rows.Count - 1
                    dgv.Item(0, I).Value = I + 1
                Next

            End If
        End Sub
        Public Shared Property LockGrid() As Boolean
            Get
                Return bolLockGrid
            End Get
            Set(ByVal value As Boolean)
                bolLockGrid = value
            End Set
        End Property
        Public Shared Sub checkboxAll(ByVal dgv As DataGridView, ByVal k As Integer)
            If k = 0 Then uncheckAll(dgv) Else checkAll(dgv)

        End Sub
        Private Shared Sub uncheckAll(ByVal dgv As DataGridView)
            Dim I As Integer
            For I = 0 To dgv.Rows.Count - 1
                dgv.Rows(I).Cells("check").Value = False
            Next
        End Sub
        Private Shared Sub checkAll(ByVal dgv As DataGridView)
            Dim I As Integer
            For I = 0 To dgv.Rows.Count - 1
                dgv.Rows(I).Cells("check").Value = True
            Next
        End Sub
#Region "User"
        Public Shared Function adminActive(ByVal userid As Integer) As Boolean

            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable

            Dim SQL As String = "SELECT * FROM USERS WHERE ROLEID = 1 AND ACTVE = 1 AND UKEY <> " + userid.ToString
            Adapter = New FbDataAdapter(SQL, Env.ConStr)

            Table = New DataTable
            Adapter.Fill(Table)

            If Table.Rows.Count > 0 Then Return True

            Return False

        End Function
        Public Shared Function adminExist(ByVal userid As Integer) As Boolean

            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable

            Dim SQL As String = "SELECT * FROM USERS WHERE ROLEID = 1 AND UKEY <> " + userid.ToString
            Adapter = New FbDataAdapter(SQL, Env.ConStr)

            Table = New DataTable
            Adapter.Fill(Table)

            If Table.Rows.Count > 0 Then Return True

            Return False

        End Function

        Public Shared Function loadUser(ByVal userid As Integer) As DataTable

            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable

            Dim SQL As String = "SELECT * FROM USERS WHERE UKEY=" + userid.ToString
            Adapter = New FbDataAdapter(SQL, Env.ConStr)

            Table = New DataTable
            Adapter.Fill(Table)

            Return Table

        End Function

        Public Shared Function validateUser(ByVal username As String, Optional ByVal userid As Integer = 0) As Boolean

            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable

            Dim SQL As String = "SELECT * FROM USERS WHERE USERNAME='" + username.ToLower + "' AND UKEY <> " + userid.ToString
            Adapter = New FbDataAdapter(SQL, Env.ConStr)

            Table = New DataTable
            Adapter.Fill(Table)

            If Table.Rows.Count = 0 Then Return True

            Return False

        End Function
        Public Shared Function validateUserPassword(ByVal password As String) As Boolean

            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable

            Dim SQL As String = "SELECT * FROM USERS WHERE USERNAME='" + Env.LogInName.ToString + "' AND PASSD = '" + password.GetHashCode.ToString + "'"
            Adapter = New FbDataAdapter(SQL, Env.ConStr)

            Table = New DataTable
            Adapter.Fill(Table)

            If Table.Rows.Count > 0 Then Return True

            Return False

        End Function
        Public Shared Function removeUser(ByVal userid As Integer) As Boolean

            Dim conn As New FbConnection(Env.ConStr)
            Dim cmd As FbCommand

            Dim SQL As String = "DELETE FROM USERS WHERE UKEY=" + userid.ToString
            conn.Open()

            Try
                cmd = New FbCommand(SQL, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                Return True
            Catch ex As Exception

            End Try

            Return False

        End Function
        Public Shared Function insertUser(ByVal username As String, ByVal password As String, ByVal fullname As String, ByVal actve As Integer, ByVal roleid As Integer, ByVal statusid As Char) As Boolean

            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable
            Dim Builder As New FbCommandBuilder

            Dim SQL As String = "SELECT * FROM USERS"
            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Builder.DataAdapter = Adapter
            Adapter.InsertCommand = Builder.GetInsertCommand
            Table = New DataTable

            Try

                Adapter.Fill(Table)
                Dim row As DataRow

                row = Table.NewRow
                row.Item("NAME") = fullname
                row.Item("USERNAME") = username.ToLower
                row.Item("PASSD") = password.GetHashCode
                row.Item("ACTVE") = actve
                row.Item("ROLEID") = roleid
                row.Item("STATUSID") = statusid
                Table.Rows.Add(row)
                Adapter.Update(Table)
                Return True
            Catch ex As Exception
                If ex.Message.Contains("violation of PRIMARY or UNIQUE KEY") Then
                    MessageBox.Show(Messages.Duplicate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Throw ex
                End If
            End Try

            Return False

        End Function
        Public Shared Function updateUserPassword(ByVal password As String, ByVal userid As Integer) As Boolean

            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable
            Dim Builder As New FbCommandBuilder

            Dim SQL As String = "SELECT * FROM USERS WHERE UKEY=" + userid.ToString
            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Builder.DataAdapter = Adapter
            Adapter.UpdateCommand = Builder.GetUpdateCommand

            Table = New DataTable

            Try

                Adapter.Fill(Table)
                If Table.Rows.Count > 0 Then
                    Table.Rows(0).Item("PASSD") = password.GetHashCode
                    Adapter.Update(Table)
                    Return True
                End If

            Catch ex As Exception
                If ex.Message.Contains("violation of PRIMARY or UNIQUE KEY") Then
                    MessageBox.Show(Messages.Duplicate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Throw ex
                End If
            End Try

            Return False
        End Function
        Public Shared Function updateUser(ByVal username As String, ByVal password As String, ByVal fullname As String, ByVal actve As Integer, ByVal roleid As Integer, ByVal userid As Integer) As Boolean

            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable
            Dim Builder As New FbCommandBuilder

            Dim SQL As String = "SELECT * FROM USERS WHERE UKEY=" + userid.ToString
            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Builder.DataAdapter = Adapter
            Adapter.InsertCommand = Builder.GetInsertCommand
            Adapter.DeleteCommand = Builder.GetDeleteCommand
            Adapter.UpdateCommand = Builder.GetUpdateCommand

            Table = New DataTable

            Try

                Adapter.Fill(Table)
                If Table.Rows.Count > 0 Then
                    Table.Rows(0).Item("NAME") = fullname
                    Table.Rows(0).Item("USERNAME") = username.ToLower
                    If password <> "" Then Table.Rows(0).Item("PASSD") = password.GetHashCode
                    Table.Rows(0).Item("ACTVE") = actve
                    Table.Rows(0).Item("ROLEID") = roleid
                    Adapter.Update(Table)
                    Return True
                Else

                End If

            Catch ex As Exception
                If ex.Message.Contains("violation of PRIMARY or UNIQUE KEY") Then
                    MessageBox.Show(Messages.Duplicate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Throw ex
                End If
            End Try

            Return False
        End Function
        Public Shared Sub populatePermissionGrid(ByVal Grid As DataGridView, Optional ByVal gwidth As Integer = 200)

            With Grid
                .BackgroundColor = Env.GirdBackgroundColor
                .RowsDefaultCellStyle.SelectionBackColor = Env.GirdSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Env.GirdSelectionForeColor
                .AlternatingRowsDefaultCellStyle = Nothing
                .Columns.Clear()
                .Rows.Clear()
                .RowHeadersVisible = False
                .AllowUserToResizeRows = False
                .AllowUserToResizeColumns = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ColumnHeadersVisible = True
                '/serial No.
                .Columns.Add("sn", "S/N")
                .Columns("sn").Width = 35
                .Columns("sn").ReadOnly = True
                .Columns("sn").DefaultCellStyle.BackColor = .RowHeadersDefaultCellStyle.BackColor
                .Columns("sn").SortMode = DataGridViewColumnSortMode.NotSortable

                '/Title
                .Columns.Add("p", "Permissions")
                .Columns("p").Width = 250
                .Columns("p").ReadOnly = True
                .Columns("p").SortMode = DataGridViewColumnSortMode.NotSortable
                '/Mark
                .Columns.Add("pid", "Permissions ID")
                .Columns("pid").Width = 6
                .Columns("pid").ReadOnly = True
                .Columns("pid").Visible = False
                .Columns("pid").SortMode = DataGridViewColumnSortMode.NotSortable
                '/Check box
                Dim ck As New DataGridViewCheckBoxColumn
                ck.Name = "check"
                ck.HeaderText = ""
                ck.Width = 50
                ck.MinimumWidth = 50
                ck.ReadOnly = True
                .Columns.Add(ck)

            End With

            Dim I As Integer
            Dim strPermissions() As String = {
                "View Profile", "Add Retiree Record", "Edit Retiree Record", "Remove Retiree Record", _
                "View Payment Profile", "Knockoff Payment", "Prepare Allocation", "Edit Allocation", "Remove Allocation", _
                "View Outstanding Retiree", "Edit Outstanding Retiree Status", "Generate Oustanding Report", _
                "View Outstanding Retiree - [Above Limit]", "Edit Outstanding Retiree Status - [Above Limit]", "Generate Outstanding Report - [Above Limit]", _
                "View Retiree Summary", "Generate Retiree Summary Report", "View Retiree Summary - [Above Limit]", "Generate Retiree Summary Report - [Above Limit]", _
                "View Payment Details", "Edit Payment Status", "Remove Payment", "Generate Payment Report", "View Payment Details - [Above Limit]", "Edit Payment Status - [Above Limit]", "Remove Payment - [Above Limit]", "Generate Payment Report - [Above Limit]", _
                "Process Payment", "Edit Menu", "Settings", "User Account", "Server Settings", "Extra Menu", "Backup/Restore", "Report Menu"
            }

            Dim strPermissionsID() As String = {
                "1", "2", "3", "4", _
                "5", "6", "7", "8", "9", _
                "10", "11", "12", _
                "13", "14", "15", _
                "16", "17", "18", "19", _
                "20", "21", "22", "23", "24", "25", "26", "27", _
                "28", "29", "30", "31", "32", "33", "34", "35"
            }


            Grid.Rows.Add(35)

            For I = 0 To 34
                Grid.Rows(I).Cells("p").Value = strPermissions(I).ToUpper
                Grid.Rows(I).Cells("pid").Value = strPermissionsID(I)
                Grid.Rows(I).Cells("check").Value = False
            Next
            ListSerials(Grid)

        End Sub
        Public Shared Sub saveRolePrivilege(ByVal roleid As Integer, ByVal Grid As DataGridView)
            Dim I As Integer
            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable
            Dim Builder As New FbCommandBuilder
            Dim strPrivilege(20) As String

            Dim SQL As String = "SELECT * FROM USERROLES WHERE UKEY =" + roleid.ToString
            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Builder.DataAdapter = Adapter
            Adapter.InsertCommand = Builder.GetInsertCommand
            Adapter.DeleteCommand = Builder.GetDeleteCommand
            Adapter.UpdateCommand = Builder.GetUpdateCommand

            Table = New DataTable
            Adapter.Fill(Table)

            If Table.Rows.Count = 0 Then Exit Sub

            For I = 0 To 34
                If Grid.Rows(I).Cells("check").Value = True Then
                    strPrivilege(I) = Grid.Rows(I).Cells("pid").Value
                Else
                    strPrivilege(I) = 0
                End If
            Next

            Table.Rows(0).Item("PRIVILEGE") = String.Join(",", strPrivilege)
            Adapter.Update(Table)

        End Sub
        Public Shared Sub loadRolePrivilege(ByVal roleid As Integer, ByVal Grid As DataGridView, ByVal gwidth As Integer)
            Dim I As Integer
            Dim K As Integer
            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable
            Dim Builder As New FbCommandBuilder

            If roleid > 9 Then

                populatePermissionGrid(Grid, gwidth)

                Dim SQL As String = "SELECT * FROM USERROLES WHERE UKEY =" + roleid.ToString
                Adapter = New FbDataAdapter(SQL, Env.ConStr)
                Builder.DataAdapter = Adapter
                Adapter.InsertCommand = Builder.GetInsertCommand
                Adapter.DeleteCommand = Builder.GetDeleteCommand
                Adapter.UpdateCommand = Builder.GetUpdateCommand

                Table = New DataTable
                Adapter.Fill(Table)

                bolLockGrid = False

                If Table.Rows.Count = 0 Then Exit Sub
                Dim strPrivilege() As String = Table.Rows(0).Item("PRIVILEGE").ToString.Split(",")

                For K = 0 To strPrivilege.Length - 1
                    If strPrivilege(K) <> "" Then
                        For I = 0 To 34
                            If Grid.Rows(I).Cells("pid").Value = strPrivilege(K).Trim Then
                                Grid.Rows(I).Cells("check").Value = True
                                Exit For
                            End If
                        Next
                    End If
                Next

            Else
                getPermissions(Grid, roleid, gwidth)
            End If


        End Sub
        Public Shared Function getAccountCreationStatus() As Boolean

            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable

            Dim SQL As String = "SELECT * FROM BRANCH WHERE ENABLE_USERS=1"
            Adapter = New FbDataAdapter(SQL, Env.ConStr)

            Table = New DataTable
            Adapter.Fill(Table)

            If Table.Rows.Count > 0 Then Return True

            Return False

        End Function
        Public Shared Sub enableAccountCreation(ByVal enable As Boolean)
            Dim conn As New FbConnection(Env.ConStr)
            Dim cmd As FbCommand
            Dim SQL As String

            If enable = True Then
                SQL = "UPDATE BRANCH SET ENABLE_USERS=1"
            Else
                SQL = "UPDATE BRANCH SET ENABLE_USERS=0"
            End If

            conn.Open()

            Try
                cmd = New FbCommand(SQL, conn)
                cmd.ExecuteNonQuery()
                conn.Close()

            Catch ex As Exception

            End Try

        End Sub
        Public Shared Sub setUserPrivileges(ByVal Role As Integer)
            Privilege = Privileges.getUserPrivilege
            initUserPrivileges()

            Select Case Role
                Case 1 : setAdministrator()
                Case 2 : setViewer()
                Case 3 : setVoucherOperator()
                Case 4 : setScheduleOperator()
                Case 5 : setOperator()
                Case 6 : setOfficer()
                Case 7 : setDirector()
                Case 8 : setDirectorGeneral()
                Case 9 : setCommissioner()
                Case Else
                    bolLockGrid = False
            End Select
        End Sub
        Private Shared Sub initUserPrivileges()
            Privilege.Profile = False '0
            Privilege.AddRetireRecord = False '1
            Privilege.EditRetireRecord = False '2
            Privilege.RemoveRetireRecord = False '3
            Privilege.ViewPaymentProfile = False '4
            Privilege.KnockoffPayment = False '5
            Privilege.PrepareAllocation = False '6
            Privilege.EditAllocation = False '7
            Privilege.RemoveAllocation = False '8
            Privilege.ViewOustandingRetiree = False '9
            Privilege.EditRetireeStatus = False '10
            Privilege.GenerateOustandingReport = False '11
            Privilege.ViewOustandingRetireeAL = False '12
            Privilege.EditRetireeStatusAL = False '13
            Privilege.GenerateOustandingReportAL = False '14
            Privilege.ViewOustandingSummary = False '15
            Privilege.GenerateSummaryReport = False '16 
            Privilege.ViewOustandingSummaryAL = False '17
            Privilege.GenerateSummaryReportAL = False '18
            Privilege.ViewPaymentDetails = False '19
            Privilege.EditPaymentStatus = False '20
            Privilege.RemovePayment = False '21
            Privilege.GeneratePaymentDetailsReport = False '22
            Privilege.ViewPaymentDetailsAL = False '23
            Privilege.EditPaymentStatusAL = False '24
            Privilege.RemovePaymentAL = False '25
            Privilege.GeneratePaymentDetailsReportAL = False '26
            Privilege.ProcessPayment = False '27
            Privilege.EditMenu = False '28
            Privilege.Settings = False '29
            Privilege.UserAccountSettings = False '30
            Privilege.ServerSettings = False '31
            Privilege.ExtraMenuSettings = False '32
            Privilege.BackupRestore = False '33
            Privilege.ReportMenu = False '34
        End Sub
        Private Shared Sub setAdministrator()
            Privilege.Profile = True '0
            Privilege.AddRetireRecord = True '1
            Privilege.EditRetireRecord = True '2
            Privilege.RemoveRetireRecord = True '3
            Privilege.ViewPaymentProfile = True '4
            Privilege.KnockoffPayment = True '5
            Privilege.PrepareAllocation = True '6
            Privilege.EditAllocation = True '7
            Privilege.RemoveAllocation = True '8
            Privilege.ViewOustandingRetiree = True '9
            Privilege.EditRetireeStatus = False '10
            Privilege.GenerateOustandingReport = True '11
            Privilege.ViewOustandingRetireeAL = True '12
            Privilege.EditRetireeStatusAL = False '13
            Privilege.GenerateOustandingReportAL = True '14
            Privilege.ViewOustandingSummary = True '15
            Privilege.GenerateSummaryReport = True '16 
            Privilege.ViewOustandingSummaryAL = True '17
            Privilege.GenerateSummaryReportAL = True '18
            Privilege.ViewPaymentDetails = True '19
            Privilege.EditPaymentStatus = False '20
            Privilege.RemovePayment = True '21
            Privilege.GeneratePaymentDetailsReport = True '22
            Privilege.ViewPaymentDetailsAL = True '23
            Privilege.EditPaymentStatusAL = False '24
            Privilege.RemovePaymentAL = True '25
            Privilege.GeneratePaymentDetailsReportAL = True '26
            Privilege.ProcessPayment = True '27
            Privilege.EditMenu = True '28
            Privilege.Settings = True '29
            Privilege.UserAccountSettings = True '30
            Privilege.ServerSettings = True '31
            Privilege.ExtraMenuSettings = True '32
            Privilege.BackupRestore = True '33
            Privilege.ReportMenu = True '34
        End Sub
        Private Shared Sub setViewer()
            Privilege.Profile = True '0
            Privilege.AddRetireRecord = False '1
            Privilege.EditRetireRecord = False '2
            Privilege.RemoveRetireRecord = False '3
            Privilege.ViewPaymentProfile = True '4
            Privilege.KnockoffPayment = False '5
            Privilege.PrepareAllocation = False '6
            Privilege.EditAllocation = False '7
            Privilege.RemoveAllocation = False '8
            Privilege.ViewOustandingRetiree = True '9
            Privilege.EditRetireeStatus = False '10
            Privilege.GenerateOustandingReport = False '11
            Privilege.ViewOustandingRetireeAL = True '12
            Privilege.EditRetireeStatusAL = False '13
            Privilege.GenerateOustandingReportAL = False '14
            Privilege.ViewOustandingSummary = True '15
            Privilege.GenerateSummaryReport = False '16 
            Privilege.ViewOustandingSummaryAL = True '17
            Privilege.GenerateSummaryReportAL = False '18
            Privilege.ViewPaymentDetails = False '19
            Privilege.EditPaymentStatus = False '20
            Privilege.RemovePayment = False '21
            Privilege.GeneratePaymentDetailsReport = False '22
            Privilege.ViewPaymentDetailsAL = False '23
            Privilege.EditPaymentStatusAL = False '24
            Privilege.RemovePaymentAL = False '25
            Privilege.GeneratePaymentDetailsReportAL = False '26
            Privilege.ProcessPayment = False '27
            Privilege.EditMenu = True '28
            Privilege.Settings = False '29
            Privilege.UserAccountSettings = False '30
            Privilege.ServerSettings = True '31
            Privilege.ExtraMenuSettings = False '32
            Privilege.BackupRestore = False '33
            Privilege.ReportMenu = True '34
        End Sub
        Private Shared Sub setVoucherOperator()
            Privilege.Profile = True '0
            Privilege.AddRetireRecord = False '1
            Privilege.EditRetireRecord = False '2
            Privilege.RemoveRetireRecord = False '3
            Privilege.ViewPaymentProfile = True '4
            Privilege.KnockoffPayment = False '5
            Privilege.PrepareAllocation = False '6
            Privilege.EditAllocation = False '7
            Privilege.RemoveAllocation = False '8
            Privilege.ViewOustandingRetiree = True '9
            Privilege.EditRetireeStatus = False '10
            Privilege.GenerateOustandingReport = False '11
            Privilege.ViewOustandingRetireeAL = True '12
            Privilege.EditRetireeStatusAL = False '13
            Privilege.GenerateOustandingReportAL = False '14
            Privilege.ViewOustandingSummary = True '15
            Privilege.GenerateSummaryReport = False '16 
            Privilege.ViewOustandingSummaryAL = True '17
            Privilege.GenerateSummaryReportAL = False '18
            Privilege.ViewPaymentDetails = False '19
            Privilege.EditPaymentStatus = False '20
            Privilege.RemovePayment = False '21
            Privilege.GeneratePaymentDetailsReport = False '22
            Privilege.ViewPaymentDetailsAL = False '23
            Privilege.EditPaymentStatusAL = False '24
            Privilege.RemovePaymentAL = False '25
            Privilege.GeneratePaymentDetailsReportAL = False '26
            Privilege.ProcessPayment = False '27
            Privilege.EditMenu = True '28
            Privilege.Settings = False '29
            Privilege.UserAccountSettings = False '30
            Privilege.ServerSettings = True '31
            Privilege.ExtraMenuSettings = False '32
            Privilege.BackupRestore = False '33
            Privilege.ReportMenu = True '34

        End Sub
        Private Shared Sub setScheduleOperator()
            Privilege.Profile = True '0
            Privilege.AddRetireRecord = False '1
            Privilege.EditRetireRecord = False '2
            Privilege.RemoveRetireRecord = False '3
            Privilege.ViewPaymentProfile = True '4
            Privilege.KnockoffPayment = False '5
            Privilege.PrepareAllocation = False '6
            Privilege.EditAllocation = False '7
            Privilege.RemoveAllocation = False '8
            Privilege.ViewOustandingRetiree = True '9
            Privilege.EditRetireeStatus = False '10
            Privilege.GenerateOustandingReport = False '11
            Privilege.ViewOustandingRetireeAL = True '12
            Privilege.EditRetireeStatusAL = False '13
            Privilege.GenerateOustandingReportAL = False '14
            Privilege.ViewOustandingSummary = True '15
            Privilege.GenerateSummaryReport = False '16 
            Privilege.ViewOustandingSummaryAL = True '17
            Privilege.GenerateSummaryReportAL = False '18
            Privilege.ViewPaymentDetails = False '19
            Privilege.EditPaymentStatus = False '20
            Privilege.RemovePayment = False '21
            Privilege.GeneratePaymentDetailsReport = False '22
            Privilege.ViewPaymentDetailsAL = False '23
            Privilege.EditPaymentStatusAL = False '24
            Privilege.RemovePaymentAL = False '25
            Privilege.GeneratePaymentDetailsReportAL = False '26
            Privilege.ProcessPayment = False '27
            Privilege.EditMenu = True '28
            Privilege.Settings = False '29
            Privilege.UserAccountSettings = False '30
            Privilege.ServerSettings = True '31
            Privilege.ExtraMenuSettings = False '32
            Privilege.BackupRestore = False '33
            Privilege.ReportMenu = True '34
        End Sub
        Private Shared Sub setOperator()
            Privilege.Profile = True '0
            Privilege.AddRetireRecord = True '1
            Privilege.EditRetireRecord = True '2
            Privilege.RemoveRetireRecord = True '3
            Privilege.ViewPaymentProfile = True '4
            Privilege.KnockoffPayment = True '5
            Privilege.PrepareAllocation = True '6
            Privilege.EditAllocation = True '7
            Privilege.RemoveAllocation = True '8
            Privilege.ViewOustandingRetiree = True '9
            Privilege.EditRetireeStatus = True '10
            Privilege.GenerateOustandingReport = False '11
            Privilege.ViewOustandingRetireeAL = True '12
            Privilege.EditRetireeStatusAL = True '13
            Privilege.GenerateOustandingReportAL = False '14
            Privilege.ViewOustandingSummary = True '15
            Privilege.GenerateSummaryReport = False '16 
            Privilege.ViewOustandingSummaryAL = True '17
            Privilege.GenerateSummaryReportAL = False '18
            Privilege.ViewPaymentDetails = True '19
            Privilege.EditPaymentStatus = True '20
            Privilege.RemovePayment = True '21
            Privilege.GeneratePaymentDetailsReport = False '22
            Privilege.ViewPaymentDetailsAL = True '23
            Privilege.EditPaymentStatusAL = True '24
            Privilege.RemovePaymentAL = False '25
            Privilege.GeneratePaymentDetailsReportAL = False '26
            Privilege.ProcessPayment = False '27
            Privilege.EditMenu = True '28
            Privilege.Settings = False '29
            Privilege.UserAccountSettings = False '30
            Privilege.ServerSettings = True '31
            Privilege.ExtraMenuSettings = False '32
            Privilege.BackupRestore = False '33
            Privilege.ReportMenu = True '34
        End Sub
        Private Shared Sub setOfficer()
            Privilege.Profile = True '0
            Privilege.AddRetireRecord = True '1
            Privilege.EditRetireRecord = True '2
            Privilege.RemoveRetireRecord = True '3
            Privilege.ViewPaymentProfile = True '4
            Privilege.KnockoffPayment = True '5
            Privilege.PrepareAllocation = True '6
            Privilege.EditAllocation = True '7
            Privilege.RemoveAllocation = True '8
            Privilege.ViewOustandingRetiree = True '9
            Privilege.EditRetireeStatus = True '10
            Privilege.GenerateOustandingReport = True '11
            Privilege.ViewOustandingRetireeAL = True '12
            Privilege.EditRetireeStatusAL = True '13
            Privilege.GenerateOustandingReportAL = True '14
            Privilege.ViewOustandingSummary = True '15
            Privilege.GenerateSummaryReport = True '16 
            Privilege.ViewOustandingSummaryAL = True '17
            Privilege.GenerateSummaryReportAL = True '18
            Privilege.ViewPaymentDetails = True '19
            Privilege.EditPaymentStatus = True '20
            Privilege.RemovePayment = True '21
            Privilege.GeneratePaymentDetailsReport = True '22
            Privilege.ViewPaymentDetailsAL = True '23
            Privilege.EditPaymentStatusAL = True '24
            Privilege.RemovePaymentAL = True '25
            Privilege.GeneratePaymentDetailsReportAL = True '26
            Privilege.ProcessPayment = True '27
            Privilege.EditMenu = True '28
            Privilege.Settings = True '29
            Privilege.UserAccountSettings = False '30
            Privilege.ServerSettings = True '31
            Privilege.ExtraMenuSettings = True '32
            Privilege.BackupRestore = True '33
            Privilege.ReportMenu = True '34
        End Sub
        Private Shared Sub setDirector()
            Privilege.Profile = True '0
            Privilege.AddRetireRecord = False '1
            Privilege.EditRetireRecord = False '2
            Privilege.RemoveRetireRecord = False '3
            Privilege.ViewPaymentProfile = True '4
            Privilege.KnockoffPayment = False '5
            Privilege.PrepareAllocation = False '6
            Privilege.EditAllocation = False '7
            Privilege.RemoveAllocation = False '8
            Privilege.ViewOustandingRetiree = True '9
            Privilege.EditRetireeStatus = True '10
            Privilege.GenerateOustandingReport = True '11
            Privilege.ViewOustandingRetireeAL = True '12
            Privilege.EditRetireeStatusAL = True '13
            Privilege.GenerateOustandingReportAL = True '14
            Privilege.ViewOustandingSummary = True '15
            Privilege.GenerateSummaryReport = True '16 
            Privilege.ViewOustandingSummaryAL = True '17
            Privilege.GenerateSummaryReportAL = True '18
            Privilege.ViewPaymentDetails = True '19
            Privilege.EditPaymentStatus = True '20
            Privilege.RemovePayment = False '21
            Privilege.GeneratePaymentDetailsReport = True '22
            Privilege.ViewPaymentDetailsAL = True '23
            Privilege.EditPaymentStatusAL = True '24
            Privilege.RemovePaymentAL = False '25
            Privilege.GeneratePaymentDetailsReportAL = True '26
            Privilege.ProcessPayment = False '27
            Privilege.EditMenu = True '28
            Privilege.Settings = False '29
            Privilege.UserAccountSettings = True '30
            Privilege.ServerSettings = True '31
            Privilege.ExtraMenuSettings = True '32
            Privilege.BackupRestore = True '33
            Privilege.ReportMenu = True '34
        End Sub
        Private Shared Sub setDirectorGeneral()
            Privilege.Profile = True '0
            Privilege.AddRetireRecord = False '1
            Privilege.EditRetireRecord = False '2
            Privilege.RemoveRetireRecord = False '3
            Privilege.ViewPaymentProfile = True '4
            Privilege.KnockoffPayment = False '5
            Privilege.PrepareAllocation = False '6
            Privilege.EditAllocation = False '7
            Privilege.RemoveAllocation = False '8
            Privilege.ViewOustandingRetiree = True '9
            Privilege.EditRetireeStatus = False '10
            Privilege.GenerateOustandingReport = False '11
            Privilege.ViewOustandingRetireeAL = True '12
            Privilege.EditRetireeStatusAL = False '13
            Privilege.GenerateOustandingReportAL = False '14
            Privilege.ViewOustandingSummary = True '15
            Privilege.GenerateSummaryReport = False '16 
            Privilege.ViewOustandingSummaryAL = True '17
            Privilege.GenerateSummaryReportAL = False '18
            Privilege.ViewPaymentDetails = False '19
            Privilege.EditPaymentStatus = False '20
            Privilege.RemovePayment = False '21
            Privilege.GeneratePaymentDetailsReport = False '22
            Privilege.ViewPaymentDetailsAL = False '23
            Privilege.EditPaymentStatusAL = False '24
            Privilege.RemovePaymentAL = False '25
            Privilege.GeneratePaymentDetailsReportAL = False '26
            Privilege.ProcessPayment = False '27
            Privilege.EditMenu = True '28
            Privilege.Settings = False '29
            Privilege.UserAccountSettings = False '30
            Privilege.ServerSettings = True '31
            Privilege.ExtraMenuSettings = False '32
            Privilege.BackupRestore = False '33
            Privilege.ReportMenu = True '34
        End Sub
        Private Shared Sub setCommissioner()
            Privilege.Profile = True '0
            Privilege.AddRetireRecord = False '1
            Privilege.EditRetireRecord = False '2
            Privilege.RemoveRetireRecord = False '3
            Privilege.ViewPaymentProfile = True '4
            Privilege.KnockoffPayment = False '5
            Privilege.PrepareAllocation = False '6
            Privilege.EditAllocation = False '7
            Privilege.RemoveAllocation = False '8
            Privilege.ViewOustandingRetiree = True '9
            Privilege.EditRetireeStatus = False '10
            Privilege.GenerateOustandingReport = False '11
            Privilege.ViewOustandingRetireeAL = True '12
            Privilege.EditRetireeStatusAL = False '13
            Privilege.GenerateOustandingReportAL = False '14
            Privilege.ViewOustandingSummary = True '15
            Privilege.GenerateSummaryReport = False '16 
            Privilege.ViewOustandingSummaryAL = True '17
            Privilege.GenerateSummaryReportAL = False '18
            Privilege.ViewPaymentDetails = False '19
            Privilege.EditPaymentStatus = False '20
            Privilege.RemovePayment = False '21
            Privilege.GeneratePaymentDetailsReport = False '22
            Privilege.ViewPaymentDetailsAL = False '23
            Privilege.EditPaymentStatusAL = False '24
            Privilege.RemovePaymentAL = False '25
            Privilege.GeneratePaymentDetailsReportAL = False '26
            Privilege.ProcessPayment = False '27
            Privilege.EditMenu = True '28
            Privilege.Settings = False '29
            Privilege.UserAccountSettings = False '30
            Privilege.ServerSettings = True '31
            Privilege.ExtraMenuSettings = False '32
            Privilege.BackupRestore = False '33
            Privilege.ReportMenu = True '34
        End Sub
        Private Shared Sub writeAdministrator(ByVal Grid As DataGridView)
            Dim I As Integer
            For I = 0 To 34
                Grid.Rows(I).Cells("check").Value = True
            Next
            bolLockGrid = True
        End Sub
        Private Shared Sub writeViewer(ByVal Grid As DataGridView)
            Dim I As Integer

            For I = 0 To 34
                Grid.Rows(I).Cells("check").Value = False
            Next

            Grid.Rows(0).Cells("check").Value = True
            Grid.Rows(4).Cells("check").Value = True
            Grid.Rows(9).Cells("check").Value = True
            Grid.Rows(12).Cells("check").Value = True
            Grid.Rows(15).Cells("check").Value = True
            Grid.Rows(17).Cells("check").Value = True
            Grid.Rows(28).Cells("check").Value = True
            Grid.Rows(31).Cells("check").Value = True
            Grid.Rows(34).Cells("check").Value = True

            bolLockGrid = True
        End Sub
        Private Shared Sub writeVoucherOperator(ByVal Grid As DataGridView)
            Dim I As Integer

            For I = 0 To 34
                Grid.Rows(I).Cells("check").Value = False
            Next

            Grid.Rows(0).Cells("check").Value = True
            Grid.Rows(4).Cells("check").Value = True
            Grid.Rows(9).Cells("check").Value = True
            Grid.Rows(12).Cells("check").Value = True
            Grid.Rows(15).Cells("check").Value = True
            Grid.Rows(17).Cells("check").Value = True
            Grid.Rows(28).Cells("check").Value = True
            Grid.Rows(31).Cells("check").Value = True
            Grid.Rows(34).Cells("check").Value = True

            bolLockGrid = True
        End Sub
        Private Shared Sub writeScheduleOperator(ByVal Grid As DataGridView)
            Dim I As Integer

            For I = 0 To 34
                Grid.Rows(I).Cells("check").Value = False
            Next

            Grid.Rows(0).Cells("check").Value = True
            Grid.Rows(4).Cells("check").Value = True
            Grid.Rows(9).Cells("check").Value = True
            Grid.Rows(12).Cells("check").Value = True
            Grid.Rows(15).Cells("check").Value = True
            Grid.Rows(17).Cells("check").Value = True
            Grid.Rows(28).Cells("check").Value = True
            Grid.Rows(31).Cells("check").Value = True
            Grid.Rows(34).Cells("check").Value = True

            bolLockGrid = True
        End Sub
        Private Shared Sub writeOperator(ByVal Grid As DataGridView)
            Dim I As Integer
            For I = 0 To 34
                Grid.Rows(I).Cells("check").Value = False
            Next

            Grid.Rows(0).Cells("check").Value = True
            Grid.Rows(1).Cells("check").Value = True
            Grid.Rows(2).Cells("check").Value = True
            Grid.Rows(3).Cells("check").Value = True
            Grid.Rows(4).Cells("check").Value = True
            Grid.Rows(5).Cells("check").Value = True
            Grid.Rows(6).Cells("check").Value = True
            Grid.Rows(7).Cells("check").Value = True
            Grid.Rows(8).Cells("check").Value = True
            Grid.Rows(9).Cells("check").Value = True
            Grid.Rows(10).Cells("check").Value = True
            Grid.Rows(12).Cells("check").Value = True
            Grid.Rows(13).Cells("check").Value = True
            Grid.Rows(15).Cells("check").Value = True
            Grid.Rows(17).Cells("check").Value = True
            Grid.Rows(19).Cells("check").Value = True
            Grid.Rows(20).Cells("check").Value = True
            Grid.Rows(21).Cells("check").Value = True
            Grid.Rows(23).Cells("check").Value = True
            Grid.Rows(24).Cells("check").Value = True
            Grid.Rows(25).Cells("check").Value = True
            Grid.Rows(28).Cells("check").Value = True
            Grid.Rows(31).Cells("check").Value = True
            Grid.Rows(34).Cells("check").Value = True

            bolLockGrid = True

        End Sub
        Private Shared Sub writeOfficer(ByVal Grid As DataGridView)
            Dim I As Integer
            For I = 0 To 34
                Grid.Rows(I).Cells("check").Value = True
            Next

            Grid.Rows(30).Cells("check").Value = False

            bolLockGrid = True
        End Sub
        Private Shared Sub writeDirector(ByVal Grid As DataGridView)
            Dim I As Integer
            For I = 0 To 34
                Grid.Rows(I).Cells("check").Value = False
            Next

            Grid.Rows(0).Cells("check").Value = True
            Grid.Rows(4).Cells("check").Value = True
            Grid.Rows(9).Cells("check").Value = True
            Grid.Rows(10).Cells("check").Value = True
            Grid.Rows(11).Cells("check").Value = True
            Grid.Rows(12).Cells("check").Value = True
            Grid.Rows(13).Cells("check").Value = True
            Grid.Rows(14).Cells("check").Value = True
            Grid.Rows(15).Cells("check").Value = True
            Grid.Rows(16).Cells("check").Value = True
            Grid.Rows(17).Cells("check").Value = True
            Grid.Rows(18).Cells("check").Value = True
            Grid.Rows(19).Cells("check").Value = True
            Grid.Rows(20).Cells("check").Value = True
            Grid.Rows(22).Cells("check").Value = True
            Grid.Rows(23).Cells("check").Value = True
            Grid.Rows(24).Cells("check").Value = True
            Grid.Rows(26).Cells("check").Value = True
            Grid.Rows(28).Cells("check").Value = True
            Grid.Rows(30).Cells("check").Value = True
            Grid.Rows(31).Cells("check").Value = True
            Grid.Rows(32).Cells("check").Value = True
            Grid.Rows(33).Cells("check").Value = True
            Grid.Rows(34).Cells("check").Value = True

            bolLockGrid = True
        End Sub
        Private Shared Sub writeDirectorGeneral(ByVal Grid As DataGridView)
            Dim I As Integer
            For I = 0 To 34
                Grid.Rows(I).Cells("check").Value = False
            Next

            Grid.Rows(0).Cells("check").Value = True
            Grid.Rows(4).Cells("check").Value = True
            Grid.Rows(9).Cells("check").Value = True
            Grid.Rows(12).Cells("check").Value = True
            Grid.Rows(15).Cells("check").Value = True
            Grid.Rows(17).Cells("check").Value = True
            Grid.Rows(28).Cells("check").Value = True
            Grid.Rows(31).Cells("check").Value = True
            Grid.Rows(34).Cells("check").Value = True

            bolLockGrid = True
        End Sub
        Private Shared Sub writeCommissioner(ByVal Grid As DataGridView)
            Dim I As Integer
            For I = 0 To 34
                Grid.Rows(I).Cells("check").Value = False
            Next

            Grid.Rows(0).Cells("check").Value = True
            Grid.Rows(4).Cells("check").Value = True
            Grid.Rows(9).Cells("check").Value = True
            Grid.Rows(12).Cells("check").Value = True
            Grid.Rows(15).Cells("check").Value = True
            Grid.Rows(17).Cells("check").Value = True
            Grid.Rows(28).Cells("check").Value = True
            Grid.Rows(31).Cells("check").Value = True
            Grid.Rows(34).Cells("check").Value = True

            bolLockGrid = True
        End Sub
        Public Shared Sub getPermissions(ByVal Grid As DataGridView, ByVal role As Integer, Optional ByVal gwidth As Integer = 200)
            populatePermissionGrid(Grid, gwidth)
            Select Case role
                Case 1 : writeAdministrator(Grid)
                Case 2 : writeViewer(Grid)
                Case 3 : writeVoucherOperator(Grid)
                Case 4 : writeScheduleOperator(Grid)
                Case 5 : writeOperator(Grid)
                Case 6 : writeOfficer(Grid)
                Case 7 : writeDirector(Grid)
                Case 8 : writeDirectorGeneral(Grid)
                Case 9 : writeCommissioner(Grid)
                Case Else
                    bolLockGrid = False
            End Select
        End Sub
        Public Shared Function getStatus(ByVal role As Integer) As Char
            Dim statusID As Char
            Select Case role
                Case 1 : statusID = "0"
                Case 2 : statusID = "0"
                Case 3 : statusID = "0"
                Case 4 : statusID = "0"
                Case 5 : statusID = "0"
                Case 6 : statusID = "1"
                Case 7 : statusID = "2"
                Case 8 : statusID = "0"
                Case 9 : statusID = "0"
                Case Else
                    statusID = "0"
            End Select

            Return statusID
        End Function
#End Region
#Region "User List"

        Public Shared Sub populateUserListGrid(ByVal Grid As DataGridView, ByVal cbo As ComboBox)

            With Grid
                .BackgroundColor = Env.GirdBackgroundColor
                .RowsDefaultCellStyle.SelectionBackColor = Env.GirdSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Env.GirdSelectionForeColor
                .AlternatingRowsDefaultCellStyle = Nothing
                .Columns.Clear()
                .Rows.Clear()
                .RowHeadersVisible = False
                .AllowUserToResizeRows = False
                .AllowUserToResizeColumns = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ColumnHeadersVisible = True

                '/serial No.
                .Columns.Add("sn", "S/N")
                .Columns("sn").Width = 35
                .Columns("sn").ReadOnly = True
                .Columns("sn").DefaultCellStyle.BackColor = .RowHeadersDefaultCellStyle.BackColor
                .Columns("sn").SortMode = DataGridViewColumnSortMode.NotSortable

                .Columns.Add("fn", "Full Name")
                .Columns("fn").Width = 200
                .Columns("fn").ReadOnly = True
                .Columns("fn").SortMode = DataGridViewColumnSortMode.NotSortable

                .Columns.Add("usn", "Username")
                .Columns("usn").Width = 150
                .Columns("usn").ReadOnly = True
                .Columns("usn").SortMode = DataGridViewColumnSortMode.NotSortable

                .Columns.Add("r", "Role")
                .Columns("r").Width = 250
                .Columns("r").ReadOnly = True
                .Columns("r").SortMode = DataGridViewColumnSortMode.NotSortable

                '/Check box
                Dim ck As New DataGridViewCheckBoxColumn
                ck.Name = "check"
                ck.HeaderText = ""
                ck.Width = 30
                ck.MinimumWidth = 30
                ck.ReadOnly = True
                .Columns.Add(ck)

                '/Check box
                'Dim btns As New DataGridViewButtonColumn
                'btns.Name = "sections"
                'btns.HeaderText = "Sections"
                'btns.Width = 50
                'btns.MinimumWidth = 50
                'btns.ReadOnly = True
                '.Columns.Add(btns)

                '/Check box
                'Dim btnc As New DataGridViewButtonColumn
                'btnc.Name = "classes"
                'btnc.HeaderText = "Classes"
                'btnc.Width = 50
                'btnc.MinimumWidth = 50
                'btnc.ReadOnly = True
                '.Columns.Add(btnc)

                '/Check box
                'Dim btnsubj As New DataGridViewButtonColumn
                'btnsubj.Name = "subject"
                'btnsubj.HeaderText = "Subjects"
                'btnsubj.Width = 50
                'btnsubj.MinimumWidth = 50
                'btnsubj.ReadOnly = True
                '.Columns.Add(btnsubj)

            End With

            Dim I As Integer
            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable

            Dim SQL As String = "SELECT * FROM USERS ORDER BY NAME"
            Adapter = New FbDataAdapter(SQL, Env.ConStr)

            Table = New DataTable
            Adapter.Fill(Table)

            If Table.Rows.Count = 0 Then Exit Sub

            Grid.Rows.Add(Table.Rows.Count)

            Try
                For I = 0 To Table.Rows.Count - 1
                    Grid.Rows(I).Cells("fn").Value = Table.Rows(I).Item("NAME")
                    Grid.Rows(I).Cells("usn").Value = Table.Rows(I).Item("USERNAME")
                    'cbo.SelectedValue = Table.Rows(I).Item("ROLEID")
                    'Grid.Rows(I).Cells("r").Value = Env.RoleName.Contains(Table.Rows(I).Item("ROLEID"))
                    Grid.Rows(I).Cells("r").Value = Populate.RoleName(Table.Rows(I).Item("ROLEID"))
                    'Grid.Rows(I).Cells("check").Value = cbo.Text
                    Grid.Rows(I).Cells("check").Value = Table.Rows(I).Item("ACTVE")
                    Grid.Rows(I).Cells("fn").Tag = Table.Rows(I).Item("UKEY")
                    Grid.Rows(I).Cells("r").Tag = Table.Rows(I).Item("ROLEID")
                Next
            Catch ex As Exception
                Throw ex
            End Try



            ListSerials(Grid)

        End Sub
        Public Shared Function adminActiveUserList(ByVal Grid As DataGridView) As Boolean
            Dim I As Integer

            For I = 0 To Grid.Rows.Count - 1
                If Grid.Rows(I).Cells("r").Tag = 1 And Grid.Rows(I).Cells("check").Value = 1 Then
                    Return True
                End If
            Next
            Return False

        End Function
        Public Shared Sub saveUserListGrid(ByVal Grid As DataGridView)
            Dim I As Integer
            Dim K As Integer
            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable
            Dim Builder As New FbCommandBuilder
            Dim strPrivilege(20) As String

            Dim SQL As String = "SELECT * FROM USERS ORDER BY NAME"
            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Builder.DataAdapter = Adapter
            Adapter.InsertCommand = Builder.GetInsertCommand
            Adapter.DeleteCommand = Builder.GetDeleteCommand
            Adapter.UpdateCommand = Builder.GetUpdateCommand

            Table = New DataTable
            Adapter.Fill(Table)

            If Table.Rows.Count = 0 Then Exit Sub
            For I = 0 To Table.Rows.Count - 1
                Table.Rows(I).Item("ACTVE") = 0
                For K = 0 To Grid.Rows.Count - 1
                    If Grid.Rows(K).Cells("fn").Tag = Table.Rows(I).Item("UKEY") Then
                        If Grid.Rows(K).Cells("check").Value = 1 Then
                            Table.Rows(I).Item("ACTVE") = 1
                        End If
                        Exit For
                    End If
                Next
            Next
            Adapter.Update(Table)

        End Sub

#End Region

#Region "Subject Assisgned"


        Public Shared Sub subjectAssigned(ByVal Grid As DataGridView, ByVal userid As Long)

            Dim I As Integer
            Dim K As Integer

            Dim Adapter As New FbDataAdapter
            Dim Table As DataTable

            Dim SQL As String = "SELECT * FROM SUBJECTASSIGNED WHERE USERID =" + userid.ToString
            Adapter = New FbDataAdapter(SQL, Env.ConStr)

            Table = New DataTable
            Adapter.Fill(Table)

            If Table.Rows.Count = 0 Then Exit Sub

            If Grid.Rows.Count > 0 Then
                For I = 0 To Grid.Rows.Count - 1
                    Grid.Rows(I).Visible = False
                Next
            End If
            For I = 0 To Table.Rows.Count - 1
                For K = 0 To Grid.Rows.Count - 1
                    If Table.Rows(I).Item("SUBJECT") = Grid.Rows(K).Tag Then
                        Grid.Rows(K).Visible = True
                        Exit For
                    End If
                Next
            Next

        End Sub

#End Region
    End Class

End Namespace