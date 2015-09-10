Imports Opal.Code
Imports System.Windows.Forms
Imports Opal.GuiClass
Namespace cForm
    Public Class frmFindStudent
        Dim F As New FindStudent
        Dim mCancel As Boolean
        ReadOnly Property StudentID() As Long
            Get
                Return F.StudentID
            End Get
        End Property

        ReadOnly Property CancelRecord() As Boolean
            Get
                Return mCancel
            End Get
        End Property
        Private Sub frmFindStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            rbAdmissionNo.Checked = True
            F.bAdmissionNo = True
            F.LoadRecord(lvStudent)
            lblCount.Text = F.RecordCount.ToString
            Me.BackColor = Env.FormBackColor

        End Sub

        Private Sub ShowView()

            F.LoadList(txtFind.Text.ToString.Trim)
            lblCount.Text = F.RecordCount.ToString
            lblName.Text = F.FullName

        End Sub

        Private Sub lvStudent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvStudent.DoubleClick
            Me.Close()
        End Sub


        Private Sub lvStudent_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvStudent.ItemSelectionChanged
            F.ListClick(e.ItemIndex)
            lblName.Text = F.FullName

        End Sub

        Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
            ShowView()
        End Sub

        Private Sub rbStudentName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbStudentName.Click
            F.bAdmissionNo = False
            ShowView()
        End Sub

        Private Sub rbAdmissionNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbAdmissionNo.Click
            F.bAdmissionNo = True
            ShowView()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            If F.FullName.Trim = "" Then mCancel = True Else mCancel = False
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            mCancel = True
            Me.Close()
        End Sub


    End Class

End Namespace