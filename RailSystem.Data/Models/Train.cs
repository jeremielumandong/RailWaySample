using System.Collections.Generic;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Models
{
    public class Train : IKeyEntity
    {
        public Train()
        {
            this.TrainSchedules = new List<TrainSchedule>();
        }

        public int Id { get; set; }

        public string Code { get; set; }

        public virtual ICollection<TrainSchedule> TrainSchedules { get; set; }

        public int EntityId
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
    }
}