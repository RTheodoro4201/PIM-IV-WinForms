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
        return await dbConnection.QueryAsync<ClienteFisico>("SELECT * FROM clientes_fisicos");
    }

    public async Task<ClienteFisico> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<ClienteFisico>("SELECT * FROM clientes_fisicos WHERE id_cliente = @Id", new { Id = id });
    }

    public async Task Add(ClienteFisico entity)
    {
        var query =
            "INSERT INTO clientes_fisicos (nome_completo, rg, cpf, email, telefone, endereco, data_de_nascimento) VALUES (@Nome, @Rg, @Cpf, @Email, @Telefone, @Endereco, @DataNascimento)";
        await dbConnection.ExecuteAsync(query, new
        {
            Nome = entity.Nome,
            Rg = entity.Rg,
            Cpf = entity.Cpf,
            Email = entity.Email,
            Telefone = entity.Telefone,
            Endereco = entity.Endereco.ToString(),
            DataNascimento = entity.DataNascimento
        });
    }

    public async Task Update(ClienteFisico entity)
    {
        var query = "UPDATE clientes_fisicos SET nome_completo = @Nome, rg = @Rg, cpf = @Cpf, email = @Email, telefone = @Telefone, endereco = @Endereco.ToString(), data_de_nascimento = @DataNascimento WHERE id_cliente = @Id";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM clientes_fisicos WHERE id_cliente = @Id", new { Id = id });
    }

}
