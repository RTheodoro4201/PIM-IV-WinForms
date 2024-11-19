using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Controllers;

public class CulturaController(IRepository<Cultura> culturaRepository)
{
    public async Task<bool> Create(Cultura cultura)
    {
        var culturaValidator = new CulturaValidator();
       var culturaValidationResult = await culturaValidator.ValidateAsync(cultura);

        if (culturaValidationResult.IsValid)
        {
            await culturaRepository.Add(cultura);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<Cultura>> Index()
    {
        var culturas = await culturaRepository.GetAll();
        return culturas;
    }

    public async Task<Cultura> SearchCultura(int culturaId)
    {
        var cultura = await culturaRepository.GetById(culturaId);
        return cultura;
    }

    public async Task<bool> Edit(Cultura cultura)
    {
        var culturaValidator = new CulturaValidator();
        var culturaValidationResult = await culturaValidator.ValidateAsync(cultura);

        if (culturaValidationResult.IsValid)
        {
            await culturaRepository.Update(cultura);
            return true;
        }

        return false;
    }

    public async Task<bool> Delete(int id)
    {
        var cultura = await culturaRepository.GetById(id);

        if (cultura != null)
        {
            await culturaRepository.Delete(id);
            return true;
        }

        return false;
    }
}