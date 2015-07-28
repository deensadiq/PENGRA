Imports fyiReporting.RDL
Imports fyiReporting.RdlViewer
Imports PENGRA.Reports.Forms
Imports FirebirdSql.Data.FirebirdClient
Imports System.Windows.Forms
Imports PENGRA.Connection.Classes

Namespace Classes

    Public Class myReport
        Dim SQL As String

        Dim mBenefit As Integer
        Dim mLimit As Integer
        Dim mBudgetYear As Integer
        Dim mBudgetMonth As Integer
        Dim mAuditYear As Integer
        Dim mAuditMonth As Integer
        Dim mBudget As Integer
        Dim mEmployee As Integer
        Dim mMinistry As Integer
        Dim mReportTitle As String
        Dim mTitle As String
        Dim mParent As Form

        Private rpt As fyiReporting.RDL.Report
        Private ds As fyiReporting.RDL.DataSource
        Private dset As fyiReporting.RDL.DataSet
        Dim Adapter As FbDataAdapter

        Property Parent() As Form
            Get
                Return mParent
            End Get
            Set(ByVal value As Form)
                mParent = value
            End Set
        End Property
        Property Title As String
            Get
                Return mTitle
            End Get
            Set(ByVal value As String)
                mTitle = value
            End Set
        End Property
        Property Employee() As Long
            Get
                Return mEmployee
            End Get
            Set(ByVal value As Long)
                mEmployee = value
            End Set
        End Property
        Property Ministry() As Integer
            Get
                Return mMinistry
            End Get
            Set(ByVal value As Integer)
                mMinistry = value
            End Set
        End Property
        Property Limit() As Integer
            Get
                Return mLimit
            End Get
            Set(ByVal value As Integer)
                mLimit = value
            End Set
        End Property
        Property Benefit() As Integer
            Get
                Return mBenefit
            End Get
            Set(ByVal value As Integer)
                mBenefit = value
            End Set
        End Property
        Property Budget() As Integer
            Get
                Return mBudget
            End Get
            Set(ByVal value As Integer)
                mBudget = value
            End Set
        End Property
        Property BudgetYear() As Integer
            Get
                Return mBudgetYear
            End Get
            Set(ByVal value As Integer)
                mBudgetYear = value
            End Set
        End Property
        Property BudgetMonth() As Integer
            Get
                Return mBudgetMonth
            End Get
            Set(ByVal value As Integer)
                mBudgetMonth = value
            End Set
        End Property
        Property AuditYear() As Integer
            Get
                Return mAuditYear
            End Get
            Set(ByVal value As Integer)
                mAuditYear = value
            End Set
        End Property
        Property AuditMonth() As Integer
            Get
                Return mAuditMonth
            End Get
            Set(ByVal value As Integer)
                mAuditMonth = value
            End Set
        End Property
        Property ReportTitle() As String
            Get
                Return mReportTitle
            End Get
            Set(ByVal value As String)
                mReportTitle = value
            End Set
        End Property
        Private Sub PrintReport(ByVal Viewer As frmReport)
            Dim pDoc As New System.Drawing.Printing.PrintDocument
            Dim pDialog As New PrintDialog()


            pDialog.AllowCurrentPage = True
            pDialog.AllowSomePages = True
            pDialog.UseEXDialog = True
            pDialog.Document = pDoc

            If pDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then Viewer.RdlV.Print(pDoc)

        End Sub
        Public Sub OustandingBeneficiariesReport(ByVal bolPrint As Boolean, ByVal SQL As String)
            Dim Table As New DataTable
            Dim Viewer As New frmReport

            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Adapter.Fill(Table)

            With Viewer.RdlV
                .SourceRdl = enc.GetString(My.Resources.OUTSTANDINGRETIREES)
                rpt = .Report
                dset = rpt.DataSets("Data")
                dset.SetData(Table)
                .Parameters = "Title=" + Title
                .Rebuild()
            End With
            Viewer.Text = ReportTitle
            Viewer.MdiParent = Parent
            If bolPrint = True Then PrintReport(Viewer) Else Viewer.Show()
        End Sub
        Public Sub SummaryDetailedReport(ByVal bolPrint As Boolean, ByVal SQL As String)
            Dim Table As New DataTable
            Dim Viewer As New frmReport

            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Adapter.Fill(Table)

            With Viewer.RdlV
                .SourceRdl = enc.GetString(My.Resources.SUMMARYDETAILED)
                rpt = .Report
                dset = rpt.DataSets("Data")
                dset.SetData(Table)
                .Parameters = "Title=" + Title
                .Rebuild()
            End With
            Viewer.Text = ReportTitle
            Viewer.MdiParent = Parent
            If bolPrint = True Then PrintReport(Viewer) Else Viewer.Show()
        End Sub
        Public Sub SummaryBreakdownReport(ByVal bolPrint As Boolean, ByVal SQL As String)
            Dim Table As New DataTable
            Dim Viewer As New frmReport

            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Adapter.Fill(Table)

            With Viewer.RdlV
                .SourceRdl = enc.GetString(My.Resources.SUMMARYBREAKDOWN)
                rpt = .Report
                dset = rpt.DataSets("Data")
                dset.SetData(Table)
                .Parameters = "Title=" + Title
                .Rebuild()
            End With
            Viewer.Text = ReportTitle
            Viewer.MdiParent = Parent
            If bolPrint = True Then PrintReport(Viewer) Else Viewer.Show()
        End Sub
        Public Sub BenefitPaymentReport(ByVal bolPrint As Boolean, ByVal SQL As String)
            Dim Table As New DataTable
            Dim Viewer As New frmReport

            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Adapter.Fill(Table)

            With Viewer.RdlV
                .SourceRdl = enc.GetString(My.Resources.PAYMENTOFBENEFIT)
                rpt = .Report
                dset = rpt.DataSets("Data")
                dset.SetData(Table)
                .Parameters = "Title=" + Title
                .Rebuild()
            End With
            Viewer.Text = ReportTitle
            Viewer.MdiParent = Parent
            If bolPrint = True Then PrintReport(Viewer) Else Viewer.Show()
        End Sub
        Public Sub BenefitPaymentSummaryReport(ByVal bolPrint As Boolean, ByVal SQL As String)
            Dim Table As New DataTable
            Dim Viewer As New frmReport

            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Adapter.Fill(Table)

            With Viewer.RdlV
                .SourceRdl = enc.GetString(My.Resources.PAYMENTSUMMARY2)
                rpt = .Report
                dset = rpt.DataSets("Data")
                dset.SetData(Table)
                .Parameters = "Title=" + Title
                .Rebuild()
            End With
            Viewer.Text = ReportTitle
            Viewer.MdiParent = Parent
            If bolPrint = True Then PrintReport(Viewer) Else Viewer.Show()
        End Sub
        Public Sub PensionPayrollReport(ByVal bolPrint As Boolean, ByVal SQL As String)
            Dim Table As New DataTable
            Dim Viewer As New frmReport

            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Adapter.Fill(Table)

            With Viewer.RdlV
                .SourceRdl = enc.GetString(My.Resources.PENSIONPAYROLL2)
                rpt = .Report
                dset = rpt.DataSets("Data")
                dset.SetData(Table)
                .Parameters = "Title=" + Title
                .Rebuild()
            End With
            Viewer.Text = ReportTitle
            Viewer.MdiParent = Parent
            If bolPrint = True Then PrintReport(Viewer) Else Viewer.Show()
        End Sub
        Public Sub PensionPayrollSummaryReport(ByVal bolPrint As Boolean, ByVal SQL As String)
            Dim Table As New DataTable
            Dim Viewer As New frmReport

            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Adapter.Fill(Table)

            With Viewer.RdlV
                .SourceRdl = enc.GetString(My.Resources.PENSIONPAYROLLSUMMARY2)
                rpt = .Report
                dset = rpt.DataSets("Data")
                dset.SetData(Table)
                .Parameters = "Title=" + Title
                .Rebuild()
            End With
            Viewer.Text = ReportTitle
            Viewer.MdiParent = Parent
            If bolPrint = True Then PrintReport(Viewer) Else Viewer.Show()
        End Sub
        Public Sub DeathPensionPayrollReport(ByVal bolPrint As Boolean, ByVal SQL As String)
            Dim Table As New DataTable
            Dim Viewer As New frmReport

            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Adapter.Fill(Table)

            With Viewer.RdlV
                .SourceRdl = enc.GetString(My.Resources.DEATHPENSIONPAYROLL2)
                rpt = .Report
                dset = rpt.DataSets("Data")
                dset.SetData(Table)
                .Parameters = "Title=" + Title
                .Rebuild()
            End With
            Viewer.Text = ReportTitle
            Viewer.MdiParent = Parent
            If bolPrint = True Then PrintReport(Viewer) Else Viewer.Show()
        End Sub
        Public Sub DeathPayrollSummaryReport(ByVal bolPrint As Boolean, ByVal SQL As String)
            Dim Table As New DataTable
            Dim Viewer As New frmReport

            Adapter = New FbDataAdapter(SQL, Env.ConStr)
            Adapter.Fill(Table)

            With Viewer.RdlV
                .SourceRdl = enc.GetString(My.Resources.DEATHPAYROLLSUMMARY)
                rpt = .Report
                dset = rpt.DataSets("Data")
                dset.SetData(Table)
                .Parameters = "Title=" + Title
                .Rebuild()
            End With
            Viewer.Text = ReportTitle
            Viewer.MdiParent = Parent
            If bolPrint = True Then PrintReport(Viewer) Else Viewer.Show()
        End Sub
    End Class
End Namespace