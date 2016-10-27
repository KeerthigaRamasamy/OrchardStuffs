using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(caching.Startup))]
namespace caching
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
