using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiangKhaiMinh_2011062641.Startup))]
namespace GiangKhaiMinh_2011062641
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
