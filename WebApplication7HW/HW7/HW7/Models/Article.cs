﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW7.Models
{
    public class Article : Entity
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}