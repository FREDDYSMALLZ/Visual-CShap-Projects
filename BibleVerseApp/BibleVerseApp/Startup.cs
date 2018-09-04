using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BibleVerseApp.Startup))]
namespace BibleVerseApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
