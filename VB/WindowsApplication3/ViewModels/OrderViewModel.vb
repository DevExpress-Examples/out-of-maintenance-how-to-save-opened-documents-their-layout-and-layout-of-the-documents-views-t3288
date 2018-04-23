Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DXSample.Common.ViewModels
Imports DXSample.Models


Namespace DXSample.ViewModels
    Public Class OrderViewModel
        Inherits BaseViewModel(Of Order)

        Protected Overrides Sub LoadEntities()
            MyBase.LoadEntities()
            For i As Integer = 0 To 9
                Entities.Add(New Order() With {.ID = Entities.Count, .OrderDate = Date.Now.AddDays(-i), .ProductType = i Mod 4})
            Next i
        End Sub
    End Class
End Namespace
