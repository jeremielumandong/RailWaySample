using System.Collections.Generic;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Models
{
    public class TrainLineStatus : IKeyEntity
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<TrainLine> TrainLines { get; set; }

        public int EntityId
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
    }
}