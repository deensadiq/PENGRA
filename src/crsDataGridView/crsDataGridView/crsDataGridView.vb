Public Class crsDataGridView
    Inherits DataGridView

    Public Sub New()
        Me.ColumnHeadersHeight = 35
        Me.RowHeadersVisible = False
        Me.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 250)
        Me.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.Window
        Me.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.AllowUserToOrderColumns = False
        Me.AllowUserToResizeColumns = False
        Me.AllowUserToAddRows = False

        Me.EnableHeadersVisualStyles = False
        Me.BorderStyle = BorderStyle.FixedSingle
        Me.DefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.CellBorderStyle = DataGridViewCellBorderStyle.Single
        Me.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoubleBuffered = True
        'Me.RowsDefaultCellStyle.SelectionBackColor = Color.Transparent
        'Me.RowsDefaultCellStyle.SelectionForeColor = Color.Transparent
    End Sub

End Class
