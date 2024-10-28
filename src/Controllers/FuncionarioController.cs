using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Controllers;

public class FuncionarioController(IRepository<Funcionario> funcionarioRepository)
{
    public async Task<bool> Create(Funcionario funcionario, Endereco endereco)
    {
        var funcionarioValidator = new FuncionarioValidator();
        var enderecoValidator = new EnderecoValidator();
        var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);
        var clienteValidationResult = await funcionarioValidator.ValidateAsync(funcionario);

        if (enderecoValidationResult.IsValid && clienteValidationResult.IsValid)
        {
            await funcionarioRepository.Add(funcionario);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<Funcionario>> Index()
    {
        var funcionarios = await funcionarioRepository.GetAll();
        return funcionarios;
    }

    public async Task<Funcionario> SearchFuncionario(int funcionarioId)
    {
        var funcionario = await funcionarioRepository.GetById(funcionarioId);
        return funcionario;
    }

    public async Task<bool> Edit(Funcionario funcionario, Endereco endereco)
    {
        var funcionarioValidator = new FuncionarioValidator();
        var enderecoValidator = new EnderecoValidator();
        var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);
        var funcionarioValidationResult = await funcionarioValidator.ValidateAsync(funcionario);

        if (enderecoValidationResult.IsValid && funcionarioValidationResult.IsValid)
        {
            await funcionarioRepository.Update(funcionario);
            return true;
        }

        return false;
    }

    public async Task<bool> Delete(int id)
    {
        var funcionario = await funcionarioRepository.GetById(id);

        if (funcionario != null)
        {
            await funcionarioRepository.Delete(id);
            return true;
        }

        return false;
    }
}