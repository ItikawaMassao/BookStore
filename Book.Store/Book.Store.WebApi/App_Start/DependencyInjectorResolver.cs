using Book.Store.Application.AppServices;
using Book.Store.Application.Interfaces;
using Book.Store.IoC;
using Book.Store.WebApi;
using System.Web.Http;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(DependencyInjectorResolver), "Start")]

namespace Book.Store.WebApi
{
    public class DependencyInjectorResolver
    {
        public static void Start()
        {
            DependencyInjector.Initialize();
            DependencyInjector.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            DependencyInjector.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = DependencyInjector.Resolver();
        }
    }
}