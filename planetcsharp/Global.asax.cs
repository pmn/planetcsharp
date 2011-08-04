using planetcsharp.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Routing;

namespace planetcsharp
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        // Using StackOverflow's method for running background jobs:
        // http://blog.stackoverflow.com/2008/07/easy-background-tasks-in-aspnet/

        private static CacheItemRemovedCallback OnCacheRemove = null;

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        private void AddTask(string taskName, int seconds)
        {
            // http://blog.stackoverflow.com/2008/07/easy-background-tasks-in-aspnet/
            OnCacheRemove = new CacheItemRemovedCallback(CacheItemRemoved);

            HttpRuntime.Cache.Insert(taskName, seconds, null,
                DateTime.Now.AddSeconds(seconds), Cache.NoSlidingExpiration,
                CacheItemPriority.NotRemovable, OnCacheRemove);
        }

        public void CacheItemRemoved(string k, object v, CacheItemRemovedReason r)
        {
            // http://blog.stackoverflow.com/2008/07/easy-background-tasks-in-aspnet/

            if (k == "CheckFeeds")
            {
                FeedReader.CheckAllFeeds();
            }

            AddTask(k, Convert.ToInt32(v));
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            // Add the task to check our feeds
            AddTask("CheckFeeds", 1800);
        }
    }
}