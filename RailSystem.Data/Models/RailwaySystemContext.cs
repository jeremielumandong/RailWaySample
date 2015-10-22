using System.Configuration;
using System.Data.Entity;
using RailSystem.Data.Models.Mapping;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Models
{
    public class RailwaySystemContext : DbContext
    {
        static RailwaySystemContext()
        {
            Database.SetInitializer<RailwaySystemContext>(null);
        }

        public RailwaySystemContext()
            : base("name=RailwayDb")
        {
        }

        public DbSet<LineColor> LineColors { get; set; }

        public DbSet<Station> Stations { get; set; }

        public DbSet<Train> Trains { get; set; }

        public DbSet<TrainLine> TrainLines { get; set; }

        public DbSet<TrainLineStation> TrainLineStations { get; set; }

        public DbSet<TrainLineStatus> TrainLineStatus { get; set; }

        public DbSet<TrainSchedule> TrainSchedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<IKeyEntity>();

            modelBuilder.Configurations.Add(new LineColorMap());
            modelBuilder.Configurations.Add(new StationMap());
            modelBuilder.Configurations.Add(new TrainMap());
            modelBuilder.Configurations.Add(new TrainLineMap());
            modelBuilder.Configurations.Add(new TrainLineStationMap());
            modelBuilder.Configurations.Add(new TrainLineStatusMap());
            modelBuilder.Configurations.Add(new TrainScheduleMap());
        }
    }
}