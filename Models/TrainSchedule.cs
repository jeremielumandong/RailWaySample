using System;

namespace RailSystem.Data.Models
{
    public class TrainSchedule
    {
        public int TrainId { get; set; }
        
        public int FromStationId { get; set; }

        public int ToStationId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime ArriveTime { get; set; }
    }
}