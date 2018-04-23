Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DXSample.Common.ViewModels
Imports DXSample.MVVM

Namespace DXSample.ViewModels
    Public Class DocumentsViewModel
        Implements ISupportLogicalLayout

        Private Const ViewLayoutName As String = "DocumentsViewModel"
        Public Sub New()
            Modules = CreateModules()
        End Sub
        Private privateModules As ModuleDescription()
        Public Property Modules() As ModuleDescription()
            Get
                Return privateModules
            End Get
            Private Set(ByVal value As ModuleDescription())
                privateModules = value
            End Set
        End Property
        Protected ReadOnly Property IDocumentManagerService() As IDocumentManagerService
            Get
                Return Me.GetService(Of IDocumentManagerService)()
            End Get
        End Property
        Protected ReadOnly Property LayoutSerializationService() As ILayoutSerializationService
            Get
                Return Me.GetService(Of ILayoutSerializationService)()
            End Get
        End Property
        #Region "ISupportLogicalLayout"
        Public ReadOnly Property LookupViewModels() As IEnumerable(Of Object) Implements ISupportLogicalLayout.LookupViewModels
            Get
                Return Nothing
            End Get
        End Property
        Private ReadOnly Property DocumentManagerService() As IDocumentManagerService Implements ISupportLogicalLayout.DocumentManagerService
            Get
                Return IDocumentManagerService
            End Get
        End Property
        Public ReadOnly Property CanSerialize() As Boolean Implements ISupportLogicalLayout.CanSerialize
            Get
                Return True
            End Get
        End Property
        #End Region
        Public Overridable Sub OnClosing(ByVal cancelEventArgs As CancelEventArgs)
            SaveLogicalLayout()
            If LayoutSerializationService IsNot Nothing Then
                ViewModelLogicalLayoutHelper.PersistentViewsLayout(ViewLayoutName) = LayoutSerializationService.Serialize()
            End If
            ViewModelLogicalLayoutHelper.SaveLayout()
        End Sub
        Public Sub SaveLogicalLayout()
            ViewModelLogicalLayoutHelper.PersistentLogicalLayout = LogicalLayoutSerializationHelper.SerializeDocumentManagerService(Me)
        End Sub
        Public Sub Show(ByVal [module] As ModuleDescription)
            ShowCore([module])
        End Sub
        Public Function ShowCore(ByVal [module] As ModuleDescription) As IDocument
            If [module] Is Nothing OrElse DocumentManagerService Is Nothing Then
                Return Nothing
            End If
            Dim document As IDocument = DocumentManagerService.FindDocumentByIdOrCreate([module].DocumentType, Function(x) CreateDocument([module]))
            document.Show()
            Return document
        End Function
        Private Function CreateDocument(ByVal [module] As ModuleDescription) As IDocument
            Dim document = DocumentManagerService.CreateDocument([module].DocumentType, Nothing, Me)
            document.Title = [module].Title
            document.DestroyOnClose = False
            Return document
        End Function
        Public Overridable Sub OnLoaded()
            RestoreLogicalLayout()
            Dim state As String = Nothing
            If LayoutSerializationService IsNot Nothing AndAlso ViewModelLogicalLayoutHelper.PersistentViewsLayout.TryGetValue(ViewLayoutName, state) Then
                LayoutSerializationService.Deserialize(state)
            End If
        End Sub
        Public Function RestoreLogicalLayout() As Boolean
            If String.IsNullOrWhiteSpace(ViewModelLogicalLayoutHelper.PersistentLogicalLayout) Then
                Return False
            End If
            Me.RestoreDocumentManagerService(ViewModelLogicalLayoutHelper.PersistentLogicalLayout)
            Return True
        End Function
        Protected Function CreateModules() As ModuleDescription()
            Return New ModuleDescription() { _
                New ModuleDescription("CustomerView", "Customers"), _
                New ModuleDescription("OrderView", "Orders") _
            }
        End Function

    End Class
End Namespace
