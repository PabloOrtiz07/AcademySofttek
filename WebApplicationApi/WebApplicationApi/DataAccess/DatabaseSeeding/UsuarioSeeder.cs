using Microsoft.EntityFrameworkCore;
using WebApplicationApi.Entities;

namespace WebApplicationApi.DataAccess.DatabaseSeeding
{
    public class UsuarioSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Name = "Pablo"
                });
        }

        
    }
}
