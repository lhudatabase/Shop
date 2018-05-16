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
            #region Login
                context.MapRoute(
                    "Login",
                    "login",
                    new { action = "Login", controller = "Login", id = UrlParameter.Optional }
                );
            #endregion

            #region AdminWorkspace
                context.MapRoute(
                    "Dashboard",
                    "dashboard",
                    new { action = "Dashboard", controller = "Admin", id = UrlParameter.Optional }
                );

                context.MapRoute(
                    "Messages",
                    "messages",
                    new { action = "Messages", controller = "Admin", id = UrlParameter.Optional }
                );

                context.MapRoute(
                    "Forms",
                    "forms",
                    new { action = "Forms", controller = "Admin", id = UrlParameter.Optional }
                );

                context.MapRoute(
                    "Gallery",
                    "gallery",
                    new { action = "Gallery", controller = "Admin", id = UrlParameter.Optional }
                );

                context.MapRoute(
                    "UsersAccount",
                    "users-account",
                    new { action = "UsersAccount", controller = "Admin", id = UrlParameter.Optional }
                );

                context.MapRoute(
                    "Calendar",
                    "calendar",
                    new { action = "Calendar", controller = "Admin", id = UrlParameter.Optional }
                );

                context.MapRoute(
                    "FileManager",
                    "file-manager",
                    new { action = "FileManager", controller = "Admin", id = UrlParameter.Optional }
                );

                context.MapRoute(
                    "Icon",
                    "icon",
                    new { action = "Icon", controller = "Admin", id = UrlParameter.Optional }
                );
            #endregion

            context.MapRoute(
                "Admin_default",
                "admin/{controller}",
                new { action = "Admin", controller = "Admin", id = UrlParameter.Optional }
            );
        }
    }
}