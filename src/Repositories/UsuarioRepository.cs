using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Repositories;

public class UsuarioRepository(IDbConnection dbConnection) : IUsuarioRepository
{
    public async Task<IEnumerable<Usuario>> GetAll()
    {
        return await dbConnection.QueryAsync<Usuario>("SELECT * FROM usuarios");
    }

    public async Task<Usuario> GetById(int id)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Usuario>(
            "SELECT * FROM usuarios WHERE id_usuario = @Id_Usuario", new { Id_Usuario = id });
    }

    public async Task<Usuario> GetByLoginAndSenha(string login, string senha)
    {
        return await dbConnection.QueryFirstOrDefaultAsync<Usuario>(
            "SELECT * FROM usuarios WHERE login = @Login AND senha = @Senha", new { Login = login, Senha = senha });
    }

    public async Task Add(Usuario entity)
    {
        var query =
            "INSERT INTO usuarios (login, senha) " +
            "VALUES (@Login, @Senha)";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Update(Usuario entity)
    {
        var query = "UPDATE usuarios " +
                    "SET login = @Login, senha = @Senha " +
                    "WHERE id_usuario = @Id_Usuario";
        await dbConnection.ExecuteAsync(query, entity);
    }

    public async Task Delete(int id)
    {
        await dbConnection.ExecuteAsync("DELETE FROM usuarios WHERE id_usuario = @Id_Usuario",
            new { Id_Usuario = id });
    }
}