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
            builder.Property(b => b.date_log).IsRequired();
            builder.Property(b => b.wind_direction).IsRequired();
            builder.Property(b => b.surface_current).IsRequired();
            builder.Property(b => b.diving_permit).IsRequired();
            builder.Property(b => b.wave_height).IsRequired();
            builder.Property(b => b.divers_number).IsRequired();
            builder.Property(b => b.observations).IsRequired();
            }
    }
}