using System.Data;
using DataModel.Shared.BusinessObjects;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using Microsoft.Extensions.DependencyInjection;

namespace DataModel.Shared.DatabaseUpdate;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
public class Updater : ModuleUpdater {
    private const string AdministratorUserName = "Admin";
    private const string AdministratorRoleName = "Administrators";
    private const string DefaultUserName = "User";
    private const string DefaultUserRoleName = "Users";

    public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
        base(objectSpace, currentDBVersion) {
    }
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();
        CreateUser();
        CreateAdmin();
        CreateEmployees();
    }

    private void CreateUser() {
        UserManager userManager = ObjectSpace.ServiceProvider.GetRequiredService<UserManager>();
        // If a user named 'User' doesn't exist in the database, create this user
        if(userManager.FindUserByName<ApplicationUser>(ObjectSpace, DefaultUserName) == null) {
            // Set a password if the standard authentication type is used
            string EmptyPassword = "";
            _ = userManager.CreateUser<ApplicationUser>(ObjectSpace, DefaultUserName, EmptyPassword, (user) => {
                // Add the Users role to the user
                user.Roles.Add(GetUserRole());
            });
            ObjectSpace.CommitChanges();
        }
    }

    private void CreateAdmin() {
        UserManager userManager = ObjectSpace.ServiceProvider.GetRequiredService<UserManager>();
        // If a user named 'Admin' doesn't exist in the database, create this user
        if(userManager.FindUserByName<ApplicationUser>(ObjectSpace, AdministratorUserName) == null) {
            // Set a password if the standard authentication type is used
            string EmptyPassword = "";
            _ = userManager.CreateUser<ApplicationUser>(ObjectSpace, AdministratorUserName, EmptyPassword, (user) => {
                // Add the Administrators role to the user
                user.Roles.Add(GetAdminRole());
            });
            ObjectSpace.CommitChanges();
        }
    }

    private PermissionPolicyRole GetAdminRole() {
        PermissionPolicyRole adminRole = ObjectSpace.FirstOrDefault<PermissionPolicyRole>(u => u.Name == AdministratorRoleName);
        if(adminRole == null) {
            adminRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
            adminRole.Name = AdministratorRoleName;
            adminRole.IsAdministrative = true;
        }
        return adminRole;
    }

    private PermissionPolicyRole GetUserRole() {
        PermissionPolicyRole userRole = ObjectSpace.FirstOrDefault<PermissionPolicyRole>(u => u.Name == DefaultUserRoleName);
        if(userRole == null) {
            userRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
            userRole.Name = DefaultUserRoleName;
            userRole.AddTypePermission<Employee>(SecurityOperations.Read, SecurityPermissionState.Allow);
            // Users have only read-only access to Employee records.
            userRole.AddTypePermission<Employee>(SecurityOperations.Write, SecurityPermissionState.Deny);
            // For more information on criteria language syntax (both string and strongly-typed formats), see https://docs.devexpress.com/CoreLibraries/4928/.
        }
        return userRole;
    }

    private void CreateEmployees() {
        // Create dataset
        if(!ObjectSpace.GetObjectsQuery<Employee>().Any()) {
            string shortName = "Employees.xml";
            string embeddedResourceName = Array.Find<string>(this.GetType().Assembly.GetManifestResourceNames(), (s) => {
                return s.Contains(shortName);
            });
            Stream stream = this.GetType().Assembly.GetManifestResourceStream(embeddedResourceName);
            if(stream == null) {
                throw new Exception(string.Format("Cannot read employees data from the {0} file!", shortName));
            }
            DataSet ds = new DataSet();
            ds.ReadXml(stream);

            foreach(DataRow employeeRow in ds.Tables["Employee"].Rows) {
                Employee employee = ObjectSpace.CreateObject<Employee>();
                employee.Email = Convert.ToString(employeeRow["EmailAddress"]);
                employee.FirstName = Convert.ToString(employeeRow["FirstName"]);
                employee.LastName = Convert.ToString(employeeRow["LastName"]);
                employee.Birthday = Convert.ToDateTime(employeeRow["BirthDate"]);

                string departmentTitle = Convert.ToString(employeeRow["GroupName"]);
                Department department = ObjectSpace.FirstOrDefault<Department>(d => d.Title == departmentTitle, true);
                if(department == null) {
                    department = ObjectSpace.CreateObject<Department>();
                    department.Title = departmentTitle;
                    Random rnd = new Random();
                    department.Office = $"{rnd.Next(1, 7)}0{rnd.Next(9)}";
                }
                employee.Department = department;
            }
            ObjectSpace.CommitChanges();
        }
    }
}
