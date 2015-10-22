using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RailSystem.Data.Models.Mapping
{
    public class TrainScheduleMap : EntityTypeConfiguration<TrainSchedule>
    {
        public TrainScheduleMap()
        {
            // Primary Key
            this.HasKey(t => new {t.TrainId, t.FromStationId, t.ToStationId, t.StartTime, t.ArriveTime});

            // Properties
            this.Property(t => t.TrainId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FromStationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ToStationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TrainSchedule");
            this.Property(t => t.TrainId).HasColumnName("TrainId");
            this.Property(t => t.FromStationId).HasColumnName("FromStationId");
            this.Property(t => t.ToStationId).HasColumnName("ToStationId");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.ArriveTime).HasColumnName("ArriveTime");
            
            this.HasRequired(t => t.TrainLine)
              .WithMany(t => t.TrainSchedules)
              .HasForeignKey(d => d.LineId)
              .WillCascadeOnDelete(false);

        }
    }
}