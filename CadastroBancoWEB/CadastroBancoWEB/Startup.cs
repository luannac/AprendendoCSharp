using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CadastroBancoWEB.Startup))]
namespace CadastroBancoWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
