using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.Registration;
using RailSystem.Data.Repository;

namespace RailSystem.Data.Facility
{
    public class RepositoryFacility : AbstractFacility
    {
        protected override void Init()
        {
            this.Kernel.Register(
                Component.For<ITrainLineRepository>().ImplementedBy<TrainLineRepository>().LifestyleTransient());
            this.Kernel.Register(
               Component.For<IStationRepository>().ImplementedBy<StationRepository>().LifestyleTransient());
        }
    }
}