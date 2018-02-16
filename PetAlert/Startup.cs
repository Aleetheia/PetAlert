using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetAlert.Startup))]
namespace PetAlert
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
