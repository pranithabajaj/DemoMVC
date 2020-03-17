using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class EventsExController : Controller
    {
        // GET: EventsEx
        public ActionResult Index()
        {
            //step1,delDept retrive all dept data
            ViewBag.EL = DBOperations.delDept();
            return View();
        }
        public ActionResult GetData()
        {
            //Request.Form will not work for onblur,onchange ;it will only work for submit
            //int empno = int.Parse(Request.Form["ddlEmpno"]);
            int empno = int.Parse(Request.QueryString["empno"]);
            ViewBag.msg=DBOperations.DeleteEmp(empno);
            //to get the data after refreshing
            ViewBag.EL = DBOperations.delDept();
            return View("Index");
        }
    }
}