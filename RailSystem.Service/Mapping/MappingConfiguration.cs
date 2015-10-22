using AutoMapper;
using RailSystem.Data.Models;

namespace RailSystem.Service.Mapping
{
    public static class MappingConfiguration
    {
        public static void ConfigureClassMapping()
        {
            Mapper.CreateMap<Station, Common.Models.Station>();
            Mapper.CreateMap<LineColor, Common.Models.LineColor>();
            Mapper.CreateMap<Train, Common.Models.Train>();
            Mapper.CreateMap<TrainLineStatus, Common.Models.TrainLineStatus>();
            Mapper.CreateMap<TrainLine, Common.Models.TrainLine>();
            Mapper.CreateMap<TrainSchedule, Common.Models.TrainSchedule>();
        }
    }
}