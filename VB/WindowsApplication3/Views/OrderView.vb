Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DXSample.ViewModels
Imports DevExpress.XtraEditors.Controls

Namespace DXSample.Views
    <DevExpress.Utils.MVVM.UI.ViewType("OrderView")> _
    Partial Public Class OrderView
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            If Not DesignMode Then
                Dim fluentApi = mvvmContext.OfType(Of OrderViewModel)()
                fluentApi.SetObjectDataSourceBinding(bindingSource, Function(x) x.Entities)
            End If
            InitImageComboBox()
        End Sub
        Private Sub InitImageComboBox()
            For i As Integer = 0 To imageCollection1.Images.Count - 1
                repositoryItemImageComboBox1.Items.Add(New ImageComboBoxItem(i, i))
            Next i
        End Sub
    End Class
End Namespace
