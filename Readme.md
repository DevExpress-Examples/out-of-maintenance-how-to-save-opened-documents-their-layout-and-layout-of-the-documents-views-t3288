# How to save opened documents, their layout and layout of the documents' views 


<p>If you show multiple documents by using the <strong>DocumentManagerService</strong>, and then close and re-open your application, you will observe that these previously opened documents are no longer shown.<br><br></p>
<p>This example illustrates how to preserve opened documents. To achieve this goal, we use the inner static <strong>LogicalLayoutSerializationHelper</strong> class. This class allows you to store documents only if a View Model implements the <strong>ISupportLogicalLayout</strong> interface. The <strong>LogicalLayoutSerializationHelper</strong> stores documents to a string by using document’s id, title, and type. To save documents, we use the<strong> LogicalLayoutSerializationHelper.Serialize</strong> or an extension <strong>ISupportLogicalLayout.SerializeDocumentManagerService</strong> method. After this method is called, we save this string to the <strong>Application Settings</strong>. You are free to save this string in any other way.<br><br></p>
<p>When we restore the opened documents, the <strong>LogicalLayoutSerializationHelper</strong> loads the necessary document information from the saved string. Then, by using <strong>DocumentManagerService</strong>, new documents are created with the saved document’s id, title, and type. That is why these documents show correct Views.<br><br></p>
<p>Now, when opened documents are restored properly, we can see that visual layout of these documents together with layout of their Views are not preserved. To save this layout as well, we use a special <strong>LayoutSerializationService</strong>. This service uses the <strong>WorkspaceManagerSerializer</strong> class, which is used by our <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument17674">WorkspaceManager</a> internally. Thus, the <strong>LayoutSerializationService</strong> allows you to save the layout of multiple controls and components located on your main View. </p>

<br/>


