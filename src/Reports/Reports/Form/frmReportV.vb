Imports FirebirdSql.Data.FirebirdClient
Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports PENGRA.Reports.Classes

Namespace Forms
    Public Class frmReportV
        'Dim Cbo As New cPopulateCombobox

        Public Enum rType
            SubjectResult
            StudentRegistration
            StudentWithoutScore
            ScoreSheet
        End Enum

        Private mReportType As rType

        Property ReportType() As rType
            Get
                Return mReportType
            End Get
            Set(ByVal value As rType)
                mReportType = value
            End Set
        End Property


        Private Sub frmReportSCCSSSA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            'Dim Cbo As New cPopulateCombobox

            'With Cbo
            '    .PopulateCategory(cboCategory, Env.UserID)
            '    .PopulateReportSemester(cboSemester)
            '    .PopulateReportSession(cboSession)
            '    .PopulateSubject(cboSubject, Env.UserID)
            'End With

        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            If cboSemester.Text = "" Or cboSession.Text = "" Or cboCategory.Text = "" Then
                MessageBox.Show(Messages.NoSelection, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Dim rSQl As New myReport

            With rSQl
                '.Assessment = CType(cboAssessment.SelectedValue, Integer)
                '.Category = CType(cboCategory.SelectedValue, Integer)
                '.Session = CType(cboSession.SelectedValue, Integer)
                '.Term = CType(cboSemester.SelectedValue, Integer)
                '.YearGroup = CType(cboYeargroup.SelectedValue, Integer)
                '.School = CType(1, Integer)
                '.Subject = CType(cboSubject.SelectedValue, Integer)
                '.CClass = CType(cboClass.SelectedValue, Integer)
                '.Parent = Me.MdiParent
            End With

            Try
                Select Case mReportType
                    Case rType.SubjectResult
                        rSQl.ReportTitle = Me.Text
                        'rSQl.getSubjectResultSQL(rbPrint.Checked)
                    Case rType.StudentRegistration
                        rSQl.ReportTitle = Me.Text
                        'rSQl.getSubjectRegisteredStudentsSQL(rbPrint.Checked)
                    Case rType.StudentWithoutScore
                        rSQl.ReportTitle = Me.Text
                        'rSQl.getStudentWithoutScoreSQL(rbPrint.Checked)
                    Case rType.ScoreSheet
                        rSQl.ReportTitle = Me.Text
                        'rSQl.getScoreSheetSQL(rbPrint.Checked)
                End Select


            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub


        Private Sub cboYeargroup_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboYeargroup.SelectedValueChanged
            'Try
            '    Cbo.PopulateClass(cboClass, CType(1, Short), CType(cboCategory.SelectedValue, Short), CType(cboYeargroup.SelectedValue, Short), Env.UserID)
            'Catch ex As Exception

            'End Try
        End Sub

        Private Sub cboCategory_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedValueChanged
            'Try
            '    Cbo.PopulateYearGroup(cboYeargroup, CType(1, Short), CType(cboCategory.SelectedValue, Short))
            '    Cbo.PopulateAssessment(cboAssessment, CType(cboCategory.SelectedValue, Short), CType(cboYeargroup.SelectedValue, Short))
            'Catch ex As Exception

            'End Try
        End Sub
    End Class
End Namespace