using System.Web.Mvc;

namespace AreaDemo.Areas.Women
{
    public class WomenAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
           /* retun the name folder that we get the data
            * => ex: get the name of ~\women\View\Home\Index.cshtml
            to display the View*/
            get
            {
                return "women";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            /*Just register the URl to refer, you can change the Women to Wo 
             * -> URL: Wo/{controller}/{action}/{id}
             The file we access through the AreaName above*/
            context.MapRoute(
                "Women_default",
                "Women/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "AreaDemo.Areas.Women.Controllers" }
            );
        }
    }
}
