Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes
Imports PENGRA.Connection.Forms
Imports PENGRA.Forms

Namespace MCSA

    Module Connection

        Public Function CheckForExistingInstance() As Boolean

            If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then

                MessageBox.Show _
                 ("Another Instance Of " + Application.ProductName + " Is Already Running. Multiple Instances Not Allowed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return True
            Else
                Return False
            End If

        End Function

        Public Sub Main()

            Dim Conn As New FbConnection
            Dim strConnectMessage As String = ""
            Dim strMCSA As String = "PENGRANEW"
            Dim Connected As Boolean = False
           

            Application.EnableVisualStyles()


            If CheckForExistingInstance() = True Then Exit Sub

            'If CheckLicense() = False Then
            '    GuiMan.showUnlock()
            '    End
            'End If

            'Set Environment Variables
            SetEnvVariables()

            

            '==============================================

            DB.Host = DB.getHost 'Get Host Name and Set as Default
            DB.DataBase = strMCSA 'Set Default Database
            DB.getLogIn(DB.User, DB.Password) 'Get Database Login (User Name and Password) and Assign
            Env.ConStr = DB.createConnection(strMCSA, DB.Host, DB.User, DB.Password) 'Create The Connection String and assign to global location

            If DB.pingHost(DB.Host, DB.User, DB.Password, strConnectMessage) = True Then
                Conn.ConnectionString = Env.ConStr
                Conn.Open()
                DB.ConnObj = Conn
            Else
                'If connection cannot be made to the database, exit the application
                If strConnectMessage.Contains("Unable to complete network request to host") Then
                    Dim form As New frmServer
                    form.ShowDialog()
                ElseIf strConnectMessage.Contains("Your user name and password are not defined") Then
                    'GuiMan.showConnect()
                    Dim form As New frmConnect
                    form.ShowDialog()
                ElseIf strConnectMessage.Contains("Create") Then
                    MessageBox.Show("Error loading Database. Please contact your Administrator, " + Application.ProductName + " will now Close.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Unable To Connect To Database", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                End

            End If


            '=============================================================================================

            If Passwords.Isset = True Then
                frmSplash.ShowDialog()
                frmLogin.ShowDialog()
                If Env.CurrentUser <> "" Then
                    Mdi.mdiControlPanel.ShowDialog()
                End If
            Else
                frmSplash.ShowDialog()
                Mdi.mdiControlPanel.ShowDialog()
            End If

        End Sub

        Public Function CheckLicense() As Boolean

            'Returns False If Evaluation Period Has Expired Or Has Been Tampared With
            Return True

            'Dim licence As New Lasisi("stayalive")
            'Dim isTrue As Boolean
            'Dim demoDays As Integer = 30
            'Dim DaysLeft As Integer = 0
            'Dim strMessage As String
            'Dim firstRun As Date
            'Dim lastRun As Date


            'isTrue = licence.loadLicence()

            ''Unlocked
            'If licence.Open = True Then
            '    Env.Company = licence.Licencee
            '    Env.Address = licence.Address
            '    Env.Open = True
            '    Return True
            'End If

            ''First Run
            'If isTrue = False Then
            '    licence.saveLicence()
            '    strMessage = "You Have " + CStr(demoDays) + " Day(s) Left To Finish Evaluating Opal"
            '    MessageBox.Show(strMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Return True
            'End If

            'firstRun = licence.Firstrun
            'lastRun = licence.Lastrun
            ''If firstRun <> lastRun Then demoDays = (lastRun - firstRun).Days
            'DaysLeft = demoDays - (Date.Today - firstRun).Days

            ''Check If System Is Back-Dated Or Evaluation Has Expired
            'If (lastRun > Date.Today) Or (firstRun > lastRun) Or (DaysLeft < 0) Then
            '    strMessage = "     Evaluation Period Has Expired     "
            '    MessageBox.Show(strMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Return False
            'End If

            'If demoDays >= 0 Then
            '    strMessage = "You Have " + CStr(DaysLeft) + " Day(s) Left To Finish Evaluating Opal"
            '    MessageBox.Show(strMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    licence.Lastrun = Date.Today
            '    licence.saveLicence()
            '    Return True
            'End If

        End Function

        Private Sub SetEnvVariables()
            'Dim GuiMan As GuiClass.Gui
            'Dim Table As New DataTable
            'Dim Adapter As FirebirdSql.Data.FirebirdClient.FbDataAdapter
            'Dim strSql As String


            'strSql = "SELECT SESSION, SEMESTER FROM TBL_CALENDAR"
            'Adapter = New FirebirdSql.Data.FirebirdClient.FbDataAdapter(strSql, GuiClass.Env.ConStr)
            'Adapter.Fill(Table)

            'If Not Table.Rows.Count = 0 Then
            '    GuiClass.Env.Session = Table.Rows(0).Item("SESSION")
            '    GuiClass.Env.Semester = Table.Rows(0).Item("SEMESTER")
            'End If
        End Sub

    End Module
End Namespace
