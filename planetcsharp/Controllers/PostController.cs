using planetcsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace planetcsharp.Controllers
{
    public class PostController : Controller
    {
        planetcsharpEntities db = new planetcsharpEntities();

        //
        // GET: /Post/

        public ActionResult Index()
        {
            var posts = db.Posts;
            return View(posts);
        }

        //
        // GET: /Post/Details/5

        public ActionResult Details(int id)
        {
            var post = db.Posts.Single(p => p.ID == id);
            return View(post);
        }

        //
        // GET: /Post/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Post/Create

        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Posts.AddObject(post);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                // Return the view if there is a validation error
                return View();
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Post/Edit/5
 
        public ActionResult Edit(int id)
        {
            var post = db.Posts.Single(p => p.ID == id);
            return View();
        }

        //
        // POST: /Post/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var post = db.Posts.Single(p => p.ID == id);

                if (TryUpdateModel(post))
                {
                    db.SaveChanges();
                    RedirectToAction("Index");
                }

                // Return the view if there is a validation error
                return View();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Post/Delete/5
 
        public ActionResult Delete(int id)
        {
            var post = db.Posts.Single(p => p.ID == id);
            return View(post);
        }

        //
        // POST: /Post/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var post = db.Posts.Single(p => p.ID == id);
                db.DeleteObject(post);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
