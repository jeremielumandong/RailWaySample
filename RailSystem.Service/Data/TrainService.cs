using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using RailSystem.Data.Models;
using RailSystem.Data.Repository;
using Station = RailSystem.Common.Models.Station;
using TrainLine = RailSystem.Common.Models.TrainLine;
using TrainLineStatus = RailSystem.Common.Models.TrainLineStatus;
using TrainSchedule = RailSystem.Common.Models.TrainSchedule;

namespace RailSystem.Service.Data
{
    public class TrainService : ITrainService
    {
        private readonly IStationRepository stationRepository;
        private readonly ITrainLineRepository trainLineRepository;

        public TrainService(ITrainLineRepository trainLineRepository, IStationRepository stationRepository)
        {
            this.trainLineRepository = trainLineRepository;
            this.stationRepository = stationRepository;
        }

        public List<Station> GetStations()
        {
            return this.stationRepository.Get().Select(Mapper.Map<Station>).ToList();
        }

        public List<TrainLine> GetTrainLines()
        {
            return this.trainLineRepository.Get().Select(Mapper.Map<TrainLine>).ToList();
        }

        public TrainLineStatus GetTrainLineStatus(int id)
        {
            return Mapper.Map<TrainLineStatus>(this.trainLineRepository.GetStatus(id));
        }

        public List<TrainSchedule> GetTrainSchedules(int lineId)
        {
            return this.trainLineRepository.GetTrainSchedules(lineId).Select(Mapper.Map<TrainSchedule>).ToList();
        }

    }
}