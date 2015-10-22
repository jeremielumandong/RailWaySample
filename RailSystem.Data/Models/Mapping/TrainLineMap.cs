using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RailSystem.Data.Models.Mapping
{
    public class TrainLineMap : EntityTypeConfiguration<TrainLine>
    {
        public TrainLineMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TrainLine");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FirstStationId).HasColumnName("FirstStationId");
            this.Property(t => t.LastStationId).HasColumnName("LastStationId");
            this.Property(t => t.LineColorId).HasColumnName("LineColorId");
            this.Property(t => t.StatusId).HasColumnName("StatusId");

            // Relationships
            this.HasRequired(t => t.LineColor)
                .WithMany(t => t.TrainLines)
                .HasForeignKey(d => d.LineColorId)
                .WillCascadeOnDelete(false);
            this.HasRequired(t => t.TrainLineStatus)
                .WithMany(t => t.TrainLines)
                .HasForeignKey(d => d.StatusId)
                .WillCascadeOnDelete(false);


            this.Ignore(t => t.EntityId);
        }
    }
}
