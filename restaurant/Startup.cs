using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(restaurant.Startup))]
namespace restaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
