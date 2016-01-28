using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessTemplateFullPage.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tinh_nang()
        {
            return View();
        }
         
        public ActionResult Dich_vu()
        {
            return View();
        }

        public ActionResult San_pham()
        {
            return View();
        }

        public ActionResult Gioi_thieu()
        {
            return View();
        }

        public ActionResult Tin_tuc(String id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                return View();
            }
            else
            {
                ViewBag.Title = id;
                return View("BlogDetail");
            }
        }

        public ActionResult Lien_he()
        {
            return View();
        } 
    }
}
