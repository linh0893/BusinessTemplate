using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessTemplateFullPage.Models;

namespace BusinessTemplateFullPage.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        CoreDB DB = new CoreDB();

        public HomeController()
        {
            ViewBag.category = DB.Categories;
        }

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

        public ActionResult San_pham(int Category = 0, int page = 0, String Search = "")
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
            ViewBag.company = DB.CompanyInfors.FirstOrDefault();
            if (ViewBag.company == null)
            {
                ViewBag.company = new CompanyInfor();
            }
            return View();
        } 
    }
}
