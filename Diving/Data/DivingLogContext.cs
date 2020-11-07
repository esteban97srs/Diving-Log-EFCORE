using DivingLogs.Models;
using Microsoft.EntityFrameworkCore;
namespace DivingLogs.Data 
{
    public class DivingLogContext : DbContext
    {
        public DivingLogContext(DbContextOptions <DivingLogContext> opt) : base(opt)
        {
        }
        public DbSet<DivingLog> Divings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DivingLogConfiguration()); // Aplicando la configuracion del archivo Fluent API para entidad DIVINGLOG
        }
        
    }
}