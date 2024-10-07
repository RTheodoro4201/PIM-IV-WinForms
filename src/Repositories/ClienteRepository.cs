using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class ClienteRepository(IDbConnection dbConnection) : IRepository<Cliente>
{
    public async Task<IEnumerable<Cliente>> GetAll()
    {
        return await dbConnection.QueryAsync<Cliente>("SELECT * FROM clientes");
    }

    public async Task<Cliente?> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Cliente>("SELECT * FROM clientes WHERE id = @Id", new { Id = id });
    }

    public async Task Add(Cliente entity)
    {
        var query = "INSERT INTO clientes (nome, documento, tipoDocumento, telefone) VALUES (@Nome, @Documento, @TipoDocumento, @Telefone)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Cliente entity)
    {
        var query = "UPDATE clientes SET nome = @Nome, documento = @Documento, tipoDocumento = @TipoDocumento, telefone = @Telefone WHERE id = @Id";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM clientes WHERE Id = @Id", new { Id = id });
    }
}