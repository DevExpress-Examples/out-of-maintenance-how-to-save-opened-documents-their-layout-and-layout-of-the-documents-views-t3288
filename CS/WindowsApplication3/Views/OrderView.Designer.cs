namespace DXSample.Views {
    partial class OrderView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderView));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colOrderDate = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colProductType = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.layoutViewField_colProductType = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(561, 357);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(DXSample.Models.Order);
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colID,
            this.colOrderDate,
            this.colProductType});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsCarouselMode.CardCount = 5;
            this.layoutView1.OptionsSingleRecordMode.StretchCardToViewHeight = true;
            this.layoutView1.OptionsSingleRecordMode.StretchCardToViewWidth = true;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.LayoutViewField = this.layoutViewField_colID;
            this.colID.Name = "colID";
            // 
            // layoutViewField_colID
            // 
            this.layoutViewField_colID.EditorPreferredWidth = 127;
            this.layoutViewField_colID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colID.Name = "layoutViewField_colID";
            this.layoutViewField_colID.Size = new System.Drawing.Size(202, 20);
            this.layoutViewField_colID.TextSize = new System.Drawing.Size(68, 13);
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.LayoutViewField = this.layoutViewField_colOrderDate;
            this.colOrderDate.Name = "colOrderDate";
            // 
            // layoutViewField_colOrderDate
            // 
            this.layoutViewField_colOrderDate.EditorPreferredWidth = 127;
            this.layoutViewField_colOrderDate.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_colOrderDate.Name = "layoutViewField_colOrderDate";
            this.layoutViewField_colOrderDate.Size = new System.Drawing.Size(202, 20);
            this.layoutViewField_colOrderDate.TextSize = new System.Drawing.Size(68, 13);
            // 
            // colProductType
            // 
            this.colProductType.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colProductType.FieldName = "ProductType";
            this.colProductType.LayoutViewField = this.layoutViewField_colProductType;
            this.colProductType.Name = "colProductType";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageCollection1;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertImage(global::DXSample.Properties.Resources.Monitors, "Monitors", typeof(global::DXSample.Properties.Resources), 0);
            this.imageCollection1.Images.SetKeyName(0, "Monitors");
            this.imageCollection1.InsertImage(global::DXSample.Properties.Resources.Projectors, "Projectors", typeof(global::DXSample.Properties.Resources), 1);
            this.imageCollection1.Images.SetKeyName(1, "Projectors");
            this.imageCollection1.InsertImage(global::DXSample.Properties.Resources.TVs, "TVs", typeof(global::DXSample.Properties.Resources), 2);
            this.imageCollection1.Images.SetKeyName(2, "TVs");
            this.imageCollection1.InsertImage(global::DXSample.Properties.Resources.VideoPlayers, "VideoPlayers", typeof(global::DXSample.Properties.Resources), 3);
            this.imageCollection1.Images.SetKeyName(3, "VideoPlayers");
            // 
            // layoutViewField_colProductType
            // 
            this.layoutViewField_colProductType.EditorPreferredWidth = 127;
            this.layoutViewField_colProductType.Location = new System.Drawing.Point(0, 40);
            this.layoutViewField_colProductType.Name = "layoutViewField_colProductType";
            this.layoutViewField_colProductType.Size = new System.Drawing.Size(202, 20);
            this.layoutViewField_colProductType.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colID,
            this.layoutViewField_colOrderDate,
            this.layoutViewField_colProductType});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DXSample.ViewModels.OrderViewModel);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(561, 357);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colOrderDate;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colOrderDate;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colProductType;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colProductType;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}
