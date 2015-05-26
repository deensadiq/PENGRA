Imports System.Windows.Forms
Namespace Forms
    Public Class frmServer

        Private bolTestConnection As Boolean = False

        Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click

            If txtServer.Text.Trim = "" Then Exit Sub

            If DB.pingHost(txtServer.Text.Trim) = True Then
                MessageBox.Show(Messages.Connected)
                bolTestConnection = True
            Else
                MessageBox.Show(Messages.NotConnected, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If


        End Sub

        Private Sub disabled()
            btnChange.Enabled = True
            btnClose.Enabled = True
            btnAccept.Enabled = False
            btnUndo.Enabled = False
            btnTest.Enabled = False
            txtServer.Enabled = False
        End Sub

        Private Sub enable()
            btnChange.Enabled = False
            btnClose.Enabled = False
            btnTest.Enabled = True
            btnAccept.Enabled = True
            btnUndo.Enabled = True
            txtServer.Enabled = True
        End Sub

        Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click


            enable()
            txtServer.Focus()

        End Sub

        Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click

            txtServer.Text = DB.getHost
            disabled()

        End Sub

        Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click

            If bolTestConnection = False Then Exit Sub

            Try
                If DB.pingHost(txtServer.Text.Trim) = False Then Throw New Exception("Wrong Server Name")
                Env.ConStr = DB.createConnection(Application.StartupPath + "\pengrareport.dll", txtServer.Text.Trim, , )
                DB.setHost(txtServer.Text.Trim)
                disabled()
            Catch ex As Exception
                MessageBox.Show("The Server Name Provide Is Not Valid. You Most Have Edit It After Testing.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End Sub

        Private Sub frmServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
            disabled()

            If Not DB.getHost = "" Then txtServer.Text = DB.getHost

        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace