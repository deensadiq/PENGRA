Imports System.Windows.Forms
Imports FirebirdSql.Data.FirebirdClient
Imports System.Drawing
Namespace Classes

    Public Class Env

        Enum eUserPriv
            Admin = 0
            Director = 1
            Officer_1 = 2
            Officer_2 = 3
            User_1 = 4
            User_2 = 5
        End Enum

        Public Shared CurrentUser As String
        Public Shared LogInName As String
        Private Shared strCon As String = ""
        Private Shared strCompany As String = ""
        Private Shared strAddress As String = ""
        Private Shared mformBackColor As Color = Color.FromArgb(225, 228, 233)
        Private Shared mGridBackgroundColor As Color = Color.White
        Private Shared mGirdSelectionBackColor As Color = Color.LightYellow
        Private Shared mGirdSelectionForeColor As Color = Color.Black
        Private Shared strProductKey As String = ""
        Private Shared mOpen As Boolean
        Private Shared mUserPriv As eUserPriv
        Private Shared m_branch As Integer
        Private Shared m_calendarYear As Date
        Private Shared current_session As Integer
        Private Shared current_semester As Integer

        Private Shared mroleid As Integer
        Private Shared mrolename As String
        Private Shared muserid As Integer
        Private Shared muserstatus As Char

        Public Shared Add_Records As Boolean
        Public Shared Edit_Records As Boolean
        Public Shared Remove_Records As Boolean
        Public Shared Print_Records As Boolean
        Public Shared Preview_Records As Boolean

        Public Shared LogedIn As Boolean

        Private Shared intYear As Integer
        Private Shared intMonth As Integer

        Public Shared intSetPercentage As Integer

        Private Shared staff_RegDate As Date
        Private Shared staff_ukey As Integer
        Private Shared staff_ID As String
        Private Shared staff_name As String

        Private Shared group_name As String
        Private Shared group_ukey As Integer
        Private Shared group_CODE As String
        Private Shared payment_day As String

        Private Shared status As String

        Public Shared Property UserID() As Integer
            Get
                Return muserid
            End Get

            Set(ByVal value As Integer)
                muserid = value
            End Set

        End Property
        Public Shared Property UserStatus() As Char
            Get
                Return muserstatus
            End Get

            Set(ByVal value As Char)
                muserstatus = value
            End Set

        End Property
        Public Shared Property RoleID() As Integer
            Get
                Return mroleid
            End Get

            Set(ByVal value As Integer)
                mroleid = value
            End Set

        End Property
        Public Shared Property RoleName() As String
            Get
                Return mrolename
            End Get

            Set(ByVal value As String)
                mrolename = value
            End Set

        End Property

        Public Shared Property YEAR() As Integer
            Get
                Return intYear
            End Get

            Set(ByVal value As Integer)
                intYear = value
            End Set

        End Property

        Public Shared Property MONTH() As Integer
            Get
                Return intMonth
            End Get

            Set(ByVal value As Integer)
                intMonth = value
            End Set

        End Property

        Public Shared Property STAFFUKEY() As Integer
            Get
                Return staff_ukey
            End Get

            Set(ByVal value As Integer)
                staff_ukey = value
            End Set

        End Property

        Public Shared Property STAFFID() As String
            Get
                Return staff_ID
            End Get

            Set(ByVal value As String)
                staff_ID = value
            End Set

        End Property

        Public Shared Property STAFFNAME() As String
            Get
                Return staff_name
            End Get

            Set(ByVal value As String)
                staff_name = value
            End Set
        End Property

        Public Shared Property REGDATE() As Date
            Get
                Return staff_RegDate
            End Get

            Set(ByVal value As Date)
                staff_RegDate = value
            End Set
        End Property

        Public Shared Property GROUPNAME() As String
            Get
                Return group_name
            End Get

            Set(ByVal value As String)
                group_name = value
            End Set
        End Property

        Public Shared Property GROUPCODE() As String
            Get
                Return group_CODE
            End Get

            Set(ByVal value As String)
                group_CODE = value
            End Set
        End Property

        Public Shared Property GROUP() As String
            Get
                Return group_ukey
            End Get

            Set(ByVal value As String)
                group_ukey = value
            End Set
        End Property

        Public Shared Property PAYMENTDAY() As String
            Get
                Return payment_day
            End Get

            Set(ByVal value As String)
                payment_day = value
            End Set
        End Property

        Public Shared Property Session() As Integer
            Get
                Return current_session
            End Get

            Set(ByVal value As Integer)
                current_session = value
            End Set

        End Property

        Public Shared Property Semester() As Integer
            Get

                Return current_semester
            End Get

            Set(ByVal value As Integer)
                current_semester = value
            End Set

        End Property

        Public Shared Property ACCOUNTINGPERIOD() As Date
            Get

                Return m_calendarYear
            End Get

            Set(ByVal value As Date)
                m_calendarYear = value
            End Set

        End Property

        Public Shared Property Branch() As Integer
            Get

                Return m_branch
            End Get

            Set(ByVal value As Integer)
                m_branch = value
            End Set

        End Property

        Public Shared Property Open() As Boolean
            Get
                Return mOpen
            End Get

            Set(ByVal value As Boolean)
                mOpen = value
            End Set

        End Property

        Public Shared Property UserPrivillege() As eUserPriv
            Get
                Return mUserPriv
            End Get

            Set(ByVal value As eUserPriv)
                mUserPriv = value
            End Set

        End Property

        Public Shared Property ConStr() As String
            Get

                If strCon.Trim = "" Then strCon = DB.createConnection(Application.StartupPath + "\PENGRAREPORT.DLL", , , )
                Return strCon
            End Get

            Set(ByVal value As String)
                strCon = value
            End Set

        End Property

        Public Shared Property Company() As String
            Get
                If strCompany.Trim = "" Then strCompany = "UNLICENCED"
                Return strCompany
            End Get

            Set(ByVal value As String)
                strCompany = value
            End Set

        End Property

        Public Shared Property Address() As String
            Get
                If strAddress.Trim = "" Then strAddress = ""
                Return strAddress
            End Get

            Set(ByVal value As String)
                strAddress = value
            End Set

        End Property

        Public Shared Property ProductKey() As String
            Get
                If strProductKey.Trim = "" Then strProductKey = ""
                Return strProductKey
            End Get

            Set(ByVal value As String)
                strProductKey = value
            End Set

        End Property

        Public Shared Property FormBackColor() As Color
            Get
                Return mformBackColor
            End Get

            Set(ByVal value As Color)
                mformBackColor = value
            End Set

        End Property

        Public Shared Property GirdBackgroundColor() As Color
            Get
                Return mGridBackgroundColor
            End Get

            Set(ByVal value As Color)
                mGridBackgroundColor = value
            End Set

        End Property

        Public Shared Property GirdSelectionBackColor() As Color
            Get
                Return mGirdSelectionBackColor
            End Get

            Set(ByVal value As Color)
                mGirdSelectionBackColor = value
            End Set

        End Property

        Public Shared Property GirdSelectionForeColor() As Color
            Get
                Return mGirdSelectionForeColor
            End Get

            Set(ByVal value As Color)
                mGirdSelectionForeColor = value
            End Set

        End Property

        Public Shared ReadOnly Property GetStatus As String
            Get
                status = "2"
                Return status
            End Get
        End Property

        Public Shared Property ColorTheme() As Color

            Get
                Dim RegKey As Microsoft.Win32.RegistryKey
                Dim BColor As Color

                RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\PENGRA")
                If RegKey Is Nothing Then
                    BColor = Color.White
                Else
                    If Not RegKey.GetValue("colortheme") = Nothing Then
                        BColor = Color.FromName(RegKey.GetValue("colortheme"))
                    Else
                        BColor = Color.WhiteSmoke
                    End If
                    RegKey.Close()
                End If

                Return BColor

            End Get

            Set(ByVal value As Color)

                Dim RegKey As Microsoft.Win32.RegistryKey

                RegKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\PENGRA")
                RegKey.SetValue("colortheme", value.Name)
                RegKey.Flush()
                RegKey.Close()

            End Set

        End Property


    End Class
End Namespace
