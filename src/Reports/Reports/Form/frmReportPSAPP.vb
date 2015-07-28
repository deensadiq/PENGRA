Imports FirebirdSql.Data.FirebirdClient
Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports PENGRA.Reports.Classes

Namespace Forms
    Public Class frmReportPSAPP
        'Dim Cbo As New cPopulateCombobox

        Public Enum rType
            ClassStudentAssessmentResult
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


        Private Sub frmReportSCCSSA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor

            'With Cbo
            '    .PopulateCategory(cboCategory, Env.UserID)
            '    .PopulateReportSemester(cboSemester)
            '    .PopulateReportSession(cboSession)
            'End With
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            If cboSemester.Text = "" Or cboSession.Text = "" Or cboCategory.Text = "" Or _
                cboYeargroup.Text = "" Or cboClass.Text = "" Then
                MessageBox.Show(Messages.NoSelection, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If



            Dim rSQl As New myReport

            With rSQl
                '.Category = CType(cboCategory.SelectedValue, Integer)
                '.Session = CType(cboSession.SelectedValue, Integer)
                '.Term = CType(cboSemester.SelectedValue, Integer)
                '.YearGroup = CType(cboYeargroup.SelectedValue, Integer)
                '.School = CType(1, Integer)
                '.CClass = CType(cboClass.SelectedValue, Integer)
                '.Assessment = CType(cboAssessment.SelectedValue, Integer)
                '.Parent = Me.MdiParent
            End With

            Try
                Select Case mReportType
                    Case rType.ClassStudentAssessmentResult
                        rSQl.ReportTitle = Me.Text
                        'rSQl.getClassStudentAssessmentResultSQL(rbPrint.Checked)
                End Select

            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
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

        Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged

        End Sub
    End Class
End Namespace