Module modReport

    Public enc As New System.Text.UTF8Encoding()

    Public Sub GetYear(ByVal cbo As ComboBox)
        Dim I As Integer
        cbo.Items.Clear()
        cbo.Items.Add("")
        For I = 2013 To Now.Year
            cbo.Items.Add(I.ToString)
        Next
        cbo.Text = cbo.Items(0)

    End Sub

    Public Sub GetMonth(ByVal cbo As ComboBox)

        cbo.Items.Clear()
        cbo.Items.Add("")
        cbo.Items.Add("JANUARY")
        cbo.Items.Add("FEBRUARY")
        cbo.Items.Add("MARCH")
        cbo.Items.Add("APRIL")
        cbo.Items.Add("MAY")
        cbo.Items.Add("JUNE")
        cbo.Items.Add("JULY")
        cbo.Items.Add("AUGUST")
        cbo.Items.Add("SEPTEMBER")
        cbo.Items.Add("OCTOBER")
        cbo.Items.Add("NOVEMBER")
        cbo.Items.Add("DECEMBER")
        cbo.Text = cbo.Items(0)
    End Sub
End Module
