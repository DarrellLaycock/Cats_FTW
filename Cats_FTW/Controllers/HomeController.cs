using Cats_FTW.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cats_FTW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CatLoader.LoadCatImagesToTable();

            Response.Redirect("swagger/ui/index");

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
