using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Post : Entity
    {
        public string Title { get; set; }
        public string ImgPath { get; set; }
        public string News{ get; set; }
    }
}