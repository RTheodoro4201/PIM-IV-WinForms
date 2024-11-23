using System;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class VendaValidator : AbstractValidator<Venda>
{
    public VendaValidator()
    {
        RuleFor(venda => venda.Id_Cliente)
            .NotEmpty().WithMessage("O código do cliente deve ser informado.");

        RuleFor(venda => venda.Nome_Cliente)
            .NotEmpty().WithMessage("O nome do cliente deve ser informado.")
            .Must(nomeCliente => !string.IsNullOrWhiteSpace(nomeCliente)).WithMessage("O nome não pode conter apenas espaços em branco.");

        RuleFor(venda => venda.Id_Produto)
            .NotEmpty().WithMessage("O código do produto deve ser informado.");

        RuleFor(venda => venda.Nome_Produto)
            .NotEmpty().WithMessage("O nome do produto deve ser informado.")
            .Must(nomeProduto => !string.IsNullOrWhiteSpace(nomeProduto)).WithMessage("O nome não pode conter apenas espaços em branco.");

        RuleFor(venda => venda.Descricao_Produto)
            .NotEmpty().WithMessage("A descrição do produto deve ser informada.")
            .Must(descricaoProduto => !string.IsNullOrWhiteSpace(descricaoProduto)).WithMessage("O nome não pode conter apenas espaços em branco.");

        RuleFor(venda => venda.Data_Venda)
            .NotEmpty().WithMessage("A data de venda deve ser informada.")
            .LessThanOrEqualTo(DateTime.Now).WithMessage("A data de venda não pode ser futura.");

        RuleFor(venda => venda.Valor_Unitario)
            .NotEmpty().WithMessage("O valor unitário deve ser informado.")
            .GreaterThan(0).WithMessage("O valor unitário deve ser maior que zero.");

        RuleFor(venda => venda.Quantidade_Vendida)
            .NotEmpty().WithMessage("A quantidade vendida deve ser informada")
            .GreaterThan(0).WithMessage("A quantidade vendida deve ser maior que zero.");

        RuleFor(venda => venda.Valor_Total)
            .NotEmpty().WithMessage("O valor total deve ser informado.")
            .GreaterThan(0).WithMessage("O valor total deve ser maior que zero.");
    }
}