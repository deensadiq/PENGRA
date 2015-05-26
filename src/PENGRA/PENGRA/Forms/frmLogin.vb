Imports PENGRA.Connection.Classes

Namespace Forms

    Public Class frmLogin

        Private Sub LogUser()

            Env.LogedIn = False
            If Passwords.Login(txtUsername.Text.Trim, txtPassword.Text.Trim.GetHashCode) = True Then
                Env.LogedIn = True
                Me.Close()
            Else
                MessageBox.Show(Messages.AccessDenied, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        End Sub
        Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
            LogUser()
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            btnLogin.Focus()
        End Sub

        Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
            If e.KeyValue = Keys.Enter Then
                LogUser()
            End If
        End Sub

    End Class
End Namespace