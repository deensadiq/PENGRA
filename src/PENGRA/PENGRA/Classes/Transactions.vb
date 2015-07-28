Imports PENGRA.Connection.Classes
Imports FirebirdSql.Data.FirebirdClient

Namespace Classes
    Public Class Transactions
        Public Shared Function GetValueName(ByVal iTable As String, ByVal iValue As Integer) As String
            Dim da As FbDataAdapter
            Dim tbl As New DataTable
            Dim str As String
            GetValueName = ""

            str = "SELECT * FROM " & iTable & " WHERE UKEY = '" & iValue & "'"

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then GetValueName = tbl.Rows(0).Item("NAME")

            Return GetValueName
        End Function
        Public Shared Function GetBudgetBalance(ByVal iBudget As Integer, ByVal iYear As Integer, ByVal iMonth As Integer) As Double
            Dim budgetAmount As Double
            Dim budgetUse As Double
            Dim str As String
            Dim da As FbDataAdapter
            Dim tbl As DataTable

            GetBudgetBalance = 0
            budgetAmount = 0
            budgetUse = 0

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            str = "SELECT * FROM BUDGETING a WHERE a.BUDGET = '" & iBudget & "' AND a.BYEAR = '" & iYear & "' AND a.BMONTH = '" & iMonth & "'"

            tbl = New DataTable
            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 And IsDBNull(tbl.Rows(0).Item("AMOUNT")) = False Then budgetAmount = tbl.Rows(0).Item("AMOUNT")


            str = "SELECT SUM(a.DEBIT) FROM TRANSACTIONS a WHERE a.BUDGET = '" & iBudget & "' AND a.BYEAR = '" & iYear & "' AND a.BMONTH = '" & iMonth & "'"
            tbl = New DataTable
            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 And IsDBNull(tbl.Rows(0).Item("SUM")) = False Then budgetUse = tbl.Rows(0).Item("SUM")

            'Calculate the Budget Balance
            GetBudgetBalance = budgetAmount - budgetUse

            Return GetBudgetBalance
        End Function
        Public Shared Function IsPaymentMade(ByVal iBudget As Integer, ByVal iYear As Integer, ByVal iMonth As Integer) As Boolean
            Dim strSQL As String
            Dim Table As New DataTable
            Dim Adapter As FbDataAdapter


            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            strSQL = "SELECT * FROM PAYMENTDETAILS a WHERE a.BUDGET = '" & iBudget & "' AND a.BYEAR = '" & iYear & "' AND a.BMONTH = '" & iMonth & "'"

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Adapter.Fill(Table)

            If Table.Rows.Count = 0 Then Return False

            Return True
        End Function
        Public Shared Function IsAllPaymentApproved(ByVal iBudget As Integer, ByVal iYear As Integer, ByVal iMonth As Integer) As Boolean
            Dim strSQL As String
            Dim Table As New DataTable
            Dim Adapter As FbDataAdapter


            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            strSQL = "SELECT * FROM TRANSACTIONS a WHERE a.BUDGET = '" & iBudget & "' AND a.BYEAR = '" & iYear & "' AND a.BMONTH = '" & iMonth & "' AND a.STATUS <> '2'"

            Adapter = New FbDataAdapter(strSQL, DB.ConnObj)
            Adapter.Fill(Table)

            If Table.Rows.Count > 0 Then Return False

            Return True
        End Function
        Public Shared Function GetTransactionNo(ByVal Benefit As String) As String
            Dim str As String
            Dim tbl As DataTable
            Dim da As FbDataAdapter

            GetTransactionNo = ""

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            str = "SELECT a.CODE FROM BENEFITTYPE a WHERE a.UKEY = '" & Benefit & "'"


            da = New FbDataAdapter(str, DB.ConnObj)
            tbl = New DataTable
            da.Fill(tbl)

            If tbl.Rows.Count = 0 Then Return GetTransactionNo

            GetTransactionNo = tbl.Rows(0).Item("CODE")

            str = "SELECT GEN_ID(GEN_TRANSACTION, 1) from RDB$DATABASE"

            tbl = New DataTable
            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            GetTransactionNo = GetTransactionNo + "/" + Format(tbl.Rows(0).Item("GEN_ID"), "000000")

            Return GetTransactionNo
        End Function
    End Class
End Namespace