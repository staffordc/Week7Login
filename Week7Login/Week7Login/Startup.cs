using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week7Login.Startup))]
namespace Week7Login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
