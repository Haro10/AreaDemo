using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AreaDemo.Areas.Women.Models;

namespace AreaDemo.Areas.Women.Controllers.Models
{
    public class WomenRepository
    {

        public List<WomenClothing> GetCloths()
        {
            List<WomenClothing> result = new List<WomenClothing> { 
                new WomenClothing () { Id = 1, Name = "Kurta", Size= 32, Price = 2000, imageURL="/Areas/Women/Content/images/women_cloths/img_c1.jpg"},
                new WomenClothing () { Id = 2, Name = "Shirt", Size= 34, Price = 1000, imageURL="/Areas/Women/Content/images/women_cloths/img_c2.jpg"},
                new WomenClothing () { Id = 3, Name = "Kurta", Size= 30, Price = 1500, imageURL="/Areas/Women/Content/images/women_cloths/img_c3.jpg"},
                new WomenClothing () { Id = 4, Name = "Kurta", Size= 36, Price = 1800, imageURL="/Areas/Women/Content/images/women_cloths/img_c4.jpg"}
            };

            return result;
        }



        public List<WomenFootwears> GetFootwears()
        {
            List<WomenFootwears> result = new List<WomenFootwears> { 
                new WomenFootwears () { Id = 1, Name = "Casual Sandal", Size= 6, Price = 800, imageURL="/Areas/Women/Content/images/women_footwears/img_f1.jpg"},
                new WomenFootwears () { Id = 2, Name = "Casual Slipper", Size= 7, Price = 1200, imageURL="/Areas/Women/Content/images/women_footwears/img_f2.jpg"},
                new WomenFootwears () { Id = 3, Name = "Casual Sandal", Size= 7, Price = 3000, imageURL="/Areas/Women/Content/images/women_footwears/img_f3.jpg"},
                new WomenFootwears () { Id = 4, Name = "Casual Sandal", Size= 8, Price = 3500, imageURL="/Areas/Women/Content/images/women_footwears/img_f4.jpg"}
            };

            return result;
        }
    }
}
