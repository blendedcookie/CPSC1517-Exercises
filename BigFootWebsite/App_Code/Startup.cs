using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fort_Sasquatch_Indoor_Soccer.Startup))]
namespace Fort_Sasquatch_Indoor_Soccer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
