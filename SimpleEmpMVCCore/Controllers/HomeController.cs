using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleEmpMVCCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleEmpMVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Employee> empList = new List<Employee>();

            Employee e1 = new Employee() { Empno = 78979, Ename = "Scott", Job = "Manager" };
            Employee e2 = new Employee() { Empno = 88979, Ename = "Smith", Job = "Lead" };
            Employee e3 = new Employee() { Empno = 98979, Ename = "Sam", Job = "Tech Support" };
            Employee e4 = new Employee() { Empno = 68979, Ename = "Sandy", Job = "Programmer" };

            empList.Add(e1);
            empList.Add(e2);
            empList.Add(e3);
            empList.Add(e4);


            return View(empList);
        }

        // GET: Emps
        public ActionResult Details()
        {

            ViewBag.Info = "This page demonstrate sharing data between controller to View";

            Employee obj = new Employee();
            obj.Empno = 10256;
            obj.Ename = "Scott";
            obj.Job = "Manager";

            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
