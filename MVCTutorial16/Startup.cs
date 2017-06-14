using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTutorial16.Startup))]
namespace MVCTutorial16
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
