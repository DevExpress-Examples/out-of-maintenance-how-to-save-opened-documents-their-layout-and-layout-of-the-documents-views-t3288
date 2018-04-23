using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.XtraEditors;

namespace DXSample.MVVM {
    [DevExpress.Utils.MVVM.UI.ViewType("CustomerView")]
    public partial class CustomerView : DevExpress.XtraEditors.XtraUserControl {
        public CustomerView() {
            InitializeComponent();
            if (!DesignMode) {
                var fluentApi = mvvmContext1.OfType<CustomerViewModel>();
                fluentApi.SetBinding(gridControl1, g => g.DataSource, x => x.Entities);
            }
        }
    }
}
