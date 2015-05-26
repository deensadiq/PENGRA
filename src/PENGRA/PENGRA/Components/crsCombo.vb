Imports System.Drawing.Drawing2D

Public Class crsCombo
    Inherits ComboBox

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        DoubleBuffered = True
        DropDownStyle = ComboBoxStyle.Simple
    End Sub

    Function ToPen(ByVal color As Color) As Pen
        Return New Pen(color)
    End Function

    Function ToBrush(ByVal color As Color) As Brush
        Return New SolidBrush(color)
    End Function

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Try : BackColor = Color.FromArgb(246, 248, 252) : Catch : End Try
        G.Clear(Color.FromArgb(246, 248, 252))
        G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, 0), New Point(0, Width))    'comment out to get rid of the borders
        G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, 0), New Point(Width, 0))    'comment out to get rid of the borders
        G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, Height - 1), New Point(Width, Height - 1))    'comment out to get rid of the borders
        G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(Width - 1, 0), New Point(Width - 1, Height))    'comment out to get rid of the borders

        e.Graphics.DrawImage(B.Clone, 0, 0)
        G.Dispose() : B.Dispose()
    End Sub

End Class
