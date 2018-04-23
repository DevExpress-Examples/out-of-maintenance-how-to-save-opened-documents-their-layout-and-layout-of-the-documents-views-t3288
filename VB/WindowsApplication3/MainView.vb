Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Mvvm
Imports DevExpress.Utils.MVVM
Imports DevExpress.XtraEditors
Imports DXSample.ViewModels


Namespace DXSample
    Partial Public Class MainView
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            mvvmContext.RegisterService(DevExpress.Utils.MVVM.Services.LayoutSerializationService.Create(Me, True))
            Dim service As IDocumentManagerService = DirectCast(DevExpress.Utils.MVVM.Services.DocumentManagerService.Create(dockManager), IDocumentManagerService)
            mvvmContext.RegisterService(service)
            Dim fluentAPI = mvvmContext.OfType(Of DocumentsViewModel)()
            fluentAPI.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
            fluentAPI.WithEvent(Of FormClosingEventArgs)(Me, "FormClosing").EventToCommand(Sub(x) x.OnClosing(Nothing), New Func(Of CancelEventArgs, Object)(Function(args) args))
            fluentAPI.BindCommand(showCustomersBtn, Sub(x, m) x.Show(m), Function(x) x.Modules(0))
            fluentAPI.BindCommand(showOrdersBtn, Sub(x, m) x.Show(m), Function(x) x.Modules(1))
        End Sub
    End Class
End Namespace

