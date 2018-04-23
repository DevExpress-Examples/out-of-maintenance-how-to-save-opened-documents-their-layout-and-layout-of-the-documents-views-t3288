Imports System
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Threading
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.XtraEditors

Namespace DXSample
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
            SkinManager.EnableFormSkins()
            SkinManager.EnableMdiFormSkins()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MainView())
        End Sub
    End Class
End Namespace