using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestTestTest.Startup))]
namespace TestTestTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
