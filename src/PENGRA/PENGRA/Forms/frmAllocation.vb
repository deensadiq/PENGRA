Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes

Namespace Forms

    Public Class frmAllocation
        Dim bolAdd As Boolean = False
        Dim bolEdit As Boolean = False

        Dim bld As New FbCommandBuilder
        Dim strSQL As String
        Dim tbl As DataTable
        Dim da As FbDataAdapter

        Dim K As Integer
        Sub New(ByVal Caption As String)

            strSQL = "SELECT * FROM BUDGET"

            InitializeComponent()
            Me.Text = Caption

        End Sub

        Private Sub IsEditMode(ByVal bolEdit As Boolean)
            If bolEdit = True Then
                dgvGrid.ReadOnly = False

                btnEdit.Enabled = False
                btnClose.Enabled = False
                btnRemove.Enabled = False

                btnSave.Enabled = True
                btnCancel.Enabled = True
            Else
                dgvGrid.ReadOnly = True

                btnEdit.Enabled = True
                btnClose.Enabled = True
                btnRemove.Enabled = True

                btnSave.Enabled = False
                btnCancel.Enabled = False
            End If
        End Sub

        Private Sub InitDgv()  'INITIALIZING THE GRID

            da = New FbDataAdapter(strSQL, DB.ConnObj)
            bld.DataAdapter = da

            da.UpdateCommand = bld.GetUpdateCommand
            da.InsertCommand = bld.GetInsertCommand
            da.DeleteCommand = bld.GetDeleteCommand

            tbl = New DataTable

            da.Fill(tbl)

            replaceDoubleApostrophe()

            dgvGrid.Columns.Clear()

            With dgvGrid

                .Columns.Add("sn", "S/N")
                .Columns("sn").Width = 30
                .Columns("sn").Resizable = DataGridViewTriState.False
                .Columns("sn").ReadOnly = True

                .Columns.Add("Code", "Code")
                .Columns("code").Width = 70
                .Columns("code").Resizable = DataGridViewTriState.False
                .Columns("code").DataPropertyName = "CODE"

                .Columns.Add("name", "Description")
                .Columns("name").Width = 300
                .Columns("name").Resizable = DataGridViewTriState.False
                .Columns("name").DataPropertyName = "NAME"

                .DataSource = tbl.DefaultView

                .Columns("UKEY").Visible = False
            End With

            Populate.ListSerials(dgvGrid)

        End Sub

        Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor

            With dgvGrid
                .BackgroundColor = Env.GirdBackgroundColor
                .RowsDefaultCellStyle.SelectionBackColor = Env.GirdSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Env.GirdSelectionForeColor
            End With

            InitDgv()
            IsEditMode(False)
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            If bolEdit = False Then Exit Sub

            tbl.RejectChanges()
            IsEditMode(False)
            Populate.ListSerials(dgvGrid)

            bolAdd = False
            bolEdit = False
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

            If bolEdit = False Then Exit Sub

            checkForApostrophe()

            Try
                da.Update(tbl)
                IsEditMode(False)
                dgvGrid.EndEdit()

                replaceDoubleApostrophe()
                bolAdd = False
                bolEdit = False
            Catch ex As Exception
                If ex.Message.Trim.Contains("violation") = True Then
                    MessageBox.Show("Duplicate record not allowed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    Throw ex
                End If
            End Try
        End Sub

        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

            IsEditMode(True)
            dgvGrid.CurrentCell() = dgvGrid.Rows(dgvGrid.RowCount - 1).Cells(1)
            dgvGrid.BeginEdit(True)

            bolEdit = True

        End Sub

        Private Sub dgvGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvGrid.CellMouseDoubleClick

            IsEditMode(True)
            dgvGrid.CurrentCell() = dgvGrid.Rows(dgvGrid.CurrentCell.RowIndex).Cells(dgvGrid.CurrentCell.ColumnIndex)
            dgvGrid.BeginEdit(True)

            bolEdit = True
        End Sub

        Private Sub dgvGrid_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvGrid.RowsAdded
            Populate.ListSerials(dgvGrid)
        End Sub

        Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
            If bolEdit = True Then Exit Sub

            If MessageBox.Show("Are You Sure You Want To Remove The Current Record?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Try
                dgvGrid.Rows.RemoveAt(dgvGrid.CurrentRow.Index)
                da.Update(tbl)
            Catch ex As Exception
                If ex.Message.Contains("FK_") Then
                    MessageBox.Show(Messages.ForeignKey, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tbl.RejectChanges()
                Else
                    Throw ex
                End If
            End Try
        End Sub

        Private Sub checkForApostrophe()
            Dim description As String

            If tbl.Rows.Count <= 0 Then Exit Sub

            For I As Integer = 0 To tbl.Rows.Count - 1
                description = tbl.Rows(I).Item("NAME").ToString()
                tbl.Rows(I).Item("NAME") = description.Replace("'", "''")
            Next

        End Sub

        Private Sub replaceDoubleApostrophe()
            Dim description As String

            If tbl.Rows.Count <= 0 Then Exit Sub

            For I As Integer = 0 To tbl.Rows.Count - 1
                description = tbl.Rows(I).Item("NAME").ToString()
                tbl.Rows(I).Item("NAME") = description.Replace("''", "'")
            Next

        End Sub
    End Class
End Namespace