using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesSystem.Web.Startup))]
namespace MoviesSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
