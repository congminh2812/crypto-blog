using CryptoBlog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CryptoBlog.Persistence.DbContext
{
    public class BlogAppContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public BlogAppContext(DbContextOptions<BlogAppContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
