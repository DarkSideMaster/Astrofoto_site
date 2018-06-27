using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AstroFotoWebSite.Startup))]
namespace AstroFotoWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
