using planetcsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Web;
using System.Xml;

namespace planetcsharp.Tasks
{
    public static class FeedReader
    {
        // Set up the planet db 
        

        public static void CheckAllFeeds()
        {
            // Check all of the feeds for updates 
            planetcsharpEntities db = new planetcsharpEntities();
            var blogs = db.Blogs;

            foreach (var blog in blogs)
            {
                CheckFeed(blog);
            }
        }

        public static void CheckFeed(Blog blog)
        {
            // set up the database
            planetcsharpEntities db = new planetcsharpEntities();

            // Check a specific feed for an update 
            XmlReader reader = XmlReader.Create(blog.FeedUrl);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            // loop through the feed items we've just retrieved 
            foreach (var item in feed.Items)
            {
                // Test to see if the post is already in our database
                var postUrl = item.Links[0].Uri.OriginalString;
                if (!db.Posts.Any(p => p.Url == postUrl))
                {
                    // If the post is not in the db, add it
                    var newPost = new Post
                    {
                        BlogID = blog.ID,
                        Url = item.Links[0].Uri.OriginalString,
                        Title = item.Title.Text,
                        Content = item.Summary.Text,
                        PostedDate = item.PublishDate.DateTime,
                        CreatedAt = DateTime.Now
                    };
                    db.AddToPosts(newPost);
                }
            }
            db.SaveChanges();
        }
    }
}