Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes


Namespace Forms

    Public Class frmBenefitCalculator

        Dim iFullName As String
        Dim iSalaryScale As Integer
        Dim iGradeLevel As Integer
        Dim iStep As Integer
        Dim iBenefitType As Integer
        Dim iGratuity As Double
        Dim iPension As Double
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
                lblFullName.Text = iFullName
                cboSalaryScale.SelectedValue = iSalaryScale
                cboLevel.SelectedIndex = iGradeLevel
                cboStep.SelectedIndex = iStep
                cboBenefitType.SelectedValue = iBenefitType
                txtGratuityPerc.Text = iGratuity
                txtPensionPerc.Text = iPension
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

                btnSave.Visible = True

            End If
        End Sub

        Private Sub IsEditMode(ByVal bolEdit As Boolean)
            'Dim page As System.Windows.Forms.TabPage
            '---
            If bolEdit = False Then

                btnClose.Enabled = True
                btnSave.Enabled = False

            ElseIf bolEdit = True Then

                btnClose.Enabled = False
                btnSave.Enabled = True

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
            Me.Icon = Nothing
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


        Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
            If (txtGratuity.Text = "" Or (txtPensionArrears.Text = "" Or txtDeathPension.Text = "")) Then Exit Sub

            If SaveRecord() = True Then Me.Close()

        End Sub

        Private Function ValidateComputation() As Boolean

            If cboSalaryScale.Text = "" Or cboLevel.Text = "" Or cboStep.Text = "" Or cboBenefitType.Text = "" Or _
                txtGratuityPerc.Text.Trim = "" Or txtPensionPerc.Text.Trim = "" Then
                MessageBox.Show(Messages.Empty, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Return True
        End Function

        Private Sub Computation()

        End Sub

        Private Sub CButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CButton1.Click

            If ValidateComputation() = False Then Exit Sub

            Computation()
        End Sub
    End Class
End Namespace