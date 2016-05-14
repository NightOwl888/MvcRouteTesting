using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcRouteTesting.Startup))]
namespace MvcRouteTesting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
