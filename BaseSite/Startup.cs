using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseSite.Startup))]
namespace BaseSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
