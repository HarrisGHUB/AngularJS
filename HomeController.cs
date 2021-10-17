using SqlToJsonToAngularJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SqlToJsonToAngularJS.Controllers
{
    
    public class HomeController : Controller
    {
        db_angularJSEntities db = new db_angularJSEntities();

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllEmployee()
        {
            List<tbl_employee> emplist = db.tbl_employee.ToList();
            List<employeeviewmodel> li = emplist.Select(x => new employeeviewmodel
            {
                emp_id = x.emp_id,
                emp_name=x.emp_name,
                emp_salary=x.emp_salary,
                emp_department=x.emp_department,
                dept_name=x.tbl_department.dept_name

            }).ToList();
            return Json(li,JsonRequestBehavior.AllowGet);
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