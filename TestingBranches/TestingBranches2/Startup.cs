using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingBranches2.Startup))]
namespace TestingBranches2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
