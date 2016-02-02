using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessTemplateFullPage.Models;
using BusinessTemplateFullPage.Services;

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

        public ActionResult San_pham(int Category = 0, int page = 1, String Search = null)
        {
            int test = DB.Products.ToList().Count;
            int ck = Config.ItemPerPage;

          
            ViewBag.Search = Search;
            ViewBag.page = page;
            ViewBag.categoryId = Category;

            //int price;
            //bool isNumeric = int.TryParse(Search, out n);
            List<Product> data = new List<Product>();
            if (Category != 0)
            {
               if (String.IsNullOrEmpty(Search))
               {
                   data = DB.Products.Where(p => p.Category_Id == Category ).ToList();
               }
               else
               {
                   data = DB.Products.Where(p => ((p.Product_name + " " + p.Descriptions + " " + p.Price.ToString()).ToLower().Contains(Search.ToLower()))).ToList();
               }
            }
            else
            {
                if (String.IsNullOrEmpty(Search))
                {
                    data = DB.Products.ToList();
                }
                else
                {
                    data = DB.Products.Where(p => ((p.Product_name + " " + p.Descriptions + " " + p.Price.ToString()).ToLower().Contains(Search.ToLower()))).ToList();
                }
              
            }

            ViewBag.Allpage = (int)Math.Ceiling((Double)data.Count / Config.ItemPerPage) == 0 ? 1 : (int)Math.Ceiling((Double)data.Count / Config.ItemPerPage);


            int start = (page - 1) * Config.ItemPerPage;
            int length = data.Count < page * Config.ItemPerPage ? data.Count - start : page * Config.ItemPerPage - start;

            data = data.GetRange(start, length);

            return View(data);
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
