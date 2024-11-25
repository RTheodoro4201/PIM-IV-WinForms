using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Controllers;

public class UsuarioController(
    IUsuarioRepository usuarioRepository)
{
    public async Task<bool> Create(Usuario usuario)
    {
        var usuarioValidator = new UsuarioValidator();
        var usuarioValidationResult = await usuarioValidator.ValidateAsync(usuario);

        if (usuarioValidationResult.IsValid)
        {
            await usuarioRepository.Add(usuario);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<Usuario>> Index()
    {
        var usuarios = await usuarioRepository.GetAll();
        return usuarios;
    }

    public async Task<Usuario> SearchUsuario(int usuarioId)
    {
        return await usuarioRepository.GetById(usuarioId);
    }

    public async Task<Usuario> TestUsuario(string login, string senha)
    {
        return await usuarioRepository.GetByLoginAndSenha(login, senha);
    }
    public async Task<bool> Edit(Usuario usuario)
    {
        var usuarioValidator = new UsuarioValidator();
        var usuarioValidationResult = await usuarioValidator.ValidateAsync(usuario);

        if (usuarioValidationResult.IsValid)
        {
            await usuarioRepository.Update(usuario);
            return true;
        }

        return false;
    }

    public async Task<bool> Delete(int id)
    {
        var usuario = await usuarioRepository.GetById(id);

        if (usuario != null)
        {
            await usuarioRepository.Delete(id);

            return true;
        }

        return false;
    }
}