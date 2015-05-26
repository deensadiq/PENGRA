'Imports Opal.Code
Imports System.Windows.Forms
Imports System.Drawing
Imports PENGRA.Connection.Classes
Namespace cForm
    Public Class frmRegisterUser
        'Dim cbo As New cPopulateCombobox
        Private Sub Clear()

            txtName.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtConfirmPassword.Clear()
            cboRoles.SelectedValue = 2

        End Sub


        Private Sub frmStudent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.BackColor = Env.FormBackColor
            'cbo.PopulateRoles(cboRoles, False)
            Clear()
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

            If txtName.Text.Trim = "" Or txtPassword.Text.Trim = "" Or txtConfirmPassword.Text.Trim = "" Or txtUsername.Text.Trim = "" Then
                MessageBox.Show(Messages.Empty, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'If Users.validateUser(txtUsername.Text) = False Then
            '    MessageBox.Show(Messages.UserExist, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            If txtPassword.Text.Trim <> txtConfirmPassword.Text.Trim Then
                MessageBox.Show(Messages.VerifyPassword, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtPassword.SelectAll()
                txtPassword.Focus()
                Exit Sub
            End If

            Try
                'If cUsers.insertUser(txtUsername.Text, txtPassword.Text, txtName.Text, 0, cboRoles.SelectedValue) = True Then
                '    MessageBox.Show(Messages.UserRegistrationSuccessful, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Me.Close()
                'Else
                '    MessageBox.Show(Messages.Duplicate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If

            Catch ex As Exception
                Throw ex
            End Try

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