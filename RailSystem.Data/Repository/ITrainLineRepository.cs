using System.Collections.Generic;
using RailSystem.Data.Models;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Repository
{
    public interface ITrainLineRepository : IDataRepository<TrainLine>
    {
        TrainLineStatus GetStatus(int id);

        IEnumerable<TrainSchedule> GetTrainSchedules(int lineId);
    }
}