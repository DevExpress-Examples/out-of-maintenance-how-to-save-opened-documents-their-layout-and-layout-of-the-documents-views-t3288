Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Mvvm
Imports DevExpress.XtraEditors

Namespace DXSample.MVVM
    <DevExpress.Utils.MVVM.UI.ViewType("CustomerView")> _
    Partial Public Class CustomerView
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
            If Not DesignMode Then
                Dim fluentApi = mvvmContext1.OfType(Of CustomerViewModel)()
                fluentApi.SetBinding(gridControl1, Function(g) g.DataSource, Function(x) x.Entities)
            End If
        End Sub
    End Class
End Namespace
