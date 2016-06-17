using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YB.CMS.Ui.Startup))]
namespace YB.CMS.Ui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
