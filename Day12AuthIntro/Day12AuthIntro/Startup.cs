using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day12AuthIntro.Startup))]
namespace Day12AuthIntro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
