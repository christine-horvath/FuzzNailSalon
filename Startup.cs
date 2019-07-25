using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuzzAuth.Startup))]
namespace FuzzAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
