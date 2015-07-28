Imports PENGRA.Connection.Classes
Imports System.Windows.Forms
Imports FirebirdSql.Data.FirebirdClient

Namespace Forms
    Public Class frmBackupRestore


        Private Sub BackupDatabase(ByVal backupFile As String)

            Dim bkp As New FirebirdSql.Data.Services.FbBackup

            bkp.ConnectionString = Env.ConStr

            Dim bp As New FirebirdSql.Data.Services.FbBackupFile(backupFile, 4096)
            bkp.BackupFiles.Add(bp)

            'bkp.Verbose = True
            Try
                bkp.Execute()
                Timer1.Stop()
                prgBar.Value = 100
                MessageBox.Show(Messages.Completed, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End Sub
        Private Sub RestoreDatabase(ByVal restoreFile As String)

            Dim cs As New FirebirdSql.Data.FirebirdClient.FbConnectionStringBuilder

            cs.UserID = "sysdba"
            cs.Password = "masterkey"
            cs.Database = Application.StartupPath + "\OPALREPORT.DLL"


            Dim res As New FirebirdSql.Data.Services.FbRestore

            Dim bp As New FirebirdSql.Data.Services.FbBackupFile(restoreFile, 4096)

            res.ConnectionString = cs.ConnectionString

            res.BackupFiles.Add(bp)
            res.PageSize = 4096
            res.Options = FirebirdSql.Data.Services.FbRestoreFlags.Replace + FirebirdSql.Data.Services.FbRestoreFlags.Create
            'res.Verbose = True
            Try

                FirebirdSql.Data.FirebirdClient.FbConnection.ClearAllPools()

                res.Execute()

                Timer1.Stop()
                prgBar.Value = 100
                MessageBox.Show(Messages.Completed, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                'Throw ex
                MessageBox.Show("Enter A Valid System Directory in Space Provided Location.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        End Sub

        Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub


        Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
            If rbRestore.Checked = True Then
                With ofdMain
                    .Filter = "Backup Files(*.bkp)|*.bkp|All Files |*.*"
                    .DefaultExt = "bkp"
                    .ShowDialog()
                    txtLocation.Text = .FileName
                    prgBar.Value = 0
                End With
            Else
                With sfdMain
                    .Filter = "Backup Files(*.bkp)|*.bkp|All Files |*.*"
                    .DefaultExt = "bkp"
                    .ShowDialog()
                    txtLocation.Text = .FileName
                    prgBar.Value = 0
                End With
            End If
        End Sub

        Private Sub btnProcessing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessing.Click
            prgBar.Value = 0

            If rbBackup.Checked = True And txtLocation.Text = "" Then Exit Sub

            If rbRestore.Checked = True And txtLocation.Text = "" Then Exit Sub

            Timer1.Enabled = True
            Timer1.Start()


            If rbBackup.Checked = True Then BackupDatabase(Trim(txtLocation.Text))

            If rbRestore.Checked = True Then RestoreDatabase(Trim(txtLocation.Text))


        End Sub

        Private Sub frmBackupRestore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.BackColor = Env.FormBackColor
        End Sub

        Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
            If prgBar.Value = prgBar.Maximum Then prgBar.Value = 0
            prgBar.Value = prgBar.Value + 1
        End Sub
    End Class
End Namespace