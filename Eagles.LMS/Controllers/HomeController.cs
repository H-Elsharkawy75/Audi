using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Eagles.LMS.BLL;
using Eagles.LMS.DTO;
using Eagles.LMS.Models;

namespace Eagles.LMS.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork ctx = new UnitOfWork();
        // GET: Home
        public ActionResult Index()
        {
            
            //return Redirect("/Admission");
            return View();
        }

        public ActionResult Price()
        {

            //return Redirect("/Admission");
            return View();
        }
        public ActionResult Engine()
        {

            //return Redirect("/Admission");
            return View();
        }
        public ActionResult Equipment()
        {

            return View();
        }
        
        public ActionResult Colour()
        {

            return View();
        }

        public ActionResult Form1()
        {

            return View();
        }
        public ActionResult Results()
        {

            return View();
        }

        public ActionResult ChangeLanguage(string SelectedLanguage, string redirect)
        {

            var controller = RouteData.Values["controller"].ToString();
            var action = RouteData.Values["action"].ToString(); ;
            if (SelectedLanguage != null)
            {
                Thread.CurrentThread.CurrentCulture =
                    CultureInfo.CreateSpecificCulture(SelectedLanguage);
                Thread.CurrentThread.CurrentUICulture =
                    new CultureInfo(SelectedLanguage);
                var cookie = new HttpCookie("Language");
                cookie.Value = SelectedLanguage;
                Response.Cookies.Add(cookie);
            }
            if (redirect == null)
                redirect = "/";
            return Redirect(redirect);
        }

        public ActionResult Changethems(string redirect)
        {

            var controller = RouteData.Values["controller"].ToString();
            var action = RouteData.Values["action"].ToString(); ;


            var cookie = Request.Cookies["thems"];
            if (cookie == null)
            {
                cookie = new HttpCookie("thems");
                cookie.Value = "default";
            }
            else
            {
                cookie.Value = (cookie.Value == "dark") ? "default" : "dark";
            }
            Response.Cookies.Add(cookie);
            if (redirect == null)
                redirect = "/";
            return Redirect(redirect);
        }





        public ActionResult indextwo()
        {
            return View();
        }

        public ActionResult indexhreee()
        {
            return View();
        }


    }
}