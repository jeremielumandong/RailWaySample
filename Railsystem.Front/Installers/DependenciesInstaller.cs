using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RailSystem.Data.Facility;
using RailSystem.Service.Facility;

namespace Railsystem.Front.Installers
{
    /// <summary>
    ///     Installer for all dependencies
    /// </summary>
    public class DependenciesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<LoggingFacility>(f => f.UseLog4Net());
            container.AddFacility<RepositoryFacility>();
            container.AddFacility<ServiceFacility>();
        }
    }
}