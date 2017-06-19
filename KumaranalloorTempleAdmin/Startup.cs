using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KumaranalloorTempleAdmin.Startup))]
namespace KumaranalloorTempleAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
