Imports PENGRA.Connection.Classes
Imports FirebirdSql.Data.FirebirdClient
Namespace Classes
    Public Class Calculator
        Private iSalary As Integer
        Private iGL As Integer
        Private iStep As Integer
        Private iGratuityPerc As Short
        Private iPensionPerc As Short
        Private iBenefitType As Integer
        Private iAuditDate As Date
        Private ipwefDate As Date

        Private iConsolidated As Decimal
        Private iGratuity As Decimal
        Private iPension As Decimal
        Private iPensionArrears As Decimal
        Private iDeathPension As Decimal

        ReadOnly Property SalaryStructure As Integer
            Get
                Return iSalary
            End Get
        End Property
        ReadOnly Property GradeLevel As Integer
            Get
                Return iGL
            End Get
        End Property
        ReadOnly Property GradeStep As Integer
            Get
                Return iStep
            End Get
        End Property
        ReadOnly Property GratuityPercentage As Short
            Get
                Return iGratuityPerc
            End Get
        End Property
        ReadOnly Property PensionPercentage As Short
            Get
                Return iPensionPerc
            End Get
        End Property
        ReadOnly Property Consolidated As Decimal
            Get
                Return iConsolidated
            End Get
        End Property
        ReadOnly Property Gratuity As Decimal
            Get
                Return iGratuity
            End Get
        End Property
        ReadOnly Property Pension As Decimal
            Get
                Return iPension
            End Get
        End Property
        ReadOnly Property PensionArrears As Decimal
            Get
                Return iPensionArrears
            End Get
        End Property
        ReadOnly Property DeathPension As Decimal
            Get
                Return iDeathPension
            End Get
        End Property
        Private Sub New()

        End Sub
        Public Sub New(ByVal SalaryStructure As Integer, ByVal GradeLevel As Integer, ByVal GradeStep As Integer, ByVal GratuityPercentage As Short, ByVal PensionPercentage As Short, ByVal BenefitType As Integer, ByVal AuditDate As Date, ByVal PWEFDate As Date)
            iSalary = SalaryStructure
            iGL = GradeLevel
            iStep = GradeStep
            iGratuityPerc = GratuityPercentage
            iPensionPerc = PensionPercentage
            iBenefitType = BenefitType
            iAuditDate = AuditDate
            ipwefDate = PWEFDate

            computeBenefit()
        End Sub
        Private Sub computeBenefit()
            Dim str As String
            Dim da As FbDataAdapter
            Dim tbl As New DataTable

            str = "SELECT SUM(a.AMOUNT) AS AMOUNT FROM SETENTITLEMENT a where a.STRUCTURE = '" & iSalary & "' and a.GL = '" & iGL & "' and a.ST = '" & iStep & "'"

            If DB.ConnObj.State = ConnectionState.Closed Then DB.ConnObj.Open()

            da = New FbDataAdapter(str, DB.ConnObj)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 And Not IsDBNull(tbl.Rows(0).Item("AMOUNT")) Then
                iConsolidated = tbl.Rows(0).Item("AMOUNT") * 12
                iGratuity = (iConsolidated * CDec(iGratuityPerc)) / 100
                iPension = (iConsolidated * CDec(iPensionPerc)) / 100

                computeArrears()
            End If

        End Sub
        Private Sub computeArrears()
            Dim NoMonth As Integer

            NoMonth = DateDiff(DateInterval.Month, ipwefDate, iAuditDate)

            If iBenefitType = 1 Then
                iPensionArrears = (iPension / 12) * NoMonth
                iDeathPension = 0
            Else
                iPensionArrears = 0
                iDeathPension = iPension * 5
            End If

        End Sub
    End Class
End Namespace