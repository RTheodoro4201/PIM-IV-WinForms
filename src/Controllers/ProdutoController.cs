using System.Collections.Generic;
using System.Threading.Tasks;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Repositories;
using PIM_IV_Forms.Validator;

namespace PIM_IV_Forms.Controllers;

public class ProdutoController(IRepository<Produto> produtoRepository)
{
    public async Task<bool> Create(Produto produto)
    {
        var produtoValidator = new ProdutoValidator();
        var produtoValidationResult = await produtoValidator.ValidateAsync(produto);

        if (produtoValidationResult.IsValid)
        {
            await produtoRepository.Add(produto);
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<Produto>> Index()
    {
        var produtos = await produtoRepository.GetAll();
        return produtos;
    }

    public async Task<Produto> SearchProduto(int produtoId)
    {
        var produto = await produtoRepository.GetById(produtoId);
        return produto;
    }

    public async Task<bool> Edit(Produto produto)
    {
        var produtoValidator = new ProdutoValidator();
        var produtoValidationResult = await produtoValidator.ValidateAsync(produto);

        if (produtoValidationResult.IsValid)
        {
            await produtoRepository.Update(produto);
            return true;
        }

        return false;
    }

    public async Task<bool> Delete(int id)
    {
        var produto = await produtoRepository.GetById(id);

        if (produto != null)
        {
            await produtoRepository.Delete(id);
            return true;
        }

        return false;
    }
}