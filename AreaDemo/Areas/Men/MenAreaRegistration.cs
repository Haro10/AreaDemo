using System.Web.Mvc;

namespace AreaDemo.Areas.Men
{
    public class MenAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Men";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Men_default",
                "Men/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "AreaDemo.Areas.Men.Controllers" }
            );
        }
    }
}
