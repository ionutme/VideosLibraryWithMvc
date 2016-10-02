using System.Web.Mvc;
using System.Web.Routing;

namespace Sticker
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Video",
                "Video/{action}",
                new {controller = "Video", action = "List"}
            );
            routes.MapRoute("VideosDefault",
                "Videos",
                new { controller = "Video", action = "List" }
            );
            routes.MapRoute("Videos",
                "Videos/List",
                new { controller = "Video", action = "List" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}