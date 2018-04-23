using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DXSample.ViewModels;


namespace DXSample {
    public partial class MainView : XtraForm {
        public MainView() {
            InitializeComponent();
            mvvmContext.RegisterService(DevExpress.Utils.MVVM.Services.LayoutSerializationService.Create(this, true));
            IDocumentManagerService service = (IDocumentManagerService)DevExpress.Utils.MVVM.Services.DocumentManagerService.Create(dockManager);
            mvvmContext.RegisterService(service);
            var fluentAPI = mvvmContext.OfType<DocumentsViewModel>();
            fluentAPI.WithEvent(this, "Load")
               .EventToCommand(x => x.OnLoaded());
            fluentAPI.WithEvent<FormClosingEventArgs>(this, "FormClosing")
                .EventToCommand(x => x.OnClosing(null), new Func<CancelEventArgs, object>((args) => args));
            fluentAPI.BindCommand(showCustomersBtn, (x, m) => x.Show(m), x => x.Modules[0]);
            fluentAPI.BindCommand(showOrdersBtn, (x, m) => x.Show(m), x => x.Modules[1]);
        }
    }
}

