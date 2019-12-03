using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationHW7.Models
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Text { get; set; }
        public string ImgPath { get; set; }
    }
}