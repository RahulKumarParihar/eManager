using System.Data.Entity;
using System.Linq;
using eManager.Domain;

namespace eManager.Web.Infrastructure
{
    public class DepartmentDb : DbContext, IDepartmentDataSource
    {
        /// <summary>
        ///     Gets or sets the employees.
        /// </summary>
        /// <value>
        ///     The employees.
        /// </value>
        public DbSet<Employees> Employees { get; set; }

        /// <summary>
        ///     Gets or sets the departments.
        /// </summary>
        /// <value>
        ///     The departments.
        /// </value>
        public DbSet<Departments> Departments { get; set; }

        /// <summary>
        ///     Gets the employees.
        /// </summary>
        /// <value>
        ///     The employees.
        /// </value>
        IQueryable<Employees> IDepartmentDataSource.Employees => Employees;

        /// <summary>
        ///     Gets the departments.
        /// </summary>
        /// <value>
        ///     The departments.
        /// </value>
        IQueryable<Departments> IDepartmentDataSource.Departments => Departments;

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save() => SaveChanges();
    }
}