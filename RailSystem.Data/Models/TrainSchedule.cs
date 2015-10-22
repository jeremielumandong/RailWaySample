using System;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Models
{
    public class TrainSchedule : IKeyEntity
    {
        public int TrainId { get; set; }

        public int FromStationId { get; set; }

        public int ToStationId { get; set; }

        public int LineId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime ArriveTime { get; set; }

        public int EntityId { get; set; }

        public virtual TrainLine TrainLine { get; set; }

    }
}