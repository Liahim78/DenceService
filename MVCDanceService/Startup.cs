using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDanceService.Startup))]
namespace MVCDanceService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
