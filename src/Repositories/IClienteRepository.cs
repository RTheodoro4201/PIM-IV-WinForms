using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public interface IClienteRepository : IRepository<Cliente>
{
    Task<IEnumerable<Cliente>> GetAllFisico();
    Task<IEnumerable<Cliente>> GetAllJuridico();
}