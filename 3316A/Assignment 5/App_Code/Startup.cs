using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_5.Startup))]
namespace Assignment_5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
