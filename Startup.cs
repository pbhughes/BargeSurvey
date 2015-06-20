using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BargeSurvey.Startup))]
namespace BargeSurvey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
