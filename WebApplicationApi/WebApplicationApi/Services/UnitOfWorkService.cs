using WebApplicationApi.DataAcces;
using WebApplicationApi.DataAccess;

namespace WebApplicationApi.Services
{
    public class UnitOfWorkService : IUnitOfWork
    {
        private readonly AplicacionDbContext _context;

        public UsuarioRepository UsuarioRepository { get; private set; }

        public UnitOfWorkService( AplicacionDbContext context )
        {
            _context = context;
            UsuarioRepository = new UsuarioRepository(_context);
        }

        public Task<int> Complete()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
