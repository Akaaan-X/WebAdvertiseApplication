using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAdvertiseApplication.Startup))]
namespace WebAdvertiseApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
