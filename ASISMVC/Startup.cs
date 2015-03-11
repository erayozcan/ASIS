using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASISMVC.Startup))]
namespace ASISMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
