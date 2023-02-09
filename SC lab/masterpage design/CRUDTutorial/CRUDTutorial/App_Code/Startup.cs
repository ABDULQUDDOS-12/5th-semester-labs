using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDTutorial.Startup))]
namespace CRUDTutorial
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
