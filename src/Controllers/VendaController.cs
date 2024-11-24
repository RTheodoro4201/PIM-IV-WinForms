using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Controllers;

#region TODO

//TODO Adicionar correção de estoque ao editar venda

#endregion

public class VendaController(
    IRepository<Venda> vendaRepository,
    IClienteRepository clienteFisicoRepository,
    IProdutoRepository produtoRepository)
{
    public async Task<bool> Create(Venda venda)
    {
        var vendaValidator = new VendaValidator();
        var vendaValidationResult = await vendaValidator.ValidateAsync(venda);

        if (vendaValidationResult.IsValid)
        {
            await vendaRepository.Add(venda);

            var produto = await produtoRepository.GetById(venda.Id_Produto);
            produto.Quantidade_Estoque -= venda.Quantidade_Vendida;

            await produtoRepository.UpdateEstoque(produto);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<Venda>> Index()
    {
        var vendas = await vendaRepository.GetAll();
        return vendas;
    }

    public async Task<Venda> SearchVenda(int vendaId)
    {
        return await vendaRepository.GetById(vendaId);
    }

    public async Task<Cliente> SearchCliente(int idCliente)
    {
        return await clienteFisicoRepository.GetById(idCliente);
    }

    public async Task<Produto> SearchProduto(int idProduto)
    {
        return await produtoRepository.GetById(idProduto);
    }

    public async Task<bool> Edit(Venda venda)
    {
        var vendaValidator = new VendaValidator();
        var vendaValidationResult = await vendaValidator.ValidateAsync(venda);

        if (vendaValidationResult.IsValid)
        {
            await vendaRepository.Update(venda);
            return true;
        }

        return false;
    }

    public async Task<bool> Delete(int id)
    {
        var venda = await vendaRepository.GetById(id);

        if (venda != null)
        {
            await vendaRepository.Delete(id);

            var produto = await produtoRepository.GetById(venda.Id_Produto);
            produto.Quantidade_Estoque += venda.Quantidade_Vendida;

            await produtoRepository.UpdateEstoque(produto);
            return true;
        }

        return false;
    }
}