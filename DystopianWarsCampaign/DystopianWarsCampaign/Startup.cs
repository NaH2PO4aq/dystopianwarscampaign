using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DystopianWarsCampaign.Startup))]
namespace DystopianWarsCampaign
{
    //Helllllo Thomas!
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
