using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lms_sampe1.Startup))]
namespace lms_sampe1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
