using System.Threading.Tasks;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public interface IUsuarioRepository : IRepository<Usuario>
{
    Task<Usuario> GetByLoginAndSenha(string login, string senha);
}