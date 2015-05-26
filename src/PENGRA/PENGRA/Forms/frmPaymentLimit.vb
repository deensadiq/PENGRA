Imports System.Windows.Forms
Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes

Namespace Forms
    Public Class frmPaymentLimit



        Dim bolAdd As Boolean
        Dim bolEdit As Boolean
        Dim bolSave As Boolean

        Dim Adapter As FbDataAdapter
        Dim Table As DataTable
        Dim Builder As New FbCommandBuilder
        Dim iLimitValue As Double

        Dim iSess As Short
        Dim iSem As Short
        Dim ukey As Short

        Dim allowEdit As Integer
        Dim allowAdd As Integer
        Dim rowcount As Integer

        Private Sub Enable()

            txtPaymentLimit.Enabled = True
            chkOverride.Enabled = True

            btnEdit.Enabled = False
            btnUndo.Enabled = True
            btnSave.Enabled = True

        End Sub

        Private Sub Disable()

            txtPaymentLimit.Enabled = False
            chkOverride.Enabled = False

            btnEdit.Enabled = True
            btnUndo.Enabled = False
            btnSave.Enabled = False

        End Sub

        Private Sub LoadData()
            Dim str As String

            Table = New DataTable
            str = "SELECT * FROM PAYMENTLIMIT a"

            Adapter = New FbDataAdapter(str, Env.ConStr)

            Builder.DataAdapter = Adapter
            Adapter.InsertCommand = Builder.GetInsertCommand
            Adapter.DeleteCommand = Builder.GetDeleteCommand
            Adapter.UpdateCommand = Builder.GetUpdateCommand

            Adapter.Fill(Table)

            If Table.Rows.Count = 0 Then
                txtPaymentLimit.Text = Format(0, "#,##0.00")
            Else
                txtPaymentLimit.Text = Format(Table.Rows(0).Item(0), "#,##0.00")
            End If
        End Sub

        Private Sub toTable(ByVal Ro As DataRow)

            With Ro
                .Item(0) = txtPaymentLimit.Text.Trim
            End With
        End Sub

        Private Sub frmStudent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.BackColor = Env.FormBackColor
            bolSave = True

            LoadData()
            Disable()
        End Sub

        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

            bolEdit = True
            bolAdd = False
            Enable()
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

            If validateSave() = False Then Exit Sub

            If Table.Rows.Count = 0 Then
                Dim ro As DataRow
                ro = Table.NewRow
                Table.Rows.Add(ro)
            End If

            Try
                toTable(Table.Rows(0))

                Adapter.Update(Table)
                btnUndo.PerformClick()

                '=============================================================
                'Update Employee Total Benefit Limit For Process
                '=============================================================
                If chkOverride.Checked = True Then bwLimit.RunWorkerAsync()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Function validateEdit() As Boolean
            Return True
        End Function

        Private Function validateSave() As Boolean
            If IsNumeric(txtPaymentLimit.Text.Trim) = False Then
                MessageBox.Show("You Entered '" & txtPaymentLimit.Text.Trim & "' Limit Value Most Be A Numerical Value.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnUndo.PerformClick()
                Return False
            End If

            If CDec(txtPaymentLimit.Text.Trim) <= 0 Then
                MessageBox.Show("You Entered '" & txtPaymentLimit.Text.Trim & "' Limit Value Most Be Greater Than Zero(0).", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnUndo.PerformClick()
                Return False
            End If

            Return True
        End Function

        Private Sub undoEdit()

        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click

            bolEdit = False
            bolAdd = False
            LoadData()
            Disable()
        End Sub

        Private Sub bwCalendar_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwLimit.DoWork
            Dim J As Integer
            Dim k As Integer
            Dim iGratuity As Double = 0
            Dim iPension As Double = 0
            Dim iDeathPension As Double = 0
            Dim iTotalBenefit As Double = 0
            Dim iAdapter As FirebirdSql.Data.FirebirdClient.FbDataAdapter
            Dim iTable As New DataTable

            Dim conn As New FirebirdSql.Data.FirebirdClient.FbConnection(Env.ConStr)
            conn.Open()

            '=======================================================================
            ' Make Sure Query Will Include Employee That There Payment Limit
            ' Has Been Set To Zero(0) But No Payment Has Been Made in There Account
            '=======================================================================
            Dim strSQL As String = "SELECT * FROM EMPLOYEEBENEFITS a WHERE a.LIMIT = 0"

            iAdapter = New FirebirdSql.Data.FirebirdClient.FbDataAdapter(strSQL, Env.ConStr)
            iAdapter.Fill(iTable)
            rowcount = iTable.Rows.Count
            bwLimit.ReportProgress(0)

            J = 1
            If rowcount > 0 Then
                For Each t As DataRow In iTable.Rows
                    If Not IsDBNull(t.Item(3)) Then iGratuity = t.Item(3)
                    If Not IsDBNull(t.Item(4)) Then iPension = t.Item(4)
                    If Not IsDBNull(t.Item(5)) Then iDeathPension = t.Item(5)
                    iTotalBenefit = iGratuity + iPension + iDeathPension
                    If iTotalBenefit > CDec(Table.Rows(0).Item(0)) Then
                        t.Item("LIMIT") = 1
                    End If
                    k = CInt((J / rowcount) * 100)
                    bwLimit.ReportProgress(k)
                    J += 1
                Next
            End If
            If rowcount > 0 Then iAdapter.Update(iTable)
            conn.Close()

        End Sub

        Private Sub bwCalendar_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLimit.ProgressChanged
            If e.ProgressPercentage = 0 Then
                pbLimit.Step = 1
                pbLimit.Minimum = 0
                pbLimit.Maximum = rowcount
            End If

            If e.ProgressPercentage > rowcount Or e.ProgressPercentage < 1 Then Exit Sub
            pbLimit.Value = e.ProgressPercentage

        End Sub

        Private Sub bwCalendar_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLimit.RunWorkerCompleted
            MessageBox.Show(Messages.Completed, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            pbLimit.Value = 0
            lblCalendar.Text = ""
        End Sub

    End Class


End Namespace