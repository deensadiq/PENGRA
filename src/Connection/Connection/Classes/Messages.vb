Imports System.Windows.Forms

Namespace Classes
    Public Class Messages

        ' This class serves messages that are displayed in messageboxes
        Public Shared FatalError As String = "It Seems A Fatal Error Has Occured. Please Contact Cerebro Information Systems Limited."
        Public Shared Proceed As String = "Are You Sure You Want To Continue With The Current Process?"
        Public Shared Delete As String = "Are You Sure You Want To Delete ?."
        Public Shared Duplicate As String = "Cannot Continue, Saving This Record Will Create Duplicate."
        Public Shared Empty As String = "Empty Entries Cannot Be Saved."
        Public Shared Numeric As String = "Non Numeric Entry In Numeric Field."
        Public Shared DataType As String = "Wrong Data Type Entered."
        Public Shared Connected As String = "Connection Successfull."
        Public Shared NotConnected As String = "Connection Failed."
        Public Shared MustRestart As String = Application.ProductName + " Will Restart To Continue."
        Public Shared AccessDenied As String = "Dont Have The Privilege To Edit This Record. Check With Your Superior Officer."
        Public Shared Completed As String = "Processing Completed Successfully."
        Public Shared Cancelled As String = "Processing Has Been Cancelled."
        Public Shared Aborted As String = "Processing Aborted."
        Public Shared NoRecord As String = "No record found."
        Public Shared NoPrivilege As String = "Dont Have The Access Privilege To Continue With The Process."
        Public Shared NoAdministrator As String = "The First User Must Have Administrator Role"
        Public Shared SelectStudent As String = "Please select a Student by clicking on Find button"
        Public Shared NoSelection As String = "Empty Selection Not allowed."
        Public Shared NoNegative As String = "Value Must Be Greater Than Or Equal To Zero"
        Public Shared WrongKey As String = "Wrong Product Key"
        Public Shared Expired As String = "Your Evaluation Period Has Expired"
        Public Shared Unlocked As String = "Congratulations, You Have Successfully Unlocked Opal."
        Public Shared NoCalendar As String = "Calendar Must Be Set Before You Can Continue."
        Public Shared NoSubjectRegd As String = "Subjects Must Be Set Before You Can Continue."
        Public Shared ForeignKey As String = "Cannot Remove This Record.The Record Is Being Used By Another Section"
        Public Shared NoPromotion As String = "Cannot Perform This Action Because The Current Term Is Not Promotional."
        Public Shared SubjectRegistration As String = "This Subject Has The Student Scores. It Can Not Be Remove."
        Public Shared LogoError As String = "Selected Picture Not Supported."
        Public Shared ChangeClass As String = "Cannot Change Student Class Because Some Subjects Have Score."

        Public Shared AllowChangeClass As String = "Student has scores in some Subjects. Are you sure you want to change the Student's Class.?"
        Public Shared ContinueWithAction As String = "This Action cannot be undone. Are you sure you want to continue.?"
        Public Shared DeletePhoto As String = "Are You Sure You Want To Delete This Photo?."
        Public Shared NoUnlocked As String = "You Have To Unlock Opal Before You Can Change School Logo."
        Public Shared OnlyAdminPrivilege As String = "Only Administrator Is Allowed To Perform This Action."

        Public Shared TotalMarks As String = "Total Assessment Score Must Be Equal To 100."
        Public Shared VerifyPassword As String = "Please Verify Your Password."
        Public Shared UserExist As String = "The Username already exist please specify a different username."
        Public Shared UserRegistrationSuccessful As String = "Your account has been created. An Administrator approval is required to activate it before you can login."
        Public Shared ChangedPasswordSuccessful As String = "Your account password has been Updated."
        Public Shared ActiveAdministrator As String = "At Least One Administrator Must Be Active."
        Public Shared NumericValue As String = "Only Numeric Value Is Allowed."

        Public Shared AmountOver As String = "This Transaction Cannot Be Process. Amount Is Greater Than Allocation Amount."

        Public Shared SetToDefault As String = "Apply Deafult Settings."

    End Class
End Namespace