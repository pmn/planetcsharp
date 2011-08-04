using planetcsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace planetcsharp.Controllers
{
    public class BlogController : Controller
    {
        planetcsharpEntities db = new planetcsharpEntities();

        //
        // GET: /Blog/

        public ActionResult Index()
        {
            var blogs = db.Blogs;
            return View(blogs);
        }

        //
        // GET: /Blog/Details/5

        public ActionResult Details(int id)
        {
            var blog = db.Blogs.Single(b => b.ID == id);
            return View(blog);
        }

        //
        // GET: /Blog/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Blog/Create

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Blogs.AddObject(blog);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Blog/Edit/5
 
        public ActionResult Edit(int id)
        {
            var blog = db.Blogs.Single(b => b.ID == id);
            return View(blog);
        }

        //
        // POST: /Blog/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var blog = db.Blogs.Single(b => b.ID == b.ID);

                if (TryUpdateModel(blog))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                // Redisplay the form if there is a validation error
                return View();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Blog/Delete/5
 
        public ActionResult Delete(int id)
        {
            // Prompt to verify the deletion
            var blog = db.Blogs.Single(b => b.ID == id);
            return View(blog);
        }

        //
        // POST: /Blog/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // Perform the deletion
            try
            {
                var blog = db.Blogs.Single(b => b.ID == id);
                db.Blogs.DeleteObject(blog);
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
