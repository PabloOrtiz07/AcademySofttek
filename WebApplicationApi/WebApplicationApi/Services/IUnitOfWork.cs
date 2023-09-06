using WebApplicationApi.DataAccess;
using WebApplicationApi.DataAccess.Interfaces;

namespace WebApplicationApi.Services
{
    public interface IUnitOfWork : IDisposable
    {
        public UsuarioRepository UsuarioRepository { get; }

        Task<int> Complete();
    }
}
