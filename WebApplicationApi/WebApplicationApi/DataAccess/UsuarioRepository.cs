using WebApplicationApi.DataAccess.Interfaces;
using WebApplicationApi.DataAccess.Repositories;
using WebApplicationApi.Entities;

namespace WebApplicationApi.DataAccess
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
    }
}
