using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    //with submit button
    public class EventEx2Controller : Controller
    {
        // GET: EventEx2
        public ActionResult Index()
        {
            ViewBag.EL = DBOperations.delDept();
            return View();
        }
        public ActionResult DelEmp()
        {
            int empno = int.Parse(Request.Form["ddlEmpno"]);
            ViewBag.msg = DBOperations.DeleteEmp(empno);
            ViewBag.EL = DBOperations.delDept();
            return View("Index");
        }
    }
}