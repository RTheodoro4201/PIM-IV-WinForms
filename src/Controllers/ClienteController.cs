using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using PIM_IV_Forms.Validator;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;

namespace PIM_IV_Forms.Controllers;

public class ClienteController(IRepository<Cliente> clienteRepository)
{
    public async Task Create(Cliente cliente)
    {
        ClienteValidator validator = new ClienteValidator();
        if (validator.ValidateModel(cliente))
        {
            await clienteRepository.Add(cliente);
        }

        if (validator.Erros.Any())
        {
            foreach (var erro in validator.Erros)
            {
                Console.WriteLine(erro.ToString());
            }
        }
    }

    public async Task Index()
    {
        var clientes = await clienteRepository.GetAll();
    }

    /*
    [HttpPost]
    public async Task<IActionResult> Edit(int id, Cliente cliente)
    {
        if (id != cliente.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                await clienteRepository.Update(cliente);
            }
            catch (Exception)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
        return View(cliente);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var cliente = await clienteRepository.GetById(id);

        if (!ModelState.IsValid || cliente == null)
        {
            return NotFound();
        }
        return View(cliente);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if (ModelState.IsValid)
        {
            await clienteRepository.Delete(id);
        }
        return RedirectToAction(nameof(Index));
    }
    */
}