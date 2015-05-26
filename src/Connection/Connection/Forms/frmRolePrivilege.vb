'Imports Opal.Code
Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports FirebirdSql.Data.FirebirdClient

Namespace Forms
    Public Class frmRolePrivilege


        Dim bolAdd As Boolean
        Dim bolEdit As Boolean

        Dim iSess As Short
        Dim iSem As Short
        Dim ukey As Short

        Dim allowEdit As Integer
        Dim allowAdd As Integer
        Dim rowNum As Integer
        Dim Adapter As FbDataAdapter
        Dim Table As New DataTable
        Dim Builder As New FbCommandBuilder

        'Dim Combo As New cPopulateCombobox
        Dim GuiMan As Gui
        Dim K As Integer

        Public Sub New()

            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            GuiMan = Gui.getGuiManager

        End Sub
        Private Sub LoadRecord()
            Users.loadRolePrivilege(cboRoles.SelectedValue, Grid, 280)
        End Sub

        Private Sub Enable()

            btnEdit.Enabled = False
            cboRoles.Enabled = False
            btnUndo.Enabled = True
            btnSave.Enabled = True
            Grid.Columns(3).ReadOnly = False
        End Sub

        Private Sub Disable()
            btnEdit.Enabled = True
            cboRoles.Enabled = True
            btnUndo.Enabled = False
            btnSave.Enabled = False
            Grid.Columns(3).ReadOnly = True
        End Sub

        Private Sub frmStudent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.BackColor = Env.FormBackColor
            Populate.PopulateRoles(cboRoles)
            LoadRecord()
            Disable()
        End Sub

        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            If Users.LockGrid = True Then Exit Sub
            bolEdit = True
            Enable()
            Grid.BeginEdit(False)
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


            Try
                Grid.EndEdit()
                Users.saveRolePrivilege(cboRoles.SelectedValue, Grid)
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


        Private Sub btnRole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRole.Click
            'GuiMan.setUserRoles(Me)
            Populate.PopulateRoles(cboRoles)
        End Sub


        Private Sub cboRoles_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRoles.SelectedValueChanged
            Try
                LoadRecord()
            Catch ex As Exception

            End Try
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