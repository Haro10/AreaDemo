﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreaDemo.Areas.Women.Controllers.Models
{
    public class WomenClothing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public string imageURL { get; set; }
    }
}