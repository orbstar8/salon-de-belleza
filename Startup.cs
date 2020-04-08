using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Peluqueria.Startup))]
namespace Peluqueria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
