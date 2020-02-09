using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeTracker.Startup))]
namespace RecipeTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
