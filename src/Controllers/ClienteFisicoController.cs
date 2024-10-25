using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Controllers;

public class ClienteFisicoController(IRepository<ClienteFisico> clienteFisicoRepository)
{
    public async Task<bool> Create(ClienteFisico cliente)
    {
        var validator = new ClienteFisicoValidator();
        var validationResult = await validator.ValidateAsync(cliente);

        if (validationResult.IsValid)
        {
            await clienteFisicoRepository.Add(cliente);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<ClienteFisico>> Index()
    {
        var clientes = await clienteFisicoRepository.GetAll();
        return clientes;
    }

    public async Task<ClienteFisico> SearchCliente(int clienteId)
    {
        var cliente = await clienteFisicoRepository.GetById(clienteId);
        return cliente;
    }

    public async Task<bool> Edit(ClienteFisico cliente)
    {
        var validator = new ClienteFisicoValidator();
        var validationResult = await validator.ValidateAsync(cliente);

        if (validationResult.IsValid)
        {
            await clienteFisicoRepository.Update(cliente);
            return true;
        }

        return false;
    }

    public async Task<bool> Delete(int id)
    {
        var cliente = await clienteFisicoRepository.GetById(id);

        if (cliente != null)
        {
            await clienteFisicoRepository.Delete(id);
            return true;
        }

        return false;
    }
}