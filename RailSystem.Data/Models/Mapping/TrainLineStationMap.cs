using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RailSystem.Data.Models.Mapping
{
    public class TrainLineStationMap : EntityTypeConfiguration<TrainLineStation>
    {
        public TrainLineStationMap()
        {
            // Primary Key
            this.HasKey(t => new {t.LineId, t.StationId});

            // Properties
            this.Property(t => t.LineId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TrainLineStation");
            this.Property(t => t.LineId).HasColumnName("LineId");
            this.Property(t => t.StationId).HasColumnName("StationId");
            this.Property(t => t.NextStationId).HasColumnName("NextStationId");
            this.Property(t => t.PreviousStationId).HasColumnName("PreviousStationId");
        }
    }
}