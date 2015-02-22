using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GasAnalytics.UI.Startup))]
namespace GasAnalytics.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
