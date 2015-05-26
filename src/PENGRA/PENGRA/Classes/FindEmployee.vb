Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports FirebirdSql.Data.FirebirdClient

Namespace Classes

    Public Class FindEmployee

        Dim lv As ListView
        Dim bID As Boolean
        Dim iEmployeeID As Long
        Dim iRecordCount As Integer
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
        Property bIDNumber() As Boolean
            Get
                Return bID
            End Get
            Set(ByVal value As Boolean)
                bID = value
            End Set
        End Property

#End Region

#Region "Subs"


        Sub LoadRecord(ByVal lvStud As ListView)
            Dim SQL As String = "SELECT UKEY,IDNO,FULLNAME FROM EMPLOYEEINFO"
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