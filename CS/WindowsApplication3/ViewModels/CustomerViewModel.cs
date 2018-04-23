using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;
using DXSample.Common.ViewModels;

namespace DXSample.MVVM {

    public class CustomerViewModel : BaseViewModel<Customer> {
        protected override void LoadEntities() {
            base.LoadEntities();
            for (int i = 0; i < 10; i++) {
                Entities.Add(new Customer() { ID = Entities.Count, Name = string.Format("Test Name {0}", Entities.Count) });
            } 
        }
    }
}
