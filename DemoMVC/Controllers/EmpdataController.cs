using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class EmpdataController : Controller
    {
        // GET: Empdata
        List<EMPDATA> list1 = null;
        public ActionResult Index()
        {
            list1 = DBOperations.delDept();
            return View(list1);
        }
        public ActionResult GetEmp()
        {
            //int empno = Convert.ToInt32(Request.Form["rdb"].ToString());
            int empno = int.Parse(Request.Form["rdb"]);
            EMPDATA E = DBOperations.GetDetails(empno);
            return View(E);
        }
    }
}