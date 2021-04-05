using System.Collections.Generic;
namespace A10_Blog
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}