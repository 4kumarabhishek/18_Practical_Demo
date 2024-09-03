using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18_Practical_Demo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ViewResult Personal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Personal(string sname, string contact, string address)
        {
            if(sname==""|| contact=="" || address == "")
            {
                ViewBag.msg = "Please enter valid details";
                return View();
            }
            else
            {
                TempData["name"] = sname;
                TempData["contact"] = contact;
                TempData["address"] = address;

                return RedirectToAction("Marks");
            }
        }

        public ViewResult Marks()
        {
            return View();
        }
    }
}