using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace linxOne.Data.EF
{
  public  class linxOneDbContextFactory : IDesignTimeDbContextFactory<linxOneDbContext>
    {
        public linxOneDbContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();
            // ....................





            var optionsBuilder = new DbContextOptionsBuilder<linxOneDbContext>();
            optionsBuilder.UseSqlServer("Data Source=blog.db");

            return new linxOneDbContext(optionsBuilder.Options);
        }
    }
} 
