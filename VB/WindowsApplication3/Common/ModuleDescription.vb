Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DXSample
    Public Class ModuleDescription
        Public Sub New(ByVal documentType As String, ByVal title As String)
            Me.DocumentType = documentType
            Me.Title = title
        End Sub
        Public Property DocumentType() As String
        Public Property Title() As String
    End Class
End Namespace
