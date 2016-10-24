using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stemming.Startup))]
namespace Stemming
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
