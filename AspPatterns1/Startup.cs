using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspPatterns1.Startup))]
namespace AspPatterns1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
