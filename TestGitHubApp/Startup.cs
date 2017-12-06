using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitHubApp.Startup))]
namespace TestGitHubApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
