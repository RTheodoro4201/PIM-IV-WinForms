using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Controllers;

public class CompraController(
    IRepository<Compra> compraRepository,
    IFornecedorRepository fornecedorRepository,
    IInsumoRepository insumoRepository)
{
    public async Task<bool> Create(Compra compra)
    {
        var compraValidator = new CompraValidator();
        var compraValidationResult = await compraValidator.ValidateAsync(compra);

        if (compraValidationResult.IsValid)
        {
            await compraRepository.Add(compra);

            var insumo = await insumoRepository.GetById(compra.Id_Insumo);
            insumo.Quantidade_Estoque += compra.Quantidade_Comprada;

            await insumoRepository.UpdateEstoque(insumo);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<Compra>> Index()
    {
        var compras = await compraRepository.GetAll();
        return compras;
    }

    public async Task<Compra> SearchCompra(int compraId)
    {
        return await compraRepository.GetById(compraId);
    }

    public async Task<Fornecedor> SearchFornecedor(int idFornecedor)
    {
        return await fornecedorRepository.GetById(idFornecedor);
    }

    public async Task<Insumo> SearchInsumo(int idInsumo)
    {
        return await insumoRepository.GetById(idInsumo);
    }

    public async Task<bool> Edit(Compra compra)
    {
        var compraValidator = new CompraValidator();
        var compraValidationResult = await compraValidator.ValidateAsync(compra);

        if (compraValidationResult.IsValid)
        {
            await compraRepository.Update(compra);
            return true;
        }

        return false;
    }

    public async Task<bool> Delete(int id)
    {
        var compra = await compraRepository.GetById(id);

        if (compra != null)
        {
            await compraRepository.Delete(id);
            return true;
        }

        return false;
    }
}