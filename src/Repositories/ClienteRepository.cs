using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class ClienteRepository(IDbConnection dbConnection) : IClienteRepository
{
    public async Task<IEnumerable<Cliente>> GetAll()
    {
        return await dbConnection.QueryAsync<Cliente>("SELECT * FROM clientes");
    }

    public async Task<IEnumerable<Cliente>> GetAllFisico()
    {
        return await dbConnection.QueryAsync<Cliente>("SELECT * FROM clientes WHERE tipo = N'Físico'");
    }

    public async Task<IEnumerable<Cliente>> GetAllJuridico()
    {
        return await dbConnection.QueryAsync<Cliente>("SELECT * FROM clientes WHERE tipo = N'Jurídico'");
    }

    public async Task<Cliente> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Cliente>(
            "SELECT * FROM clientes WHERE id_cliente = @Id", new { Id = id });
    }

    public async Task Add(Cliente entity)
    {
        var query =
            "INSERT INTO clientes (nome, tipo, documento, email, telefone, endereco, data_inicial) VALUES (@Nome, @Tipo, @Documento, @Email, @Telefone, @Endereco, @Data_Inicial)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Cliente entity)
    {
        var query =
            "UPDATE clientes SET nome = @Nome, tipo = @Tipo, documento = @Documento, email = @Email, telefone = @Telefone, endereco = @Endereco, data_inicial = @Data_Inicial WHERE id_cliente = @Id_Cliente";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM clientes WHERE id_cliente = @Id_Cliente",
            new { Id_Cliente = id });
    }
}