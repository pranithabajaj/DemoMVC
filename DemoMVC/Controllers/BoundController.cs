using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class BoundController : Controller
    {
        // GET: Bound
        //to send empty object from controller to view
        public ActionResult Index()
        {
            FirstEmp E = new FirstEmp();
            return View(E);
        }
        public ActionResult Display(FirstEmp A)
        {
            return View(A);
        }
        public ActionResult Index1()
        {
            FirstEmp E = new FirstEmp();
            return View(E);
        }
        [HttpPost]
        public ActionResult Index1(FirstEmp E)
        {
            return View("Display",E);
        }
        public ActionResult UnBound()
        {
            return View();
        }
        public ActionResult ShowData()
        {
            FirstEmp E = new FirstEmp();
            E.Empno = int.Parse(Request.Form["txtEmpno"]);
            E.Ename = Request.Form["txtEname"];
            E.Salary = Double.Parse(Request.Form["txtSalary"]);
            return View(E);
        }
    }
}