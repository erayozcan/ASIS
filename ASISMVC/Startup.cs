using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASIS.MVC.Startup))]
namespace ASIS.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
