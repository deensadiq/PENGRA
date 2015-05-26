'Imports Opal.Code
Imports System.Windows.Forms
Imports System.Drawing
Imports PENGRA.Classes
Imports PENGRA.Connection.Classes
Imports PENGRA.Connection.Forms
Namespace Forms
    Public Class frmUsers
        'Dim cbo As New cPopulateCombobox
        Dim bolAdd As Boolean
        Dim bolEdit As Boolean
        Dim userID As Long
        Dim GuiMan As Gui
        Public Sub New()

            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            GuiMan = Gui.getGuiManager

        End Sub
        Private Sub Clear()

            txtName.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            txtConfirmPassword.Clear()
            cboRoles.SelectedValue = 2
            chkActive.Checked = False
            picPhoto.Image = Nothing
            picSign.Image = Nothing
            chkActive.Checked = False
        End Sub
        Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.BackColor = Env.FormBackColor
            Users.populatePermissionGrid(Grid)
            Populate.PopulateRoles(cboRoles)
            Clear()
            Disable()

        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub


        Private Sub Enable()

            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnSearch.Enabled = False
            btnUndo.Enabled = True
            btnSave.Enabled = True

            txtName.Enabled = True
            txtPassword.Enabled = True
            txtConfirmPassword.Enabled = True
            txtUsername.Enabled = True
            cboRoles.Enabled = True
            chkActive.Enabled = True

        End Sub

        Private Sub Disable()

            btnAdd.Enabled = True
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnSearch.Enabled = True
            btnUndo.Enabled = False
            btnSave.Enabled = False

            txtName.Enabled = False
            txtPassword.Enabled = False
            txtConfirmPassword.Enabled = False
            txtUsername.Enabled = False
            cboRoles.Enabled = False
            chkActive.Enabled = False

        End Sub
        Private Sub loadRecord()
            Clear()

            Dim tbl As New DataTable

            tbl = Users.loadUser(userID)
            If tbl.Rows.Count = 0 Then Exit Sub
            txtName.Text = tbl.Rows(0).Item("NAME")
            txtUsername.Text = tbl.Rows(0).Item("USERNAME")
            cboRoles.SelectedValue = tbl.Rows(0).Item("ROLEID")
            chkActive.Checked = tbl.Rows(0).Item("ACTVE")
            picPhoto.Image = Scanner.getPicture(tbl.Rows(0).Item("PHOTO"))
            picSign.Image = Scanner.getPicture(tbl.Rows(0).Item("SIGNATURE"))

        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            If txtName.Text.Trim = "" Or txtUsername.Text.Trim = "" Then
                MessageBox.Show(Messages.Empty, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If bolAdd = True Then
                If txtPassword.Text.Trim = "" Or txtConfirmPassword.Text.Trim = "" Then
                    MessageBox.Show(Messages.Empty, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            If Users.validateUser(txtUsername.Text, userID) = False Then
                MessageBox.Show(Messages.UserExist, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If txtPassword.Text.Trim <> txtConfirmPassword.Text.Trim And txtPassword.Text.Trim <> "" Then
                MessageBox.Show(Messages.VerifyPassword, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtPassword.SelectAll()
                txtPassword.Focus()
                Exit Sub
            End If
            If Users.adminExist(userID) = False And cboRoles.SelectedValue <> 1 Then
                MessageBox.Show(Messages.NoAdministrator, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Try
                If bolAdd = True Then
                    If cboRoles.SelectedValue = 1 Then chkActive.Checked = True
                    If Users.insertUser(txtUsername.Text, txtPassword.Text, txtName.Text, chkActive.CheckState, cboRoles.SelectedValue, Users.getStatus(cboRoles.SelectedValue)) = True Then
                        Disable()
                    Else
                        MessageBox.Show(Messages.Duplicate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                If bolEdit = True Then
                    If chkActive.Checked = False Then
                        If Users.adminActive(userID) = False Then
                            If cboRoles.SelectedValue = 1 Then
                                MessageBox.Show(Messages.ActiveAdministrator, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        End If

                    End If
                    If Users.updateUser(txtUsername.Text, txtPassword.Text, txtName.Text, chkActive.CheckState, cboRoles.SelectedValue, userID) = True Then
                        Disable()
                    Else
                        MessageBox.Show(Messages.Duplicate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try



        End Sub
        Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
            txtPassword.SelectAll()
        End Sub

        Private Sub txtConfirmPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConfirmPassword.GotFocus
            txtConfirmPassword.SelectAll()
        End Sub


        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            If userID = 0 Then Exit Sub
            bolEdit = True
            bolAdd = False
            Enable()
            txtName.Focus()
        End Sub

        Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
            bolEdit = False
            bolAdd = True
            Enable()
            Clear()
            userID = 0
            txtName.Focus()
        End Sub

        Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
            bolEdit = False
            bolAdd = False
            Disable()
            loadRecord()
        End Sub

        Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
            Dim F As New frmFindUsers
            F.ShowDialog()
            If F.CancelRecord = False Then
                userID = F.UserID.ToString
                loadRecord()
            End If

        End Sub


        Private Sub cboRoles_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRoles.SelectedValueChanged
            Try
                Users.getPermissions(Grid, cboRoles.SelectedValue)
            Catch ex As Exception

            End Try

        End Sub


        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

            If Env.UserPrivillege = Env.eUserPriv.User_2 Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If userID = 0 Then Exit Sub
            If Users.adminActive(userID) = False Then
                MessageBox.Show(Messages.ActiveAdministrator, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show(Messages.Delete, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Try
                Users.removeUser(userID)
                Clear()
                userID = 0
            Catch ex As Exception
                If ex.Message.Contains("FK_") Then
                    MessageBox.Show(Messages.ForeignKey, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Throw ex
                End If
            End Try

        End Sub

        Private Sub btnRole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRole.Click
            'GuiMan.setUserRoles(Me)
            Populate.PopulateRoles(cboRoles)
        End Sub
    End Class
End Namespace