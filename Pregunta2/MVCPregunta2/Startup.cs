using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPregunta2.Startup))]
namespace MVCPregunta2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
