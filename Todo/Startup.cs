using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Todo.Startup))]
namespace Todo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
