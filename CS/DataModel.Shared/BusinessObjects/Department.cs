using System;
using System.Collections.ObjectModel;
using DevExpress.Persistent.BaseImpl.EF;

namespace DataModel.Shared.BusinessObjects {
    public class Department : BaseObject {

        public virtual string Title { get; set; }

        public virtual string Office { get; set; }

        public virtual IList<Employee> Employees { get; set; } = new ObservableCollection<Employee>();

        public override string ToString() {
            return Title;
        }
    }
}
