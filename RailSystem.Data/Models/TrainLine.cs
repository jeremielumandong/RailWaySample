using System.Collections.Generic;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Models
{
    public class TrainLine : IKeyEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int FirstStationId { get; set; }

        public int LastStationId { get; set; }

        public int LineColorId { get; set; }

        public int StatusId { get; set; }

        public virtual LineColor LineColor { get; set; }
             
        public virtual TrainLineStatus TrainLineStatus { get; set; }

        public virtual ICollection<TrainSchedule> TrainSchedules { get; set; }

        public int EntityId
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
    }
}