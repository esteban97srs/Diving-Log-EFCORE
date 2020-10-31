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
    }
}