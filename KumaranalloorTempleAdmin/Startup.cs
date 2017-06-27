using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kumaranalloordevitempleadminweb.Startup))]
namespace kumaranalloordevitempleadminweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
