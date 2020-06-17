using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace SweetSavory.Models
{
    public class SweetSavoryContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Flavor> Flavors { get; set; }
        public virtual DbSet<Treat> Treats { get; set; }
        public virtual DbSet<FlavorTreat> FlavorTreat { get; set; }
        public SweetSavoryContext(DbContextOptions options) : base(options) { }
    }
}