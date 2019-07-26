using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BussinessCard.Web.Startup))]
namespace BussinessCard.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
