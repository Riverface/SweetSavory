using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SweetSavory.Models
{
    public class SweetSavoryContextFactory : IDesignTimeDbContextFactory<SweetSavoryContext>
    {
        SweetSavoryContext IDesignTimeDbContextFactory<SweetSavoryContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var builder = new DbContextOptionsBuilder<SweetSavoryContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new SweetSavoryContext(builder.Options);
        }
    }
}