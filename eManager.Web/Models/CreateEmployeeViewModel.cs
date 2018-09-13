using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace eManager.Web.Models
{
    public class CreateEmployeeViewModel
    {
        /// <summary>
        ///     Gets or sets the department identifier.
        /// </summary>
        /// <value>
        ///     The department identifier.
        /// </value>
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int DepartmentID { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the hire date.
        /// </summary>
        /// <value>
        ///     The hire date.
        /// </value>
        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}