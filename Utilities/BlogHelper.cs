using System.Collections.Generic;
using System.Linq;
using TheBlogProject.Data;
using TheBlogProject.Models;

namespace TheBlogProject.Utilities
{
    public class BlogHelper
    {
        public static List<Blog> GetBlogs(ApplicationDbContext db)
        {
            return db.Blog.ToList();
        }
    }
}
