using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult GetEmpName(int EmpId)
        {
            var employees = new[] {
                new {EmpId = 1, EmpName = "Scott", Salary = 8000},
                new {EmpId = 2, EmpName = "Smith", Salary = 2540},
                new {EmpId = 3, EmpName = "Allen", Salary = 9400}
            };
            string matchEmpName = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }
            //return new ContentResult() { Content = matchEmpName, ContentType = "text/plain"};
            return Content(matchEmpName, "text/plain");
        }
        public ActionResult GetPaySlip(int EmpId)
        {
            string fileName = "~/PaySlip" + EmpId + ".pdf";
            return File(fileName, "application/pdf");
        }
    }
}