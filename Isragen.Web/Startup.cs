using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Isragen.Web.Startup))]
namespace Isragen.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
