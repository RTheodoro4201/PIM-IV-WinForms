using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public interface IFornecedorRepository : IRepository<Fornecedor>
{
    Task<IEnumerable<Fornecedor>> GetAllFisico();
    Task<IEnumerable<Fornecedor>> GetAllJuridico();
}