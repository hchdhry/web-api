using Microsoft.EntityFrameworkCore;
using Test.models;


namespace Test.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext (DbContextOptions<AppDBContext> options):base(options)
        {

        }
        public DbSet<Car> cars {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>().HasData(
  new Car() {name = "test",weight = 123,registration = "t3st"},
 new Car(){name = "test1", weight = 1234, registration = "t3st1"});
 }}}
