using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DXSample.Common.ViewModels {
    public class BaseViewModel<T> : ISupportLogicalLayout, ISupportParentViewModel
       where T : class {
       public BaseViewModel() {
            Entities = new BindingList<T>();
            LoadEntities();
        }
        protected virtual void LoadEntities() {
        }
        public virtual T SelectedEntity { get; set; }
        public virtual BindingList<T> Entities { get; set; }
        #region ISupportLogicalLayout
        public bool CanSerialize {
            get { return true; }
        }
        public IDocumentManagerService DocumentManagerService {
            get { return this.GetRequiredService<IDocumentManagerService>(); }
        }
        public IEnumerable<object> LookupViewModels {
            get {return null; }
        }
        #endregion
        #region ISupportParentViewModel
        object _parentViewModel;
        public object ParentViewModel {
            get {
               return _parentViewModel;
            }
            set {
                if (_parentViewModel != value)
                    _parentViewModel = value;
            }
        }
        #endregion
    }
}
