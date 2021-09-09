using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntroToWeb.Startup))]
namespace IntroToWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
