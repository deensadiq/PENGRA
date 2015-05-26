Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes


Namespace Forms

    Public Class frmSalaryTable
        Dim I As Integer
        Dim mStruc As Integer
        Dim mType As Integer
        Dim mAllow As Integer
        Dim mAppt As Integer

        Private Sub IsEditMode(ByVal bolEdit As Boolean)
            If bolEdit = True Then
                btnEdit.Enabled = False
                btnClose.Enabled = False

                btnSave.Enabled = True
                btnCancel.Enabled = True
                ckbActive.Enabled = True
            ElseIf bolEdit = False Then
                btnEdit.Enabled = True
                btnClose.Enabled = True

                btnSave.Enabled = False
                btnCancel.Enabled = False
                ckbActive.Enabled = False
            End If
        End Sub

        Private Sub LoadCombo()
            Populate.comboBox(cboSalaryScale, "SELECT * FROM SALARYSCALE")
            Populate.GetRenumerationType(cboType)
        End Sub

        Private Sub LoadData()
            If cboSalaryScale.Text = "" Or cboType.Text = "" Or cboAllowance.Text = "" Then Exit Sub

            mType = cboType.SelectedIndex
            mStruc = cboSalaryScale.SelectedValue
            mAllow = cboAllowance.SelectedValue

            LoadGrid(cboSalaryScale.SelectedValue, cboType.SelectedIndex, cboAllowance.SelectedValue)

        End Sub
       
        Public Sub LoadGrid(ByVal struc As Integer, ByVal typ As Integer, ByVal allow As Integer)
            Dim tbl As DataTable
            Dim cmd As New FbCommand
            Dim da As New FbDataAdapter

            Dim r As Integer
            Dim c As Integer



            mStruc = struc
            mType = typ
            mAllow = allow
            'mAppt = appt

            dgvGrid.Columns.Clear()
            Populate.WriteColumn(dgvGrid, "cGL", "GRADE LEVEL", 75, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)

            For I As Integer = 1 To 15
                Populate.WriteColumn(dgvGrid, "cCode" + I.ToString, "STEP" + I.ToString, 75, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                dgvGrid.Columns(I).ValueType = GetType(Double)
                dgvGrid.Columns(I).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvGrid.Columns(I).DefaultCellStyle.Format = "#,##0.00"

            Next
            dgvGrid.Columns(0).ReadOnly = True
            dgvGrid.RowCount = 17
            Populate.ListSerials(dgvGrid)
            dgvGrid.ReadOnly = True

            tbl = New DataTable
            If typ = 1 Then da = New FbDataAdapter("select * from SETENTITLEMENT where structure='" & struc & "' and entitlement='" & allow & "'", DB.ConnObj)
            If typ = 2 Then da = New FbDataAdapter("select * from SETDEDUCTIONS where structure='" & struc & "' and recoveries='" & allow & "'", DB.ConnObj)
            'If typ = 3 Then da = New FbDataAdapter("select * from tbl_setloan where structure='" & struc & "' and loan='" & allow & "'", DB.ConnObj)
            'If typ = 4 Then da = New FbDataAdapter("select * from tbl_setcontribution where structure='" & struc & "' and contribution='" & allow & "'", DB.ConnObj)

            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then
                For I As Integer = 0 To tbl.Rows.Count - 1
                    r = tbl.Rows(I).Item("GL").ToString
                    c = tbl.Rows(I).Item("ST").ToString
                    dgvGrid.Item(c, r - 1).Value = tbl.Rows(I).Item("amount")
                Next
            End If

            If tbl.Rows.Count > 0 Then
                If tbl.Rows(I).Item("STATUS").ToString = "1" Then
                    ckbActive.CheckState = CheckState.Checked
                Else
                    ckbActive.CheckState = CheckState.Unchecked
                End If

            End If
        End Sub

        Public Sub displayInfo(ByVal struc As String, ByVal allow As String)
            'txtPaygroup.Text = struc
            'txtType.Text = allow
            'txtAppt.Text = appt
        End Sub

        Private Sub SaveRecord()
            Dim I As Integer
            Dim tbl As DataTable
            Dim cmd As New FbCommand
            Dim da As New FbDataAdapter
            Dim bld As New FbCommandBuilder


            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            tbl = New DataTable
            bld = New FbCommandBuilder

            If mType = 1 Then da = New FbDataAdapter("select * from SETENTITLEMENT where structure='" & mStruc & "' and entitlement='" & mAllow & "'", DB.ConnObj)
            If mType = 2 Then da = New FbDataAdapter("select * from SETDEDUCTIONS where structure='" & mStruc & "'  and recoveries='" & mAllow & "'", DB.ConnObj)
            'If mType = 2 Then da = New FbDataAdapter("select * from tbl_setloan where structure='" & mStruc & "'  and loan='" & mAllow & "'", DB.ConnObj)
            'If mType = 3 Then da = New FbDataAdapter("select * from tbl_setcontribution where structure='" & mStruc & "'  and contribution='" & mAllow & "'", DB.ConnObj)

            bld.DataAdapter = da

            da.UpdateCommand = bld.GetUpdateCommand
            da.InsertCommand = bld.GetInsertCommand
            da.DeleteCommand = bld.GetDeleteCommand
            da.Fill(tbl)


            Dim r As Integer
            Dim c As Integer
            Dim K As Integer
            Dim amount As Double

            With dgvGrid
                For I = 0 To .Rows.Count - 1
                    r = I
                    For K = 1 To 15
                        c = K
                        If Not IsDBNull(.Item(c, r).Value) Then

                            If Not .Item(c, r).Value = 0 Then
                                amount = dgvGrid.Item(c, r).Value
                                Dim Ro As DataRow
                                Dim bolRo As Boolean = False
                                Dim N As Integer

                                For N = 0 To tbl.Rows.Count - 1
                                    If mType = 1 Then

                                        If (tbl.Rows(N).Item("GL") = r + 1) And (tbl.Rows(N).Item("ST") = c) And (mAllow = tbl.Rows(N).Item("entitlement")) Then

                                            tbl.Rows(N).Item("amount") = amount
                                            If ckbActive.CheckState = CheckState.Checked Then
                                                tbl.Rows(N).Item("status") = 1
                                            Else
                                                tbl.Rows(N).Item("status") = 0
                                            End If

                                            bolRo = True
                                        End If

                                    ElseIf mType = 2 Then
                                        If (tbl.Rows(N).Item("GL") = r + 1) And (tbl.Rows(N).Item("ST") = c) And (mAllow = tbl.Rows(N).Item("recoveries")) Then

                                            tbl.Rows(N).Item("amount") = amount
                                            If ckbActive.CheckState = CheckState.Checked Then
                                                tbl.Rows(N).Item("status") = 1
                                            Else
                                                tbl.Rows(N).Item("status") = 0
                                            End If

                                            bolRo = True
                                        End If
                                    ElseIf mType = 3 Then
                                        If (tbl.Rows(N).Item("GL") = r + 1) And (tbl.Rows(N).Item("ST") = c) And (mAllow = tbl.Rows(N).Item("loan")) Then

                                            tbl.Rows(N).Item("amount") = amount
                                            If ckbActive.CheckState = CheckState.Checked Then
                                                tbl.Rows(N).Item("status") = 1
                                            Else
                                                tbl.Rows(N).Item("status") = 0
                                            End If

                                            bolRo = True
                                        End If
                                    ElseIf mType = 4 Then
                                        If (tbl.Rows(N).Item("GL") = r + 1) And (tbl.Rows(N).Item("ST") = c) And (mAllow = tbl.Rows(N).Item("contribution")) Then

                                            tbl.Rows(N).Item("amount") = amount
                                            If ckbActive.CheckState = CheckState.Checked Then
                                                tbl.Rows(N).Item("status") = 1
                                            Else
                                                tbl.Rows(N).Item("status") = 0
                                            End If

                                            bolRo = True
                                        End If
                                    End If
                                Next

                                If bolRo = False Then
                                    Ro = tbl.NewRow
                                    Ro.Item("structure") = mStruc
                                    Ro.Item("amount") = amount
                                    If mType = 1 Then Ro.Item("entitlement") = mAllow
                                    If mType = 2 Then Ro.Item("recoveries") = mAllow
                                    If mType = 3 Then Ro.Item("loan") = mAllow
                                    If mType = 4 Then Ro.Item("contribution") = mAllow
                                    If ckbActive.CheckState = CheckState.Checked Then
                                        Ro.Item("status") = 1
                                    Else
                                        Ro.Item("status") = 0
                                    End If
                                    Ro.Item("GL") = r + 1
                                    Ro.Item("ST") = c
                                    tbl.Rows.Add(Ro)
                                End If

                            End If

                        Else
                            Dim N As Integer
                            Dim bolDeleteRow As Boolean = False
                            For N = 0 To tbl.Rows.Count - 1
                                If mType = 1 Then
                                    If (tbl.Rows(N).Item("GL") = r + 1) And (tbl.Rows(N).Item("ST") = c) And (tbl.Rows(N).Item("entitlement") = mAllow) Then
                                        tbl.Rows(N).Delete()
                                        bolDeleteRow = True
                                    End If
                                ElseIf mType = 2 Then
                                    If (tbl.Rows(N).Item("GL") = r + 1) And (tbl.Rows(N).Item("ST") = c) And (tbl.Rows(N).Item("recoveries") = mAllow) Then
                                        tbl.Rows(N).Delete()
                                        bolDeleteRow = True
                                    End If
                                ElseIf mType = 3 Then
                                    If (tbl.Rows(N).Item("GL") = r + 1) And (tbl.Rows(N).Item("ST") = c) And (tbl.Rows(N).Item("loan") = mAllow) Then
                                        tbl.Rows(N).Delete()
                                        bolDeleteRow = True
                                    End If
                                ElseIf mType = 4 Then
                                    If (tbl.Rows(N).Item("GL") = r + 1) And (tbl.Rows(N).Item("ST") = c) And (tbl.Rows(N).Item("contribution") = mAllow) Then
                                        tbl.Rows(N).Delete()
                                        bolDeleteRow = True
                                    End If
                                End If
                            Next
                            If bolDeleteRow Then da.Update(tbl)
                        End If

                    Next
                Next

            End With

            da.Update(tbl)
            dgvGrid.ReadOnly = True

            IsEditMode(False)
        End Sub

        Private Sub frmSalaryTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor

            With dgvGrid
                .BackgroundColor = Env.GirdBackgroundColor
                .RowsDefaultCellStyle.SelectionBackColor = Env.GirdSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Env.GirdSelectionForeColor
            End With

            LoadCombo()
            IsEditMode(False)
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub


        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            If dgvGrid.RowCount = 0 Then Exit Sub
            dgvGrid.ReadOnly = False
            dgvGrid.Columns(0).ReadOnly = True
            IsEditMode(True)
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            If dgvGrid.RowCount = 0 Then Exit Sub
            dgvGrid.ReadOnly = True
            dgvGrid.Columns(0).ReadOnly = True
            IsEditMode(False)
        End Sub

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            If dgvGrid.RowCount = 0 Then Exit Sub

            SaveRecord()

        End Sub

        Private Sub dgvGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvGrid.DataError

        End Sub

        Private Sub cboSalaryScale_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSalaryScale.SelectedValueChanged
            Try
                LoadData()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub cboAllowance_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAllowance.SelectedValueChanged
            Try
                LoadData()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub cboType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboType.SelectedValueChanged
            Try
                If cboType.SelectedIndex = 1 Then
                    Populate.comboBox(cboAllowance, "SELECT * FROM ALLOWANCES")
                ElseIf cboType.SelectedIndex = 2 Then
                    Populate.comboBox(cboAllowance, "SELECT * FROM DEDUCTIONS")
                Else
                    cboAllowance.DataSource = Nothing
                End If
            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace