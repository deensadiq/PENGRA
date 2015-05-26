Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports FirebirdSql.Data.FirebirdClient
Namespace Classes

    Public Class FindUser

        Dim lv As ListView
        Dim bUsn As Boolean
        Dim iUserID As Long
        Dim iUserStatus As Char
        Dim iRecordCount As Integer
        Dim iUsername As String
        Dim iFullName As String
        Dim dTable As DataTable
        Dim dAdapter As FbDataAdapter
#Region "Property"
        ReadOnly Property RecordCount() As Integer
            Get
                Return iRecordCount
            End Get
        End Property
        ReadOnly Property UserID() As Long
            Get
                Return iUserID
            End Get
        End Property

        ReadOnly Property FullName() As String
            Get
                Return iFullName
            End Get
        End Property
        ReadOnly Property UserName() As String
            Get
                Return iUsername
            End Get
        End Property
        Property bUserName() As Boolean
            Get
                Return bUsn
            End Get
            Set(ByVal value As Boolean)
                bUsn = value
            End Set
        End Property

#End Region

#Region "Subs"


        Sub LoadRecord(ByVal lvStud As ListView)
            Dim SQL As String = "SELECT UKEY,USERNAME,NAME FROM USERS"
            dTable = New DataTable
            dAdapter = New FbDataAdapter(SQL, Env.ConStr)
            dAdapter.Fill(dTable)

            lv = lvStud
            LoadList("")
        End Sub

        Sub ListClick(ByVal K As Integer)
            If bUsn = True Then
                iUserID = CType(lv.Items(K).Tag, Long)
                iUsername = lv.Items(K).SubItems(1).Text
                iFullName = lv.Items(K).SubItems(2).Text.ToUpper

            Else
                iUserID = CType(lv.Items(K).Tag, Long)
                iUsername = lv.Items(K).SubItems(2).Text
                iFullName = lv.Items(K).SubItems(1).Text.ToUpper

            End If

        End Sub
        Public Sub LoadList(ByVal SEARCH As String)
            Dim it As ListViewItem
            Dim I As Integer
            Dim dr As DataRow()


            If bUsn = True Then
                If SEARCH.Trim <> "" Then
                    dr = dTable.Select("USERNAME LIKE '%" + SEARCH.Replace("'", "''") + "%'", "USERNAME")
                Else
                    dr = dTable.Select("UKEY > 0", "USERNAME")
                End If
            Else
                If SEARCH.Trim <> "" Then
                    dr = dTable.Select("NAME LIKE '%" + SEARCH.Replace("'", "''") + "%'", "NAME")
                Else
                    dr = dTable.Select("UKEY > 0", "NAME")
                End If
            End If

            InitList()

            iRecordCount = 0
            If dr.Length = 0 Then Exit Sub
            I = 0
            For Each r As DataRow In dr
                I = I + 1
                it = New ListViewItem
                If bUsn = True Then
                    it.Text = CType(I, String)
                    it.SubItems.Add(r("USERNAME").ToString)
                    it.SubItems.Add(r("NAME").ToString.ToUpper)
                    it.Tag = r("UKEY")
                Else
                    it.Text = CType(I, String)
                    it.SubItems.Add(r("NAME").ToString.ToUpper)
                    it.SubItems.Add(r("USERNAME").ToString)
                    it.Tag = r("UKEY")
                End If

                lv.Items.Add(it)
            Next
            If bUsn = True Then
                iUserID = CType(lv.Items(0).Tag, Long)
                iUsername = lv.Items(0).SubItems(1).Text
                iFullName = lv.Items(0).SubItems(2).Text

            Else
                iUserID = CType(lv.Items(0).Tag, Long)
                iUsername = lv.Items(0).SubItems(2).Text
                iFullName = lv.Items(0).SubItems(1).Text

            End If

            iRecordCount = lv.Items.Count
        End Sub

        Private Sub InitList()

            '// INITIALIZING THE GRID

            iUsername = ""
            iFullName = ""
            iUserID = 0
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

                If bUsn = True Then
                    .Columns.Add("Username.", 150, HorizontalAlignment.Left)
                    .Columns.Add("Full Name", 300, HorizontalAlignment.Left)

                Else
                    .Columns.Add("Full Name", 300, HorizontalAlignment.Left)
                    .Columns.Add("Username", 150, HorizontalAlignment.Left)
                End If

            End With


        End Sub
#End Region


    End Class

End Namespace