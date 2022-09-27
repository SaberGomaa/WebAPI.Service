using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Service.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } 
            = new HashSet<Employee>();
    }
}