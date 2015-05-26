Imports System.Windows.Forms
Imports System.Drawing
Namespace Forms
    Public Class frmChangePassword

        Private Sub Clear()

            txtOPassword.Clear()
            txtPassword.Clear()
            txtConfirmPassword.Clear()

        End Sub


        Private Sub frmStudent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Me.BackColor = Env.FormBackColor
            Clear()
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

            'If txtPassword.Text.Trim = "" Or txtConfirmPassword.Text.Trim = "" Or txtOPassword.Text.Trim = "" Then
            '    MessageBox.Show(Messages.Empty, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            'If cUsers.validateUserPassword(txtOPassword.Text) = False Then
            '    MessageBox.Show(Messages.VerifyPassword, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    txtOPassword.SelectAll()
            '    txtOPassword.Focus()
            '    Exit Sub
            'End If

            'If txtPassword.Text.Trim <> txtConfirmPassword.Text.Trim Then
            '    MessageBox.Show(Messages.VerifyPassword, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    txtPassword.SelectAll()
            '    txtPassword.Focus()
            '    Exit Sub
            'End If

            'Try
            '    If cUsers.updateUserPassword(txtPassword.Text, Env.UserID) = True Then
            '        MessageBox.Show(Messages.ChangedPasswordSuccessful, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        Me.Close()
            '    End If

            'Catch ex As Exception
            '    Throw ex
            'End Try

        End Sub


        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
            txtPassword.SelectAll()
        End Sub

        Private Sub txtConfirmPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConfirmPassword.GotFocus
            txtConfirmPassword.SelectAll()
        End Sub
    End Class
End Namespace