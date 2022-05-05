using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheBlogProject.Models;

namespace TheBlogProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<BlogUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TheBlogProject.Models.Blog> Blog { get; set; }
        public DbSet<TheBlogProject.Models.Post> Post { get; set; }
        public DbSet<TheBlogProject.Models.Comment> Comment { get; set; }
        public DbSet<TheBlogProject.Models.Tag> Tag { get; set; }
    }
}
