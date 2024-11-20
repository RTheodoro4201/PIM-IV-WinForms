using System;
using System.Data;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class InsumoValidator : AbstractValidator<Insumo>
{
    public InsumoValidator()
    {
        RuleFor(insumo => insumo.Nome)
            .NotEmpty().WithMessage("O nome do insumo deve ser informado.")
            .MinimumLength(3).WithMessage("O nome deve conter ao menos 3 letras.")
            .Matches(@"^[a-zA-Zà-úÀ-Ú\s\-\']+$")
            .WithMessage("O nome deve conter apenas letras, acentos, espaços, hífens e apóstrofos.")
            .Must(nome => !string.IsNullOrWhiteSpace(nome))
            .WithMessage("O nome não pode conter apenas espaços em branco.")
            .Must(nome => char.IsLetter(nome[0])).WithMessage("A primeira letra do nome deve ser uma letra.");

        RuleFor(insumo => insumo.Descricao)
            .NotEmpty().WithMessage("A descrição do insumo deve ser informada.")
            .MinimumLength(10).WithMessage("A descrição deve conter ao menos 10 caracteres.");

        RuleFor(insumo => insumo.Quantidade_Estoque)
            .NotEmpty().WithMessage("A quantidade em estoque deve ser informada.")
            .GreaterThan(-1).WithMessage("A quantidade em estoque não pode ser negativa.");

        RuleFor(insumo => insumo.Data_Compra)
            .NotEmpty().WithMessage("A data de compra deve ser informada.");

        RuleFor(insumo => insumo.Data_Validade)
            .NotEmpty().WithMessage("A data de validade deve ser informada.")
            .GreaterThan(DateTime.Now).WithMessage("A data de validade não pode ser menor ou igual a data de hoje.");

        RuleFor(insumo => insumo.Id_Fornecedor)
            .NotEmpty().WithMessage("O código do fornecedor deve ser informado.");
    }
}