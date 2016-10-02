using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sticker.Startup))]
namespace Sticker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
