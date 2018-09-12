using System.Web.Mvc;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepartmentDataSource _db;

        /// <summary>
        ///     Initializes a new instance of the <see cref="HomeController" /> class.
        /// </summary>
        /// <param name="db">The database.</param>
        public HomeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        /// <summary>
        ///     Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var allDepartments = _db.Departments;
            return View(allDepartments);
        }

        /// <summary>
        ///     Abouts this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        ///     Contacts this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}