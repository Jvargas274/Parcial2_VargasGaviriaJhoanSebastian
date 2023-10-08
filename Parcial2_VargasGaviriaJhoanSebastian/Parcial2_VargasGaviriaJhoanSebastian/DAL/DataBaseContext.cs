using Microsoft.EntityFrameworkCore;
using Parcial2_VargasGaviriaJhoanSebastian.DAL.Entities;

namespace Parcial2_VargasGaviriaJhoanSebastian.DAL
{
    public class DataBaseContext : DbContext
    {
        public DbSet<NaturalPerson> NaturalPerson { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NaturalPerson>().HasIndex(NaturalPerson => NaturalPerson.FullName).IsUnique();
        }
    }
}
