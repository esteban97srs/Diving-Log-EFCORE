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
            builder.Property(b => b.DateLog).IsRequired().HasMaxLength(15);
            builder.Property(b => b.WindDirection).IsRequired().HasMaxLength(50);
            builder.Property(b => b.SurfaceCurrent).IsRequired().HasMaxLength(50);
            builder.Property(b => b.DivingPermit).IsRequired().HasMaxLength(50);
            builder.Property(b => b.WaveHeight).IsRequired().HasMaxLength(5);
            builder.Property(b => b.DiversNumber).IsRequired().HasMaxLength(5);
            builder.Property(b => b.Observations).IsRequired().HasMaxLength(200);
        }
    }
}