using Microsoft.EntityFrameworkCore;
using TRAPI.Models;

namespace TRAPI
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Data> Data { get; set; } = null!;
        public DbSet<FuelType> FuelTypes{ get; set; } = null!;
        public DbSet<Station> Stations { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5OJID68\GODSHOT;Initial Catalog=TrainingDB;User ID=test;Password=123");
        }
    }
}
