using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class VendaRepository(IDbConnection dbConnection) : IRepository<Venda>
{
    public async Task<IEnumerable<Venda>> GetAll()
    {
        return await dbConnection.QueryAsync<Venda>("SELECT * FROM vendas");
    }

    public async Task<Venda> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Venda>(
            "SELECT * FROM vendas WHERE id_venda = @Id_Venda", new { Id_Venda = id });
    }

    public async Task Add(Venda entity)
    {
        var query =
            "INSERT INTO vendas (id_cliente, nome_cliente, id_produto, nome_produto, descricao_produto, data_venda, valor_unitario, quantidade_vendida, valor_total)" +
            "VALUES (@Id_Cliente, @Nome_Cliente, @Id_Produto, @Nome_Produto, @Descricao_Produto, @Data_Venda, @Valor_Unitario, @Quantidade_Vendida, @Valor_Total)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Venda entity)
    {
        var query = "UPDATE vendas " +
                    "SET id_cliente = @Id_Cliente, nome_cliente = @Nome_Cliente, id_produto = @Id_Produto, nome_produto = @Nome_Produto, descricao_produto = @Descricao_Produto, data_venda = @Data_Venda, valor_unitario = @Valor_Unitario, quantidade_vendida = @Quantidade_Vendida, valor_total = @Valor_Total " +
                    "WHERE id_venda = @Id_Venda";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM vendas WHERE id_venda = @Id_Venda",
            new { Id_Venda = id });
    }
}