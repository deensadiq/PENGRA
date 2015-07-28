Namespace Classes
    Public Class Passwords

        'Checks wether a password is set so that a login dialog will be displayed
        Public Shared Function Isset() As Boolean

            Dim da As FbDataAdapter
            Dim tbl As New DataTable

            Dim strSQL As String = "SELECT * FROM USERS a"

            da = New FbDataAdapter(strSQL, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count = 0 Then
                '----------------------------------------
                'Set User Variables
                '----------------------------------------
                Env.UserPrivillege = Env.eUserPriv.Admin
                Env.RoleID = 1
                Env.UserID = 0
                Env.UserStatus = "2"
                Users.setUserPrivileges(Env.RoleID)

                Return False
            Else
                Return True
            End If

        End Function

        'Checks wether a password is set so that a login dialog will be displayed
        Public Shared Function IsAdminset() As Boolean

            Dim da As FbDataAdapter
            Dim tbl As New DataTable

            Dim strSQL As String = "SELECT * FROM USERS a WHERE a.PRIV = 'Admin'"

            da = New FbDataAdapter(strSQL, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then Return True Else Return False

        End Function

        'Returns True if Login is successfull
        Public Shared Function Login(ByVal strUser As String, ByVal strPassword As String) As Boolean
            Dim da As FbDataAdapter
            Dim tbl As New DataTable

            Dim strSQL As String = "SELECT * FROM USERS a where a.USERNAME = '" & strUser & "' AND a.PASSD = '" & strPassword & "' AND ACTVE=1"

            da = New FbDataAdapter(strSQL, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then
                If tbl.Rows(0).Item("USERNAME") = strUser And tbl.Rows(0).Item("PASSD") = strPassword Then
                    Env.CurrentUser = tbl.Rows(0).Item("NAME")
                    Env.LogInName = tbl.Rows(0).Item("USERNAME")
                    'Env.Branch = tbl.Rows(0).Item("BRANCH")
                    'Env.UserPrivillege = tbl.Rows(0).Item("PRIV")
                    Env.UserPrivillege = Env.eUserPriv.Admin
                    Env.RoleID = tbl.Rows(0).Item("ROLEID")
                    Env.UserStatus = tbl.Rows(0).Item("STATUSID")
                    Env.UserID = tbl.Rows(0).Item("UKEY")
                    Users.setUserPrivileges(Env.RoleID)
                    Return True
                Else
                    Env.CurrentUser = ""
                    Env.LogInName = ""
                    Env.UserPrivillege = Env.eUserPriv.Admin
                    Env.RoleID = 1
                    Env.UserID = 0
                    Env.UserStatus = Users.getStatus(Env.RoleID)
                    Users.setUserPrivileges(Env.RoleID)
                    Return False
                End If
            Else
                Env.CurrentUser = ""
                Env.LogInName = ""
                Env.UserPrivillege = Env.eUserPriv.Admin
                Env.RoleID = 1
                Env.UserStatus = "2"
                Env.UserID = 0
                Return False
            End If


        End Function
    End Class
End Namespace