using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(appTest.Startup))]
namespace appTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
