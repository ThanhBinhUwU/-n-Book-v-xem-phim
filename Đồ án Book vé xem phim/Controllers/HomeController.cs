using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Đồ_án_Book_vé_xem_phim.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Index()
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