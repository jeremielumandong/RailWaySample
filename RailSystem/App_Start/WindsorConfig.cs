using System.Web.Http;
using System.Web.Http.Dispatcher;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace RailSystem
{
    public class WindsorConfig
    {
        private static IWindsorContainer container;

        public static void Register(HttpConfiguration configuration)
        {
            container = new WindsorContainer();
            container.Install(FromAssembly.This());
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel, true));
            configuration.Services.Replace(typeof (IHttpControllerActivator), new WindsorCompositionRoot(container));
        }

        public static void Dispose()
        {
            container.Dispose();
        }
    }
}