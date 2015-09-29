using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InvestigatorReq.Startup))]
namespace InvestigatorReq
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
