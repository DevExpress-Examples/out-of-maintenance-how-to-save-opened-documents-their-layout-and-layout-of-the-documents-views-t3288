Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace DXSample.Common.ViewModels
    Public Class BaseViewModel(Of T As Class)
        Implements ISupportLogicalLayout, ISupportParentViewModel

       Public Sub New()
            Entities = New BindingList(Of T)()
            LoadEntities()
       End Sub
        Protected Overridable Sub LoadEntities()
        End Sub
        Public Overridable Property SelectedEntity() As T
        Public Overridable Property Entities() As BindingList(Of T)
        #Region "ISupportLogicalLayout"
        Public ReadOnly Property CanSerialize() As Boolean Implements ISupportLogicalLayout.CanSerialize
            Get
                Return True
            End Get
        End Property
        Public ReadOnly Property DocumentManagerService() As IDocumentManagerService Implements ISupportLogicalLayout.DocumentManagerService
            Get
                Return Me.GetRequiredService(Of IDocumentManagerService)()
            End Get
        End Property
        Public ReadOnly Property LookupViewModels() As IEnumerable(Of Object) Implements ISupportLogicalLayout.LookupViewModels
            Get
                Return Nothing
            End Get
        End Property
        #End Region
        #Region "ISupportParentViewModel"
        Private _parentViewModel As Object
        Public Property ParentViewModel() As Object Implements ISupportParentViewModel.ParentViewModel
            Get
                Return _parentViewModel
            End Get
            Set(ByVal value As Object)
                If _parentViewModel IsNot value Then
                    _parentViewModel = value
                End If
            End Set
        End Property
        #End Region
    End Class
End Namespace
