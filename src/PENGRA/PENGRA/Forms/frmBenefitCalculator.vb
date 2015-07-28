Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes
Imports PENGRA.Classes

Namespace Forms

    Public Class frmBenefitCalculator

        Dim iFullName As String
        Dim iSalaryScale As Integer
        Dim iGradeLevel As Integer
        Dim iStep As Integer
        Dim iBenefitType As Integer
        Dim iGratuityPerc As Short
        Dim iPensionPerc As Short
        Dim iAuditDate As Date
        Dim iPensionWEF As Date

        Dim bolHasEmployeeRecord As Boolean = False

        Private Sub LoadCombo()
            Populate.comboBox(cboSalaryScale, "SELECT * FROM SALARYSCALE")
            Populate.comboBox(cboBenefitType, "SELECT * FROM BENEFIT")
            Populate.GetGradeLevel(cboLevel)
            Populate.GetSalaryStep(cboStep)
        End Sub

        Private Sub LoadRecord(ByVal HasEmployeeRecord As Boolean)

            LoadCombo()

            If HasEmployeeRecord = True Then
                'lblFullName.Text = iFullName
                cboSalaryScale.SelectedValue = iSalaryScale
                cboLevel.SelectedIndex = iGradeLevel
                cboStep.SelectedIndex = iStep
                cboBenefitType.SelectedValue = iBenefitType
                txtGratuityPerc.Text = iGratuityPerc
                txtPensionPerc.Text = iPensionPerc
                dtpDAA.Value = iAuditDate
                dtpPensionWEF.Value = iPensionWEF

                cboSalaryScale.Enabled = False
                cboLevel.Enabled = False
                cboStep.Enabled = False
                cboBenefitType.Enabled = False
                txtGratuityPerc.Enabled = False
                txtPensionPerc.Enabled = False
                dtpDAA.Enabled = False
                dtpPensionWEF.Enabled = False

                'btnSave.Visible = True

            End If
        End Sub

        Private Sub IsEditMode(ByVal bolEdit As Boolean)
            'Dim page As System.Windows.Forms.TabPage
            '---
            If bolEdit = False Then

                btnClose.Enabled = True
                'btnSave.Enabled = False

            ElseIf bolEdit = True Then

                btnClose.Enabled = False
                'btnSave.Enabled = True

            End If
        End Sub

        Private Sub DisableEdit()

            IsEditMode(False)
        End Sub
        Private Sub EnableEdit()

            IsEditMode(True)
        End Sub

        Private Sub frmProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.BackColor = Env.FormBackColor
            LoadRecord(bolHasEmployeeRecord)
            DisableEdit()
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Function ValidateSave() As Boolean
            Return True
        End Function

        Private Function SaveRecord() As Boolean

            If ValidateSave() = False Then Return False

            Return True
        End Function


        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If (txtConsolidated.Text = "" Or (txtGratuity.Text = "" Or txtPension.Text = "")) Then Exit Sub

            If SaveRecord() = True Then Me.Close()

        End Sub

        Private Function ValidateComputation() As Boolean

            If cboSalaryScale.Text = "" Or cboLevel.Text = "" Or cboStep.Text = "" Or cboBenefitType.Text = "" Or _
                txtGratuityPerc.Text.Trim = "" Or txtPensionPerc.Text.Trim = "" Then
                MessageBox.Show(Messages.Empty, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                Return False
            End If

            If IsNumeric(txtGratuityPerc.Text.Trim) = False Then
                MessageBox.Show(Messages.NumericValue, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtGratuityPerc.Focus()
                Return False
            End If

            If IsNumeric(txtPensionPerc.Text.Trim) = False Then
                MessageBox.Show(Messages.NumericValue, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPensionPerc.Focus()
                Return False
            End If

            If dtpDAA.Value < dtpPensionWEF.Value Then
                MessageBox.Show("Pension w.e.f. Date Can Not Be Later Than Audit Date Of Approval.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpPensionWEF.Focus()
                Return False
            End If

            iSalaryScale = cboSalaryScale.SelectedValue
            iGradeLevel = cboLevel.SelectedIndex
            iStep = cboStep.SelectedIndex
            iBenefitType = cboBenefitType.SelectedValue
            iGratuityPerc = CShort(txtGratuityPerc.Text.Trim)
            iPensionPerc = CShort(txtPensionPerc.Text.Trim)

            Return True
        End Function

        Private Sub Computation()
            Dim BC As Calculator
            BC = New Calculator(iSalaryScale, iGradeLevel, iStep, iGratuityPerc, iPensionPerc, iBenefitType, dtpDAA.Value, dtpPensionWEF.Value)

            txtConsolidated.Text = Format(BC.Consolidated, "#,##0.00")
            txtGratuity.Text = Format(BC.Gratuity, "#,##0.00")
            txtPension.Text = Format(BC.Pension, "#,##0.00")
            txtPensionArrears.Text = Format(BC.PensionArrears, "#,##0.00")
            txtDeathPension.Text = Format(BC.DeathPension, "#,##0.00")
        End Sub

        Private Sub CButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CButton1.Click

            If ValidateComputation() = False Then Exit Sub

            Computation()
        End Sub
    End Class
End Namespace