Imports System.Windows.Forms
Imports PENGRA.Connection.Classes
Imports FirebirdSql.Data.FirebirdClient

Namespace Classes

    Public Class Finder

        Dim lv As ListView
        Dim bNum As Boolean
        Private m_ID As Long
        Private m_RecordCount As Integer
        Private m_Num As String
        Private m_Name As String
        Private m_Group As String
        Private m_GroupUkey As Integer
        Private m_PaymentDay As String
        Private m_RegDate As Date
        Private m_Ward As String
        Private m_LGA As String
        Private m_ukey As Integer
        Private m_bolInitLvw As Boolean

        Public m_GroupID As Integer = 0

        'Private Conn As New FbConnection
        Private Reader As FbDataReader
        Private Command As New FbCommand


#Region "Properties"

        ReadOnly Property RecordCount() As Integer
            Get
                Return m_RecordCount
            End Get
        End Property

        ReadOnly Property ID() As Long
            Get
                Return m_ID
            End Get
        End Property

        ReadOnly Property FullName() As String
            Get
                Return m_Name & " (" & m_Num & ") "
            End Get
        End Property

        ReadOnly Property Name() As String
            Get
                Return m_Name
            End Get
        End Property

        ReadOnly Property Number() As String
            Get
                Return m_Num
            End Get
        End Property

        Property byNumber() As Boolean
            Get
                Return bNum
            End Get
            Set(ByVal value As Boolean)
                bNum = value
            End Set
        End Property

        Property Group() As String
            Get
                Return m_Group
            End Get
            Set(ByVal value As String)
                m_Group = value
            End Set
        End Property

        Property GroupUkey() As Integer
            Get
                Return m_GroupUkey
            End Get
            Set(ByVal value As Integer)
                m_GroupUkey = value
            End Set
        End Property

        Property PaymentDay() As String
            Get
                Return m_PaymentDay
            End Get
            Set(ByVal value As String)
                m_PaymentDay = value
            End Set
        End Property

        Property RegDate As Date
            Get
                Return m_RegDate
            End Get
            Set(ByVal value As Date)
                m_RegDate = value
            End Set
        End Property

        Property Ward() As String
            Get
                Return m_Ward
            End Get
            Set(ByVal value As String)
                m_Ward = value
            End Set
        End Property

        Property LGA() As String
            Get
                Return m_LGA
            End Get
            Set(ByVal value As String)
                m_LGA = value
            End Set
        End Property

        Property InitLvw() As Boolean
            Get
                Return m_bolInitLvw
            End Get
            Set(ByVal value As Boolean)
                m_bolInitLvw = value
            End Set
        End Property


#End Region

