using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Controllers;

public class FornecedorController(IFornecedorRepository fornecedorRepository)
{
    public async Task<bool> Create(Fornecedor fornecedor, Endereco endereco)
    {
        var fornecedorValidator = new FornecedorValidator();
        var enderecoValidator = new EnderecoValidator();
        var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);
        var clienteValidationResult = await fornecedorValidator.ValidateAsync(fornecedor);

        if (enderecoValidationResult.IsValid && clienteValidationResult.IsValid)
        {
            await fornecedorRepository.Add(fornecedor);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<Fornecedor>> IndexAll()
    {
        var fornecedores = await fornecedorRepository.GetAll();
        return fornecedores;
    }

    public async Task<IEnumerable<Fornecedor>> IndexFisico()
    {
        var fornecedores = await fornecedorRepository.GetAllFisico();
        return fornecedores;
    }

    public async Task<IEnumerable<Fornecedor>> IndexJuridico()
    {
        var fornecedores = await fornecedorRepository.GetAllJuridico();
        return fornecedores;
    }

    public async Task<Fornecedor> SearchFornecedor(int fornecedorId)
    {
        var fornecedor = await fornecedorRepository.GetById(fornecedorId);
        return fornecedor;
    }

    public async Task<bool> Edit(Fornecedor fornecedor, Endereco endereco)
    {
        var fornecedorValidator = new FornecedorValidator();
        var enderecoValidator = new EnderecoValidator();
        var enderecoValidationResult = await enderecoValidator.ValidateAsync(endereco);
        var fornecedorValidationResult = await fornecedorValidator.ValidateAsync(fornecedor);

        if (enderecoValidationResult.IsValid && fornecedorValidationResult.IsValid)
        {
            await fornecedorRepository.Update(fornecedor);
            return true;
        }

        return false;
    }

    public async Task<bool> Delete(int id)
    {
        var fornecedor = await fornecedorRepository.GetById(id);

        if (fornecedor != null)
        {
            await fornecedorRepository.Delete(id);
            return true;
        }

        return false;
    }
}