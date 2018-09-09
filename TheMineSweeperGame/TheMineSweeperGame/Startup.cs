using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheMineSweeperGame.Startup))]
namespace TheMineSweeperGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
