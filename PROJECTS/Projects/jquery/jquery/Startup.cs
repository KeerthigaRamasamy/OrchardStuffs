using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jquery.Startup))]
namespace jquery
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
