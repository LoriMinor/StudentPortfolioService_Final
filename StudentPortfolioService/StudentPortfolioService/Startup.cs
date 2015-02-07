using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentPortfolioService.Startup))]
namespace StudentPortfolioService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
