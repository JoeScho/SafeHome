using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SafeHomeWebsite.Startup))]
namespace SafeHomeWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
