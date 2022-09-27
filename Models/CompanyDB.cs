using System;
using System.Data.Entity;
using System.Linq;
using System.Xml;

namespace WebAPI.Service.Models
{
    public class CompanyDB : DbContext
    {
        public CompanyDB()
            : base(@"Data source = SABER;Initial catalog = companyDaBase;User Id = saber ; Password = 123456789 ;")
        {
            // To remove self reference loop for all models instead [JsonIgnore]
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Department> Departments { get; set; }
    }

}