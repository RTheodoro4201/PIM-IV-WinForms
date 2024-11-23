using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class InsumoRepository(IDbConnection dbConnection) : IInsumoRepository
{
    public async Task<IEnumerable<Insumo>> GetAll()
    {
        return await dbConnection.QueryAsync<Insumo>("SELECT * FROM insumos");
    }

    public async Task<Insumo> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Insumo>(
            "SELECT * FROM insumos WHERE id_insumo= @Id_Insumo", new { Id_Insumo = id });
    }

    public async Task Add(Insumo entity)
    {
        var query =
            "INSERT INTO insumos (nome, descricao, quantidade_estoque, data_compra, data_validade, id_fornecedor, nome_fornecedor)" +
            "VALUES (@Nome, @Descricao, @Quantidade_Estoque, @Data_Compra, @Data_Validade, @Id_Fornecedor, @Nome_Fornecedor)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Insumo entity)
    {
        var query = "UPDATE insumos " +
                    "SET nome = @Nome, descricao = @Descricao, quantidade_estoque = @Quantidade_Estoque, data_compra = @Data_Compra, data_validade = @Data_Validade, id_fornecedor = @Id_Fornecedor, nome_fornecedor = @Nome_Fornecedor " +
                    "WHERE id_insumo = @Id_Insumo";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM insumos WHERE id_insumo = @Id_Insumo",
            new { Id_Insumo = id });
    }

    public async Task UpdateEstoque(Insumo insumo)
    {
        var query = "UPDATE insumos " +
                    "SET quantidade_estoque = @Quantidade_Estoque "+
                    "WHERE id_insumo = @Id_Insumo";
        await dbConnection.ExecuteAsync(query, insumo);
    }
}