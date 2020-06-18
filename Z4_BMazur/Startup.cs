using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Z4_BMazur.Startup))]
namespace Z4_BMazur
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
