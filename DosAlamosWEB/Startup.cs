using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DosAlamosWEB.Startup))]
namespace DosAlamosWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
