using Microsoft.EntityFrameworkCore;
using WebApplicationApi.DataAcces;
using WebApplicationApi.DataAccess.Interfaces;

namespace WebApplicationApi.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AplicacionDbContext _context;

        public Repository(AplicacionDbContext context)
        {
            _context = context;
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }


    }
}
