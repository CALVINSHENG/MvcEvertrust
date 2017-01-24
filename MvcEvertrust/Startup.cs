using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcEvertrust.Startup))]
namespace MvcEvertrust
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
