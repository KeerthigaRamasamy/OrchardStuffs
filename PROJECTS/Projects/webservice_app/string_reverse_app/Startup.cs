using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(string_reverse_app.Startup))]
namespace string_reverse_app
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
