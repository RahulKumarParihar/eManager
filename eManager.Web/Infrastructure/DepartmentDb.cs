using System;
using System.Data.Entity;
using System.Linq;
using eManager.Domain;

namespace eManager.Web.Infrastructure
{
    public class DepartmentDb : DbContext, IDepartmentDataSource
    {
        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        public DbSet<Employee> Employees { get; set; }
        /// <summary>
        /// Gets or sets the departments.
        /// </summary>
        /// <value>
        /// The departments.
        /// </value>
        public DbSet<Department> Departments { get; set; }

        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        IQueryable<Employee> IDepartmentDataSource.Employees => Employees;

        /// <summary>
        /// Gets the departments.
        /// </summary>
        /// <value>
        /// The departments.
        /// </value>
        IQueryable<Department> IDepartmentDataSource.Departments => Departments;
    }
}