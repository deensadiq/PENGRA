Namespace Classes
    Public Class Privileges
        Private Shared m_Privilege As Privileges

        Private m_Profile As Boolean
        Private m_Add_Retiree_Record As Boolean
        Private m_Edit_Retiree_Record As Boolean
        Private m_Remove_Retiree_Record As Boolean
        Private m_View_Payment_Profile As Boolean
        Private m_Knockoff_Payment As Boolean
        Private m_Prepare_Allocation As Boolean
        Private m_Edit_Allocation As Boolean
        Private m_Remove_Allocation As Boolean
        Private m_View_Oustanding_Retiree As Boolean
        Private m_Edit_Retiree_Status As Boolean
        Private m_Gen_Oustanding_Reort As Boolean
        Private m_View_Oustanding_Retiree_AL As Boolean
        Private m_Edit_Retiree_Status_AL As Boolean
        Private m_Gen_Oustanding_Reort_AL As Boolean
        Private m_View_Oustanding_Retiree_Summary As Boolean
        Private m_Gen_Retiree_Summary_Report As Boolean
        Private m_View_Oustanding_Retiree_Summary_AL As Boolean
        Private m_Gen_Retiree_Summary_Report_AL As Boolean
        Private m_View_Payment_Details As Boolean
        Private m_Edit_Payment_Status As Boolean
        Private m_Remove_Payment As Boolean
        Private m_Gen_Payment_Details_Report As Boolean
        Private m_View_Payment_Details_AL As Boolean
        Private m_Edit_Payment_Status_AL As Boolean
        Private m_Remove_Payment_AL As Boolean
        Private m_Gen_Payment_Details_Report_AL As Boolean
        Private m_Process_Payment As Boolean
        Private m_Edit_Menu As Boolean
        Private m_Settings As Boolean
        Private m_User_Account As Boolean
        Private m_Server_Settings As Boolean
        Private m_Extra_Menu As Boolean
        Private m_Backup_Restore As Boolean
        Private m_Report_Menu As Boolean
        Public Property Profile() As Boolean
            Get
                Return m_Profile
            End Get
            Set(ByVal value As Boolean)
                m_Profile = value
            End Set
        End Property
        Public Property AddRetireRecord() As Boolean
            Get
                Return m_Add_Retiree_Record
            End Get
            Set(ByVal value As Boolean)
                m_Add_Retiree_Record = value
            End Set
        End Property
        Public Property EditRetireRecord() As Boolean
            Get
                Return m_Edit_Retiree_Record
            End Get
            Set(ByVal value As Boolean)
                m_Edit_Retiree_Record = value
            End Set
        End Property
        Public Property RemoveRetireRecord() As Boolean
            Get
                Return m_Remove_Retiree_Record
            End Get
            Set(ByVal value As Boolean)
                m_Remove_Retiree_Record = value
            End Set
        End Property
        Public Property ViewPaymentProfile() As Boolean
            Get
                Return m_View_Payment_Profile
            End Get
            Set(ByVal value As Boolean)
                m_View_Payment_Profile = value
            End Set
        End Property
        Public Property KnockoffPayment() As Boolean
            Get
                Return m_Knockoff_Payment
            End Get
            Set(ByVal value As Boolean)
                m_Knockoff_Payment = value
            End Set
        End Property
        Public Property PrepareAllocation() As Boolean
            Get
                Return m_Prepare_Allocation
            End Get
            Set(ByVal value As Boolean)
                m_Prepare_Allocation = value
            End Set
        End Property
        Public Property EditAllocation() As Boolean
            Get
                Return m_Edit_Allocation
            End Get
            Set(ByVal value As Boolean)
                m_Edit_Allocation = value
            End Set
        End Property
        Public Property RemoveAllocation() As Boolean
            Get
                Return m_Remove_Allocation
            End Get
            Set(ByVal value As Boolean)
                m_Remove_Allocation = value
            End Set
        End Property
        Public Property ViewOustandingRetiree() As Boolean
            Get
                Return m_View_Oustanding_Retiree
            End Get
            Set(ByVal value As Boolean)
                m_View_Oustanding_Retiree = value
            End Set
        End Property
        Public Property EditRetireeStatus() As Boolean
            Get
                Return m_Edit_Retiree_Status
            End Get
            Set(ByVal value As Boolean)
                m_Edit_Retiree_Status = value
            End Set
        End Property
        Public Property GenerateOustandingReport() As Boolean
            Get
                Return m_Gen_Oustanding_Reort
            End Get
            Set(ByVal value As Boolean)
                m_Gen_Oustanding_Reort = value
            End Set
        End Property
        Public Property ViewOustandingRetireeAL() As Boolean
            Get
                Return m_View_Oustanding_Retiree_AL
            End Get
            Set(ByVal value As Boolean)
                m_View_Oustanding_Retiree_AL = value
            End Set
        End Property
        Public Property EditRetireeStatusAL() As Boolean
            Get
                Return m_Edit_Retiree_Status_AL
            End Get
            Set(ByVal value As Boolean)
                m_Edit_Retiree_Status_AL = value
            End Set
        End Property
        Public Property GenerateOustandingReportAL() As Boolean
            Get
                Return m_Gen_Oustanding_Reort_AL
            End Get
            Set(ByVal value As Boolean)
                m_Gen_Oustanding_Reort_AL = value
            End Set
        End Property
        Public Property ViewOustandingSummary() As Boolean
            Get
                Return m_View_Oustanding_Retiree_Summary
            End Get
            Set(ByVal value As Boolean)
                m_View_Oustanding_Retiree_Summary = value
            End Set
        End Property
        Public Property GenerateSummaryReport() As Boolean
            Get
                Return m_Gen_Retiree_Summary_Report
            End Get
            Set(ByVal value As Boolean)
                m_Gen_Retiree_Summary_Report = value
            End Set
        End Property
        Public Property ViewOustandingSummaryAL() As Boolean
            Get
                Return m_View_Oustanding_Retiree_Summary_AL
            End Get
            Set(ByVal value As Boolean)
                m_View_Oustanding_Retiree_Summary_AL = value
            End Set
        End Property
        Public Property GenerateSummaryReportAL() As Boolean
            Get
                Return m_Gen_Retiree_Summary_Report_AL
            End Get
            Set(ByVal value As Boolean)
                m_Gen_Retiree_Summary_Report_AL = value
            End Set
        End Property
        Public Property ViewPaymentDetails() As Boolean
            Get
                Return m_View_Payment_Details
            End Get
            Set(ByVal value As Boolean)
                m_View_Payment_Details = value
            End Set
        End Property
        Public Property EditPaymentStatus() As Boolean
            Get
                Return m_Edit_Payment_Status
            End Get
            Set(ByVal value As Boolean)
                m_Edit_Payment_Status = value
            End Set
        End Property
        Public Property RemovePayment() As Boolean
            Get
                Return m_Remove_Payment
            End Get
            Set(ByVal value As Boolean)
                m_Remove_Payment = value
            End Set
        End Property
        Public Property GeneratePaymentDetailsReport() As Boolean
            Get
                Return m_Gen_Payment_Details_Report
            End Get
            Set(ByVal value As Boolean)
                m_Gen_Payment_Details_Report = value
            End Set
        End Property
        Public Property ViewPaymentDetailsAL() As Boolean
            Get
                Return m_View_Payment_Details_AL
            End Get
            Set(ByVal value As Boolean)
                m_View_Payment_Details_AL = value
            End Set
        End Property
        Public Property EditPaymentStatusAL() As Boolean
            Get
                Return m_Edit_Payment_Status_AL
            End Get
            Set(ByVal value As Boolean)
                m_Edit_Payment_Status_AL = value
            End Set
        End Property
        Public Property RemovePaymentAL() As Boolean
            Get
                Return m_Remove_Payment_AL
            End Get
            Set(ByVal value As Boolean)
                m_Remove_Payment_AL = value
            End Set
        End Property
        Public Property GeneratePaymentDetailsReportAL() As Boolean
            Get
                Return m_Gen_Payment_Details_Report_AL
            End Get
            Set(ByVal value As Boolean)
                m_Gen_Payment_Details_Report_AL = value
            End Set
        End Property
        Public Property ProcessPayment() As Boolean
            Get
                Return m_Process_Payment
            End Get
            Set(ByVal value As Boolean)
                m_Process_Payment = value
            End Set
        End Property
        Public Property EditMenu() As Boolean
            Get
                Return m_Edit_Menu
            End Get
            Set(ByVal value As Boolean)
                m_Edit_Menu = value
            End Set
        End Property
        Public Property Settings() As Boolean
            Get
                Return m_Settings
            End Get
            Set(ByVal value As Boolean)
                m_Settings = value
            End Set
        End Property
        Public Property UserAccountSettings() As Boolean
            Get
                Return m_User_Account
            End Get
            Set(ByVal value As Boolean)
                m_User_Account = value
            End Set
        End Property
        Public Property ServerSettings() As Boolean
            Get
                Return m_Server_Settings
            End Get
            Set(ByVal value As Boolean)
                m_Server_Settings = value
            End Set
        End Property
        Public Property ExtraMenuSettings() As Boolean
            Get
                Return m_Extra_Menu
            End Get
            Set(ByVal value As Boolean)
                m_Extra_Menu = value
            End Set
        End Property
        Public Property BackupRestore() As Boolean
            Get
                Return m_Backup_Restore
            End Get
            Set(ByVal value As Boolean)
                m_Backup_Restore = value
            End Set
        End Property
        Public Property ReportMenu() As Boolean
            Get
                Return m_Report_Menu
            End Get
            Set(ByVal value As Boolean)
                m_Report_Menu = value
            End Set
        End Property
        Private Sub New()

        End Sub
        Public Shared Function getUserPrivilege() As Privileges
            If m_Privilege Is Nothing Then m_Privilege = New Privileges
            Return m_Privilege
        End Function

    End Class
End Namespace