using DystopianWarsCampaign.Data_Access_Layer;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(DystopianWarsCampaign.Startup))]
namespace DystopianWarsCampaign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Database.SetInitializer<MapContext>(new MapInitializer());
        }
    }
}
