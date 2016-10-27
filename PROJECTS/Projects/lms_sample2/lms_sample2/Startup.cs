using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lms_sample2.Startup))]
namespace lms_sample2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
