using System.Web.Mvc;

namespace Shop.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Login",
                "login",
                new { action = "Login", controller = "Login", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Admin_default",
                "admin/{controller}",
                new { action = "Admin", controller = "Admin", id = UrlParameter.Optional }
            );
        }
    }
}