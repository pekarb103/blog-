using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class homeController : Controller
    {
        //public ActionResult Index()
        //{
        //    var model = new ArticleModel();
        //    return View(model);
        //}

        //public ActionResult Index(string id)
        //{
        //    var model = new ArticleModel();
        //    return View(model);
        //}

        public ActionResult Index ()
        {
            string query = Request.QueryString["Foo"];
            var model = new ArticleModel();
            return View(model);
        }
    }
}
