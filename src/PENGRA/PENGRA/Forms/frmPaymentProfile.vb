Imports System.Windows.Forms
Imports System.Drawing
Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes
Imports PENGRA.Classes

Namespace Forms
    Public Class frmPaymentProfile

        Private Profile As DataTable
        Private History As DataTable

        'Private GuiMan As Gui

        Private Newrec As Boolean = False

        Private daProfile As FbDataAdapter
        Private daHistory As FbDataAdapter
        Private strSQL As String = ""

        Private Sub Clear()

            txtID.Clear()
            txtName.Clear()
            txtMinistry.Clear()

            dtpAuditDate.Value = Date.Now
            txtGratuity.Clear()
            txtPension.Clear()
            txtDeathPension.Clear()
            txtTotalBenefit.Clear()
            txtBalance.Clear()

            dtpPensionWEF.Value = Date.Now
            txtGratuityPaid.Clear()
            txtPensionPaid.Clear()
            txtDeathPaid.Clear()
            txtBenefitPaid.Clear()

        End Sub

        Private Sub Enable()
            txtID.Enabled = True
            txtBenefitType.Enabled = True
            txtName.Enabled = True
            txtMinistry.Enabled = True

            dtpAuditDate.Enabled = True
            txtGratuity.Enabled = True
            txtPension.Enabled = True
            txtDeathPension.Enabled = True
            txtTotalBenefit.Enabled = True
            txtBalance.Enabled = True

            dtpPensionWEF.Enabled = True
            txtGratuityPaid.Enabled = True
            txtPensionPaid.Enabled = True
            txtDeathPaid.Enabled = True
            txtBenefitPaid.Enabled = True
        End Sub

        Private Sub Disable()
            'txtID.Enabled = False
            txtName.Enabled = False
            txtBenefitType.Enabled = False
            txtMinistry.Enabled = False

            dtpAuditDate.Enabled = False
            txtGratuity.Enabled = False
            txtPension.Enabled = False
            txtDeathPension.Enabled = False
            txtTotalBenefit.Enabled = False
            txtBalance.Enabled = False

            dtpPensionWEF.Enabled = False
            txtGratuityPaid.Enabled = False
            txtPensionPaid.Enabled = False
            txtDeathPaid.Enabled = False
            txtBenefitPaid.Enabled = False
        End Sub

        Public Sub LoadRecord(ByVal Employee As Integer)
            Profile = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            strSQL = "SELECT p.ID, p.EMPLOYEENAME, p.MINISTRYNAME, p.BENEFITTYPE, p.AUDITDATE, p.PENSIONWEF, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PEANSIONPAID, p.DEATHPAID, p.TOTALPAID, p.BALANCE FROM SP_PAYMENT_PROFILE('" & Employee & "') p"

            daHistory = New FbDataAdapter(strSQL, DB.ConnObj)
            Profile = New DataTable
            daHistory.Fill(Profile)

            If Profile.Rows.Count > 0 Then toForm()

            InitGrid(Employee)

            ListSerials(dgvGrid)
        End Sub
        Public Sub LoadRetiree(ByVal IDNo As String)
            Dim retireeUkey As Integer = 0
            Dim strGetUkey As String = "SELECT UKEY FROM EMPLOYEEINFO WHERE IDNO = '" & IDNo & "'"
            Dim tblGetUkey As DataTable
            Dim daGetUkey As FbDataAdapter
            Profile = New DataTable

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            daGetUkey = New FbDataAdapter(strGetUkey, DB.ConnObj)
            tblGetUkey = New DataTable
            daGetUkey.Fill(tblGetUkey)

            If tblGetUkey.Rows.Count > 0 Then retireeUkey = tblGetUkey.Rows(0).Item("UKEY")

            strSQL = "SELECT p.ID, p.EMPLOYEENAME, p.MINISTRYNAME, p.BENEFITTYPE, p.AUDITDATE, p.PENSIONWEF, p.GRATUITY, p.PENSIONARREARS, p.DEATHPENSION, p.TOTALBENEFIT, p.GRATUITYPAID, p.PEANSIONPAID, p.DEATHPAID, p.TOTALPAID, p.BALANCE FROM SP_PAYMENT_PROFILE('" & retireeUkey & "') p"

            daHistory = New FbDataAdapter(strSQL, DB.ConnObj)
            Profile = New DataTable
            daHistory.Fill(Profile)

            If Profile.Rows.Count > 0 Then toForm()

            InitGrid(retireeUkey)

            ListSerials(dgvGrid)
        End Sub

        Private Sub InitGrid(ByVal Employee As Integer)
            History = New DataTable

            strSQL = "SELECT p.SN, p.TDATE, p.DESCRIPTION, p.BENEFIT, p.TRANS, AMOUNT FROM SP_PAYMENT_HISTORY('" & Employee & "') p"

            daHistory = New FbDataAdapter(strSQL, DB.ConnObj)
            daHistory.Fill(History)

            With dgvGrid
                .Columns.Clear()
                .ColumnHeadersHeight = 50
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 129, 207)
                .ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.Window
                .ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                .AllowUserToOrderColumns = False
                .AllowUserToResizeColumns = False
                .RowHeadersVisible = False

                .EnableHeadersVisualStyles = False
                .BorderStyle = BorderStyle.FixedSingle
                .DefaultCellStyle.BackColor = Color.WhiteSmoke
                .CellBorderStyle = DataGridViewCellBorderStyle.Single
                .DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


                Populate.WriteSN(dgvGrid)
                Populate.WriteColumn(dgvGrid, "cDate", "Date", 80, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cBudget", "Description", 180, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cBenefit", "Benefit", 120, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cDescription", "Transaction", 120, DataGridViewTriState.False, DataGridViewContentAlignment.MiddleLeft)
                Populate.WriteColumn(dgvGrid, "cAmount", "AMOUNT", 100, DataGridViewTriState.False, DataGridViewContentAlignment.BottomRight)

                .Columns(0).ReadOnly = True
                .Columns(0).DataPropertyName = "SN"

                .Columns(1).ReadOnly = True
                .Columns(1).DataPropertyName = "TDATE"

                .Columns(2).ReadOnly = True
                .Columns(2).DataPropertyName = "DESCRIPTION"

                .Columns(3).ReadOnly = True
                .Columns(3).DataPropertyName = "BENEFIT"

                .Columns(4).ReadOnly = True
                .Columns(4).DataPropertyName = "TRANS"

                .Columns(5).ReadOnly = True
                .Columns(5).DataPropertyName = "AMOUNT"
                .Columns(5).ValueType = GetType(Double)
                .Columns(5).DefaultCellStyle.Format = "#,##0.00"

                .DataSource = History.DefaultView
                'History.AcceptChanges()
            End With

        End Sub

        Public Sub ListSerials(ByVal dgv As DataGridView)
            If dgv.Rows.Count > 0 Then
                Dim I As Integer
                For I = 0 To dgv.Rows.Count - 1
                    dgv.Rows(I).Cells("tSN").Value = I + 1
                Next
            End If
        End Sub

        Private Sub toForm()

            Clear()

            With Profile.Rows(0)
                If Not IsDBNull(.Item("ID")) Then txtID.Text = .Item("ID")
                If Not IsDBNull(.Item("EMPLOYEENAME")) Then txtName.Text = .Item("EMPLOYEENAME")
                If Not IsDBNull(.Item("MINISTRYNAME")) Then txtMinistry.Text = .Item("MINISTRYNAME")
                If Not IsDBNull(.Item("BENEFITTYPE")) Then txtBenefitType.Text = .Item("BENEFITTYPE")
                If Not IsDBNull(.Item("AUDITDATE")) Then dtpAuditDate.Text = CType(.Item("AUDITDATE"), String)
                If Not IsDBNull(.Item("PENSIONWEF")) Then dtpPensionWEF.Text = CType(.Item("PENSIONWEF"), String)
                If Not IsDBNull(.Item("GRATUITY")) Then txtGratuity.Text = Format(.Item("GRATUITY"), "#,##0.00")
                If Not IsDBNull(.Item("PENSIONARREARS")) Then txtPension.Text = Format(.Item("PENSIONARREARS"), "#,##0.00")
                If Not IsDBNull(.Item("DEATHPENSION")) Then txtDeathPension.Text = Format(.Item("DEATHPENSION"), "#,##0.00")
                If Not IsDBNull(.Item("TOTALBENEFIT")) Then txtTotalBenefit.Text = Format(.Item("TOTALBENEFIT"), "#,##0.00")
                If Not IsDBNull(.Item("GRATUITYPAID")) Then txtGratuityPaid.Text = Format(.Item("GRATUITYPAID"), "#,##0.00")
                If Not IsDBNull(.Item("PEANSIONPAID")) Then txtPensionPaid.Text = Format(.Item("PEANSIONPAID"), "#,##0.00")
                If Not IsDBNull(.Item("DEATHPAID")) Then txtDeathPaid.Text = Format(.Item("DEATHPAID"), "#,##0.00")
                If Not IsDBNull(.Item("TOTALPAID")) Then txtBenefitPaid.Text = Format(.Item("TOTALPAID"), "#,##0.00")
                If Not IsDBNull(.Item("BALANCE")) Then txtBalance.Text = Format(.Item("BALANCE"), "#,##0.00")
            End With
        End Sub

        Private Sub frmPaymentStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor

            With dgvGrid
                .BackgroundColor = Env.GirdBackgroundColor
                .RowsDefaultCellStyle.SelectionBackColor = Env.GirdSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Env.GirdSelectionForeColor
            End With

            Disable()
        End Sub

        Private Sub CButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
            Dim F As New frmFindEmployee
            F.ShowDialog()
            If F.CancelRecord = False Then LoadRecord(F.EmployeeID.ToString)
        End Sub

        Private Sub txtID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyUp
            If txtID.Text = "" Then Exit Sub

            If e.KeyCode = Keys.Enter Then
                LoadRetiree(txtID.Text)
            End If
        End Sub
    End Class
End Namespace