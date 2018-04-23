using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DXSample.Common.ViewModels;
using DXSample.MVVM;

namespace DXSample.ViewModels {
    public class DocumentsViewModel : ISupportLogicalLayout {
        const string ViewLayoutName = "DocumentsViewModel";
        public DocumentsViewModel() {
            Modules = CreateModules();
        }
        public ModuleDescription[] Modules { get; private set; }
        protected IDocumentManagerService DocumentManagerService { get { return this.GetService<IDocumentManagerService>(); } }
        protected ILayoutSerializationService LayoutSerializationService { get { return this.GetService<ILayoutSerializationService>(); } }
        #region ISupportLogicalLayout
        public IEnumerable<object> LookupViewModels {
            get { return null; }
        }
        IDocumentManagerService ISupportLogicalLayout.DocumentManagerService {
            get { return DocumentManagerService; }
        }
        public bool CanSerialize {
            get { return true; }
        }
        #endregion
        public virtual void OnClosing(CancelEventArgs cancelEventArgs) {
            SaveLogicalLayout();
            if (LayoutSerializationService != null) {
                ViewModelLogicalLayoutHelper.PersistentViewsLayout[ViewLayoutName] = LayoutSerializationService.Serialize();
            }
            ViewModelLogicalLayoutHelper.SaveLayout();
        }
        public void SaveLogicalLayout() {
            ViewModelLogicalLayoutHelper.PersistentLogicalLayout = LogicalLayoutSerializationHelper.SerializeDocumentManagerService(this);
        }
        public void Show(ModuleDescription module) {
            ShowCore(module);
        }
        public IDocument ShowCore(ModuleDescription module) {
            if (module == null || DocumentManagerService == null)
                return null;
            IDocument document = DocumentManagerService.FindDocumentByIdOrCreate(module.DocumentType, x => CreateDocument(module));
            document.Show();
            return document;
        }
        IDocument CreateDocument(ModuleDescription module) {
            var document = DocumentManagerService.CreateDocument(module.DocumentType, null, this);
            document.Title = module.Title;
            document.DestroyOnClose = false;
            return document;
        }
        public virtual void OnLoaded() {
            RestoreLogicalLayout();
            string state = null;
            if (LayoutSerializationService != null && ViewModelLogicalLayoutHelper.PersistentViewsLayout.TryGetValue(ViewLayoutName, out state)) {
                LayoutSerializationService.Deserialize(state);
            }
        }
        public bool RestoreLogicalLayout() {
            if (string.IsNullOrWhiteSpace(ViewModelLogicalLayoutHelper.PersistentLogicalLayout))
                return false;
            this.RestoreDocumentManagerService(ViewModelLogicalLayoutHelper.PersistentLogicalLayout);
            return true;
        }
        protected ModuleDescription[] CreateModules() {
            return new ModuleDescription[] {
                new ModuleDescription("CustomerView", "Customers"),
                new ModuleDescription("OrderView", "Orders")
			};
        }
        
    }
}
