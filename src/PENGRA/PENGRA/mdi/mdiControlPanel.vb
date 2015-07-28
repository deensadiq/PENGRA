Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports PENGRA.Classes
Imports PENGRA.Reports.Classes

Namespace Mdi

    Public Class mdiControlPanel

        Private GuiMan As GuiForms = GuiForms.getGuiManager
        Private GuiReport As ReportForms = ReportForms.getGuiManager
        Private GuiConnect As Gui = Gui.getGuiManager
        Private Sub ApplyNSubItemsColor(ByVal ts As ToolStripMenuItem)

            For Each I As ToolStripItem In ts.DropDownItems
                If I.GetType Is GetType(ToolStripSeparator) Then
                    I.BackColor = Env.FormBackColor
                Else
                    ApplyNSubItemsColor(I)
                End If
                I.BackColor = Env.FormBackColor
            Next

        End Sub
        Private Sub ApplySubItemsColor(ByVal ts As ToolStripItemCollection)

            For Each I As ToolStripItem In ts
                If I.GetType Is GetType(ToolStripSeparator) Then
                    I.BackColor = Env.FormBackColor
                Else
                    ApplyNSubItemsColor(I)
                End If
                I.BackColor = Env.FormBackColor
            Next

        End Sub

        Private Sub ApplyColorMenu()

            For Each I As ToolStripMenuItem In Me.MenuStrip.Items
                ApplySubItemsColor(I.DropDownItems)
                I.BackColor = Env.FormBackColor
            Next

            For Each I As ToolStripButton In Me.ToolStrip.Items
                I.BackColor = Env.FormBackColor
            Next
        End Sub

        Private Sub ApplyColorThemes()
            For Each cForm As crsForm.cForms In Me.MdiChildren
                If cForm.Visible = True Then cForm.BackColor = Env.FormBackColor
            Next
            Me.MenuStrip.BackColor = Env.FormBackColor
            Me.ToolStrip.BackColor = Env.FormBackColor
            Me.StatusStrip.BackColor = Env.FormBackColor
            ApplyColorMenu()
        End Sub

        Private Sub UnCheckColorTheme()
            'For Each M As ToolStripMenuItem In Me.ColorToolStripMenuItem.DropDownItems
            '    M.Checked = False
            'Next
        End Sub

        Private Sub CheckCurrentTheme()
            'Select Case Env.FormBackColor
            '    Case Drawing.Color.White
            '        Me.cDefaultToolStripMenuItem.Checked = True
            '    Case Drawing.Color.Pink
            '        Me.CyberiaToolStripMenuItem.Checked = True
            '    Case Drawing.Color.Silver
            '        Me.SilverToolStripMenuItem.Checked = True
            '    Case Drawing.Color.Gainsboro
            '        Me.LightToolStripMenuItem.Checked = True
            '    Case Drawing.Color.LightSteelBlue
            '        Me.AquaToolStripMenuItem.Checked = True
            '    Case Drawing.Color.AliceBlue
            '        Me.CrystalToolStripMenuItem.Checked = True
            'End Select
        End Sub

        Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
            Me.Close()
        End Sub

        Private Sub PayslipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportOutstandingToolStripMenuItem.Click
            'GuiReport.setReportLOB(Me, "OutStanding Beneficiaries", Reports.Forms.frmReportBYM.rType.BenefitPayment)
            GuiReport.setReportSUM(Me, "Summary of Beneficiaries [Detailed]", Reports.Forms.frmReportSUM.rType.SummaryDetails)
        End Sub

        Private Sub MenuStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

        End Sub
        Private Sub hidePrivileges()
            '-------------------------------------------------------------
            '       OPERATIONS
            '-------------------------------------------------------------
            Me.EmployeeToolStripMenuItem.Visible = False ' Retire Profile

            Me.RetireePaymentProfileToolStripMenuItem.Visible = False
            Me.RetirePaymentToolStripMenuItem.Visible = False

            Me.AllocationToolStripMenuItem.Visible = False

            Me.SummaryOutstandingToolStripMenuItem.Visible = False
            Me.OutstandingALToolStripMenuItem.Visible = False
            Me.SummaryOutstandingToolStripMenuItem.Visible = False
            Me.SummaryOutstandingALToolStripMenuItem.Visible = False

            Me.PaymentDetailsToolStripMenuItem.Visible = False
            Me.PaymentDetailsALToolStripMenuItem.Visible = False

            Me.ProcessToolStripMenuItem.Visible = False

            Me.PasswordToolStripMenuItem.Visible = False
            Me.LogoutToolStripMenuItem.Visible = False

            '----------------------------------------------------------------
            '       VIEW
            '----------------------------------------------------------------
            Me.ViewMenu.Visible = False

            Me.ToolBarToolStripMenuItem.Visible = False
            Me.StatusBarToolStripMenuItem.Visible = False

            '----------------------------------------------------------------
            '       SETTINGS
            '----------------------------------------------------------------
            Me.SettingsMenu.Visible = False

            Me.AllowanceToolStripMenuItem.Visible = False
            Me.AllocationSettingsToolStripMenuItem.Visible = False
            Me.DeductionToolStripMenuItem.Visible = False
            Me.MinistryToolStripMenuItem.Visible = False
            Me.SalaryToolStripMenuItem.Visible = False

            Me.PaymentTermsToolStripMenuItem.Visible = False
            Me.SalaryTableToolStripMenuItem.Visible = False

            Me.UserAccountToolStripMenuItem.Visible = False

            Me.ServerToolStripMenuItem.Visible = False

            '-----------------------------------------------------------------
            '       EXTRA
            '-----------------------------------------------------------------
            Me.ExtraMenu.Visible = False

            Me.BenefitCalToolStripMenuItem.Visible = False
            Me.BackupRestoreToolStripMenuItem.Visible = False

            Me.OptionsToolStripMenuItem.Visible = False

            '------------------------------------------------------------------
            '       REPORTS
            '------------------------------------------------------------------
            Me.ReportMenu.Visible = False


        End Sub

        Private Sub mdiControlPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ToolStrip.BackColor = Color.FromArgb(246, 248, 252)
            StatusStrip.BackColor = Color.FromArgb(246, 248, 252)
            MenuStrip.BackColor = Color.FromArgb(246, 248, 252)
            Me.BackColor = Env.FormBackColor

            'Apply theme
            ApplyColorThemes()
            ApplyColorMenu()

            ToolStrip.BackColor = Color.FromArgb(225, 228, 233)
            StatusStrip.BackColor = Color.FromArgb(225, 228, 233)
            MenuStrip.BackColor = Color.FromArgb(225, 228, 233)
            'Me.BackColor = Color.FromArgb(225, 228, 233)
        End Sub

        Private Sub BeneficiariesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            'Forms.frmOutstandingBeneficiaries.ShowDialog()

        End Sub

        Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
            GuiMan.showEmployee(Me)
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllowanceToolStripMenuItem.Click
            GuiMan.showSettings(Me, "Define Allowance", "ALLOWANCES")
        End Sub

        Private Sub AllowancesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllocationSettingsToolStripMenuItem.Click
            GuiMan.showAllocation(Me, "Define Allocation")
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeductionToolStripMenuItem.Click
            GuiMan.showSettings(Me, "Define Deduction", "DEDUCTIONS")
        End Sub

        Private Sub BankToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinistryToolStripMenuItem.Click
            GuiMan.showSettings(Me, "Define Ministry", "MINISTRY")
        End Sub

        Private Sub CadreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryToolStripMenuItem.Click
            GuiMan.showSettings(Me, "Define Salary Scale", "SALARYSCALE")
        End Sub

        Private Sub PaymentTermsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentTermsToolStripMenuItem.Click
            GuiMan.showPaymentLimit(Me)
        End Sub

        Private Sub SalaryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryTableToolStripMenuItem.Click
            GuiMan.showSalaryTable(Me)
        End Sub

        Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BenefitCalToolStripMenuItem.Click
            GuiMan.showCalculator(Me)
        End Sub

        Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetireePaymentProfileToolStripMenuItem.Click
            GuiMan.showStatus(Me)
        End Sub

        Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
            GuiMan.showEmployee(Me)
        End Sub

        Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OustandingToolStripMenuItem.Click
            GuiMan.showOutStandingBeneficiaries(Me)
        End Sub

        Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllocationToolStripMenuItem.Click
            GuiMan.showBudgeting(Me)
        End Sub

        Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentDetailsToolStripMenuItem.Click
            GuiMan.showPaymentDetails(Me)
        End Sub

        Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryOutstandingToolStripMenuItem.Click
            GuiMan.showOutStandingSummary(Me)
        End Sub

        Private Sub ProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessToolStripMenuItem.Click
            GuiMan.showProcessPayment(Me)
        End Sub

        Private Sub ScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportMonthlyToolStripMenuItem.Click
            GuiReport.setReportAYM(Me, "Payment of Retirement Benefit", Reports.Forms.frmReportAYM.rType.BenefitPayment)
        End Sub

        Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportPaymentSummaryToolStripMenuItem.Click
            GuiReport.setReportAYM(Me, "Payment Summary", Reports.Forms.frmReportAYM.rType.BenefitPaymentSummary)
        End Sub

        Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportPensionToolStripMenuItem.Click
            GuiReport.setReportAYM(Me, "Schedule of Pension Payroll", Reports.Forms.frmReportAYM.rType.PensionPayroll)
        End Sub

        Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportDeathToolStripMenuItem.Click
            GuiReport.setReportAYM(Me, "Death Pension Payroll Schedule", Reports.Forms.frmReportAYM.rType.DeathPensionPayroll)
        End Sub

        Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportPensionPayrollToolStripMenuItem.Click
            GuiReport.setReportAYM(Me, "Pension Payroll Summary", Reports.Forms.frmReportAYM.rType.PensionPayrollSummary)
        End Sub

        Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportDeathPayrollToolStripMenuItem.Click
            GuiReport.setReportAYM(Me, "Death Pension Payroll Summary", Reports.Forms.frmReportAYM.rType.DeathPensionPayrollSummary)
        End Sub

        Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutstandingALToolStripMenuItem.Click
            GuiMan.showAboveLimitBeneficiaries(Me)
        End Sub

        Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentDetailsALToolStripMenuItem.Click
            'GuiMan.showPaymentLimitDetails(Me)
            GuiMan.showPaymentDetailsAL(Me)
        End Sub

        Private Sub ServerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerToolStripMenuItem.Click
            GuiConnect.setServer()
        End Sub

        Private Sub UserAccountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountToolStripMenuItem.Click
            GuiConnect.showUsers(Me)
        End Sub

        Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click
            GuiConnect.showUserList(Me)
        End Sub

        Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordToolStripMenuItem.Click
            GuiConnect.showChangePassword(Me)
        End Sub

        Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
            Global.System.Windows.Forms.Application.Exit()
        End Sub

        Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
            If Passwords.Isset = True Then GuiMan.showLogIn() Else Global.System.Windows.Forms.Application.Exit()
        End Sub

        Private Sub ToolStripMenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetirePaymentToolStripMenuItem.Click
            GuiMan.showPaymentKnockoff(Me)
        End Sub

        Private Sub SummaryOutstandingALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryOutstandingALToolStripMenuItem.Click
            GuiMan.showOutStandingSummaryAL(Me)
        End Sub

        Private Sub ToolStripMenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
            GuiMan.showMemo(Me)
        End Sub

        Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
            GuiReport.setReportOB(Me, "Outstanding Beneficiaries", Reports.Forms.frmReportOB.rType.OutstandingBeneficiaries)
        End Sub

        Private Sub ToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
            GuiReport.setReportSB(Me, "Summary Breakdown of Beneficiaries", Reports.Forms.frmReportSB.rType.SummaryBreakdown)
        End Sub

        Private Sub DetailedToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            GuiReport.setReportSUM(Me, "Summary of Beneficiaries [Detailed]", Reports.Forms.frmReportSUM.rType.SummaryDetails)
        End Sub

        Private Sub GraphicalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            GuiReport.setReportSUM(Me, "Summary of Beneficiaries [Graphical]", Reports.Forms.frmReportSUM.rType.SummaryGraphs)
        End Sub

        Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
            Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
        End Sub

        Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
            Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
        End Sub

        Private Sub BackupRestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupRestoreToolStripMenuItem.Click
            GuiMan.showBackupRestore(Me)
        End Sub

        Private Sub ToolStripMenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
            GuiReport.setReportAYM(Me, "Request For Funds", Reports.Forms.frmReportAYM.rType.RequestForFund)
        End Sub

        Private Sub ReportSecuritPensionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportSecuritPensionToolStripMenuItem.Click
            GuiReport.setReportSS(Me, "Security Schedule [Gratuity]", Reports.Forms.frmReportSS.rType.SecurityScheduleGratuity)
        End Sub

        Private Sub ToolStripMenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
            GuiReport.setReportSS(Me, "Security Schedule [Pension]", Reports.Forms.frmReportSS.rType.SecuritySchedulePension)
        End Sub
    End Class
End Namespace