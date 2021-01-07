using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DivingLogs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Diving_Log
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DivingLogContext>
    {
        public DivingLogContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<DivingLogContext>();
            var connectionString = configuration.GetConnectionString("DivingConnection");
            builder.UseSqlServer(connectionString);
            return new DivingLogContext(builder.Options);
        }
    }
}
