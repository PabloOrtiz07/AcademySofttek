using Microsoft.EntityFrameworkCore;

namespace WebApplicationApi.DataAccess.DatabaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDatabase(ModelBuilder modelBuilder);
    }
}
