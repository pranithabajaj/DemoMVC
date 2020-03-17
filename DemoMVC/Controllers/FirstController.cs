using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            ViewBag.str = "My First MVC Project";
            ViewData["str1"] = "Pranitha";
            TempData["str2"] = "Bajaj";
            return View();
        }
        public ActionResult SendObject()
        {
            FirstEmp E = new FirstEmp();
            E.Empno = 1;
            E.Ename = "Pranitha";
            E.Salary = 20000;

            return View(E);
        }
        public ActionResult SendObjects()
        {
            List<FirstEmp> L = new List<FirstEmp>();
            FirstEmp E = null;
            E = new FirstEmp();
            E.Empno = 2;
            E.Ename = "Bajaj";
            E.Salary = 10000;
            L.Add(E);

            E = new FirstEmp();
            E.Empno = 3;
            E.Ename = "Ram";
            E.Salary = 20000;
            L.Add(E);
            return View(L);
        }
        public ActionResult SendObjectVB()
        {
            FirstEmp E = null;
            E = new FirstEmp();
            E.Empno = 2;
            E.Ename = "Bajaj";
            E.Salary = 10000;
            ViewBag.emp = E;
            ViewData["a"] = E;
            return View();
        }
        public ActionResult SendObjectsVB()
        {
            List<FirstEmp> L = new List<FirstEmp>();
            FirstEmp E = null;
            E = new FirstEmp();
            E.Empno = 2;
            E.Ename = "Bajaj";
            E.Salary = 10000;
            L.Add(E);

            E = new FirstEmp();
            E.Empno = 3;
            E.Ename = "Ram";
            E.Salary = 30000;
            L.Add(E);
            ViewBag.emp = L;
            ViewData["a"] = L;
            return View();
        }
    }
}