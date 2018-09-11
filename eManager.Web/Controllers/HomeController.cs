using System.Web.Mvc;
using eManager.Domain;
using eManager.Web.Infrastructure;

namespace eManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private IDepartmentDataSource _db;

        public HomeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allDepartments = _db.Departments;
            return View(allDepartments);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}