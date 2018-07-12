using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Happy_Hut_MVC.Startup))]
namespace Happy_Hut_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
