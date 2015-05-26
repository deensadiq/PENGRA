Imports System.Windows.Forms
Imports PENGRA.Connection.Forms
Imports FirebirdSql.Data.FirebirdClient

Namespace Classes
    Public Class ConnectionForms

        Private Shared Guiman As ConnectionForms

        Private formConnect As frmConnect
        'Private formPrivilege As frmPrivilege
        Private formServer As frmServer

        Private Sub New()
            'Private constructor to avoid directly creating an instance of this class
            'Use the getGuiManager function to get an instance
            'This is important to avoid creating multiple copies of this class in memory (Singleton Pattern)
        End Sub

        Public Shared Function getGuiManager() As ConnectionForms

            If Guiman Is Nothing Then Guiman = New ConnectionForms
            Return Guiman

        End Function

#Region "Connection"
        Public Sub showConnect(ByVal parent As Form)

            formConnect = New frmConnect
            formConnect.ShowDialog(parent)

        End Sub

        Public Sub showServer(ByVal parent As Form)

            formServer = New frmServer
            formServer.ShowDialog(parent)

        End Sub

        'Public Sub showPrivilege(ByVal parent As Form)

        '    formPrivilege = New frmPrivilege
        '    formPrivilege.Text = "Add User"
        '    formPrivilege.MdiParent = parent
        '    formPrivilege.Show()

        'End Sub

#End Region

    End Class
End Namespace