using System.Collections.Generic;
using System.Threading.Tasks;
using api_tw.Models;

namespace api_tw.Interfaces
{
    public interface ITipoUsuarioRepositorio
    {
        Task<List<TipoUsuario>> Get();

        Task<TipoUsuario> Get(int id);

        Task<TipoUsuario> Post (TipoUsuario tipoUsuario);

        Task<TipoUsuario> Put (TipoUsuario tipoUsuario);

        Task<TipoUsuario> Delete (TipoUsuario tipoUsuario);
        
    }
}