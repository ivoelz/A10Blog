using System;

namespace A10_Blog
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Display Blogs, 2. Add Blog, 3. Display Posts, 4. Add Post");
            var userInput = Console.ReadLine();

            var db = new BloggingContext();

            if (userInput == "1")
            {

                var query = db.Blogs.OrderBy(b => b.Name);

                Console.WriteLine("Blogs in this database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else if (userInput == "2")
            {
                Console.Write("Enter blog name: ");
                var blogName = Console.ReadLine();

                var blog = new Blog { Name = name };
                var db = new BloggingContext();
                db.AddBlog(blog);
            }
            else if (userInput == "3")
            {
                // Select from blogs 
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine($"{blog.BlogId} {blog.Url}");
                }
                var blog = new Blog();
                foreach (var post in blog.Posts)
                {
                    Console.WriteLine($"({post.PostId}) {post.Title}");
                }
            }
            else if (userInput == "4")
            {
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine($"({blog.BlogId}) {blog.Url}");
                }
            // Post
            var post = new Post()
            {
                BlogId = 1,
                Content = "Post content from blog",
                Title = "Vacation to Hawaii"
            };
            db.Posts.Add(post);
            } 
            else 
            {
                Console.WriteLine("You must enter the numbers 1,2,3, or 4");
            }
        }
    }
}
