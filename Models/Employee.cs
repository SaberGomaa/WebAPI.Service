using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebAPI.Service.Models
{
    public class Employee
    {
        //already Serializable
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        [IgnoreDataMember]
        public  Department department { get; set; }

    }
}