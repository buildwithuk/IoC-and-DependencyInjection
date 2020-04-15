using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Departments Department { get; set; }
    }
}
