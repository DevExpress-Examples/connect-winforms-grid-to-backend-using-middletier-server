using System.ComponentModel.DataAnnotations;
using DevExpress.Persistent.BaseImpl.EF;

namespace DataModel.Shared.BusinessObjects {
    public class Employee : BaseObject {

        [Required()]
        public virtual String FirstName { get; set; }

        [Required()]
        public virtual String LastName { get; set; }

        public virtual DateTime? Birthday { get; set; }

        [MaxLength(255)]
        public virtual String Email { get; set; }

        public virtual Department Department { get; set; }

        public string FullName {
            get { return $"{FirstName} {LastName}"; }
        }

        public void CopyToContextObject(Employee contextObj, DXApplication1EFCoreDbContext dbContext) {
            contextObj.FirstName = this.FirstName;
            contextObj.LastName = this.LastName;
            contextObj.Birthday = this.Birthday;
            contextObj.Email = this.Email;
            if(this.Department != null)
                contextObj.Department = dbContext.Departments.First(n => n.ID == this.Department.ID);
            else
                contextObj.Department = null;
        }
    }
}
