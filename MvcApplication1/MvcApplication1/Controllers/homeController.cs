using MvcApplication1.Models;
using MvcApplication1.Repository;
using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(string title)
        {

            if (title == null)
            {
                title = "This is my first title";
            }

            var readers = new NewDataReader();

            return View(readers.GetArticleModel(title));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(ArticleModel model)
        {
            var title = "This is my first title";

            if (model.NewComment != null && ModelState.IsValid)
            {
                var readers = new NewDataReader();
                readers.AddComment(title, model.NewComment.Comment);
                //CommentsRepository.Comments.Add(model.NewComment.Comment);
                ModelState.Clear();
                return View(readers.GetArticleModel(title));
            }
            return View(model);
        }
    }
}