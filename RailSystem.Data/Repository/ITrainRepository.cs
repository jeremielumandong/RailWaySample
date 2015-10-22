using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailSystem.Data.Models;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Repository
{
    public interface ITrainScheduleRepository : IDataRepository<TrainSchedule>
    {
        IEnumerable<TrainSchedule> GetTrainSchedules(int trainId);
    }
}
