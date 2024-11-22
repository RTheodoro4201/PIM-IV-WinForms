using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class CompraRepository(IDbConnection dbConnection) : IRepository<Compra>
{
    public async Task<IEnumerable<Compra>> GetAll()
    {
        return await dbConnection.QueryAsync<Compra>("SELECT * FROM compras");
    }

    public async Task<Compra> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Compra>(
            "SELECT * FROM compras WHERE id_compra = @Id_Compra", new { Id_Compra = id });
    }

    public async Task Add(Compra entity)
    {
        var query =
            "INSERT INTO compras (id_fornecedor, nome_fornecedor, data_compra, id_insumo, nome_insumo, quantidade_comprada, valor_unitario, valor_total)" +
            "VALUES (@Id_Fornecedor, @Nome_Fornecedor, @Data_Compra, @Id_Insumo, @Nome_Insumo, @Quantidade_Comprada, @Valor_Unitario, @Valor_Total)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Compra entity)
    {
        var query = "UPDATE compras " +
                    "SET id_fornecedor = @Id_Fornecedor, nome_fornecedor = @Nome_Fornecedor, data_compra = @Data_Compra, id_insumo = @Id_Insumo, nome_insumo = @Nome_Insumo, quantidade_comprada = @Quantidade_Comprada, valor_unitario = @Valor_Unitario, valor_total = @Valor_Total " +
                    "WHERE id_compra = @Id_Compra";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM compras WHERE id_compra = @Id_Compra",
            new { Id_Compra = id });
    }
}