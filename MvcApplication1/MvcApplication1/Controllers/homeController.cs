using MvcApplication1.Models;
using MvcApplication1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class homeController : Controller
    {
        [HttpGet]
        public ActionResult Index ()
        {
            //string query = Request.QueryString["Foo"];
            var model = new ArticleModel();
            return View(new ArticleModel());
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(ArticleModel model)
        {
            if (model.NewComment != null && ModelState.IsValid) 
            {
                CommentsRepository.Comments.Add(model.NewComment.Comment);
                return View(new ArticleModel());
            }
            return View(model);
        }
    }
}
