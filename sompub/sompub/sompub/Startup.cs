using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sompub.Startup))]
namespace sompub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
