using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment3_Webstore_.Startup))]
namespace Assignment3_Webstore_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
