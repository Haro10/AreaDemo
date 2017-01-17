using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AreaDemo.Areas.Women.Controllers.Models;

namespace AreaDemo.Areas.Women.Controllers
{
    public class FootwearController : Controller
    {
        public ActionResult Index()
        {
            WomenRepository womenRepository = new WomenRepository();
            var getFootwears = womenRepository.GetFootwears();
            return View(getFootwears);
        }
    }
}
