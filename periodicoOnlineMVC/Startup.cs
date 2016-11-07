using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(periodicoOnlineMVC.Startup))]
namespace periodicoOnlineMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
