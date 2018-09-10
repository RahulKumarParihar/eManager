using System.Collections.Generic;

namespace eManager.Domain
{
    public class Department
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        public virtual int ID { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        ///     Gets or sets the employees.
        /// </summary>
        /// <value>
        ///     The employees.
        /// </value>
        public virtual ICollection<Employee> Employees { get; set; }
    }
}