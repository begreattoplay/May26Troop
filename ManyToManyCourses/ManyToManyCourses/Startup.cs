using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManyToManyCourses.Startup))]
namespace ManyToManyCourses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
