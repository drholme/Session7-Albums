using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Session7AlbumsMVC.Startup))]
namespace Session7AlbumsMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
