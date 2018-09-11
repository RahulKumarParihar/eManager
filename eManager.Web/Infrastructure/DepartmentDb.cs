using System;
using System.Data.Entity;
using System.Linq;
using eManager.Domain;

namespace eManager.Web.Infrastructure
{
    public class DepartmentDb : DbContext, IDepartmentDataSource
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        IQueryable<Employee> IDepartmentDataSource.Employees => Employees;

        IQueryable<Department> IDepartmentDataSource.Departments => Departments;
    }
}