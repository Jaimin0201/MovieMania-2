using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieMania.Startup))]
namespace MovieMania
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
