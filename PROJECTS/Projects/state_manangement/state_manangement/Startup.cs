using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(state_manangement.Startup))]
namespace state_manangement
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
