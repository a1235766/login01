using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValidateSample.Startup))]
namespace ValidateSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
