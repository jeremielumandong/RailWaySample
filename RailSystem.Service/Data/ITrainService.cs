using System.Collections.Generic;
using RailSystem.Data.Models;
using Station = RailSystem.Common.Models.Station;
using TrainLine = RailSystem.Common.Models.TrainLine;
using TrainLineStatus = RailSystem.Common.Models.TrainLineStatus;
using TrainSchedule = RailSystem.Common.Models.TrainSchedule;

namespace RailSystem.Service.Data
{
    public interface ITrainService
    {
        List<Station> GetStations();
        List<TrainLine> GetTrainLines();
        TrainLineStatus GetTrainLineStatus(int id);
        List<TrainSchedule> GetTrainSchedules(int lineId);

    }
}