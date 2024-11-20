using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class ProdutoRepository(IDbConnection dbConnection) : IRepository<Produto>
{
    public async Task<IEnumerable<Produto>> GetAll()
    {
        return await dbConnection.QueryAsync<Produto>("SELECT * FROM produtos");
    }

    public async Task<Produto> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Produto>(
            "SELECT * FROM produtos WHERE Id_produto= @Id_Produto", new { Id_Produto = id });
    }

    public async Task Add(Produto entity)
    {
        var query =
            "INSERT INTO produtos (Nome, Descricao, Quantidade_Estoque, Preco_Unitario, Data_Validade)" +
            "VALUES (@Nome, @Descricao, @Quantidade_Estoque, @Preco_Unitario, @Data_Validade)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Produto entity)
    {
        var query = "UPDATE produtos " +
                    "SET Nome = @Nome, Descricao = @Descricao, Quantidade_Estoque = @Quantidade_Estoque, Preco_Unitario = @Preco_Unitario, Data_Validade = @Data_Validade " +
                    "WHERE Id_Produto = @Id_Produto";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM produtos WHERE Id_Produto = @Id_Produto",
            new { Id_Produto = id });
    }
}