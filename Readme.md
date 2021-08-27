<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128614871/15.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T328880)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ModuleDescription.cs](./CS/WindowsApplication3/Common/ModuleDescription.cs) (VB: [ModuleDescription.vb](./VB/WindowsApplication3/Common/ModuleDescription.vb))
* [BaseViewModel.cs](./CS/WindowsApplication3/Common/ViewModels/BaseViewModel.cs) (VB: [BaseViewModel.vb](./VB/WindowsApplication3/Common/ViewModels/BaseViewModel.vb))
* [ViewModelLogicalLayoutHelper.cs](./CS/WindowsApplication3/Common/ViewModels/ViewModelLogicalLayoutHelper.cs) (VB: [ViewModelLogicalLayoutHelper.vb](./VB/WindowsApplication3/Common/ViewModels/ViewModelLogicalLayoutHelper.vb))
* [MainView.cs](./CS/WindowsApplication3/MainView.cs) (VB: [MainView.vb](./VB/WindowsApplication3/MainView.vb))
* [Customer.cs](./CS/WindowsApplication3/Models/Customer.cs) (VB: [Customer.vb](./VB/WindowsApplication3/Models/Customer.vb))
* [Order.cs](./CS/WindowsApplication3/Models/Order.cs) (VB: [Order.vb](./VB/WindowsApplication3/Models/Order.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
* [CustomerViewModel.cs](./CS/WindowsApplication3/ViewModels/CustomerViewModel.cs) (VB: [CustomerViewModel.vb](./VB/WindowsApplication3/ViewModels/CustomerViewModel.vb))
* [DocumentsViewModel.cs](./CS/WindowsApplication3/ViewModels/DocumentsViewModel.cs) (VB: [DocumentsViewModel.vb](./VB/WindowsApplication3/ViewModels/DocumentsViewModel.vb))
* [OrderViewModel.cs](./CS/WindowsApplication3/ViewModels/OrderViewModel.cs) (VB: [OrderViewModel.vb](./VB/WindowsApplication3/ViewModels/OrderViewModel.vb))
* [CustomerView.cs](./CS/WindowsApplication3/Views/CustomerView.cs) (VB: [CustomerView.vb](./VB/WindowsApplication3/Views/CustomerView.vb))
* [OrderView.cs](./CS/WindowsApplication3/Views/OrderView.cs) (VB: [OrderView.vb](./VB/WindowsApplication3/Views/OrderView.vb))
<!-- default file list end -->
# How to save opened documents, their layout and layout of the documents' views 


<p>If you show multiple documents by using the <strong>DocumentManagerService</strong>, and then close and re-open your application, you will observe that these previously opened documents are no longer shown.<br><br></p>
<p>This example illustrates how to preserve opened documents. To achieve this goal, we use the inner static <strong>LogicalLayoutSerializationHelper</strong> class. This class allows you to store documents only if a View Model implements the <strong>ISupportLogicalLayout</strong> interface. The <strong>LogicalLayoutSerializationHelper</strong> stores documents to a string by using document’s id, title, and type. To save documents, we use the<strong> LogicalLayoutSerializationHelper.Serialize</strong> or an extension <strong>ISupportLogicalLayout.SerializeDocumentManagerService</strong> method. After this method is called, we save this string to the <strong>Application Settings</strong>. You are free to save this string in any other way.<br><br></p>
<p>When we restore the opened documents, the <strong>LogicalLayoutSerializationHelper</strong> loads the necessary document information from the saved string. Then, by using <strong>DocumentManagerService</strong>, new documents are created with the saved document’s id, title, and type. That is why these documents show correct Views.<br><br></p>
<p>Now, when opened documents are restored properly, we can see that visual layout of these documents together with layout of their Views are not preserved. To save this layout as well, we use a special <strong>LayoutSerializationService</strong>. This service uses the <strong>WorkspaceManagerSerializer</strong> class, which is used by our <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument17674">WorkspaceManager</a> internally. Thus, the <strong>LayoutSerializationService</strong> allows you to save the layout of multiple controls and components located on your main View. </p>

<br/>


