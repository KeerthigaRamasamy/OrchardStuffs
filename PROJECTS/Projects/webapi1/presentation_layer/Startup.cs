using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(presentation_layer.Startup))]
namespace presentation_layer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
