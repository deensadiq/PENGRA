Imports FirebirdSql.Data.FirebirdClient
Imports PENGRA.Connection.Classes

Namespace Classes
    Public Class Payment
        Private m_Op As String 'Hold the strings describing the current operation
        Private WithEvents m_Worker As New System.ComponentModel.BackgroundWorker
        Private m_Args As System.ComponentModel.DoWorkEventArgs
        Public ReadOnly Property CurrentOperation As String
            Get
                Return m_Op
            End Get
        End Property
        Public Sub addWorker(ByVal BackgroundWorker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs)
            m_Worker = BackgroundWorker
            m_Args = e
        End Sub
#Region "Clear Payment Records"
        Public Shared Sub clearMemo(ByVal Allocation As Integer, ByVal aYear As Integer, ByVal aMonth As Integer)
            Dim Str As String
            Dim Command As New FbCommand

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Str = "UPDATE FROM MEMOS SET SUBMITTED = NULL, BUDGET = NULL, BYEAR = NULL, BMONTH = NULL WHERE BUDGET = '" & Allocation & "' AND BYEAR = '" & aYear & "' AND BMONTH = '" & aMonth & "'"
            Command.Connection = DB.ConnObj
            Command.CommandText = Str
            Command.ExecuteScalar()

        End Sub
        Public Shared Sub ClearOutstandingDetails(ByVal Allocation As Integer, ByVal Year As Integer, ByVal Month As Integer)
            Dim Str As String
            Dim command As New FbCommand

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Str = "DELETE FROM OUTSTANDINGDETAILS WHERE BUDGET = '" & Allocation & "' BYEAR = '" & Year & "' AND BMONTH = '" & Month & "'"
            command.Connection = DB.ConnObj
            command.CommandText = Str
            command.ExecuteNonQuery()

        End Sub
        Public Shared Sub ClearPaymentDetails(ByVal Allocation As Integer, ByVal Year As Integer, ByVal Month As Integer)
            Dim Str As String
            Dim Command As New FbCommand

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            Str = "DELETE FROM PAYMENTDETAILS WHERE BUDGET = '" & Allocation & "' AND BYEAR = '" & Year & "' AND BMONTH = '" & Month & "'"
            Command.Connection = DB.ConnObj
            Command.CommandText = Str
            Command.ExecuteScalar()
        End Sub
#End Region
#Region "Write Payment"
        'Process and Write Payment Details
        Private Function WritePayment(ByVal Allocation As Integer, ByVal Year As Integer, ByVal Month As Integer) As Boolean
            Dim strSQL As String
            Dim Command As FbCommand
            Dim Reader As FbDataReader
            Dim Table As New DataTable
            Dim Adapter As FbDataAdapter

            Dim intRecords As Integer
            Dim Percentage As Integer
            Dim intPos As Integer

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            strSQL = "SELECT DISTINCT a.EMPLOYEE, b.IDNO FROM TRANSACTIONS a JOIN EMPLOYEEINFO b ON (a.EMPLOYEE = b.UKEY) WHERE a.BUDGET = '" & Allocation & "' AND a.BYEAR = '" & Year & "' AND a.BMONTH = '" & Month & "' AND a.STATUS = '2'"
            Command = New FbCommand
            Command.Connection = DB.ConnObj
            Command.CommandText = strSQL
            Reader = Command.ExecuteReader

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Adapter.Fill(Table)

            intRecords = Table.Rows.Count

            '-------------------------------------------
            '   Get Started
            '-------------------------------------------
            m_Op = "WRITING PAYMENT DETAILS..."
            m_Worker.ReportProgress(0)

            System.Threading.Thread.Sleep(100)

            While Reader.Read

                'checks if the process is cancelled by the user 
                If m_Worker.CancellationPending = True Then
                    m_Op = "Cancelled"
                    m_Args.Cancel = True
                    Return False
                End If

                strSQL = "EXECUTE PROCEDURE SP_SAVE_PAYMENT('" & Reader("EMPLOYEE") & "', '" & Allocation & "', '" & Year & "', '" & Month & "')"

                Command = New FbCommand
                Command.Connection = DB.ConnObj
                Command.CommandText = strSQL
                Command.ExecuteScalar()

                intPos += 1
                Percentage = CInt((intPos / intRecords) * 100)

                m_Op = "Writing Details For [ " + Reader("IDNO").ToString + " ]..."
                m_Worker.ReportProgress(Percentage)

                System.Threading.Thread.Sleep(10)

            End While

            strSQL = "UPDATE BUDGETING SET ACTVE = '0' WHERE BUDGET = '" & Allocation & "' AND BYEAR = '" & Year & "' AND BMONTH = '" & Month & "' AND ACTVE = '1'"
            Command = New FbCommand
            Command.Connection = DB.ConnObj
            Command.CommandText = strSQL
            Command.ExecuteScalar()

            Return True
        End Function
