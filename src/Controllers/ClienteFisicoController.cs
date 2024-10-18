using System.Threading.Tasks;
using PIM_IV_Forms.Validator;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;

namespace PIM_IV_Forms.Controllers;

public class ClienteFisicoController(IRepository<ClienteFisico> clienteFisicoRepository)
{
    public async Task<bool> Create(ClienteFisico clienteFisico)
    {
        var validator = new ClienteFisicoValidator();
        var validationResult = await validator.ValidateAsync(clienteFisico);

        if (validationResult.IsValid)
        {
            await clienteFisicoRepository.Add(clienteFisico);
            return true;
        }

        return false;
    }

    /* Método de listagem
    public async Task Index()
    {
        var clientesFisicos = await clienteRepository.GetAll();
    }
    */

    /*
    [HttpPost]
    public async Task<IActionResult> Edit(int id, ClienteFisico cliente)
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