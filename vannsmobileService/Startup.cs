using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(vannsmobileService.Startup))]

namespace vannsmobileService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}