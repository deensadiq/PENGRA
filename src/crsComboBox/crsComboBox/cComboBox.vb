Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms.ComboBox

Public Class cComboBox
    Inherits System.Windows.Forms.UserControl

    Dim mZom As Boolean
    Dim mTyping As Boolean

    Event Zoom()
    Event DropDownClosed()
    Event SelectedIndexChanged()
    Event SelectedValueChanged()
    Event SelectionChangeCommitted()
    Event Typing()

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        DoubleBuffered = True

    End Sub

    Property IsZoom() As Boolean

        Get
            Return mZom
        End Get
        Set(ByVal value As Boolean)
            mZom = value
            btn.Image = My.Resources.add_combo
            ResizeControls()
        End Set
    End Property
    Property IsTyping() As Boolean

        Get
            Return mTyping
        End Get
        Set(ByVal value As Boolean)
            mTyping = value
        End Set
    End Property
    Public Property DropDownStyle() As ComboBoxStyle
        Get
            DropDownStyle = cbo.DropDownStyle
        End Get
        Set(ByVal value As ComboBoxStyle)
            cbo.DropDownStyle = value

        End Set
    End Property
    Public ReadOnly Property Items() As System.Windows.Forms.ComboBox.ObjectCollection
        Get
            Items = cbo.Items
        End Get
    End Property
    Public ReadOnly Property ItemName() As String
        Get
            ItemName = cbo.SelectedItem.ToString
        End Get
    End Property
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        ResizeControls()
        
        Try : BackColor = Color.FromArgb(246, 248, 252) : Catch : End Try
        G.Clear(Color.FromArgb(246, 248, 252))
        G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, 0), New Point(0, Width - 2))    'comment out to get rid of the borders
        G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, 0), New Point(Width - 2, 0))    'comment out to get rid of the borders
        G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, Height - 1), New Point(Width, Height - 3))    'comment out to get rid of the borders
        G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(Width - 1, 0), New Point(Width - 3, Height))    'comment out to get rid of the borders

        e.Graphics.DrawImage(B.Clone, 0, 0)
        G.Dispose() : B.Dispose()
    End Sub
    Public Overrides Property Text() As String
        Get
            Text = cbo.Text
        End Get
        Set(ByVal value As String)
            cbo.Text = value
        End Set
    End Property
    Public Property SelectedIndex() As Integer
        Get
            SelectedIndex = cbo.SelectedIndex
        End Get
        Set(ByVal value As Integer)
            cbo.SelectedIndex = value
        End Set
    End Property

    Public Property SelectedItem() As Object
        Get
            SelectedItem = cbo.SelectedIndex
        End Get
        Set(ByVal value As Object)
            cbo.SelectedItem = value
        End Set
    End Property
    Public Property SelectedText() As String
        Get
            SelectedText = cbo.SelectedText
        End Get
        Set(ByVal value As String)
            cbo.SelectedText = value
        End Set
    End Property

    Public Property SelectedValue() As Object
        Get
            SelectedValue = cbo.SelectedValue
        End Get
        Set(ByVal value As Object)
            cbo.SelectedValue = value
        End Set
    End Property

    Public Property ValueMember() As String
        Get
            ValueMember = cbo.ValueMember
        End Get
        Set(ByVal value As String)
            cbo.ValueMember = value
        End Set
    End Property

    Public Property DataSource() As Object
        Get
            DataSource = cbo.DataSource
        End Get
        Set(ByVal value As Object)
            cbo.DataSource = value
        End Set
    End Property
    Public Property DisplayMember() As String
        Get
            DisplayMember = cbo.DisplayMember
        End Get
        Set(ByVal value As String)
            cbo.DisplayMember = value
        End Set
    End Property

    Private Sub ResizeControls()
        If mZom = True Then
            btn.Visible = True
            cbo.Size = New System.Drawing.Size(MyBase.Width - 36, cbo.Height)
        Else
            btn.Visible = False
            cbo.Size = New System.Drawing.Size(MyBase.Width - 10, cbo.Height)
        End If

    End Sub
    Private Sub cComboBox_Zoom(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        If mZom = False Then Exit Sub
        RaiseEvent Zoom()

    End Sub

    Private Sub cComboBox_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo.DropDownClosed
        RaiseEvent DropDownClosed()

    End Sub

    Private Sub cComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo.SelectedIndexChanged
        RaiseEvent SelectedIndexChanged()

    End Sub

    Private Sub cComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo.SelectedValueChanged
        RaiseEvent SelectedValueChanged()

    End Sub
    Private Sub cComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo.SelectionChangeCommitted
        RaiseEvent SelectionChangeCommitted()

    End Sub
    Private Sub re(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If btn.Visible = True Then
            MyBase.Size = New System.Drawing.Size(cbo.Width + 36, cbo.Height)
        Else
            MyBase.Size = New System.Drawing.Size(cbo.Width + 10, cbo.Height)
        End If
    End Sub
    Private Sub cButton_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseEnter, MyBase.Enter
        btn.Image = My.Resources.add_combo_o
    End Sub
    Private Sub cButton_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseLeave, MyBase.Leave
        btn.Image = My.Resources.add_combo
    End Sub
    Private Sub cButton_Press(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        btn.Image = My.Resources.add_combo
    End Sub
    Private Sub cButton_Release(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        btn.Image = My.Resources.add_combo_o
    End Sub


    Private Sub cbo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo.KeyUp

        If mTyping = False Then Return

        If e.KeyCode = Keys.Tab Then Return

        If Not (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Back Or _
                e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or _
                e.KeyCode = Keys.Enter Or e.KeyCode = Keys.End) Then
            tm.Enabled = True
        End If


    End Sub


    Private Sub tm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm.Tick
        tm.Enabled = False
        RaiseEvent Typing()

        cbo.DroppedDown = True
        cbo.SelectionStart = 100
    End Sub
End Class
