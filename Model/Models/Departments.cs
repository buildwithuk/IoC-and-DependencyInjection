using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
