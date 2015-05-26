Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

<DefaultProperty("ButtonType")> _
Public Class cButton

    Enum btnType
        none
        accept
        add
        add_combo
        allowances
        aquire
        automate_settings
        backup
        batch
        cancel
        capture_photo
        close
        close2
        committee
        contact
        contributions
        courses
        deductions
        edit
        export
        find
        first
        flip
        import
        individual
        last
        loans
        login
        new_
        next_
        ok
        photo
        prev
        print
        print_preview
        qualification
        redo
        remove
        report
        restore
        save
        search
        startprocessing
        stopprocessing
        test_connection
        undo
        view
        zoom

    End Enum

    Dim mbtnType As btnType

    'Protected Overrides Sub OnPaint(ByVal pevent As System.Windows.Forms.PaintEventArgs)
    '    MyBase.OnPaint(pevent)
    '    Dim B As New Bitmap(Width, Height)
    '    Dim G As Graphics = Graphics.FromImage(B)

    '    'Try : BackColor = Color.FromArgb(246, 248, 252) : Catch : End Try
    '    'G.Clear(Color.FromArgb(246, 248, 252))
    '    'G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, 0), New Point(0, Width))    'comment out to get rid of the borders
    '    'G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, 0), New Point(Width, 0))    'comment out to get rid of the borders
    '    'G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, Height - 1), New Point(Width, Height - 1))    'comment out to get rid of the borders
    '    'G.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(Width - 1, 0), New Point(Width - 1, Height))    'comment out to get rid of the borders

    '    pevent.Graphics.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, 0), New Point(0, Width))
    '    pevent.Graphics.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, 0), New Point(Width, 0))
    '    pevent.Graphics.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(0, Height - 1), New Point(Width, Height - 1))
    '    pevent.Graphics.DrawLine(New Pen(Color.FromArgb(200, 200, 250)), New Point(Width - 1, 0), New Point(Width - 1, Height))
    '    G.Dispose() : B.Dispose()
    'End Sub

    Private Sub DefaultProperty()

        If Not MyBase.Image Is Nothing Then MyBase.Size = New System.Drawing.Size(MyBase.Image.Width, MyBase.Image.Height)
        MyBase.BackColor = Color.Transparent
        MyBase.FlatAppearance.MouseDownBackColor = Color.Transparent
        MyBase.FlatAppearance.MouseOverBackColor = Color.Transparent
        MyBase.FlatAppearance.BorderSize = 0
        MyBase.FlatStyle = Windows.Forms.FlatStyle.Flat
        MyBase.ImageAlign = ContentAlignment.MiddleCenter

    End Sub
    <Description("Specify Image to Display on the Button"), Category("Opal")> _
    Property ButtonType() As btnType
        Get
            ButtonType = mbtnType
        End Get
        Set(ByVal value As btnType)
            mbtnType = value
            GetImageNormal(Me, mbtnType)
            DefaultProperty()
        End Set
    End Property
    Private Sub GetImageNormal(ByVal btn As Button, ByVal ntype As btnType)
        'btn.BackColor = Color.Transparent
        Select Case ntype
            Case btnType.accept
                btn.Image = My.Resources.accept
            Case btnType.add
                btn.Image = My.Resources.add
            Case btnType.add_combo
                btn.Image = My.Resources.add_combo
            Case btnType.allowances
                btn.Image = My.Resources.allowances
            Case btnType.aquire
                btn.Image = My.Resources.aquire
            Case btnType.automate_settings
                btn.Image = My.Resources.Automate_settings
            Case btnType.backup
                btn.Image = My.Resources.backup
            Case btnType.batch
                btn.Image = My.Resources.batch
            Case btnType.cancel
                btn.Image = My.Resources.cancel
            Case btnType.capture_photo
                btn.Image = My.Resources.capture_photo
            Case btnType.close
                btn.Image = My.Resources.close
            Case btnType.close2
                btn.Image = My.Resources.close2
            Case btnType.committee
                btn.Image = My.Resources.committee
            Case btnType.contact
                btn.Image = My.Resources.contact
            Case btnType.contributions
                btn.Image = My.Resources.contributions
            Case btnType.courses
                btn.Image = My.Resources.courses
            Case btnType.deductions
                btn.Image = My.Resources.deductions
            Case btnType.edit
                btn.Image = My.Resources.edit
            Case btnType.export
                btn.Image = My.Resources.export
            Case btnType.find
                btn.Image = My.Resources.find
            Case btnType.first
                btn.Image = My.Resources.first
            Case btnType.flip
                btn.Image = My.Resources.flip
            Case btnType.import
                btn.Image = My.Resources.import
            Case btnType.individual
                btn.Image = My.Resources.individual
            Case btnType.last
                btn.Image = My.Resources.last
            Case btnType.loans
                btn.Image = My.Resources.loans
            Case btnType.new_
                btn.Image = My.Resources._New
            Case btnType.next_
                btn.Image = My.Resources._next
            Case btnType.ok
                btn.Image = My.Resources.ok
            Case btnType.photo
                btn.Image = My.Resources.photo
            Case btnType.prev
                btn.Image = My.Resources.prev
            Case btnType.print
                btn.Image = My.Resources.print
            Case btnType.print_preview
                btn.Image = My.Resources.print_preview
            Case btnType.qualification
                btn.Image = My.Resources.qualification
            Case btnType.redo
                btn.Image = My.Resources.redo
            Case btnType.remove
                btn.Image = My.Resources.remove
            Case btnType.report
                btn.Image = My.Resources.report
            Case btnType.restore
                btn.Image = My.Resources.restore
            Case btnType.save
                btn.Image = My.Resources.save
            Case btnType.search
                btn.Image = My.Resources.search
            Case btnType.startprocessing
                btn.Image = My.Resources.startprocessing
            Case btnType.stopprocessing
                btn.Image = My.Resources.stopprocessing
            Case btnType.test_connection
                btn.Image = My.Resources.test_connection
            Case btnType.undo
                btn.Image = My.Resources.undo
            Case btnType.view
                btn.Image = My.Resources.view
            Case btnType.zoom
                btn.Image = My.Resources.zoom
            Case btnType.login
                btn.Image = My.Resources.login
            Case btnType.none
                btn.Image = Nothing
        End Select
        If ntype <> btnType.none Then btn.Text = ""

    End Sub
    Private Sub GetImageOver(ByVal btn As Button, ByVal ntype As btnType)
        'btn.BackColor = Color.Transparent
        Select Case ntype
            Case btnType.accept
                btn.Image = My.Resources.accept_o
            Case btnType.add
                btn.Image = My.Resources.add_o
            Case btnType.add_combo
                btn.Image = My.Resources.add_combo_o
            Case btnType.allowances
                btn.Image = My.Resources.allowances_o
            Case btnType.aquire
                btn.Image = My.Resources.aquire_o
            Case btnType.automate_settings
                btn.Image = My.Resources.Automate_settings_o
            Case btnType.backup
                btn.Image = My.Resources.backup_o
            Case btnType.batch
                btn.Image = My.Resources.batch_o
            Case btnType.cancel
                btn.Image = My.Resources.cancel_o
            Case btnType.capture_photo
                btn.Image = My.Resources.capture_photo_o
            Case btnType.close
                btn.Image = My.Resources.close_o
            Case btnType.close2
                btn.Image = My.Resources.close2_o
            Case btnType.committee
                btn.Image = My.Resources.committee_o
            Case btnType.contact
                btn.Image = My.Resources.contact_o
            Case btnType.contributions
                btn.Image = My.Resources.contributions_o
            Case btnType.courses
                btn.Image = My.Resources.courses_o
            Case btnType.deductions
                btn.Image = My.Resources.deductions_o
            Case btnType.edit
                btn.Image = My.Resources.edit_o
            Case btnType.export
                btn.Image = My.Resources.export_o
            Case btnType.find
                btn.Image = My.Resources.find_o
            Case btnType.first
                btn.Image = My.Resources.first_o
            Case btnType.flip
                btn.Image = My.Resources.flip_o
            Case btnType.import
                btn.Image = My.Resources.import_o
            Case btnType.individual
                btn.Image = My.Resources.individual_o
            Case btnType.last
                btn.Image = My.Resources.last_o
            Case btnType.loans
                btn.Image = My.Resources.loans_o
            Case btnType.new_
                btn.Image = My.Resources.New_o
            Case btnType.next_
                btn.Image = My.Resources.next_o
            Case btnType.ok
                btn.Image = My.Resources.ok_o
            Case btnType.photo
                btn.Image = My.Resources.photo_o
            Case btnType.prev
                btn.Image = My.Resources.prev_o
            Case btnType.print
                btn.Image = My.Resources.print_o
            Case btnType.print_preview
                btn.Image = My.Resources.print_preview_o
            Case btnType.qualification
                btn.Image = My.Resources.qualification_o
            Case btnType.redo
                btn.Image = My.Resources.redo_o
            Case btnType.remove
                btn.Image = My.Resources.remove_o
            Case btnType.report
                btn.Image = My.Resources.report_o
            Case btnType.restore
                btn.Image = My.Resources.restore_o
            Case btnType.save
                btn.Image = My.Resources.save_o
            Case btnType.search
                btn.Image = My.Resources.search_o
            Case btnType.startprocessing
                btn.Image = My.Resources.startprocessing_o
            Case btnType.stopprocessing
                btn.Image = My.Resources.stopprocessing_o
            Case btnType.test_connection
                btn.Image = My.Resources.test_connection_o
            Case btnType.undo
                btn.Image = My.Resources.undo_o
            Case btnType.view
                btn.Image = My.Resources.view_o
            Case btnType.zoom
                btn.Image = My.Resources.zoom_o
            Case btnType.login
                btn.Image = My.Resources.login_o
            Case btnType.none
                btn.Image = Nothing
        End Select
        If ntype <> btnType.none Then btn.Text = ""

    End Sub
    Private Sub GetImagePress(ByVal btn As Button, ByVal ntype As btnType)
        'btn.BackColor = Color.Transparent
        Select Case ntype
            Case btnType.accept
                btn.Image = My.Resources.accept
            Case btnType.add
                btn.Image = My.Resources.add
            Case btnType.add_combo
                btn.Image = My.Resources.add_combo
            Case btnType.allowances
                btn.Image = My.Resources.allowances
            Case btnType.aquire
                btn.Image = My.Resources.aquire
            Case btnType.automate_settings
                btn.Image = My.Resources.Automate_settings
            Case btnType.backup
                btn.Image = My.Resources.backup
            Case btnType.batch
                btn.Image = My.Resources.batch
            Case btnType.cancel
                btn.Image = My.Resources.cancel
            Case btnType.capture_photo
                btn.Image = My.Resources.capture_photo
            Case btnType.close
                btn.Image = My.Resources.close
            Case btnType.close2
                btn.Image = My.Resources.close2
            Case btnType.committee
                btn.Image = My.Resources.committee
            Case btnType.contact
                btn.Image = My.Resources.contact
            Case btnType.contributions
                btn.Image = My.Resources.contributions
            Case btnType.courses
                btn.Image = My.Resources.courses
            Case btnType.deductions
                btn.Image = My.Resources.deductions
            Case btnType.edit
                btn.Image = My.Resources.edit
            Case btnType.export
                btn.Image = My.Resources.export
            Case btnType.find
                btn.Image = My.Resources.find
            Case btnType.first
                btn.Image = My.Resources.first
            Case btnType.flip
                btn.Image = My.Resources.flip
            Case btnType.import
                btn.Image = My.Resources.import
            Case btnType.individual
                btn.Image = My.Resources.individual
            Case btnType.last
                btn.Image = My.Resources.last
            Case btnType.loans
                btn.Image = My.Resources.loans
            Case btnType.new_
                btn.Image = My.Resources._New
            Case btnType.next_
                btn.Image = My.Resources._next
            Case btnType.ok
                btn.Image = My.Resources.ok
            Case btnType.photo
                btn.Image = My.Resources.photo
            Case btnType.prev
                btn.Image = My.Resources.prev
            Case btnType.print
                btn.Image = My.Resources.print
            Case btnType.print_preview
                btn.Image = My.Resources.print_preview
            Case btnType.qualification
                btn.Image = My.Resources.qualification
            Case btnType.redo
                btn.Image = My.Resources.redo
            Case btnType.remove
                btn.Image = My.Resources.remove
            Case btnType.report
                btn.Image = My.Resources.report
            Case btnType.restore
                btn.Image = My.Resources.restore
            Case btnType.save
                btn.Image = My.Resources.save
            Case btnType.search
                btn.Image = My.Resources.search
            Case btnType.startprocessing
                btn.Image = My.Resources.startprocessing
            Case btnType.stopprocessing
                btn.Image = My.Resources.stopprocessing
            Case btnType.test_connection
                btn.Image = My.Resources.test_connection
            Case btnType.undo
                btn.Image = My.Resources.undo
            Case btnType.view
                btn.Image = My.Resources.view
            Case btnType.zoom
                btn.Image = My.Resources.zoom
            Case btnType.login
                btn.Image = My.Resources.login
            Case btnType.none
                btn.Image = Nothing
        End Select
        If ntype <> btnType.none Then btn.Text = ""

    End Sub
    Private Sub cButton_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseEnter, MyBase.Enter
        GetImageOver(Me, Me.ButtonType)
    End Sub
    Private Sub cButton_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseLeave, MyBase.Leave
        GetImageNormal(Me, Me.ButtonType)
    End Sub
    Private Sub cButton_Press(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        GetImagePress(Me, Me.ButtonType)
    End Sub
    Private Sub cButton_Release(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        GetImageOver(Me, Me.ButtonType)
    End Sub

End Class
