using System.Collections.Generic;
namespace A10_Blog
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public List<Post> Posts { get; set; }

        public void AddPost(Post post)
        {
            Posts.Add(post);
        }
    }
}