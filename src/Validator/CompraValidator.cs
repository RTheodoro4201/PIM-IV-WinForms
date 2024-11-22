using System;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class CompraValidator : AbstractValidator<Compra>
{
    public CompraValidator()
    {
        RuleFor(compra => compra.Id_Fornecedor)
            .NotEmpty().WithMessage("O código do fornecedor deve ser informado");

        RuleFor(compra => compra.Data_Compra)
            .NotEmpty().WithMessage("A data de compra deve ser informada.")
            .LessThanOrEqualTo(DateTime.Now).WithMessage("A data de compra não pode ser maior do que a data de hoje.");

        RuleFor(compra => compra.Id_Insumo)
            .NotEmpty().WithMessage("O código do insumo deve ser informado.");

        RuleFor(compra => compra.Quantidade_Comprada)
            .NotEmpty().WithMessage("A quantidade comprada deve ser informada.")
            .GreaterThan(0).WithMessage("A quantidade comprada deve ser maior que zero.");

        RuleFor(compra => compra.Valor_Unitario)
            .NotEmpty().WithMessage("O valor unitário deve ser informado.")
            .GreaterThan(0).WithMessage("O valor unitário deve ser maior que zero.");

        RuleFor(compra => compra.Valor_Total)
            .NotEmpty().WithMessage("O valor total deve ser informado.")
            .GreaterThan(0).WithMessage("O valor total deve ser maior que zero.")
            .Must(ValidarValorTotal).WithMessage("O valor total deve ser maior ou igual o valor unitário.");
    }

    private static bool ValidarValorTotal(Compra compra, decimal valorTotal)
    {
        if (compra.Quantidade_Comprada == 1 && valorTotal == compra.Valor_Unitario)
        {
            return true;
        }

        if (compra.Quantidade_Comprada > 1 && valorTotal >= compra.Valor_Unitario)
        {
            return true;
        }

        return false;
    }
}