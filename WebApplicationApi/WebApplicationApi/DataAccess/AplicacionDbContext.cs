using Microsoft.EntityFrameworkCore;
using WebApplicationApi.DataAccess.DatabaseSeeding;
using WebApplicationApi.Entities;
using System;
using System.Collections.Generic;

namespace WebApplicationApi.DataAcces
{
    public class AplicacionDbContext : DbContext
    {
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            var seeders = new List<IEntitySeeder>
            {
                new UsuarioSeeder()
            };

            foreach (var seeder in seeders)
            {
                seeder.SeedDatabase(modelBuilder);
            }
        }
    }
}