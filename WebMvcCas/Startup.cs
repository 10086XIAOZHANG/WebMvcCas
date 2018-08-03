using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMvcCas.Startup))]
namespace WebMvcCas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
