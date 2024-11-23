using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Controllers;

public class InsumoController(IInsumoRepository insumoRepository,
    IFornecedorRepository fornecedorRepository)
{
    public async Task<bool> Create(Insumo insumo)
    {
        var insumoValidator = new InsumoValidator();
        var insumoValidationResult = await insumoValidator.ValidateAsync(insumo);

        if (insumoValidationResult.IsValid)
        {
            await insumoRepository.Add(insumo);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<Insumo>> Index()
    {
        var insumos = await insumoRepository.GetAll();
        return insumos;
    }

    public async Task<Insumo> SearchInsumo(int insumoId)
    {
        return await insumoRepository.GetById(insumoId);
    }

    public async Task<Fornecedor> SearchFornecedor(int idFornecedor)
    {
        return await fornecedorRepository.GetById(idFornecedor);
    }

    public async Task<bool> Edit(Insumo insumo)
    {
        var insumoValidator = new InsumoValidator();
        var insumoValidationResult = await insumoValidator.ValidateAsync(insumo);

        if (insumoValidationResult.IsValid)
        {
            await insumoRepository.Update(insumo);
            return true;
        }

        return false;
    }

    public async Task<bool> Delete(int id)
    {
        var insumo = await insumoRepository.GetById(id);

        if (insumo != null)
        {
            await insumoRepository.Delete(id);
            return true;
        }

        return false;
    }
}