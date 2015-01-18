using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DystopianWarsCampaign.Startup))]
namespace DystopianWarsCampaign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
