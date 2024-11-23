using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public interface IProdutoRepository : IRepository<Produto>
{
    Task UpdateEstoque(Produto produto);
}