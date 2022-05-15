using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SzakdolgozatREPO.Startup))]
namespace SzakdolgozatREPO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
