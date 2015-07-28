Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports FirebirdSql.Data.FirebirdClient

Namespace Classes

    Public Class FindEmployee

        Dim lv As ListView
        Dim bID As Boolean
        Dim bAL As Boolean
        Dim bBT As Boolean
        Dim iEmployeeID As Long
        Dim iRecordCount As Integer
        Dim iBenefit As Integer
        Dim iLimit As String
        Dim iIDNumber As String
        Dim iEmployeeName As String
        Dim dTable As DataTable
        Dim dAdapter As FbDataAdapter

#Region "Property"
        ReadOnly Property RecordCount() As Integer
            Get
                Return iRecordCount
            End Get
        End Property
        ReadOnly Property EmployeeID() As Long
            Get
                Return iEmployeeID
            End Get
        End Property
        ReadOnly Property FullName() As String
            Get
                If EmployeeName <> "" And IDNumber <> "" Then
                    Return EmployeeName & " (" & IDNumber & ") "
                Else
                    Return ""
                End If

            End Get
        End Property
        ReadOnly Property EmployeeName() As String
            Get
                Return iEmployeeName
            End Get
        End Property
        ReadOnly Property IDNumber() As String
            Get
                Return iIDNumber
            End Get
        End Property
        Property Benefit() As Integer
            Get
                Return iBenefit
            End Get
            Set(ByVal value As Integer)
                iBenefit = value
            End Set
        End Property
        Property Limit() As String
            Get
                Return iLimit
            End Get
            Set(ByVal value As String)
                iLimit = value
            End Set
        End Property
        Property bIDNumber() As Boolean
            Get
                Return bID
            End Get
            Set(ByVal value As Boolean)
                bID = value
            End Set
        End Property
        Property bAboveLimit() As Boolean
            Get
                Return bAL
            End Get
            Set(ByVal value As Boolean)
                bAL = value
            End Set
        End Property
        Property bBenefit() As Boolean
            Get
                Return bBT
            End Get
            Set(ByVal value As Boolean)
                bBT = value
            End Set
        End Property

#End Region

#Region "Subs"


        Sub LoadRecord(ByVal lvStud As ListView)
            Dim SQL As String

            If bAL = True And bBT = False Then
                SQL = "SELECT UKEY,IDNO,FULLNAME FROM EMPLOYEEINFO WHERE LIMIT = '" & iLimit & "'"
            ElseIf bAL = False And bBT = True Then
                SQL = "SELECT UKEY,IDNO,FULLNAME FROM EMPLOYEEINFO WHERE BENEFITTYPE = '" & iBenefit & "'"
            ElseIf bAL = True And bBT = True Then
                SQL = "SELECT UKEY,IDNO,FULLNAME FROM EMPLOYEEINFO WHERE LIMIT = '" & iLimit & "' AND BENEFITTYPE = '" & iBenefit & "'"
            Else
                SQL = "SELECT UKEY,IDNO,FULLNAME FROM EMPLOYEEINFO"
            End If

            dTable = New DataTable
            dAdapter = New FbDataAdapter(SQL, Env.ConStr)
            dAdapter.Fill(dTable)


            lv = lvStud
            LoadList("")

        End Sub

        Sub ListClick(ByVal K As Integer)
            If bID = True Then
                iEmployeeID = CType(lv.Items(K).Tag, Long)
                iIDNumber = lv.Items(K).SubItems(1).Text.ToUpper
                iEmployeeName = lv.Items(K).SubItems(2).Text.ToUpper

            Else
                iEmployeeID = CType(lv.Items(K).Tag, Long)
                iIDNumber = lv.Items(K).SubItems(2).Text.ToUpper
                iEmployeeName = lv.Items(K).SubItems(1).Text.ToUpper

            End If

        End Sub
        Public Sub LoadList(ByVal SEARCH As String)
            Dim it As ListViewItem
            Dim I As Integer
            Dim dr As DataRow()


            If bID = True Then
                If SEARCH.Trim <> "" Then
                    dr = dTable.Select("IDNO LIKE '%" + SEARCH.Replace("'", "''") + "%'", "IDNO")
                Else
                    dr = dTable.Select("UKEY > 0", "IDNO")
                End If
            Else
                If SEARCH.Trim <> "" Then
                    dr = dTable.Select("FULLNAME  LIKE '%" + SEARCH.Replace("'", "''") + "%'", "FULLNAME")
                Else
                    dr = dTable.Select("UKEY > 0", "FULLNAME")
                End If
            End If

            InitList()

            iRecordCount = 0
            If dr.Length = 0 Then Exit Sub
            I = 0
            For Each r As DataRow In dr
                I = I + 1
                it = New ListViewItem
                If bID = True Then
                    it.Text = CType(I, String)
                    it.SubItems.Add(r("IDNO").ToString.ToUpper)
                    it.SubItems.Add(r("FULLNAME").ToString.ToUpper)
                    it.Tag = r("UKEY")
                Else
                    it.Text = CType(I, String)
                    it.SubItems.Add(r("FULLNAME").ToString.ToUpper)
                    it.SubItems.Add(r("IDNO").ToString.ToUpper)
                    it.Tag = r("UKEY")
                End If

                lv.Items.Add(it)
            Next
            If bID = True Then
                iEmployeeID = CType(lv.Items(0).Tag, Long)
                iIDNumber = lv.Items(0).SubItems(1).Text
                iEmployeeName = lv.Items(0).SubItems(2).Text

            Else
                iEmployeeID = CType(lv.Items(0).Tag, Long)
                iIDNumber = lv.Items(0).SubItems(2).Text
                iEmployeeName = lv.Items(0).SubItems(1).Text

            End If

            iRecordCount = lv.Items.Count
        End Sub

        Private Sub InitList()

            '// INITIALIZING THE GRID

            iIDNumber = ""
            iEmployeeName = ""
            iEmployeeID = 0
            iRecordCount = 0

            With lv
                .GridLines = True
                .View = View.Details
                .HideSelection = False
                .MultiSelect = False
                .FullRowSelect = True
                .Columns.Clear()
                .Items.Clear()
                .Columns.Add("S/N", 50, HorizontalAlignment.Right)

                If bID = True Then
                    .Columns.Add("Pension/ID No.", 150, HorizontalAlignment.Left)
                    .Columns.Add("Full Name", 300, HorizontalAlignment.Left)

                Else
                    .Columns.Add("Full Name", 300, HorizontalAlignment.Left)
                    .Columns.Add("Pension/ID No.", 150, HorizontalAlignment.Left)
                End If

            End With


        End Sub
#End Region


    End Class

End Namespace