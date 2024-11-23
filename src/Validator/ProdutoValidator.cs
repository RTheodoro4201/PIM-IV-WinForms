using System;
using System.Data;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class ProdutoValidator : AbstractValidator<Produto>
{
    public ProdutoValidator()
    {
        RuleFor(produto => produto.Nome)
            .NotEmpty().WithMessage("O nome do fornecedor deve ser informado.")
            .MinimumLength(3).WithMessage("O nome deve conter ao menos 3 letras.")
            .Must(nome => !string.IsNullOrWhiteSpace(nome))
            .WithMessage("O nome não pode conter apenas espaços em branco.");

        RuleFor(produto => produto.Descricao)
            .NotEmpty().WithMessage("A descrição do produto deve ser informada.")
            .MinimumLength(10).WithMessage("A descrição deve conter ao menos 10 caracteres.");

        RuleFor(produto => produto.Quantidade_Estoque)
            .NotEmpty().WithMessage("A quantidade em estoque deve ser informada.")
            .GreaterThan(-1).WithMessage("A quantidade em estoque não pode ser negativa.");

        RuleFor(produto => produto.Preco_Unitario)
            .NotEmpty().WithMessage("O preço unitário deve ser informado.")
            .GreaterThan(0).WithMessage("O preço unitário deve ser maior que zero.");

        RuleFor(produto => produto.Data_Validade)
            .NotEmpty().WithMessage("A data de validade deve ser informada.")
            .Must(ValidarDataValidade).WithMessage("A data de validade deve ter ao menos 7 dias de diferença da data atual.");
    }

    private static bool ValidarDataValidade(DateTime dataValidade)
    {
        if (dataValidade >= DateTime.Now.AddDays(7))
        {
            return true;
        }

        return false;
    }
}