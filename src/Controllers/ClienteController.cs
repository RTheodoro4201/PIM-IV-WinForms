using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Controllers;

public class ClienteController(IClienteRepository clienteRepository)
{
    public async Task<bool> Create(Cliente cliente, Endereco enderecoCliente)
    {
        var clienteValidator = new ClienteValidator();
        var enderecoValidator = new EnderecoValidator();
        var enderecoValidationResult = await enderecoValidator.ValidateAsync(enderecoCliente);
        var clienteValidationResult = await clienteValidator.ValidateAsync(cliente);

        if (enderecoValidationResult.IsValid && clienteValidationResult.IsValid)
        {
            await clienteRepository.Add(cliente);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<Cliente>> IndexAll()
    {
        var clientes = await clienteRepository.GetAll();
        return clientes;
    }

    public async Task<IEnumerable<Cliente>> IndexFisico()
    {
        var clientes = await clienteRepository.GetAllFisico();
        return clientes;
    }

    public async Task<IEnumerable<Cliente>> IndexJuridico()
    {
        var clientes = await clienteRepository.GetAllJuridico();
        return clientes;
    }

    public async Task<Cliente> SearchCliente(int clienteId)
    {
        var cliente = await clienteRepository.GetById(clienteId);
        return cliente;
    }


    public async Task<bool> Edit(Cliente cliente, Endereco enderecoCliente)
    {
        var clienteValidator = new ClienteValidator();
        var enderecoValidator = new EnderecoValidator();
        var enderecoValidationResult = await enderecoValidator.ValidateAsync(enderecoCliente);
        var clienteValidationResult = await clienteValidator.ValidateAsync(cliente);

        if (enderecoValidationResult.IsValid && clienteValidationResult.IsValid)
        {
            await clienteRepository.Update(cliente);
            return true;
        }

        return false;
    }

    public async Task<bool> Delete(int id)
    {
        var cliente = await clienteRepository.GetById(id);

        if (cliente != null)
        {
            await clienteRepository.Delete(id);
            return true;
        }

        return false;
    }
}