using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class FornecedorRepository(IDbConnection dbConnection) : IFornecedorRepository
{
    public async Task<IEnumerable<Fornecedor>> GetAllFisico()
    {
        return await dbConnection.QueryAsync<Fornecedor>("SELECT * FROM fornecedores WHERE tipo = N'Físico'");
    }

    public async Task<IEnumerable<Fornecedor>> GetAllJuridico()
    {
        return await dbConnection.QueryAsync<Fornecedor>("SELECT * FROM fornecedores WHERE tipo = N'Jurídico'");
    }

    public async Task<IEnumerable<Fornecedor>> GetAll()
    {
        return await dbConnection.QueryAsync<Fornecedor>("SELECT * FROM fornecedores");
    }

    public async Task<Fornecedor> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Fornecedor>(
            "SELECT * FROM fornecedores WHERE id_fornecedor= @Id_Fornecedor", new { Id_Fornecedor = id });
    }

    public async Task Add(Fornecedor entity)
    {
        var query = "INSERT INTO fornecedores (nome, telefone, email, documento, endereco, data_inicial, tipo)" +
                    "VALUES (@Nome, @Telefone, @Email, @Documento, @Endereco, @Data_Inicial, @Tipo)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Fornecedor entity)
    {
        var query = "UPDATE fornecedores " +
                    "SET nome = @Nome, telefone = @Telefone, email = @Email, documento = @Documento, endereco = @Endereco, data_inicial = @Data_Inicial, tipo = @Tipo " +
                    "WHERE id_fornecedor = @Id_Fornecedor";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM fornecedores WHERE id_fornecedor = @Id_Fornecedor",
            new { Id_Fornecedor = id });
    }
}