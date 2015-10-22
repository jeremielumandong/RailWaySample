using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.Registration;
using RailSystem.Service.Data;

namespace RailSystem.Service.Facility
{
    public class ServiceFacility : AbstractFacility
    {
        protected override void Init()
        {
            this.Kernel.Register(
                Component.For<ITrainService>().ImplementedBy<TrainService>().LifestyleTransient());
        }
    }
}
