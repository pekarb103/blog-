﻿using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            var model = new ArticleModel();
            return View(model);
        }

        public ActionResult Index1()
        {
            var model = new ArticleModel();
            return View(model);
        }
        public ActionResult Index2()
        {
            var model = new ArticleModel();
            return View(model);
        }
        public ActionResult Index3()
        {
            var model = new ArticleModel();
            return View(model);
        }
    }
}
