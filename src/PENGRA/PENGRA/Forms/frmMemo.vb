Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes

Namespace Forms
    Public Class frmMemo
        Private sqlString As String
        Private cmdb As FbCommandBuilder

        Private EmployeeInfo As DataTable
        Private daEmployee As FbDataAdapter

        Private Memo As DataTable
        Private daMemo As FbDataAdapter
        Private Sub LoadCombo()
            Populate.GetYear(cboYear)
            Populate.GetMonth(cboMonth)
        End Sub
        Private Sub LoadRecord(ByVal Retiree As Integer)
            LoadEmployeeRecord(Retiree)
            LoadMemoRecord(Retiree)
            ToForm()
        End Sub
        Private Sub clearRecord()
            txtID.Clear()
            txtID.Tag = Nothing
            txtName.Clear()
            txtMinistry.Clear()
            txtBenefitType.Clear()
            txtGratuity.Clear()
            txtPensionArears.Clear()
            txtDeathPension.Clear()
            txtTotalBenefit.Clear()

            chkSubmitted.Checked = False
            cboYear.Text = ""
            cboMonth.SelectedIndex = 0
            txtDesignation.Clear()
            txtAmountInWord.Clear()
        End Sub
        Private Sub IsEditMode(ByVal EditMode As Boolean)
            If EditMode = True Then
                txtID.Enabled = False
                txtName.Enabled = False
                txtMinistry.Enabled = False
                txtBenefitType.Enabled = False
                txtGratuity.Enabled = False
                txtPensionArears.Enabled = False
                txtDeathPension.Enabled = False
                txtTotalBenefit.Enabled = False

                chkSubmitted.Enabled = False
                cboYear.Enabled = True
                cboMonth.Enabled = True
                txtDesignation.Enabled = True
                txtAmountInWord.Enabled = True

                'btnPreview.Enabled = True

                btnEdit.Enabled = False
                btnSave.Enabled = True
                btnUndo.Enabled = True
                btnSearch.Enabled = False
                btnClose.Enabled = False
            Else
                txtID.Enabled = False
                txtName.Enabled = False
                txtMinistry.Enabled = False
                txtBenefitType.Enabled = False
                txtGratuity.Enabled = False
                txtPensionArears.Enabled = False
                txtDeathPension.Enabled = False
                txtTotalBenefit.Enabled = False

                chkSubmitted.Enabled = False
                cboYear.Enabled = False
                cboMonth.Enabled = False
                txtDesignation.Enabled = False
                txtAmountInWord.Enabled = False

                'btnPreview.Enabled = False

                btnEdit.Enabled = True
                btnSave.Enabled = False
                btnUndo.Enabled = False
                btnSearch.Enabled = True
                btnClose.Enabled = True
            End If
        End Sub
        Private Sub LoadEmployeeRecord(ByVal Ukey As Integer)
            sqlString = "SELECT * FROM EMPLOYEEINFO WHERE UKEY = '" & Ukey & "'"

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            daEmployee = New FbDataAdapter(sqlString, DB.ConnObj)

            cmdb = New FbCommandBuilder
            cmdb.DataAdapter = daEmployee
            daEmployee.InsertCommand = cmdb.GetInsertCommand
            daEmployee.DeleteCommand = cmdb.GetDeleteCommand
            daEmployee.UpdateCommand = cmdb.GetUpdateCommand

            EmployeeInfo = New DataTable
            daEmployee.Fill(EmployeeInfo)
        End Sub
        Private Sub LoadMemoRecord(ByVal Ukey As Integer)
            sqlString = "SELECT * FROM MEMOS WHERE RETIREE = '" & Ukey & "'"

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            daMemo = New FbDataAdapter(sqlString, DB.ConnObj)

            cmdb = New FbCommandBuilder
            cmdb.DataAdapter = daMemo
            daMemo.InsertCommand = cmdb.GetInsertCommand
            daMemo.DeleteCommand = cmdb.GetDeleteCommand
            daMemo.UpdateCommand = cmdb.GetUpdateCommand

            Memo = New DataTable
            daMemo.Fill(Memo)
        End Sub
        Private Sub ToForm()
            Dim iGratuity As Decimal = 0
            Dim iPension As Decimal = 0
            Dim iDeathPension As Decimal = 0
            Dim iTotalBenefit As Decimal = 0

            If EmployeeInfo.Rows.Count > 0 Then
                With EmployeeInfo.Rows(0)
                    If Not IsDBNull(.Item("GAMOUNT")) Then iGratuity = .Item("GAMOUNT")
                    If Not IsDBNull(.Item("PAMOUNT")) Then iPension = .Item("PAMOUNT")
                    If Not IsDBNull(.Item("DAMOUNT")) Then iDeathPension = .Item("DAMOUNT")
                    iTotalBenefit = iGratuity + iPension + iDeathPension

                    If Not IsDBNull(.Item("UKEY")) Then txtID.Tag = .Item("UKEY")
                    If Not IsDBNull(.Item("IDNO")) Then txtID.Text = .Item("IDNO")
                    If Not IsDBNull(.Item("FULLNAME")) Then txtName.Text = .Item("FULLNAME")
                    If Not IsDBNull(.Item("MINISTRY")) Then txtMinistry.Tag = .Item("MINISTRY")
                    If Not IsDBNull(.Item("MINISTRY")) Then txtMinistry.Text = Classes.Transactions.GetValueName("MINISTRY", .Item("MINISTRY"))
                    If Not IsDBNull(.Item("BENEFITTYPE")) Then txtBenefitType.Tag = .Item("BENEFITTYPE")
                    If Not IsDBNull(.Item("BENEFITTYPE")) Then txtBenefitType.Text = Classes.Transactions.GetValueName("BENEFIT", .Item("BENEFITTYPE"))
                    If Not IsDBNull(.Item("GAMOUNT")) Then txtGratuity.Text = Format(iGratuity, "#,##0.00")
                    If Not IsDBNull(.Item("PAMOUNT")) Then txtPensionArears.Text = Format(iPension, "#,##0.00")
                    If Not IsDBNull(.Item("DAMOUNT")) Then txtDeathPension.Text = Format(iDeathPension, "#,##0.00")
                    txtTotalBenefit.Text = Format(iTotalBenefit, "#,##0.00")
                End With
            End If

            If Memo.Rows.Count > 0 Then
                With Memo.Rows(0)
                    If Not IsDBNull(.Item("SUBMITTED")) Then chkSubmitted.Checked = True
                    If Not IsDBNull(.Item("AYEAR")) Then cboYear.Text = .Item("AYEAR")
                    If Not IsDBNull(.Item("AMONTH")) Then cboMonth.SelectedIndex = .Item("AMONTH")
                    If Not IsDBNull(.Item("DESIGNATION")) Then txtDesignation.Text = .Item("DESIGNATION")
                    If Not IsDBNull(.Item("AMOUNTINWORD")) Then txtAmountInWord.Text = .Item("AMOUNTINWORD")
                End With
            End If
        End Sub
        Private Sub ToTable(ByVal Ro As DataRow)
            With Ro
                If txtID.Text <> "" Then .Item("IDNO") = txtID.Text.Trim
                If txtID.Text <> "" Then .Item("RETIREE") = txtID.Tag
                If txtName.Text <> "" Then .Item("RETIREENAME") = txtName.Text.Trim
                If txtMinistry.Text <> "" Then .Item("MINISTRY") = txtMinistry.Tag
                If txtMinistry.Text <> "" Then .Item("MINISTRYNAME") = txtMinistry.Text.Trim
                If txtBenefitType.Text <> "" Then .Item("BENEFITTYPE") = txtBenefitType.Tag
                If txtGratuity.Text <> "" Then .Item("GRATUITY") = txtGratuity.Text.Trim
                If txtPensionArears.Text <> "" Then .Item("PENSIONAREARS") = txtPensionArears.Text.Trim
                If txtDeathPension.Text <> "" Then .Item("DEATHPENSION") = txtDeathPension.Text.Trim
                If txtTotalBenefit.Text <> "" Then .Item("TOTALBENEFIT") = txtTotalBenefit.Text.Trim
                If txtDesignation.Text <> "" Then
                    .Item("DESIGNATION") = txtDesignation.Text.Trim
                Else
                    .Item("DESIGNATION") = DBNull.Value
                End If
                If txtAmountInWord.Text <> "" Then
                    .Item("AMOUNTINWORD") = txtAmountInWord.Text.Trim
                Else
                    .Item("AMOUNTINWORD") = DBNull.Value
                End If
                If cboYear.Text <> "" Then
                    .Item("AYEAR") = cboYear.Text
                Else
                    .Item("AYEAR") = DBNull.Value
                End If
                If cboMonth.Text <> "" Then
                    .Item("AMONTH") = cboMonth.SelectedIndex
                Else
                    .Item("AMONTH") = DBNull.Value
                End If
                .Item("STATUS") = Env.UserStatus
            End With
        End Sub
        Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            LoadCombo()
            IsEditMode(False)
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            If Users.Privilege.EditAllocation = False Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If txtName.Text = "" Then Exit Sub

            IsEditMode(True)
        End Sub
        Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
            Memo.RejectChanges()
            EmployeeInfo.RejectChanges()
            clearRecord()
            ToForm()
            IsEditMode(False)
        End Sub
        Private Function IsSaveValid() As Boolean
            'Make Sure A Valid Value For Year Is Provide
            If cboYear.Text = "" Then
                MessageBox.Show("Please Select A 'Year' Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboYear.Focus()
                Return False
            End If

            'Make Sure A Valid Value For Year Is Provide
            If cboMonth.Text = "" Then
                MessageBox.Show("Please Select A 'Month' Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboMonth.Focus()
                Return False
            End If

            'Make Sure A Valid Value For Year Is Provide
            If txtDesignation.Text = "" Then
                MessageBox.Show("Please Provide A Value For The Field 'Designation' Field Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDesignation.Focus()
                Return False
            End If

            'Make Sure A Valid Value For Year Is Provide
            If txtAmountInWord.Text = "" Then
                MessageBox.Show("Please Provide A Value For The Field 'Amount In Word' Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAmountInWord.Focus()
                Return False
            End If

            Return True
        End Function
        Private Function SaveRecord() As Boolean
            If IsSaveValid() = False Then Return False

            Try
                If Memo.Rows.Count > 0 Then
                    ToTable(Memo.Rows(0))
                Else
                    Dim dr As DataRow
                    dr = Memo.NewRow
                    ToTable(dr)
                    Memo.Rows.Add(dr)
                End If

                daMemo.Update(Memo)

            Catch ex As Exception
                Throw ex
            End Try

            Return True
        End Function
        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            If txtID.Text = "" Then Exit Sub

            If MessageBox.Show("Are You Sure You Want To Continue With The Current Transaction?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Try
                If SaveRecord() = True Then IsEditMode(False)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
            Dim F As New frmFindEmployee
            F.Limit = "0"
            F.bLimit = True
            F.ShowDialog()
            If F.CancelRecord = False Then
                clearRecord()
                LoadRecord(F.EmployeeID)
            End If
        End Sub
    End Class
End Namespace