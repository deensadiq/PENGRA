Imports PENGRA.Connection.Forms

Namespace Classes
    Public Class Gui
        'Private formServer As frmServer
        Private formConnect As frmConnect
        Private formFindUsers As frmFindUsers
        Private formRegisterUser As frmRegisterUser
        Private formRolePrivilege As frmRolePrivilege
        Private formServer As frmServer
        Private formUserList As frmUserList
        Private formUsers As frmUsers
        Private formChangePassword As frmChangePassword

        Private Shared Guiman As Gui

        Private Sub New()
            'Private constructor to avoid directly creating an instance of this class
            'Use the getGuiManager function to get an instance
            'This is important to avoid creating multiple copies of this class in memory (Singleton Pattern)
        End Sub

        Public Shared Function getGuiManager() As Gui

            If Guiman Is Nothing Then Guiman = New Gui
            Return Guiman

        End Function

#Region "Settings Window"
        Public Sub setServer()
            If formServer Is Nothing Then formServer = New frmServer
            If formServer.IsDisposed = True Then formServer = New frmServer
            formServer.Text = "Server Settings"
            formServer.ShowDialog()
        End Sub
        Public Sub setConnect()
            If formConnect Is Nothing Then formConnect = New frmConnect
            If formConnect.IsDisposed = True Then formConnect = New frmConnect
            formConnect.Text = "Host Name Settings"
            formConnect.ShowDialog()
        End Sub
        Public Sub setFindUsers()
            If formFindUsers Is Nothing Then formFindUsers = New frmFindUsers
            If formFindUsers.IsDisposed = True Then formFindUsers = New frmFindUsers
            formFindUsers.Text = "Find Users"
            formFindUsers.ShowDialog()
        End Sub
        Public Sub showRegisterUser(ByVal parent As Form)
            If formRegisterUser Is Nothing Then formRegisterUser = New frmRegisterUser
            If formRegisterUser.IsDisposed = True Then formRegisterUser = New frmRegisterUser
            formRegisterUser.Text = "Register Users"
            formRegisterUser.Owner = parent
            formRegisterUser.ShowDialog()
        End Sub
        Public Sub showRolePrivilege(ByVal parent As Form)
            If formRolePrivilege Is Nothing Then formRolePrivilege = New frmRolePrivilege
            If formRolePrivilege.IsDisposed = True Then formRolePrivilege = New frmRolePrivilege
            formRolePrivilege.Text = "Role"
            formRolePrivilege.Owner = parent
            formRolePrivilege.ShowDialog()
        End Sub
        Public Sub showUserList(ByVal parent As Form)
            If formUserList Is Nothing Then formUserList = New frmUserList
            If formUserList.IsDisposed = True Then formUserList = New frmUserList
            formUserList.Text = "User List"
            formUserList.MdiParent = parent
            formUserList.Show()
        End Sub
        Public Sub showUsers(ByVal parent As Form)
            If formUsers Is Nothing Then formUsers = New frmUsers
            If formUsers.IsDisposed = True Then formUsers = New frmUsers
            formUsers.Text = "User"
            formUsers.MdiParent = parent
            formUsers.Show()
        End Sub
        Public Sub showChangePassword(ByVal parent As Form)
            If formChangePassword Is Nothing Then formChangePassword = New frmChangePassword
            If formChangePassword.IsDisposed = True Then formChangePassword = New frmChangePassword
            formChangePassword.Text = "Change Password"
            formChangePassword.MdiParent = parent
            formChangePassword.Show()
        End Sub
#End Region
    End Class
End Namespace