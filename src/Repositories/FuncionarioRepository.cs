using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class FuncionarioRepository(IDbConnection dbConnection) : IRepository<Funcionario>
{
    public async Task<IEnumerable<Funcionario>> GetAll()
    {
        return await dbConnection.QueryAsync<Funcionario>("SELECT * FROM funcionarios");
    }

    public async Task<Funcionario> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Funcionario>(
            "SELECT * FROM funcionarios WHERE id_funcionario= @Id_Funcionario", new { Id_Funcionario = id });
    }

    public async Task Add(Funcionario entity)
    {
        var query =
            "INSERT INTO funcionarios (nome_completo, rg, cpf, cargo, email, telefone, salario, data_admissao, endereco)" +
            "VALUES (@Nome_Completo, @Rg, @Cpf, @Cargo, @Email, @Telefone, @Salario, @Data_Admissao, @Endereco)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Funcionario entity)
    {
        var query = "UPDATE funcionarios " +
                    "SET nome_completo = @Nome_Completo, rg = @Rg, cpf = @Cpf, cargo = @Cargo, email = @Email, telefone = @Telefone, salario = @Salario, data_admissao = @Data_Admissao, endereco = @Endereco " +
                    "WHERE id_funcionario = @Id_Funcionario";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM funcionarios WHERE id_funcionario = @Id_Funcionario",
            new { Id_Funcionario = id });
    }
}