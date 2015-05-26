'Imports Opal.Code
Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports FirebirdSql.Data.FirebirdClient
Namespace Forms
    Public Class frmUserList


        Dim bolAdd As Boolean
        Dim bolEdit As Boolean

        Dim rowNum As Integer
        Dim Adapter As FbDataAdapter
        Dim Table As New DataTable
        Dim Builder As New FbCommandBuilder


        Dim GuiMan As Gui
        'Dim Combo As New cPopulateCombobox
        Dim K As Integer

        Public Sub New()

            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            GuiMan = Gui.getGuiManager

        End Sub
        Private Sub LoadRecord()

            Users.populateUserListGrid(Grid, cbo)

        End Sub

        Private Sub Enable()
            btnEdit.Enabled = False
            btnUndo.Enabled = True
            btnSave.Enabled = True
            Grid.Columns(4).ReadOnly = False
        End Sub

        Private Sub Disable()
            btnEdit.Enabled = True
            btnUndo.Enabled = False
            btnSave.Enabled = False
            Grid.Columns(4).ReadOnly = True
        End Sub

        Private Sub frmStudent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.BackColor = Env.FormBackColor
            cbo.Visible = False
            Populate.PopulateRoles(cbo)
            LoadRecord()
            Disable()
            bolEdit = False
        End Sub

        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            If Grid.Rows.Count = 0 Then Exit Sub
            Enable()
            bolEdit = True
            Grid.BeginEdit(False)
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

            Try
                Grid.EndEdit()
                If Users.adminActiveUserList(Grid) = False Then
                    MessageBox.Show(Messages.ActiveAdministrator, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Users.saveUserListGrid(Grid)
                Disable()
                bolEdit = False
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
            LoadRecord()
            Disable()
            bolEdit = False

        End Sub

        Private Sub Grid_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick
            'If bolEdit = True Then Exit Sub
            'If e.RowIndex < 0 Then Exit Sub

            'Env.RoleID = Grid.Rows(e.RowIndex).Cells(3).Tag
            'Env.RoleName = Grid.Rows(e.RowIndex).Cells(3).Value
            'Env.UserID = Grid.Rows(e.RowIndex).Cells(1).Tag

            'If Env.UserID = 0 Then Exit Sub

            'Select Case e.ColumnIndex
            '    Case 5
            '        'GuiMan.setCategoryAssigned(Me)
            '    Case 6
            '        'GuiMan.setClassAssigned(Me)
            '    Case 7
            '        'GuiMan.setSubjectAssigned(Me)
            'End Select
        End Sub


        Private Sub Grid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Grid.CellMouseDoubleClick
            If bolEdit = False Then Exit Sub
            If K = 1 Then
                K = 0
            Else
                K = 1
            End If
            Users.checkboxAll(Grid, K)
        End Sub
    End Class


End Namespace