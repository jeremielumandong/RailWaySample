using System.Collections.Generic;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Models
{
    public class LineColor : IKeyEntity
    {
        public LineColor()
        {
            this.TrainLines = new List<TrainLine>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<TrainLine> TrainLines { get; set; }

        public int EntityId
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
    }
}