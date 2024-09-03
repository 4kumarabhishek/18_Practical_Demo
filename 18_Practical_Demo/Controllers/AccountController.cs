using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18_Practical_Demo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection values)
        {
            if (values["user"] == "admin" && values["pass"] == "12345")
            {
                Session["uname"] = "admin";
                return RedirectToAction("Personal", "Student");
            }

            else
            {
                ViewBag.msg = "Invalid";
                return View();
            }
                
        }
    }
}