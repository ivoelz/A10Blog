using Microsoft.EntityFrameworkCore;

namespace A10_Blog
{
    public class BloggingContext : DBContext
    {
        public DbSet<Blog> Blogs {get; set;}
        public DbSet<Post> Posts {get; set;}

        public void AddBlog(Blog blog)
        {
            Blogs.Add(blog);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    }
}