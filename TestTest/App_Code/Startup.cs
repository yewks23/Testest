using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestTest.Startup))]
namespace TestTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
