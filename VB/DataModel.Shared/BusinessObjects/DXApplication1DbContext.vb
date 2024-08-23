Imports DevExpress.ExpressApp.Design
Imports DevExpress.ExpressApp.EFCore.DesignTime
Imports DevExpress.Persistent.BaseImpl.EF.PermissionPolicy
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Design

Namespace DataModel.Shared.BusinessObjects

    ' This code allows our Model Editor to get relevant EF Core metadata at design time.
    ' For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
    Public Class DXApplication1ContextInitializer
        Inherits DbContextTypesInfoInitializerBase

        Protected Overrides Function CreateDbContext() As DbContext
            Dim optionsBuilder = New DbContextOptionsBuilder(Of DXApplication1EFCoreDbContext)().UseSqlServer(";").UseChangeTrackingProxies().UseObjectSpaceLinkProxies()
            Return New DXApplication1EFCoreDbContext(optionsBuilder.Options)
        End Function
    End Class

    'This factory creates DbContext for design-time services. For example, it is required for database migration.
    Public Class DXApplication1DesignTimeDbContextFactory
        Implements IDesignTimeDbContextFactory(Of DXApplication1EFCoreDbContext)

        Public Function CreateDbContext(ByVal args As String()) As DXApplication1EFCoreDbContext Implements IDesignTimeDbContextFactory(Of DXApplication1EFCoreDbContext).CreateDbContext
            Throw New InvalidOperationException("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.")
        'var optionsBuilder = new DbContextOptionsBuilder<DXApplication1EFCoreDbContext>();
        'optionsBuilder.UseSqlServer("Integrated Security=SSPI;Data Source=(localdb)\\mssqllocaldb;Initial Catalog=DXApplication1");
        'optionsBuilder.UseChangeTrackingProxies();
        'optionsBuilder.UseObjectSpaceLinkProxies();
        'return new DXApplication1EFCoreDbContext(optionsBuilder.Options);
        End Function
    End Class

    <TypesInfoInitializer(GetType(DXApplication1ContextInitializer))>
    Public Class DXApplication1EFCoreDbContext
        Inherits DbContext

        Public Sub New(ByVal options As DbContextOptions(Of DXApplication1EFCoreDbContext))
            MyBase.New(options)
        End Sub

        Public Property Roles As DbSet(Of PermissionPolicyRole)

        Public Property Users As DbSet(Of ApplicationUser)

        Public Property UserLoginInfos As DbSet(Of ApplicationUserLoginInfo)

        Public Property Employees As DbSet(Of Employee)

        Public Property Departments As DbSet(Of Department)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)
            MyBase.OnModelCreating(modelBuilder)
            modelBuilder.SetOneToManyAssociationDeleteBehavior(DeleteBehavior.SetNull, DeleteBehavior.Cascade)
            modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues)
            modelBuilder.UsePropertyAccessMode(PropertyAccessMode.PreferFieldDuringConstruction)
            modelBuilder.Entity(Of ApplicationUserLoginInfo)(Sub(b) b.HasIndex(NameOf(DevExpress.ExpressApp.Security.ISecurityUserLoginInfo.LoginProviderName), NameOf(DevExpress.ExpressApp.Security.ISecurityUserLoginInfo.ProviderUserKey)).IsUnique())
        End Sub
    End Class
End Namespace
