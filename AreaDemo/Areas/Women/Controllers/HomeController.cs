using AreaDemo.Areas.Women.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaDemo.Areas.Women.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           return View();           
        }

    }
}
