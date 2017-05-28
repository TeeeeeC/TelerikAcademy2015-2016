using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BestSportsStore.Web.Startup))]
namespace BestSportsStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
