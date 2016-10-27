using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(third_party_authorization.Startup))]
namespace third_party_authorization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
