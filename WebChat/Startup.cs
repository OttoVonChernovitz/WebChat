using WebChat.Hubs;
using WebChat.Interfaces;
using WebChat.IoC;
using WebChat.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Ninject;
using Owin;

[assembly: OwinStartup(typeof(WebChat.Startup))]

namespace WebChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.DependencyResolver.Register(
                typeof(ChatHub),
                () => new ChatHub(new UnitOfWork(new ApplicationDbContext())));
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
