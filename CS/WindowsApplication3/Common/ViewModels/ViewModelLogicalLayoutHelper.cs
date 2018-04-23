using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;

namespace DXSample.Common.ViewModels {
    public class ViewModelLogicalLayoutHelper {
        public static string PersistentLogicalLayout {
            get { return LayoutSettings.Default.LogicalLayout; }
            set { LayoutSettings.Default.LogicalLayout = value; }
        }
        static Dictionary<string, string> persistentViewsLayout;
        public static Dictionary<string, string> PersistentViewsLayout {
            get {
                if (persistentViewsLayout == null) {
                    persistentViewsLayout = LogicalLayoutSerializationHelper.Deserialize(LayoutSettings.Default.ViewsLayout);
                }
                return persistentViewsLayout;
            }
        }
        public static void SaveLayout() {
            LayoutSettings.Default.ViewsLayout = LogicalLayoutSerializationHelper.Serialize(PersistentViewsLayout);
            LayoutSettings.Default.Save();
        }
        public static void ResetLayout() {
            PersistentViewsLayout.Clear();
            PersistentLogicalLayout = null;
            SaveLayout();
        }
    }
}
