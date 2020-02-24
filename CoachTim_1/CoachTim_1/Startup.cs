using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoachTim_1.Startup))]
namespace CoachTim_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
