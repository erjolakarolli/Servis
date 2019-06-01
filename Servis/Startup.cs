using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Servis.Startup))]
namespace Servis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
