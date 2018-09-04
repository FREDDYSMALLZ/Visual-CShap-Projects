using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BibleVerseApplication.Startup))]
namespace BibleVerseApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
