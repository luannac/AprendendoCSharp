using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExerCRUD.Startup))]
namespace ExerCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
