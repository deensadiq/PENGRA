Imports System.Drawing

Namespace Classes


    Public Class Scanner

        Public Shared Function getPicture(ByVal dbfield As Object) As Image

            If IsDBNull(dbfield) = True Then Return Nothing

            Dim binary As Byte()
            Dim str As New System.IO.MemoryStream
            Dim Img As Image

            binary = CType(dbfield, Byte())
            str.Write(binary, 0, binary.Length)
            Img = Image.FromStream(str)

            Return Img

        End Function

        Public Shared Sub savePicture(ByRef dbfield As DataRow, ByVal picture As Image)

            Dim binary As Byte()

            Dim mStream As New System.IO.MemoryStream
            Dim len As Integer

            picture.Save(mStream, picture.RawFormat)
            mStream.Position = 0
            len = CInt(mStream.Length)
            ReDim binary(len)
            mStream.Read(binary, 0, len)

            'dbfield.PHOTO = binary

        End Sub
        Public Shared Sub savePicture(ByRef dbfield As DataTable, ByVal picture As Image)

            Dim binary As Byte()

            Dim mStream As New System.IO.MemoryStream
            Dim len As Integer

            picture.Save(mStream, picture.RawFormat)
            mStream.Position = 0
            len = CInt(mStream.Length)
            ReDim binary(len)
            mStream.Read(binary, 0, len)

            'dbfield.PHOTO = binary

        End Sub
        Public Shared Sub savePicture(ByRef dbfield As Object, ByVal picture As Image)

            Dim binary As Byte()

            Dim mStream As New System.IO.MemoryStream
            Dim len As Integer

            picture.Save(mStream, picture.RawFormat)
            mStream.Position = 0
            len = CInt(mStream.Length)
            ReDim binary(len)
            mStream.Read(binary, 0, len)

            dbfield.PHOTO = binary

        End Sub
        Public Shared Sub saveSignature(ByRef dbfield As Object, ByVal picture As Image)

            Dim binary As Byte()

            Dim mStream As New System.IO.MemoryStream
            Dim len As Integer

            picture.Save(mStream, picture.RawFormat)
            mStream.Position = 0
            len = CInt(mStream.Length)
            ReDim binary(len)
            mStream.Read(binary, 0, len)

            dbfield.SIGNATURE = binary

        End Sub
    End Class
End Namespace