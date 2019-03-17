using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRockers.Startup))]
namespace MVCRockers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
