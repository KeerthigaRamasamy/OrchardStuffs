using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sample_lms.Startup))]
namespace sample_lms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
