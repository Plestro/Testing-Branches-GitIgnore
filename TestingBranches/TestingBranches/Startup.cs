using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingBranches.Startup))]
namespace TestingBranches
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
