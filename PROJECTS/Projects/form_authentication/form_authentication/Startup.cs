using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(form_authentication.Startup))]
namespace form_authentication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
