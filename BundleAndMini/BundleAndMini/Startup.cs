using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BundleAndMini.Startup))]
namespace BundleAndMini
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
