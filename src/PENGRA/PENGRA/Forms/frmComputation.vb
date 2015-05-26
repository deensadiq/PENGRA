Imports System.Windows.Forms

Namespace Forms

    Public Class frmComputation

        'Dim Combo As New cPopulateCombobox
        'Dim bolStop As Boolean

        Private Shared intCategory As Integer
        Private Shared intYearGroup As Integer
        Private Shared intSession As Integer
        Private Shared intSemester As Integer
        'Public WithEvents Processor As New OpalEngine

        Private Sub Enable()

            cboCategory.Enabled = True
            cboYeargroup.Enabled = True
            cboSemester.Enabled = True
            cboSession.Enabled = True
            btnProcess.Enabled = True

            btnStop.Enabled = False

        End Sub

        Private Sub Disable()

            cboCategory.Enabled = False
            cboYeargroup.Enabled = False
            cboSemester.Enabled = False
            cboSession.Enabled = False
            btnProcess.Enabled = False

            btnStop.Enabled = True

        End Sub

        Private Sub frmComputation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            'Combo.PopulateCategory(cboCategory, Env.UserID)
            'Combo.PopulateSession(cboSession)
            'Combo.PopulateSemester(cboSemester)

            'Me.BackColor = Env.FormBackColor
            'Enable()

            'If ACTIVECALENDAR.IsSet = True Then
            '    cboSession.SelectedIndex = 1
            '    cboSemester.SelectedIndex = 1
            'End If

        End Sub

        Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            If cboCategory.Text = "" Or cboYeargroup.Text = "" Or cboSemester.Text = "" Or cboSession.Text = "" Then Exit Sub
            intCategory = CInt(cboCategory.SelectedValue)
            intYearGroup = CInt(cboYeargroup.SelectedValue)
            intSession = CInt(cboSession.SelectedValue)
            intSemester = CInt(cboSemester.SelectedValue)

            btnProcess.Enabled = False
            btnStop.Enabled = True

            BackgroundWorker.RunWorkerAsync()


        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.Close()
        End Sub

        Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'BackgroundWorker.CancelAsync()
            'OpalEngine.clearDetails(intCategory, intYearGroup, intSession, intSemester)
            'OpalEngine.clearStatus(intCategory, intYearGroup, intSession, intSemester)

            lblStudent.Text = ""
            pbStudent.Value = 0
            btnProcess.Enabled = True
            btnStop.Enabled = False

        End Sub

        Private Sub BackgroundWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork

            'Processor.addWorker(BackgroundWorker, e)
            'Processor.ProcessResult(intCategory, intYearGroup, intSession, intSemester)

        End Sub

        Private Sub BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged


            If e.ProgressPercentage = 0 Then
                pbStudent.Step = 1
                pbStudent.Minimum = 0
                pbStudent.Maximum = 100

                'If Processor.CurrentOperation = "loadSubjects" Then lblStudent.Text = "Loading Subjects"
                'If Processor.CurrentOperation = "Details_Grades" Then lblStudent.Text = "Computing Grades"
                'If Processor.CurrentOperation = "SCTP" Then lblStudent.Text = "Computing Subject Positions By Section"
                'If Processor.CurrentOperation = "Details_YP" Then lblStudent.Text = "Computing Subject Positions By Year Group"
                'If Processor.CurrentOperation = "ALLCLASS" Then lblStudent.Text = "Computing Subject Positions By All Classes"
                'If Processor.CurrentOperation = "CLASSPOS" Then lblStudent.Text = "Computing Subject Positions By Class"
                'If Processor.CurrentOperation = "STATUS" Then lblStudent.Text = "Computing Academic Status Details"
                'If Processor.CurrentOperation = "STATUS_ALLCLASS" Then lblStudent.Text = "Computing Academic Status All Classes"
                'If Processor.CurrentOperation = "STATUS_YP" Then lblStudent.Text = "Computing Academic Status Year Group"
                'If Processor.CurrentOperation = "STATUS_CTP" Then lblStudent.Text = "Computing Academic Status By Section"
                'If Processor.CurrentOperation = "STATUS_CLASSPOS" Then lblStudent.Text = "Computing Academic Status By Class"
                'If Processor.CurrentOperation = "ProcessCalendar" Then lblStudent.Text = "Process Calendar"
                'If Processor.CurrentOperation = "Cumulative_Scores" Then lblStudent.Text = "Computing Cumulative Scores"
                'If Processor.CurrentOperation = "Subject Position Cumulative YG" Then lblStudent.Text = "Computing Cumulative Subject Year Group Positions"
                'If Processor.CurrentOperation = "Subject Position Cumulative" Then lblStudent.Text = "Computing Cumulative Subject Positions"
                'If Processor.CurrentOperation = "Subject Position Cumulative Class" Then lblStudent.Text = "Computing Cumulative Subject Class Positions"
                'If Processor.CurrentOperation = "Subject Position Cumulative AllClass" Then lblStudent.Text = "Computing Cumulative Subject All Classes Positions"
                'If Processor.CurrentOperation = "CUMULATIVE STATUS" Then lblStudent.Text = "Computing Cumulative Status"
                'If Processor.CurrentOperation = "YP CUMULATIVE POSITION" Then lblStudent.Text = "Computing Cumulative Year Group Positions "
                'If Processor.CurrentOperation = "CTP CUMULATIVE POSITION" Then lblStudent.Text = "Computing Cumulative Section Positions "
                'If Processor.CurrentOperation = "CLASS CUMULATIVE POSITION" Then lblStudent.Text = "Computing Cumulative Class Positions "
                'If Processor.CurrentOperation = "ALL CUMULATIVE CLASS POSITION" Then lblStudent.Text = "Computing Cumulative All Class Positions "
                'If Processor.CurrentOperation = "Promotion" Then lblStudent.Text = "Computing Promotion"

                'If Processor.CurrentOperation = "writeSchoolsettings" Then lblStudent.Text = "Writing School Settings"
                'If Processor.CurrentOperation = "writeReports" Then lblStudent.Text = "Generating Reports"
                'If Processor.CurrentOperation = "writeComments" Then lblStudent.Text = "Writing Comments"
                'If Processor.CurrentOperation = "writeBroadSheet" Then lblStudent.Text = "Preparing Broadsheet"
                'If Processor.CurrentOperation = "Finish" Then lblStudent.Text = "Finalising"
            End If

            If e.ProgressPercentage > 100 Or e.ProgressPercentage < 1 Then Exit Sub
            pbStudent.Value = e.ProgressPercentage

        End Sub

        Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted

            'If Processor.CurrentOperation = "Cancelled" Then

            '    MessageBox.Show(Messages.Cancelled, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '    MessageBox.Show(Messages.Completed, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If


            lblStudent.Text = ""
            pbStudent.Value = 0
            btnProcess.Enabled = True
            btnStop.Enabled = False

        End Sub

        Private Sub cboCategory_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedValueChanged
            Try
                'Combo.PopulateYearGroup(cboYeargroup, 1, CType(cboCategory.SelectedValue, Short))
            Catch ex As Exception

            End Try
        End Sub



    End Class

End Namespace