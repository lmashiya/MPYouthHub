using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MPYouthHubMVP.Startup))]
namespace MPYouthHubMVP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
