using System;
using Book.Store.Domain.Interfaces.Repositories;
using Book.Store.Domain.Interfaces.Services;
using Book.Store.Domain.Services;
using Book.Store.Infra.Data.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.Web.Http;
using System.Web.Http.Dependencies;
using Book.Store.Application.AppServices;
using Book.Store.Application.Interfaces;
using Book.Store.Domain.Interfaces;
using Book.Store.Infra.Data.Context;

namespace Book.Store.IoC
{
    public static class DependencyInjector
    {
        public static bool IsStarted { get; private set; }
        private static Container _container;

        public static IDependencyResolver Resolver()
        {
            return new SimpleInjectorWebApiDependencyResolver(_container);
        }

        public static void Initialize()
        {
            if (IsStarted)
                return;

            _container = new Container();
            _container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            _container.Register<BookStoreContext>(Lifestyle.Scoped);
            _container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            _container.Register<ILivroService, LivroService>(Lifestyle.Scoped);
            _container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            _container.Register<ILivroRepository, LivroRepository>(Lifestyle.Scoped);
            //_container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<,>));
            _container.Register<ILivroAppService, LivroAppService>();
            IsStarted = true;
        }

        public static void Register<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService
        {
            Register<TService, TImplementation>(Lifestyle.Scoped);
        }

        public static void Register<TService, TImplementation>(Lifestyle lifestyle)
            where TService : class
            where TImplementation : class, TService
        {
            _container.Register<TService, TImplementation>(lifestyle);
        }

        public static void Register(Type serviceType, Type implementationType)
        {
            _container.Register(serviceType, implementationType);
        }

        public static void RegisterWebApiControllers(HttpConfiguration configuration)
        {
            _container.RegisterWebApiControllers(configuration);
        }

        public static void Verify()
        {
            Verify(_container);
        }

        public static void Verify(Container container)
        {
            if (!container.IsVerifying)
                container.Verify();
        }

        public static TType GetInstance<TType>(Container container) where TType : class
        {
            return container.GetInstance<TType>();
        }
    }
}