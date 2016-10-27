using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(final_linq.Startup))]
namespace final_linq
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
