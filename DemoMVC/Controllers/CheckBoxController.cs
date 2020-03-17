using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class CheckBoxController : Controller
    {
        // GET: CheckBox
        public ActionResult Index()
        {
            List<EMPDATA> L=ChechBox.GetEmp();
            return View(L);
        }
        public ActionResult GetEmpdata(int[] ch)
        {
            List<EMPDATA> L1= ChechBox.GetEmpData(ch);
            return View(L1);
            
        }
    }
}