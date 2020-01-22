using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jd713116_MIS4200.Startup))]
namespace jd713116_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
