using DivingLogs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DivingLogs.Data
{
    public class DivingLogConfiguration : IEntityTypeConfiguration<DivingLog>
    {
        //Aplicando Fluent Api
        public void Configure(EntityTypeBuilder<DivingLog> builder)
        {
            builder.HasKey(b => b.id);
            builder.Property(b => b.date_log).IsRequired().HasMaxLength(10);
            builder.Property(b => b.wind_direction).IsRequired().HasMaxLength(50);
            builder.Property(b => b.surface_current).IsRequired().HasMaxLength(10);
            builder.Property(b => b.diving_permit).IsRequired().HasMaxLength(30);
            builder.Property(b => b.wave_height).IsRequired().HasMaxLength(5);
            builder.Property(b => b.divers_number).IsRequired().HasMaxLength(5);
            builder.Property(b => b.observations).IsRequired().HasMaxLength(200);
        }
    }
}