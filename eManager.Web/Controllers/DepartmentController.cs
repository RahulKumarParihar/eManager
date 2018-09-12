using System.Linq;
using System.Web.Mvc;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentDataSource _db;

        /// <summary>
        ///     Initializes a new instance of the <see cref="DepartmentController" /> class.
        /// </summary>
        /// <param name="db">The database.</param>
        public DepartmentController(IDepartmentDataSource db)
        {
            _db = db;
        }

        // GET: Department/Details/5
        /// <summary>
        ///     Detailses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            var model = _db.Departments.Single(x => x.ID == id);
            return View(model);
        }
    }
}