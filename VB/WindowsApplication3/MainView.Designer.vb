Imports DevExpress.XtraGrid.Views.Grid
Namespace DXSample
    Partial Public Class MainView
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainView))
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.showCustomersBtn = New DevExpress.XtraBars.BarButtonItem()
            Me.showOrdersBtn = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            DirectCast(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(0, 0)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton1.TabIndex = 0
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DXSample.ViewModels.DocumentsViewModel)
            ' 
            ' dockManager
            ' 
            Me.dockManager.Form = Me
            Me.dockManager.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.showCustomersBtn, Me.showOrdersBtn})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 4
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1085, 139)
            ' 
            ' barButtonItem1
            ' 
            Me.showCustomersBtn.Caption = "Customers"
            Me.showCustomersBtn.Glyph = (DirectCast(resources.GetObject("barButtonItem1.Glyph"), System.Drawing.Image))
            Me.showCustomersBtn.Id = 1
            Me.showCustomersBtn.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem1.LargeGlyph"), System.Drawing.Image))
            Me.showCustomersBtn.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.showOrdersBtn.Caption = "Orders"
            Me.showOrdersBtn.Glyph = (DirectCast(resources.GetObject("barButtonItem2.Glyph"), System.Drawing.Image))
            Me.showOrdersBtn.Id = 2
            Me.showOrdersBtn.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem2.LargeGlyph"), System.Drawing.Image))
            Me.showOrdersBtn.Name = "barButtonItem2"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Main"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.showCustomersBtn)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.showOrdersBtn)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Navigation"
            ' 
            ' MainView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1085, 595)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "MainView"
            Me.Text = "Simple Application"
            DirectCast(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private showCustomersBtn As DevExpress.XtraBars.BarButtonItem
        Private showOrdersBtn As DevExpress.XtraBars.BarButtonItem



    End Class
End Namespace

