using LoginDB.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Index(Login log)
        {
            using (LoginDBContext db = new LoginDBContext())
            {
                var user = db.Logins.Where(x => x.username == log.username && x.password == log.password).Count();
                if (user>0)
                {
                    Session["user"] = log.username;

                    //HttpCookie kt = new HttpCookie("user", log.username);
                    //HttpCookie kt1 = new HttpCookie("pass", log.password);
                    //Response.Cookies.Add(kt);
                    //Response.Cookies.Add(kt1);
                    //Response.Cookies["user"].Value = log.username;

                    //to make it persistent
                    //kt.Expires = DateTime.Now.AddSeconds(30);  

                    return RedirectToAction("DashBoard");
                }
                else
                {
                    return View();
                }
            }
        }
        public ActionResult LogOut()
        {
            Session.Remove("user");
            return RedirectToAction("index","home");
        }
        public ActionResult DashBoard()
        {
            return View();
        }


    }
}