using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class CulturaRepository(IDbConnection dbConnection) : IRepository<Cultura>
{
    public async Task<IEnumerable<Cultura>> GetAll()
    {
        return await dbConnection.QueryAsync<Cultura>("SELECT * FROM culturas");
    }

    public async Task<Cultura> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Cultura>(
            "SELECT * FROM culturas WHERE id_cultura= @Id_Cultura", new { Id_Cultura = id });
    }

    public async Task Add(Cultura entity)
    {
        var query =
            "INSERT INTO culturas (nome, data_plantio, data_colheita, area_plantada, quantidade_plantada, tipo_solo, tipo_irrigacao, notas)" +
            "VALUES (@Nome, @Data_Plantio, @Data_Colheita, @Area_Plantada, @Quantidade_Plantada, @Tipo_Solo, @Tipo_Irrigacao, @Notas)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Cultura entity)
    {
        var query = "UPDATE culturas " +
                    "SET nome = @Nome, data_plantio = @Data_Plantio, data_colheita = @Data_Colheita, area_plantada = @Area_Plantada, quantidade_plantada = @Quantidade_Plantada, tipo_solo = @Tipo_Solo, tipo_irrigacao = @Tipo_Irrigacao, notas = @Notas " +
                    "WHERE id_cultura = @Id_Cultura";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM culturas WHERE id_cultura = @Id_Cultura",
            new { Id_Cultura = id });
    }
}