#Region "Methods"

        Sub LoadRecord(ByVal lvStud As ListView)
            lv = lvStud
            LoadList()
        End Sub

        Sub LoadRecord(ByVal lvStud As ListView, ByVal Code As String)
            lv = lvStud
            LoadList(Code)
        End Sub

        Sub TextChang(ByVal txt As String)
            Dim It As ListViewItem
            Try
                It = lv.FindItemWithText(txt, True, 0)

                If Not (It Is Nothing) Then

                    It.EnsureVisible()

                    It.Selected = True

                    If bNum = True Then
                        m_ID = Convert.ToInt32(It.Tag)
                        m_Num = It.SubItems(1).Text.ToUpper
                        m_Name = It.SubItems(2).Text.ToUpper.Replace("''", "'")
                        m_Group = It.SubItems(4).Text.ToUpper.Replace("''", "'")
                        m_RegDate = It.SubItems(3).Text
                        m_PaymentDay = It.SubItems(5).Text
                        m_GroupUkey = It.SubItems(6).Text
                    Else
                        m_ID = Convert.ToInt32(It.Tag)
                        m_Num = It.SubItems(2).Text.ToUpper
                        m_Name = It.SubItems(1).Text.ToUpper.Replace("''", "'")
                        m_Group = It.SubItems(4).Text.ToUpper.Replace("''", "'")
                        m_RegDate = It.SubItems(3).Text
                        m_PaymentDay = It.SubItems(5).Text
                        m_GroupUkey = It.SubItems(6).Text
                    End If

                End If
            Catch ex As Exception

            End Try


        End Sub
        Sub ListClick(ByVal K As Integer)

            If bNum = True Then
                m_ID = CType(lv.Items(K).Tag, Long)
                m_Num = lv.Items(K).SubItems(1).Text.ToUpper
                m_Name = lv.Items(K).SubItems(2).Text.ToUpper.Replace("''", "'")
                m_RegDate = lv.Items(K).SubItems(3).Text
                m_Group = lv.Items(K).SubItems(4).Text.ToUpper.Replace("''", "'")
                m_PaymentDay = lv.Items(K).SubItems(5).Text.ToUpper
                m_Group = lv.Items(K).SubItems(6).Text
            Else
                m_ID = CType(lv.Items(K).Tag, Long)
                m_Num = lv.Items(K).SubItems(2).Text.ToUpper
                m_Name = lv.Items(K).SubItems(1).Text.ToUpper.Replace("''", "'")
                m_RegDate = lv.Items(K).SubItems(3).Text
                m_Group = lv.Items(K).SubItems(4).Text.ToUpper.Replace("''", "'")
                m_PaymentDay = lv.Items(K).SubItems(5).Text.ToUpper
                m_GroupUkey = lv.Items(K).SubItems(6).Text
            End If
        End Sub

        Private Sub LoadList()


            Dim It As ListViewItem
            Dim I As Integer
            Dim strSql As String = ""
            'Dim dConn As New FbConnection
            Dim dCmd As New FbCommand
            Dim r As FbDataReader

            InitList()

            strSql = createSQL()

            dCmd.Connection = DB.ConnObj
            dCmd.CommandType = CommandType.Text
            dCmd.CommandText = strSql
            r = dCmd.ExecuteReader()

            If r.HasRows = False Then Exit Sub
            I = 0

            Try
                While r.Read = True
                    It = New ListViewItem
                    If bNum = True Then
                        It.Text = CType(I + 1, String)
                        If IsDBNull(r("ID")) Then It.SubItems.Add("-") Else It.SubItems.Add(r("ID"))
                        It.SubItems.Add(r("FULL_NAME").ToUpper)
                        It.SubItems.Add(r("adate"))
                        If IsDBNull(r("groupname")) Then It.SubItems.Add("-") Else It.SubItems.Add(r("groupname"))
                        If IsDBNull(r("payment_day")) Then It.SubItems.Add("-") Else It.SubItems.Add(r("payment_day"))
                        If IsDBNull(r("groupid")) Then It.SubItems.Add("0") Else It.SubItems.Add(r("groupid"))
                        It.Tag = r("UKEY")
                    Else
                        It.Text = CType(I + 1, String)
                        It.SubItems.Add(r("FULL_NAME").ToUpper)
                        It.SubItems.Add(r("ID"))
                        It.SubItems.Add(r("adate"))
                        If IsDBNull(r("groupname")) Then It.SubItems.Add("-") Else It.SubItems.Add(r("groupname"))
                        If IsDBNull(r("payment_day")) Then It.SubItems.Add("-") Else It.SubItems.Add(r("payment_day"))
                        If IsDBNull(r("groupid")) Then It.SubItems.Add("0") Else It.SubItems.Add(r("groupid"))
                        It.Tag = r("UKEY")
                    End If

                    lv.Items.Add(It)
                    I += 1
                End While
                r.Close()
                m_RecordCount = I
            Catch ex As Exception
                Throw ex
            End Try

            'dConn.Close()

            m_bolInitLvw = True

        End Sub
        Private Sub LoadList(ByVal Code As String)

            Dim It As ListViewItem
            Dim I As Integer
            Dim strSql As String
            'Dim dConn As New FbConnection
            Dim dCmd As New FbCommand
            Dim r As FbDataReader

            InitList()

            strSql = createSQLWithCode(Code)

            dCmd.Connection = DB.ConnObj
            dCmd.CommandType = CommandType.Text
            dCmd.CommandText = strSql
            r = dCmd.ExecuteReader()

            If r.HasRows = False Then Exit Sub
            I = 0
            While r.Read = True
                It = New ListViewItem
                If bNum = True Then
                    It.Text = CType(I + 1, String)
                    If IsDBNull(r("ID")) Then It.SubItems.Add("-") Else It.SubItems.Add(r("ID"))
                    It.SubItems.Add(r("FULL_NAME").ToUpper)
                    It.SubItems.Add(r("adate"))
                    If IsDBNull(r("groupname")) Then It.SubItems.Add("-") Else It.SubItems.Add(r("groupname"))
                    If IsDBNull(r("payment_day")) Then It.SubItems.Add("-") Else It.SubItems.Add(r("payment_day"))
                    If IsDBNull(r("groupid")) Then It.SubItems.Add("0") Else It.SubItems.Add(r("groupid"))
                    It.Tag = r("UKEY")
                Else
                    It.Text = CType(I + 1, String)
                    It.SubItems.Add(r("FULL_NAME").ToUpper)
                    It.SubItems.Add(r("ID"))
                    It.SubItems.Add(r("adate"))
                    If IsDBNull(r("groupname")) Then It.SubItems.Add("-") Else It.SubItems.Add(r("groupname"))
                    If IsDBNull(r("payment_day")) Then It.SubItems.Add("-") Else It.SubItems.Add(r("payment_day"))
                    If IsDBNull(r("groupid")) Then It.SubItems.Add("0") Else It.SubItems.Add(r("groupid"))
                    It.Tag = r("UKEY")
                End If

                lv.Items.Add(It)
                I += 1
            End While
            r.Close()
            m_RecordCount = I
            'dConn.Close()

            m_bolInitLvw = True

        End Sub

        Private Function createSQL() As String
            Dim strSQL As String = ""

            If m_GroupID = 0 Then
                If bNum = True Then
                    strSQL = "SELECT FIRST 200 UKEY, ID, groupname, adate, coalesce(firstname, '') || ' ' || coalesce(othernames, '') || ' ' || coalesce(surname, '')  as FULL_NAME, payment_day, groupid FROM TBL_CLIENTINFO order by ID"
                Else
                    strSQL = "SELECT FIRST 200 UKEY, ID, groupname, adate, coalesce(firstname, '') || ' ' || coalesce(othernames, '') || ' ' || coalesce(surname, '')  as FULL_NAME, payment_day, groupid FROM TBL_CLIENTINFO order by surname, othernames"
                End If
            Else

                If bNum = True Then
                    strSQL = "SELECT FIRST 200 UKEY, ID, groupname, adate, coalesce(firstname, '') || ' ' || coalesce(othernames, '') || ' ' || coalesce(surname, '')  as FULL_NAME, payment_day, groupid FROM TBL_CLIENTINFO WHERE groupid = '" & m_GroupID & "' order by ID"
                Else
                    strSQL = "SELECT FIRST 200 UKEY, ID, groupname, adate, coalesce(firstname, '') || ' ' || coalesce(othernames, '') || ' ' || coalesce(surname, '')  as FULL_NAME, payment_day, groupid FROM TBL_CLIENTINFO WHERE groupid = '" & m_GroupID & "' order by surname, othernames"
                End If

            End If



            Return strSQL
        End Function

        Private Function createSQLWithCode(ByVal Code As String) As String
            Dim strSQL As String = ""

            If m_GroupID = 0 Then
                If bNum = True Then
                    strSQL = "SELECT UKEY, ID, groupname, adate, coalesce(firstname, '') || ' ' || coalesce(othernames, '') || ' ' || coalesce(surname, '')  as FULL_NAME, payment_day, groupid FROM TBL_CLIENTINFO WHERE lower(trim(ID)) like '%" & Code.ToLower.Trim.Replace("'", "''") & "%' order by ID"
                Else
                    strSQL = "SELECT UKEY, ID, groupname, adate, coalesce(firstname, '') || ' ' || coalesce(othernames, '') || ' ' || coalesce(surname, '')  as FULL_NAME, payment_day, groupid FROM TBL_CLIENTINFO WHERE (lower(coalesce(firstname, '')) || ' ' || lower(coalesce(surname, '')) || ' ' || lower(coalesce(othernames, '')) like '%" & Code.ToLower.Trim.Replace("'", "''") & "%') order by firstname, surname, othernames"
                End If
            Else
                If bNum = True Then
                    strSQL = "SELECT UKEY, ID, groupname, adate, coalesce(firstname, '') || ' ' || coalesce(othernames, '') || ' ' || coalesce(surname, '')  as FULL_NAME, payment_day, groupid FROM TBL_CLIENTINFO WHERE groupid = '" & m_GroupID & "' and lower(trim(ID)) like '%" & Code.ToLower.Trim.Replace("'", "''") & "%' order by ID"
                Else
                    strSQL = "SELECT UKEY, ID, groupname, adate, coalesce(firstname, '') || ' ' || coalesce(othernames, '') || ' ' || coalesce(surname, '')  as FULL_NAME, payment_day, groupid FROM TBL_CLIENTINFO WHERE groupid = '" & m_GroupID & "' and (lower(coalesce(firstname, '')) || ' ' || lower(coalesce(surname, '')) || ' ' || lower(coalesce(othernames, '')) like '%" & Code.ToLower.Trim.Replace("'", "''") & "%') order by firstname, surname, othernames"
                End If
            End If

            Return strSQL
        End Function
        Private Sub InitList()

            '// INITIALIZING THE GRID

            m_Num = ""
            m_Name = ""
            m_ID = 0
            m_RecordCount = 0

            With lv
                .GridLines = True
                .View = View.Details
                .HideSelection = False
                .MultiSelect = False
                .FullRowSelect = True
                .Columns.Clear()
                .Items.Clear()
                .Columns.Add("S/N", 45, HorizontalAlignment.Right)

                If bNum = True Then
                    .Columns.Add("Number", 135, HorizontalAlignment.Left)
                    .Columns.Add("Name", 260, HorizontalAlignment.Left)

                Else
                    .Columns.Add("Name", 230, HorizontalAlignment.Left)
                    .Columns.Add("Number", 150, HorizontalAlignment.Left)

                End If

            End With

        End Sub

#End Region


    End Class

End Namespace