using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQueryFundamentalsUI.Startup))]
namespace jQueryFundamentalsUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
