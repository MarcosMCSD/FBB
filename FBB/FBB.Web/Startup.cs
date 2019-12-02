using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FBB.Web.Startup))]
namespace FBB.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
