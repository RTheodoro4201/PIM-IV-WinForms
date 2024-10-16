using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class ClienteFisicoRepository(IDbConnection dbConnection) : IRepository<ClienteFisico>
{
    public async Task<IEnumerable<ClienteFisico>> GetAll()
    {
        return await dbConnection.QueryAsync<ClienteFisico>("SELECT * FROM clientes");
    }

    public async Task<ClienteFisico?> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<ClienteFisico>("SELECT * FROM clientes WHERE id = @Id", new { Id = id });
    }

    public async Task Add(ClienteFisico entity)
    {
        var query = "INSERT INTO clientes (nome, documento, tipoDocumento, telefone) VALUES (@Nome, @Documento, @TipoDocumento, @Telefone)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(ClienteFisico entity)
    {
        var query = "UPDATE clientes SET nome = @Nome, documento = @Documento, tipoDocumento = @TipoDocumento, telefone = @Telefone WHERE id = @Id";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM clientes WHERE Id = @Id", new { Id = id });
    }
}