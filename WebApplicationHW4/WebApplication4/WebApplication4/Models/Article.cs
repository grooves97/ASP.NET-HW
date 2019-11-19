using System;

namespace WebApplication4.Models
{
    public class Article
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Text { get; set; }
        public string PathImg { get; set; }
    }
}