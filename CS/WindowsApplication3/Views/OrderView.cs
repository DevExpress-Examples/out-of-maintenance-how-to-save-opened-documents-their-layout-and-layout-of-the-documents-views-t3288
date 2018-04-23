using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DXSample.ViewModels;
using DevExpress.XtraEditors.Controls;

namespace DXSample.Views {
    [DevExpress.Utils.MVVM.UI.ViewType("OrderView")]
    public partial class OrderView : UserControl {
        public OrderView() {
            InitializeComponent();
            if (!DesignMode) {
                var fluentApi = mvvmContext.OfType<OrderViewModel>();
                fluentApi.SetObjectDataSourceBinding(bindingSource, x => x.Entities);
            }
            InitImageComboBox();
        }
        private void InitImageComboBox() {
            for (int i = 0; i < imageCollection1.Images.Count; i++) {
                repositoryItemImageComboBox1.Items.Add(new ImageComboBoxItem(i, i));
            }
        }
    }
}
