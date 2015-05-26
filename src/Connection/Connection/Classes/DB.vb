Namespace Classes

    Public Class DB

        Private Shared strDatabase As String
        Private Shared strUser As String
        Private Shared strPassword As String
        Private Shared strHost As String
        Private Shared Conn As FbConnection


        Public Shared Property DataBase() As String
            Get
                Return strDatabase
            End Get
            Set(ByVal value As String)
                strDatabase = value
            End Set
        End Property

        Public Shared Property User() As String
            Get
                Return strUser
            End Get
            Set(ByVal value As String)
                strUser = value
            End Set
        End Property

        Public Shared Property Password() As String
            Get
                Return strPassword
            End Get
            Set(ByVal value As String)
                strPassword = value
            End Set
        End Property

        Public Shared Property Host() As String
            Get
                Return strHost
            End Get
            Set(ByVal value As String)
                strHost = value
            End Set
        End Property

        Public Shared Property ConnObj() As FbConnection
            Get
                Return Conn
            End Get
            Set(ByVal value As FbConnection)
                Conn = value
            End Set
        End Property

        Public Shared Function ConnectionString() As String

            Dim strConnection As String

            strConnection = "Database = " & strDatabase & "; User = " & strUser & " ; Password = " & strPassword & "; Server =localhost; MaxPoolSize = 1000"
            Return strConnection

        End Function

        Public Shared Function createConnection(ByVal Database As String, Optional ByVal Host As String = "127.0.0.1", Optional ByVal User As String = "SYSDBA", Optional ByVal Password As String = "masterkey") As String

            Dim strConnection As String

            strConnection = "Database = " & Database & "; User = " & User & " ; Password = " & Password & "; Server =" & Host & "; MaxPoolSize = 1000"

            Return strConnection

        End Function

        Public Shared Sub setHost(ByVal Hostname As String)

            Dim RKey As Microsoft.Win32.RegistryKey

            RKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\PENGRA")
            RKey.SetValue("host", Hostname)
            RKey.Flush()
            RKey.Close()

        End Sub

        Public Shared Function getHost() As String

            Dim RKey As Microsoft.Win32.RegistryKey
            Dim strHost As String = "localhost"

            RKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\PENGRA")

            If Not RKey Is Nothing Then
                If Not RKey.GetValue("host") Is Nothing Then strHost = RKey.GetValue("Host").ToString Else strHost = "localhost"
                RKey.Close()
            End If

            Return strHost

        End Function

        Public Shared Function pingHost(ByVal Hostname As String, Optional ByVal Username As String = "", Optional ByVal Password As String = "", Optional ByRef Message As String = "") As Boolean

            Dim ConnectionString As String
            Dim Conn As New FirebirdSql.Data.FirebirdClient.FbConnection

            If Username.Trim = "" And Password.Trim = "" Then
                ConnectionString = createConnection("PENGRA", Hostname, , )
            Else
                ConnectionString = createConnection("PENGRA", Hostname, Username, Password)
            End If

            Try
                Conn.ConnectionString = ConnectionString
                Conn.Open()
                If Conn.State = ConnectionState.Open Then Return True Else Return False

            Catch ex As Exception

                Message = ex.Message
                Return False

            End Try

        End Function

        Public Shared Sub setLogIn(ByVal Username As String, ByVal Password As String)


            Dim RKey As Microsoft.Win32.RegistryKey

            RKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\PENGRA")
            RKey.SetValue("username", Username)
            RKey.SetValue("password", Password)
            RKey.Flush()
            RKey.Close()

        End Sub

        Public Shared Sub getLogIn(ByRef Username As String, ByRef Password As String)


            Dim RKey As Microsoft.Win32.RegistryKey
            Dim strHost As String = ""

            Username = ""
            Password = ""

            RKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\PENGRA")

            If Not RKey Is Nothing Then
                If RKey.GetValue("username") Is Nothing Then Username = "SYSDBA" Else Username = RKey.GetValue("username").ToString
                If RKey.GetValue("password") Is Nothing Then Password = "masterkey" Else Password = RKey.GetValue("password").ToString
                RKey.Close()
            End If

        End Sub

    End Class

End Namespace