#End Region
#Region "Write Outstanding Benefits"
        'Process and write Outstanding Benefits Status After making Payment
        Private Function WriteOutstandingBenefit(ByVal Allocation As Integer, ByVal Year As Integer, ByVal Month As Integer) As Boolean
            Dim strSQL As String
            Dim Command As FbCommand
            Dim Reader As FbDataReader
            Dim Table As New DataTable
            Dim Adapter As FbDataAdapter

            Dim intRecords As Integer
            Dim Percentage As Integer
            Dim intPos As Integer

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            strSQL = "SELECT a.IDNO,a.UKEY FROM EMPLOYEEINFO a WHERE a.ACTVE = 1 AND a.STATUS = '2'"
            Command = New FbCommand
            Command.Connection = DB.ConnObj
            Command.CommandText = strSQL
            Reader = Command.ExecuteReader

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Adapter.Fill(Table)

            intRecords = Table.Rows.Count

            '-------------------------------------------
            '   Get Started
            '-------------------------------------------
            m_Op = "SAVING OUTSTANDING DETAILS..."
            m_Worker.ReportProgress(0)
            System.Threading.Thread.Sleep(100)

            While Reader.Read

                'checks if the process is cancelled by the user 
                If m_Worker.CancellationPending = True Then
                    m_Op = "Cancelled"
                    m_Args.Cancel = True
                    Return False
                End If

                strSQL = "EXECUTE PROCEDURE SP_SAVE_OUTSTANDING('" & Reader("UKEY") & "', '" & Allocation & "', '" & Year & "', '" & Month & "')"
                'strSQL = "EXECUTE PROCEDURE SP_SAVE_OUTSTANDING('" & Reader("EMPLOYEE") & "', '" & Allocation & "', '" & Year & "', '" & Month & "')"

                Command = New FbCommand
                Command.Connection = DB.ConnObj
                Command.CommandText = strSQL
                Command.ExecuteScalar()

                intPos += 1
                Percentage = CInt((intPos / intRecords) * 100)

                m_Op = "Saving Details For [ " + Reader("IDNO").ToString + " ]..."
                m_Worker.ReportProgress(Percentage)

                System.Threading.Thread.Sleep(10)

            End While

            Return True
        End Function
#End Region
#Region "Write Memo"
        Private Function WriteMemo(ByVal Allocation As Integer, ByVal Year As Integer, ByVal Month As Integer) As Boolean
            Dim strSQL As String
            Dim Table As DataTable
            Dim Adapter As FbDataAdapter
            Dim Builder As FbCommandBuilder

            Dim intRecords As Integer
            Dim Percentage As Integer
            Dim intPos As Integer

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            strSQL = "SELECT * FROM MEMOS WHERE SUBMITTED IS NULL"

            Table = New DataTable
            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Builder = New FbCommandBuilder

            Builder.DataAdapter = Adapter
            Adapter.InsertCommand = Builder.GetInsertCommand
            Adapter.DeleteCommand = Builder.GetDeleteCommand
            Adapter.UpdateCommand = Builder.GetUpdateCommand

            Adapter.Fill(Table)

            intRecords = Table.Rows.Count

            If Table.Rows.Count = 0 Then Return True

            '-------------------------------------------
            '   Get Started
            '-------------------------------------------
            m_Op = "SAVING Memo..."
            m_Worker.ReportProgress(0)
            System.Threading.Thread.Sleep(100)

            For I = 0 To Table.Rows.Count - 1
                With Table.Rows(I)

                    intPos = I + 1
                    m_Op = "Record Number [ " & intPos & " ]..."

                    .Item("BUDGET") = Allocation
                    .Item("BYEAR") = Year
                    .Item("BMONTH") = Month
                    .Item("SUBMITTED") = 1
                End With

                Percentage = CInt((I / intRecords) * 100)
                m_Worker.ReportProgress(Percentage)

                System.Threading.Thread.Sleep(10)
            Next

            Try
                Adapter.Update(Table)
            Catch ex As Exception
                Throw ex
            End Try

            Return True
        End Function
#End Region
#Region "Processing"
        Public Sub ProcessPayment(ByVal Allocation As Integer, ByVal Year As Integer, ByVal Month As Integer)
            m_Op = "Started"

            m_Op = "Process Payment"
            m_Worker.ReportProgress(0)
            WritePayment(Allocation, Year, Month)
            m_Worker.ReportProgress(100)

            m_Op = "Process Oustanding Benefit"
            m_Worker.ReportProgress(0)
            WriteOutstandingBenefit(Allocation, Year, Month)
            m_Worker.ReportProgress(100)

            m_Op = "Process Memo"
            m_Worker.ReportProgress(0)
            WriteMemo(Allocation, Year, Month)
            m_Worker.ReportProgress(100)

            m_Op = "Finish"
            m_Worker.ReportProgress(0)
        End Sub
#End Region
    End Class
End Namespace