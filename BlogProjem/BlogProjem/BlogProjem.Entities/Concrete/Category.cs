using System;
using System.Collections.Generic;
using System.Text;
using BlogProjem.Entities.Interfaces;

namespace BlogProjem.Entities.Concrete
{
    public class Category : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}
