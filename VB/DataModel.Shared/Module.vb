Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating

Namespace DataModel.Shared

    ' For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ModuleBase.
    Public NotInheritable Class DXApplication1Module
        Inherits ModuleBase

        Public Sub New()
            ' 
            ' DXApplication1Module
            ' 
            Me.AdditionalExportedTypes.Add(GetType(BusinessObjects.ApplicationUser))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.EF.PermissionPolicy.PermissionPolicyRole))
            Me.RequiredModuleTypes.Add(GetType(SystemModule.SystemModule))
            Me.RequiredModuleTypes.Add(GetType(Security.SecurityModule))
            Me.RequiredModuleTypes.Add(GetType(Objects.BusinessClassLibraryCustomizationModule))
            Me.RequiredModuleTypes.Add(GetType(ConditionalAppearance.ConditionalAppearanceModule))
            Me.RequiredModuleTypes.Add(GetType(Validation.ValidationModule))
            Security.SecurityModule.UsedExportedTypes = DevExpress.Persistent.Base.UsedExportedTypes.Custom
        End Sub

        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
            Return New ModuleUpdater() {updater}
        End Function

        Public Overrides Sub Setup(ByVal application As XafApplication)
            MyBase.Setup(application)
        ' Manage various aspects of the application UI and behavior at the module level.
        End Sub
    End Class
End Namespace
