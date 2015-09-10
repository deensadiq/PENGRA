Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.SystemColors
Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes
Imports PENGRA.Classes

Namespace Forms
    Public Class frmEmployee
        Private Employee As New DataTable
        Private nEmployee As New DataTable
        Private Em As New DataTable

        Private nLimitValue As Double

        Private GuiMan As GuiForms

        Private Newrec As Boolean = False

        Private Adapter As FbDataAdapter
        Private sAdapter As FbDataAdapter
        Private nAdapter As FbDataAdapter
        Private Builder As FbCommandBuilder
        Private nBuilder As FbCommandBuilder
        Private str As String = ""

        '////////////////////////////////////////
        '
        ' Form Size = 860 by 560
        '
        '///////////////////////////////////////////
#Region "Photo"
        Private Sub loadPhoto()

            Dim Dialog As New OpenFileDialog()
            Dim strFile As String
            Dim Img As System.Drawing.Image

            Dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

            Dialog.ShowDialog()
            strFile = Dialog.FileName

            If strFile.Trim = "" Then Exit Sub
            Img = System.Drawing.Image.FromFile(strFile)

            picPhoto.Image = Img

        End Sub
        Private Sub showPhoto()
            picPhoto.Image = Nothing

            'Dim P As New PHOTO
            'With P
            '    .ConnectionString = Env.ConStr
            '    .Where.ID.Value = Employee.Rows(0).Item("UKEY")
            '    .Query.Load()
            'End With
            'If P.RowCount = 0 Then Exit Sub
            'Try
            '    If IsDBNull(P.PHOTO) = False Then picPhoto.Image = Scanner.getPicture(P.PHOTO)
            'Catch ex As Exception
            '    If ex.Message.Contains("System.DBNull") Then
            '        'MessageBox.Show(Messages.CardPro, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Else
            '        Throw ex
            '    End If
            'End Try


        End Sub
        Private Sub SavePhoto(ByVal ID As String)

            If Not IsNothing(picPhoto.Image) Then
                'Dim P As New PHOTO
                'With P
                '    .ConnectionString = Env.ConStr
                '    .Where.ID.Value = ID
                '    .Query.Load()
                'End With
                'If P.RowCount = 0 Then P.AddNew()
                'P.ID = CInt(ID)
                'Scanner.savePicture(P, picPhoto.Image)
                'P.Save()
                'P.AcceptChanges()
            End If
        End Sub
        Private Sub DeletePhoto(ByVal ID As String)

            'Dim P As New PHOTO
            'With P
            '    .ConnectionString = Env.ConStr
            '    .Where.ID.Value = ID
            '    .Query.Load()
            'End With
            'If P.RowCount = 0 Then Exit Sub

            'P.MarkAsDeleted()
            'P.Save()
            'P.AcceptChanges()
            showPhoto()
        End Sub

        Private Sub RemovePhotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            If Newrec = True Then picPhoto.Image = Nothing
            If Newrec = False Then
                If txtId.Text = "" Then Exit Sub
                If IsNothing(picPhoto.Image) Then Exit Sub
                If Env.UserPrivillege = Env.eUserPriv.User_2 Then
                    MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                If Not Employee.Rows.Count > 0 Then Exit Sub

                If MessageBox.Show(Messages.DeletePhoto, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

                DeletePhoto(Employee.Rows(0).Item("UKEY").ToString)
            End If
        End Sub

#End Region
        Private Sub InitComp()
            GetLimitValue()
            loadCombos()
            loadData("-1")
        End Sub
        Private Function GetStatus() As String
            GetStatus = "2"
            Return GetStatus
        End Function

        Private Function GetTotalBenefit() As Double
            GetTotalBenefit = 0

            If cboBenefitType.Text = "RETIREE" Then
                GetTotalBenefit = CDec(txtGratuity.Text.Trim) + CDec(txtPensionArrears.Text.Trim)
            Else
                GetTotalBenefit = CDec(txtGratuity.Text.Trim) + CDec(txtDeathPension.Text.Trim)
            End If
            Return GetTotalBenefit
        End Function

        Private Sub GetLimitValue()
            ' Load The Valu of Above Limit 
            ' If The Value Is Zero(0) Do Not Save Record
            Dim itbl As New DataTable
            Dim ida As FbDataAdapter

            nLimitValue = 0

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Dim istr As String = "SELECT * FROM PAYMENTLIMIT"
            ida = New FbDataAdapter(istr, DB.ConnObj)

            ida.Fill(itbl)
            If itbl.Rows.Count = 0 Then Exit Sub

            nLimitValue = itbl.Rows(0).Item(0)
        End Sub

        Private Function GetTransactionNo() As String
            GetTransactionNo = "CR/00001"

            Return GetTransactionNo
        End Function

        Private Function WriteBenefits() As Boolean
            Dim iGratuityAmount As Double = 0
            Dim iPensionAmount As Double = 0
            Dim iDeatPensionAmount As Double = 0
            Dim strSQLS As String
            Dim command As New FirebirdSql.Data.FirebirdClient.FbCommand

            If txtGratuity.Text <> "" Then iGratuityAmount = CDec(txtGratuity.Text.Trim)
            If txtPensionArrears.Text <> "" Then iPensionAmount = CDec(txtPensionArrears.Text.Trim)
            If txtDeathPension.Text <> "" Then iDeatPensionAmount = CDec(txtDeathPension.Text.Trim)

            Try
                'EXECUTE PROCEDURE SP_WRITE_BENEFIT(TDATE, TRANSNO, TTYPE, EMPLOYEE, MINISTRY, AYEAR, AMONTH, GAMOUNT, PAMOUNT, DPAMOUNT, STATUS)
                strSQLS = "EXECUTE PROCEDURE SP_WRITE_BENEFIT('" & Format(Date.Today, "dd/MMM/yyyy") & "', '" & GetTransactionNo() & "', '" & Employee.Rows(0).Item("LIMIT") & "', '" & Employee.Rows(0).Item("UKEY") & "', '" & Employee.Rows(0).Item("MINISTRY") & "', '" & dtpDOAA.Value.ToString("yyyy") & "', '" & dtpDOAA.Value.ToString("MM") & "', '" & iGratuityAmount & "', '" & iPensionAmount & "', '" & iDeatPensionAmount & "', '" & Env.UserStatus & "')"

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                command.Connection = DB.ConnObj

                command.CommandText = strSQLS
                command.ExecuteScalar()
            Catch ex As Exception
                Return False
            End Try

            Return True
        End Function

        Private Sub Clear()

            txtId.Clear()
            txtFullName.Clear()
            cboMinistry.SelectedValue = 0
            cboBenefitType.SelectedValue = 0
            cboSalary.SelectedValue = 0
            cboLevel.SelectedIndex = 0
            cboStep.SelectedIndex = 0
            dtpDOB.Value = Date.Now
            dtpDOA.Value = Date.Now
            dtpDOR.Value = Date.Now
            dtpDOD.Value = Date.Now

            txtRefNo.Clear()
            dtpDOAA.Value = Date.Now
            dtpPensionWEF.Value = Date.Now
            txtGratuityPerc.Clear()
            txtPensionPerc.Clear()
            txtGratuity.Clear()
            txtPensionArrears.Clear()
            txtDeathPension.Clear()
            txtPayThrough.Clear()

            picPhoto.Image = Nothing

        End Sub

        Private Sub toForm()
            Try
                txtId.Text = Employee.Rows(0).Item("IDNO").ToString
                txtId.Tag = Employee.Rows(0).Item("UKEY").ToString
                txtFullName.Text = Employee.Rows(0).Item("FULLNAME").ToString
                If Not IsDBNull(Employee.Rows(0).Item("MINISTRY")) Then cboMinistry.SelectedValue = Employee.Rows(0).Item("MINISTRY")
                If Not IsDBNull(Employee.Rows(0).Item("BENEFITTYPE")) Then cboBenefitType.SelectedValue = Employee.Rows(0).Item("BENEFITTYPE")
                If Not IsDBNull(Employee.Rows(0).Item("STRUCTURE")) Then cboSalary.SelectedValue = Employee.Rows(0).Item("STRUCTURE")
                If Not IsDBNull(Employee.Rows(0).Item("GL")) Then cboLevel.SelectedIndex = Employee.Rows(0).Item("GL")
                If Not IsDBNull(Employee.Rows(0).Item("STEP")) Then cboStep.SelectedIndex = Employee.Rows(0).Item("STEP")
                dtpDOB.Text = Employee.Rows(0).Item("DATEOFBIRTH").ToString
                dtpDOA.Text = Employee.Rows(0).Item("DOA").ToString
                dtpDOR.Text = Employee.Rows(0).Item("DOR").ToString
                dtpDOD.Text = Employee.Rows(0).Item("DEATHDATE").ToString

                If Not IsDBNull(Employee.Rows(0).Item("REFNO")) Then txtRefNo.Text = Employee.Rows(0).Item("REFNO").ToString
                If Not IsDBNull(Employee.Rows(0).Item("GRATUITY")) Then txtGratuityPerc.Text = Employee.Rows(0).Item("GRATUITY").ToString
                If Not IsDBNull(Employee.Rows(0).Item("PENSION")) Then txtPensionPerc.Text = Employee.Rows(0).Item("PENSION").ToString
                If Not IsDBNull(Employee.Rows(0).Item("PAYTHROUGH")) Then txtPayThrough.Text = Employee.Rows(0).Item("PAYTHROUGH").ToString
                If Not IsDBNull(Employee.Rows(0).Item("GAMOUNT")) Then txtGratuity.Text = Format(Employee.Rows(0).Item("GAMOUNT"), "#,##0.00")
                If Not IsDBNull(Employee.Rows(0).Item("PAMOUNT")) Then txtPensionArrears.Text = Format(Employee.Rows(0).Item("PAMOUNT"), "#,##0.00")
                If Not IsDBNull(Employee.Rows(0).Item("DAMOUNT")) Then txtDeathPension.Text = Format(Employee.Rows(0).Item("DAMOUNT"), "#,##0.00")
                dtpDOAA.Text = Employee.Rows(0).Item("DOAA").ToString
                dtpPensionWEF.Text = Employee.Rows(0).Item("WEFDATE").ToString

                'showPhoto()
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Sub toTable(ByRef Ro As DataRow)

            With Ro

                If Newrec = True Then
                    .Item("ACTVE") = 1
                    .Item("LOGTIME") = Date.Now
                End If

                .Item("IDNO") = txtId.Text.Trim
                .Item("FULLNAME") = txtFullName.Text.Trim


                If Not cboLevel.SelectedIndex = 0 Then .Item("GL") = cboLevel.SelectedIndex
                If Not cboStep.SelectedIndex = 0 Then .Item("STEP") = cboStep.SelectedIndex
                If Not cboMinistry.SelectedValue = 0 Then .Item("MINISTRY") = cboMinistry.SelectedValue
                If Not cboBenefitType.SelectedValue = 0 Then .Item("BENEFITTYPE") = cboBenefitType.SelectedValue
                If Not cboSalary.SelectedValue = 0 Then .Item("STRUCTURE") = cboSalary.SelectedValue
                .Item("DATEOFBIRTH") = CType(dtpDOB.Text, Date)
                .Item("DOA") = CType(dtpDOA.Text, Date)
                .Item("DOR") = CType(dtpDOR.Text, Date)
                .Item("DEATHDATE") = CType(dtpDOD.Text, Date)

                If txtRefNo.Text <> "" Then .Item("REFNO") = txtRefNo.Text.Trim
                If txtGratuityPerc.Text <> "" Then .Item("GRATUITY") = txtGratuityPerc.Text.Trim
                If txtPensionPerc.Text <> "" Then .Item("PENSION") = txtPensionPerc.Text.Trim
                If txtPayThrough.Text <> "" Then .Item("PAYTHROUGH") = txtPayThrough.Text.Trim
                If txtGratuity.Text <> "" Then .Item("GAMOUNT") = txtGratuity.Text.Trim
                If cboBenefitType.SelectedValue = 1 Then
                    If txtPensionArrears.Text <> "" Then .Item("PAMOUNT") = txtPensionArrears.Text.Trim
                    .Item("DAMOUNT") = DBNull.Value
                ElseIf cboBenefitType.SelectedValue = 2 Then
                    If txtDeathPension.Text <> "" Then .Item("DAMOUNT") = txtDeathPension.Text.Trim
                    .Item("PAMOUNT") = DBNull.Value
                End If
                .Item("DOAA") = CType(dtpDOAA.Text, Date)
                .Item("WEFDATE") = CType(dtpPensionWEF.Text, Date)

                If GetTotalBenefit() >= nLimitValue Then
                    .Item("LIMIT") = 0
                Else
                    .Item("LIMIT") = 1
                End If

                .Item("STATUS") = Env.UserStatus

            End With

        End Sub
        Private Sub ntoTable()
            Dim dr As DataRow
            dr = nEmployee.NewRow

            If Newrec = True Then
                dr("ACTVE") = 1
                dr("LOGTIME") = Format(Date.Now, "dd/MMM/yyyy HH:mm:ss")
            End If

            dr("IDNO") = txtId.Text.Trim
            dr("FULLNAME") = txtFullName.Text.Trim


            If Not cboLevel.SelectedIndex = 0 Then dr("GL") = cboLevel.SelectedIndex
            If Not cboStep.SelectedIndex = 0 Then dr("STEP") = cboStep.SelectedIndex
            If Not cboMinistry.SelectedValue = 0 Then dr("MINISTRY") = cboMinistry.SelectedValue
            If Not cboBenefitType.SelectedValue = 0 Then dr("BENEFITTYPE") = cboBenefitType.SelectedValue
            If Not cboSalary.SelectedValue = 0 Then dr("STRUCTURE") = cboSalary.SelectedValue
            dr("DATEOFBIRTH") = CType(dtpDOB.Text, Date)
            dr("DOA") = CType(dtpDOA.Text, Date)
            dr("DOR") = CType(dtpDOR.Text, Date)
            dr("DEATHDATE") = CType(dtpDOD.Text, Date)

            If txtRefNo.Text <> "" Then dr("REFNO") = txtRefNo.Text.Trim
            If txtGratuityPerc.Text <> "" Then dr("GRATUITY") = txtGratuityPerc.Text.Trim
            If txtPensionPerc.Text <> "" Then dr("PENSION") = txtPensionPerc.Text.Trim
            If txtPayThrough.Text <> "" Then dr("PAYTHROUGH") = txtPayThrough.Text.Trim
            If cboBenefitType.SelectedValue = 1 Then
                If txtPensionArrears.Text <> "" Then dr("PAMOUNT") = txtPensionArrears.Text.Trim
                dr("DAMOUNT") = DBNull.Value
            ElseIf cboBenefitType.SelectedValue = 2 Then
                If txtDeathPension.Text <> "" Then dr("DAMOUNT") = txtDeathPension.Text.Trim
                dr("PAMOUNT") = DBNull.Value
            End If
            If txtGratuity.Text <> "" Then dr("GAMOUNT") = txtGratuity.Text.Trim


            dr("DOAA") = CType(dtpDOAA.Text, Date)
            'dr("DOAA") = DateTime.p (dtpDOAA.Text, Date)
            dr("WEFDATE") = CType(dtpPensionWEF.Text, Date)

            If GetTotalBenefit() >= nLimitValue Then
                dr("LIMIT") = 0
            Else
                dr("LIMIT") = 1
            End If

            dr("STATUS") = Env.UserStatus

            nEmployee.Rows.Add(dr)

        End Sub

        Private Sub Enable()

            txtId.Enabled = True
            txtFullName.Enabled = True
            cboMinistry.Enabled = True
            cboBenefitType.Enabled = True
            cboSalary.Enabled = True
            cboLevel.Enabled = True
            cboStep.Enabled = True
            dtpDOB.Enabled = True
            dtpDOA.Enabled = True
            dtpDOR.Enabled = True
            dtpDOD.Enabled = True

            txtRefNo.Enabled = True
            dtpDOAA.Enabled = True
            dtpPensionWEF.Enabled = True
            txtGratuityPerc.Enabled = True
            txtPensionPerc.Enabled = True
            txtPayThrough.Enabled = True
            txtGratuity.Enabled = True
            txtPensionArrears.Enabled = True
            txtDeathPension.Enabled = True

            If cboBenefitType.Text = "" Then txtPensionArrears.ReadOnly = True
            If cboBenefitType.Text = "" Then txtDeathPension.ReadOnly = True

            txtPensionArrears.BackColor = SystemColors.Window
            txtDeathPension.BackColor = SystemColors.Window

            btnMinistry.Enabled = True
            btnSalary.Enabled = True

            btnSave.Enabled = True
            btnUndo.Enabled = True

            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnClose.Enabled = False
            btnSearch.Enabled = False

            btnGratuityAmount.Enabled = True
            btnPensionAmount.Enabled = True
            btnDeathAmount.Enabled = True

        End Sub

        Private Sub Disable()

            txtId.Enabled = False
            txtFullName.Enabled = False
            cboMinistry.Enabled = False
            cboBenefitType.Enabled = False
            cboSalary.Enabled = False
            cboLevel.Enabled = False
            cboStep.Enabled = False
            dtpDOB.Enabled = False
            dtpDOA.Enabled = False
            dtpDOR.Enabled = False
            dtpDOD.Enabled = False

            txtRefNo.Enabled = False
            dtpDOAA.Enabled = False
            dtpPensionWEF.Enabled = False
            txtGratuityPerc.Enabled = False
            txtPensionPerc.Enabled = False
            txtPayThrough.Enabled = False
            txtGratuity.Enabled = False
            txtPensionArrears.Enabled = False
            txtDeathPension.Enabled = False

            txtPensionArrears.BackColor = SystemColors.Menu
            txtDeathPension.BackColor = SystemColors.Menu

            btnMinistry.Enabled = False
            btnSalary.Enabled = False

            btnSave.Enabled = False
            btnUndo.Enabled = False

            btnAdd.Enabled = True
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnClose.Enabled = True
            btnSearch.Enabled = True

            btnGratuityAmount.Enabled = False
            btnPensionAmount.Enabled = False
            btnDeathAmount.Enabled = False

        End Sub


        Private Sub loadCombos()

            Populate.comboBox(cboMinistry, "SELECT * FROM MINISTRY")
            Populate.comboBox(cboBenefitType, "SELECT * FROM BENEFIT")
            Populate.comboBox(cboSalary, "SELECT * FROM SALARYSCALE")
            Populate.GetGradeLevel(cboLevel)
            Populate.GetSalaryStep(cboStep)
        End Sub

        Public Overloads Sub loadData(ByVal ID As String)

            Clear()

            ' reload the student for each search
            ' becos we load a single student at a time.

            Employee = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Dim str As String = "SELECT * FROM EMPLOYEEINFO WHERE UKEY = '" + ID + "'"
            Adapter = New FbDataAdapter(str, DB.ConnObj)
            Builder = New FbCommandBuilder(Adapter)
            Adapter.UpdateCommand = Builder.GetUpdateCommand
            Adapter.DeleteCommand = Builder.GetDeleteCommand

            Adapter.Fill(Employee)
            If Employee.Rows.Count > 0 Then toForm()
            txtId.Focus()

        End Sub
        Public Sub loadFromNo(ByVal number As String)
            ' reload the student for each search
            ' becos we load a single student at a time.

            Employee = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Dim str As String = "SELECT * FROM EMPLOYEEINFO WHERE IDNO = '" + number + "'"
            Adapter = New FbDataAdapter(str, DB.ConnObj)
            Builder = New FbCommandBuilder(Adapter)
            Adapter.UpdateCommand = Builder.GetUpdateCommand
            Adapter.DeleteCommand = Builder.GetDeleteCommand

            Adapter.Fill(Employee)
            If Employee.Rows.Count > 0 Then toForm()
            txtId.Focus()

        End Sub

        Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            Me.BackColor = Color.FromArgb(225, 228, 233)

            'GetLimitValue()
            'loadCombos()
            InitComp()
            Disable()

            'If Env.Edit_Records = False Then btnEdit.Visible = False
            'If Env.Add_Records = False Then btnAdd.Visible = False
            'If Env.Remove_Records = False Then btnDelete.Visible = False
            'If Env.Print_Records = False Then btnPrint.Visible = False
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
            If Users.Privilege.AddRetireRecord = False Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Enable()
            Clear()
            txtId.Focus()
            Newrec = True
        End Sub
        Private Function IsPaymentMade(ByVal Retiree As Integer) As Boolean
            Dim str As String = "SELECT * FROM TRANSACTIONS WHERE EMPLOYEE = '" & Retiree & "' AND DEBIT > 0"
            Dim tbl As New DataTable
            Dim da As FbDataAdapter

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count = 0 Then Return False

            Return True
        End Function
        Private Function IsEditValid(ByVal iRetiree As Integer) As Boolean

            If Employee.Rows(0).Item("STATUS") <> Env.UserStatus Then
                MessageBox.Show(Messages.AccessDenied, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            If IsPaymentMade(Employee.Rows(0).Item("UKEY")) = True Then
                MessageBox.Show("Payment Has Been Made To This Retiree. You Cannot Edit This Record.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Return True
        End Function
        Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
            'If Users.Privilege.EditRetireRecord = False Then
            '    MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    Exit Sub
            'End If
            If Users.Privilege.EditRetireRecord = False Then
                MessageBox.Show("You Dont Have The Privilege To Edit This Record. Check With Your Superior Officer.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If txtId.Text = "" OrElse Employee.Rows.Count = 0 OrElse IsEditValid(txtId.Tag) = False Then Exit Sub

            Enable()
            txtId.Focus()
            Newrec = False
        End Sub
        Private Function IsSaveValid() As Boolean


            If txtId.Text.Trim = "" Then
                MessageBox.Show("Please Provide A Valid Employee ID Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtId.Focus()
                Return False
            End If

            If txtFullName.Text.Trim = "" Then
                MessageBox.Show("Please Provide Employee Full Name Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtFullName.Focus()
                Return False
            End If

            If cboMinistry.Text.Trim = "" Then
                MessageBox.Show("Please Select A Ministry Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboMinistry.Focus()
                Return False
            End If

            If cboBenefitType.Text = "" Then
                MessageBox.Show("Please Select Employee Benefit Type Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboBenefitType.Focus()
                Return False
            End If

            'If cboSalary.Text = "" Then
            '    MessageBox.Show("Please Select Employee Salary Scale Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    cboSalary.Focus()
            '    Return False
            'End If

            'If cboLevel.Text = "" Then
            '    MessageBox.Show("Please Select Employee Grade Level Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    cboLevel.Focus()
            '    Return False
            'End If

            'If cboStep.Text = "" Then
            '    MessageBox.Show("Please Select Employee Salary Step Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    cboStep.Focus()
            '    Return False
            'End If

            'If txtGratuityPerc.Text = "" Then
            '    MessageBox.Show("Please Provide A Percentage Of Gratuity Employee Enjoys Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    txtGratuityPerc.Focus()
            '    Return False
            'End If

            'If IsNumeric(txtGratuityPerc.Text) = False Then
            '    MessageBox.Show("Only Number Is Allowed. Please Enter A Valid Value Before Proceeding.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    txtGratuityPerc.Focus()
            '    Return False
            'End If

            'If txtPensionPerc.Text = "" Then
            '    MessageBox.Show("Please Provide A Percentage Of Pension Employee Enjoys Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    txtPensionPerc.Focus()
            '    Return False
            'End If

            'If IsNumeric(txtPensionPerc.Text) = False Then
            '    MessageBox.Show("Only Number Is Allowed. Please Enter A Valid Value Before Proceeding.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            '    txtPensionPerc.Focus()
            '    Return False
            'End If

            If txtGratuity.Text = "" Then
                MessageBox.Show("Please Provide Total Gratuity Benefit Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtGratuity.Focus()
                Return False
            End If

            If IsNumeric(txtGratuity.Text) = False Then
                MessageBox.Show("Only Number Is Allowed. Please Enter A Valid Value Before Proceeding.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtGratuity.Focus()
                Return False
            End If

            If cboBenefitType.Text = "RETIREE" And txtPensionArrears.Text = "" Then
                MessageBox.Show("Please Provide Total Pension Arrears Benefit Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPensionArrears.Focus()
                Return False
            End If

            If cboBenefitType.Text = "RETIREE" And IsNumeric(txtPensionArrears.Text) = False Then
                MessageBox.Show("Only Number Is Allowed. Please Enter A Valid Value Before Proceeding.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtPensionArrears.Focus()
                Return False
            End If

            If cboBenefitType.Text = "DECEASED" And txtDeathPension.Text = "" Then
                MessageBox.Show("Please Provide Total Death Pension Benefit Before You Continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtDeathPension.Focus()
                Return False
            End If

            If cboBenefitType.Text = "DECEASED" And IsNumeric(txtDeathPension.Text) = False Then
                MessageBox.Show("Only Number Is Allowed. Please Enter A Valid Value Before Proceeding.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtDeathPension.Focus()
                Return False
            End If

            If DateDiff(DateInterval.Month, dtpPensionWEF.Value, dtpDOAA.Value) < 0 Then
                MessageBox.Show("Please Audit Approval Date Cannot Be Less Than Pension W.E.F Date.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpPensionWEF.Focus()
                Return False
            End If

            Return True

        End Function

        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            Dim Ro As DataRow
            If IsSaveValid() = False Then Exit Sub

            If MessageBox.Show("Are You Sure You Want To Continue With The Current Process?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Try

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                If Newrec = True Then
                    'str = "SELECT * FROM EMPLOYEEINFO"

                    'nAdapter = New FbDataAdapter(str, DB.ConnObj)
                    'nBuilder = New FbCommandBuilder(nAdapter)
                    'nEmployee = New DataTable

                    'nAdapter.InsertCommand = nBuilder.GetInsertCommand
                    'nAdapter.Fill(nEmployee)
                    'ntoTable()
                    'nAdapter.Update(nEmployee)
                    Ro = Employee.NewRow
                    toTable(Ro)
                    Employee.Rows.Add(Ro)
                    Adapter.Update(Employee)
                Else
                    toTable(Employee.Rows(0))
                    Adapter.Update(Employee)
                End If



                'str = "SELECT * FROM EMPLOYEEINFO WHERE IDNO = '" + txtId.Text.Trim + "'"
                'Em = New DataTable
                'sAdapter = New FbDataAdapter(str, DB.ConnObj)
                'sAdapter.Fill(Em)

                'SavePhoto(Em.Rows(0).Item("UKEY").ToString)

                ' to reload the student after saving to get the UKEY
                loadFromNo(txtId.Text.Trim)
                If WriteBenefits() = False Then
                    MessageBox.Show(Messages.FatalError, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Disable()
                Newrec = False
            Catch ex As Exception
                'Tx.RollbackTransaction()
                'TransactionMgr.ThreadTransactionMgrReset()
                If ex.Message.Contains("UNQ") Then
                    MessageBox.Show(Messages.Duplicate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtId.Focus()
                ElseIf ex.Message.Contains("FK_PERSDATA_5") Then
                    MessageBox.Show("Check Category And Select A Value Before Saving Student Record", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cboCategory.Focus()
                ElseIf ex.Message.Contains("FK_PERSDATA_6") Then
                    MessageBox.Show("Check Year Group And Select A Value Before Saving Student Record", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cboYeargroup.Focus()
                ElseIf ex.Message.Contains("FK_PERSDATA_7") Then
                    MessageBox.Show("Check Class And Select A Value Before Saving Student Record", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'cboAdmClass.Focus()
                Else
                    Throw ex
                End If

            End Try
        End Sub
        Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
            Clear()
            If Employee.Rows.Count > 0 Then toForm()

            Disable()
            Newrec = False
        End Sub
        Private Function IsDeleteValid(ByVal iRetiree As Integer) As Boolean

            If Employee.Rows(0).Item("STATUS") <> Env.UserStatus Then
                MessageBox.Show(Messages.AccessDenied, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            If IsPaymentMade(txtId.Tag) = True Then
                MessageBox.Show("Payment Has Been Made To This Retiree. You Cannot Delete This Record.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return False
            End If

            Return True
        End Function
        Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
            If Users.Privilege.RemoveRetireRecord = False Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If txtId.Text = "" OrElse Employee.Rows.Count = 0 OrElse IsDeleteValid(txtId.Tag) = False Then Exit Sub

            If MessageBox.Show(Messages.Delete, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub


            Try

                If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

                Dim strSql As String = "DELETE FROM TRANSACTIONS WHERE EMPLOYEE = " + CStr(Employee.Rows(0).Item("UKEY"))
                Dim cmd As New FirebirdSql.Data.FirebirdClient.FbCommand(strSql, DB.ConnObj)

                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()


                strSql = "DELETE FROM EMPLOYEEINFO WHERE UKEY = " + CStr(Employee.Rows(0).Item("UKEY"))
                cmd = New FirebirdSql.Data.FirebirdClient.FbCommand(strSql, DB.ConnObj)

                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()

                Clear()
            Catch ex As Exception
                If ex.Message.Contains("FK_") Then
                    MessageBox.Show(Messages.ForeignKey, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Employee.RejectChanges()
                Else
                    Throw ex
                End If
            End Try
        End Sub

        Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
            Dim F As New frmFindEmployee
            F.ShowDialog()
            If F.CancelRecord = False Then loadData(F.EmployeeID.ToString)
        End Sub

        Private Sub cboBenefitType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBenefitType.SelectedValueChanged
            
            If cboBenefitType.Text = "" Then
                lblDeathPension.Visible = True
                lblPensionArrears.Visible = True
                txtPensionArrears.Text = ""
                txtDeathPension.Text = ""

                txtDeathPension.ReadOnly = True
                txtPensionArrears.ReadOnly = True
            Else
                txtPensionArrears.Text = ""
                txtDeathPension.Text = ""

                If cboBenefitType.Text = "RETIREE" Then
                    txtDeathPension.ReadOnly = True
                    txtPensionArrears.ReadOnly = False
                    lblDeathPension.Visible = False
                    lblPensionArrears.Visible = True
                Else
                    txtDeathPension.ReadOnly = False
                    txtPensionArrears.ReadOnly = True
                    lblDeathPension.Visible = True
                    lblPensionArrears.Visible = False
                End If

            End If

        End Sub

        Private Sub btnCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGratuityAmount.Click
            If txtGratuityPerc.Text = "" Then Exit Sub
        End Sub

        Private Sub CButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPensionAmount.Click
            If txtPensionPerc.Text = "" Then Exit Sub
        End Sub

        Private Sub CButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeathAmount.Click
            If txtPensionPerc.Text = "" Then Exit Sub
        End Sub

        Private Sub pnlStudent_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlStudent.Paint
            pnlStudent.BorderStyle = BorderStyle.None
            'If s Then
            '    e.Graphics.DrawRectangle(Pens.Orange, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1)
            'End If
        End Sub

        Private Sub btnMinistry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinistry.Click
            If Env.UserPrivillege = Env.eUserPriv.User_2 Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            Dim form As New frmSettings("Set Minitry", "MINISTRY")
            form.ShowDialog(Me)
            Populate.comboBox(cboMinistry, "SELECT * FROM MINISTRY")
        End Sub

        Private Sub btnSalary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalary.Click
            If Env.UserPrivillege = Env.eUserPriv.User_2 Then
                MessageBox.Show(Messages.NoPrivilege, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            Dim form As New frmSettings("Set Salary Scale", "SALARYSCALE")
            form.ShowDialog(Me)
            Populate.comboBox(cboSalary, "SELECT * FROM SALARYSCALE")
        End Sub

        Private Sub picPhoto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPhoto.DoubleClick

        End Sub
    End Class


End Namespace