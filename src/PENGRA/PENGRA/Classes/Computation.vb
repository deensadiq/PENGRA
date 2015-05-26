Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports FirebirdSql.Data.FirebirdClient

Namespace Classes
    Public Class Computation

        Private m_Op As String 'Holds the string describing the current operation 
        Private WithEvents m_Worker As New System.ComponentModel.BackgroundWorker
        Private m_Args As System.ComponentModel.DoWorkEventArgs



        ''' <summary>
        ''' Returns a string describing the current operation in the process.
        ''' </summary>
        ''' <remarks></remarks>

        Public ReadOnly Property CurrentOperation() As String

            Get
                Return m_Op
            End Get

        End Property


        ''' <summary>
        ''' Adds a background worker that will be used to update gui elements like the progress bar.
        ''' </summary>
        ''' <param name="BackgroundWorker">The Backgroundworker to add</param>
        ''' <param name="e">The DoWorkEventArgs of the background worker to add</param>
        ''' <remarks></remarks>

        Public Sub addWorker(ByVal BackgroundWorker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs)

            m_Worker = BackgroundWorker
            m_Args = e
        End Sub

#Region "Write Payment Details"

        Public Sub ComputeDetails(ByVal Budget As Integer, ByVal BYear As Integer, ByVal BMonth As Integer)
            Dim Command As New FirebirdSql.Data.FirebirdClient.FbCommand
            Dim Reader As FirebirdSql.Data.FirebirdClient.FbDataReader
            'Dim Adapter As FbDataAdapter
            Dim CommandBuilder As New FbCommandBuilder
            Dim Table As New DataTable
            Dim Details As New DataTable
            Dim strSQL As String

            Dim intRecords As Integer
            Dim Percentage As Integer
            Dim intPos As Integer


            Using Conn As New FbConnection
                Conn.ConnectionString = DB.ConnectionString
                If Conn.State = ConnectionState.Closed Then Conn.Open()

                Using myTransactions = Conn.BeginTransaction

                    strSQL = "SELECT DISTINCT a.EMPLOYEE FROM TRANSACTIONS a WHERE a.BUDGET = '" & Budget & "' AND a.BYEAR = '" & BYear & "' AND a.BMONTH = '" & BMonth & "'"

                    Using commandr = New FbCommand(strSQL, Conn, myTransactions)
                        'Command = New FbCommand(strSQL, Conn)
                        commandr.CommandText = strSQL
                        Reader = commandr.ExecuteReader()

                        '-------------------get Count
                        'Table = New DataTable
                        'Adapter = New FirebirdSql.Data.FirebirdClient.FbDataAdapter(strSQL, Conn)
                        'Adapter.Fill(Table)
                        intRecords = Reader.VisibleFieldCount

                        '------------------

                        m_Op = "Process Payment Details"
                        m_Worker.ReportProgress(0)

                        While Reader.Read = True
                            Dim str As String

                            'checks if the process is cancelled by the user 
                            If m_Worker.CancellationPending = True Then
                                m_Op = "Cancelled"
                                m_Args.Cancel = True
                                Exit Sub
                            End If

                            m_Op = "Save Details For Employee ( " + Reader("EMPLOYEE").ToString + " )"

                            'EXECUTE PROCEDURE SP_SAVE_PAYMENT(EMPLOYEE, BUDGET, BYEAR, BMONTH)
                            str = "EXECUTE PROCEDURE SP_SAVE_PAYMENT('" & Reader("EMPLOYEE") & "', '" & Budget & "', '" & BYear & "', '" & BMonth & "')"

                            Using command2 = New FbCommand(str, Conn, myTransactions)
                                command2.CommandText = str
                                command2.ExecuteScalar()
                            End Using

                            intPos += 1
                            Percentage = CInt((intPos / intRecords) * 100)
                            m_Worker.ReportProgress(Percentage)

                        End While

                    End Using
                   

                    Dim sSQLS As String = "UPDATE BUDGETING SET ACTVE = '0' WHERE BUDGET = '" & Budget & "' AND BYEAR = '" & BYear & "' AND BMONTH = '" & BMonth & "' AND ACTVE = '1'"

                    Using command4 = New FbCommand(sSQLS, Conn, myTransactions)
                        command4.CommandText = sSQLS
                        command4.ExecuteScalar()
                    End Using


                    myTransactions.Commit()
                End Using

                Conn.Close()
            End Using
        End Sub
#End Region
    End Class
End Namespace