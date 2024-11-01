using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

#region TODOs
//TODO Refatorar campos
#endregion
namespace PIM_IV_Forms.Repositories;
public class FuncionarioRepository(IDbConnection dbConnection) : IRepository<Funcionario>
{
    public async Task<IEnumerable<Funcionario>> GetAll()
    {
        return await dbConnection.QueryAsync<Funcionario>("SELECT * FROM funcionarios");
    }

    public async Task<Funcionario?> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Funcionario>("SELECT * FROM funcionarios WHERE id = @Id", new { Id = id });
    }

    public async Task Add(Funcionario entity)
    {
        var query = "INSERT INTO funcionarios (nomeCompleto, cargo) VALUES (@Nome, @Cargo)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Funcionario entity)
    {
        var query = "UPDATE funcionarios SET nomeCompleto = @Nome, cargo = @Cargo WHERE id = @Id";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM funcionarios WHERE Id = @Id", new { Id = id });
    }
}