using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainingCalendar.Startup))]
namespace TrainingCalendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
