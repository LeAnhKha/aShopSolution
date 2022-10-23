using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace aShopSolution.Data.EF
{
    public class AShopDbContextFactory : IDesignTimeDbContextFactory<AShopDbContext>
    {
        public AShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("aShopSolutionDb");

            var optionsBuider = new DbContextOptionsBuilder<AShopDbContext>();
            optionsBuider.UseSqlServer(connectionString);
            return new AShopDbContext(optionsBuider.Options);
        }
    }
}
