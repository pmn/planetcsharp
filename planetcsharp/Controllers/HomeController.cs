using planetcsharp.Models;
using planetcsharp.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace planetcsharp.Controllers
{
    public class HomeController : Controller
    {
        planetcsharpEntities db = new planetcsharpEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Planet C#";

            var blogs = from blog in db.Blogs
                        select blog;

            var posts = (from post in db.Posts
                        orderby post.PostedDate descending
                        select post)
                        .Take(15);

            ViewData["blogs"] = blogs;
            return View(posts);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult CheckFeeds()
        {
            FeedReader.CheckAllFeeds();
            return View();
        }
    }
}
