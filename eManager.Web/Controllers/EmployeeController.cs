using System.Linq;
using System.Web.Mvc;
using eManager.Domain;
using eManager.Web.Models;

namespace eManager.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDepartmentDataSource _db;

        /// <summary>
        ///     Initializes a new instance of the <see cref="EmployeeController" /> class.
        /// </summary>
        /// <param name="db">The database.</param>
        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        // GET: Employee
        /// <summary>
        ///     Creates the specified department identifier.
        /// </summary>
        /// <param name="DepartmentId">The department identifier.</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create(int DepartmentId)
        {
            var Model = new CreateEmployeeViewModel();
            Model.DepartmentID = DepartmentId;
            return View();
        }

        /// <summary>
        ///     Creates the specified create employee.
        /// </summary>
        /// <param name="createEmployee">The create employee.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel createEmployee)
        {
            if (ModelState.IsValid)
            {
                var department = _db.Departments.Single(x => x.ID == createEmployee.DepartmentID);
                var employee = new Employees();
                employee.Name = createEmployee.Name;
                employee.HireDate = createEmployee.HireDate;
                department.Employees.Add(employee);

                _db.Save();

                return RedirectToAction("Details", "Department", new {id = createEmployee.DepartmentID});
            }
            return View(createEmployee);
        }
    }
}