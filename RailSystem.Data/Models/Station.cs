using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Models
{
    public class Station : IKeyEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int EntityId
        {
            get { return this.Id; }
            set { this.Id = value; }
			
			
			
        }
    }
}