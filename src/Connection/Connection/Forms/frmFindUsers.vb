Imports System.Windows.Forms
Imports PENGRA.Connection.Classes

Namespace Forms
    Public Class frmFindUsers
        Dim F As New FindUser
        Dim mCancel As Boolean
        ReadOnly Property UserID() As Long
            Get
                Return F.UserID
            End Get
        End Property

        ReadOnly Property CancelRecord() As Boolean
            Get
                Return mCancel
            End Get
        End Property
        Private Sub frmFindStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            rbUsername.Checked = True
            F.bUserName = True
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

        Private Sub rbEmployeeName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFullName.Click
            F.bUserName = False
            ShowView()
        End Sub

        Private Sub rbIDNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbUsername.Click
            F.bUserName = True
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