using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git.Branching.Startup))]
namespace Git.Branching
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
