using System.Web.Http;
using System.Web.Http.Dispatcher;
using AutoMapper;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using RailSystem.Service.Mapping;

namespace Railsystem.Front
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

            Mapper.Initialize(config => config.ConstructServicesUsing(container.Resolve));
            MappingConfiguration.ConfigureClassMapping();
        }

        public static void Dispose()
        {
            container.Dispose();
        }
    }
}