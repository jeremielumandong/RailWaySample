using System;

namespace RailSystem.Common.Models
{
    public class TrainSchedule
    {
        public int TrainId { get; set; }

        public int FromStationId { get; set; }

        public int ToStationId { get; set; }

        public int LineId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime ArriveTime { get; set; }

        public int TotalMinutes => this.ArriveTime.Subtract(this.StartTime).Minutes;
    }
}