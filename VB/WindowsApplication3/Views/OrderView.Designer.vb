Namespace DXSample.Views
    Partial Public Class OrderView
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

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrderView))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colOrderDate = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colProductType = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.layoutViewField_colProductType = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewField_colID, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewField_colOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewField_colProductType, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.bindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.layoutView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1})
            Me.gridControl1.Size = New System.Drawing.Size(561, 357)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
            ' 
            ' bindingSource
            ' 
            Me.bindingSource.DataSource = GetType(DXSample.Models.Order)
            ' 
            ' layoutView1
            ' 
            Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colID, Me.colOrderDate, Me.colProductType})
            Me.layoutView1.GridControl = Me.gridControl1
            Me.layoutView1.Name = "layoutView1"
            Me.layoutView1.OptionsBehavior.Editable = False
            Me.layoutView1.OptionsCarouselMode.CardCount = 5
            Me.layoutView1.OptionsSingleRecordMode.StretchCardToViewHeight = True
            Me.layoutView1.OptionsSingleRecordMode.StretchCardToViewWidth = True
            Me.layoutView1.OptionsView.ShowHeaderPanel = False
            Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column
            Me.layoutView1.TemplateCard = Me.layoutViewCard1
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.LayoutViewField = Me.layoutViewField_colID
            Me.colID.Name = "colID"
            ' 
            ' layoutViewField_colID
            ' 
            Me.layoutViewField_colID.EditorPreferredWidth = 127
            Me.layoutViewField_colID.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colID.Name = "layoutViewField_colID"
            Me.layoutViewField_colID.Size = New System.Drawing.Size(202, 20)
            Me.layoutViewField_colID.TextSize = New System.Drawing.Size(68, 13)
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.LayoutViewField = Me.layoutViewField_colOrderDate
            Me.colOrderDate.Name = "colOrderDate"
            ' 
            ' layoutViewField_colOrderDate
            ' 
            Me.layoutViewField_colOrderDate.EditorPreferredWidth = 127
            Me.layoutViewField_colOrderDate.Location = New System.Drawing.Point(0, 20)
            Me.layoutViewField_colOrderDate.Name = "layoutViewField_colOrderDate"
            Me.layoutViewField_colOrderDate.Size = New System.Drawing.Size(202, 20)
            Me.layoutViewField_colOrderDate.TextSize = New System.Drawing.Size(68, 13)
            ' 
            ' colProductType
            ' 
            Me.colProductType.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colProductType.FieldName = "ProductType"
            Me.colProductType.LayoutViewField = Me.layoutViewField_colProductType
            Me.colProductType.Name = "colProductType"
            ' 
            ' repositoryItemImageComboBox1
            ' 
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageCollection1
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageSize = New System.Drawing.Size(48, 48)
            Me.imageCollection1.ImageStream = (DirectCast(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imageCollection1.InsertImage(My.Resources.Monitors, "Monitors", GetType(My.Resources.Resources), 0)
            Me.imageCollection1.Images.SetKeyName(0, "Monitors")
            Me.imageCollection1.InsertImage(My.Resources.Projectors, "Projectors", GetType(My.Resources.Resources), 1)
            Me.imageCollection1.Images.SetKeyName(1, "Projectors")
            Me.imageCollection1.InsertImage(My.Resources.TVs, "TVs", GetType(My.Resources.Resources), 2)
            Me.imageCollection1.Images.SetKeyName(2, "TVs")
            Me.imageCollection1.InsertImage(My.Resources.VideoPlayers, "VideoPlayers", GetType(My.Resources.Resources), 3)
            Me.imageCollection1.Images.SetKeyName(3, "VideoPlayers")
            ' 
            ' layoutViewField_colProductType
            ' 
            Me.layoutViewField_colProductType.EditorPreferredWidth = 127
            Me.layoutViewField_colProductType.Location = New System.Drawing.Point(0, 40)
            Me.layoutViewField_colProductType.Name = "layoutViewField_colProductType"
            Me.layoutViewField_colProductType.Size = New System.Drawing.Size(202, 20)
            Me.layoutViewField_colProductType.TextSize = New System.Drawing.Size(68, 13)
            ' 
            ' layoutViewCard1
            ' 
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colID, Me.layoutViewField_colOrderDate, Me.layoutViewField_colProductType})
            Me.layoutViewCard1.Name = "layoutViewCard1"
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DXSample.ViewModels.OrderViewModel)
            ' 
            ' OrderView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "OrderView"
            Me.Size = New System.Drawing.Size(561, 357)
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewField_colID, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewField_colOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewField_colProductType, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
        Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
        Private bindingSource As System.Windows.Forms.BindingSource
        Private colID As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private layoutViewField_colID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private colOrderDate As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private layoutViewField_colOrderDate As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private colProductType As DevExpress.XtraGrid.Columns.LayoutViewColumn
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private layoutViewField_colProductType As DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Private imageCollection1 As DevExpress.Utils.ImageCollection
    End Class
End Namespace
