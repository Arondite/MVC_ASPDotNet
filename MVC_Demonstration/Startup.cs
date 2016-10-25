using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Assignment4.Startup))]
namespace MVC_Assignment4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
