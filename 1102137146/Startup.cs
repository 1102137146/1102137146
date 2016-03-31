using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1102137146.Startup))]
namespace _1102137146
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
