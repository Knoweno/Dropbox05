using Microsoft.AspNetCore.Mvc;

namespace Dropbox05.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Employee/AddEmployee 
        public ActionResult AddEmployee()
        {
            return View();
        }
        //Employee/AllEmployee 
        public ActionResult AllEmployee()
        {
            return View();
        }
    }
}
