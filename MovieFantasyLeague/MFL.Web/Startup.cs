using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MFL.Web.Startup))]
namespace MFL.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
