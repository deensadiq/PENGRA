Imports System.Windows.Forms
Namespace Forms
    Public Class frmConnect

        'This window pops up when the username and password supplied within the connectionstring cannot be used to login
        'It allows the user to set a new username and password in case the database defaults are changed

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            MessageBox.Show(Messages.MustRestart, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

            If txtUsername.Text.Trim = "" Or txtPassword.Text.Trim = "" Then
                MessageBox.Show(Messages.Empty, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            DB.setLogIn(txtUsername.Text.Trim, txtPassword.Text.Trim)

        End Sub

        Private Sub frmConnect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Label3.Text = Application.ProductName & " is unable to login to it's database server. Please enter the login information(Admin) below."
            Dim strUser As String = ""
            Dim strPassword As String = ""

            DB.getLogIn(strUser, strPassword)
            txtUsername.Text = strUser
            txtPassword.Text = strPassword
            Me.BackColor = Env.FormBackColor
        End Sub

        Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click

            Dim strHostName As String

            If txtUsername.Text.Trim = "" Or txtPassword.Text.Trim = "" Then
                MessageBox.Show(Messages.Empty, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            strHostName = DB.getHost
            If strHostName.Trim.Trim = "" Then strHostName = "127.0.0.1"

            If DB.pingHost(strHostName, txtUsername.Text, txtPassword.Text) = True Then
                MessageBox.Show(Messages.Connected, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DB.setLogIn(txtUsername.Text, txtPassword.Text)
            Else
                MessageBox.Show(Messages.NotConnected, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        End Sub
    End Class
End Namespace