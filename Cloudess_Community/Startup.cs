using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cloudess_Community.Startup))]
namespace Cloudess_Community
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
