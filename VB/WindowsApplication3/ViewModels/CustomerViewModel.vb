Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Mvvm
Imports DXSample.Common.ViewModels

Namespace DXSample.MVVM

    Public Class CustomerViewModel
        Inherits BaseViewModel(Of Customer)
        Protected Overrides Sub LoadEntities()
            MyBase.LoadEntities()
            For i As Integer = 0 To 9
                Entities.Add(New Customer() With {.ID = Entities.Count, .Name = String.Format("Test Name {0}", Entities.Count)})
            Next i
        End Sub
    End Class
End Namespace
