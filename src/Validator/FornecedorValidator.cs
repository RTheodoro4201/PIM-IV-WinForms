using System;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class FornecedorValidator : AbstractValidator<Fornecedor>
{
    public FornecedorValidator()
    {
        RuleFor(fornecedor => fornecedor.Nome)
            .NotEmpty().WithMessage("O nome do fornecedor deve ser informado.")
            .MinimumLength(3).WithMessage("O nome deve conter ao menos 3 letras!")
            .Must(nome => !string.IsNullOrWhiteSpace(nome)).WithMessage("O nome não pode conter apenas espaços em branco.");

        RuleFor(fornecedor => fornecedor.Documento)
            .NotEmpty().WithMessage("O documento deve ser informado.")
            .Matches(@"^\d{11,14}$").WithMessage("O documento deve conter 11/14 dígitos!");

        RuleFor(fornecedor => fornecedor.Email)
            .NotEmpty().WithMessage("O email deve ser informado.")
            .EmailAddress().WithMessage("O email informado não é válido!");

        RuleFor(fornecedor => fornecedor.Telefone)
            .NotEmpty().WithMessage("O telefone deve ser informado.")
            .Matches(@"^\d{11}$").WithMessage("O telefone deve conter exatamente 11 dígitos!");

        RuleFor(fornecedor => fornecedor.Data_Inicial)
            .NotEmpty().WithMessage("A data inicial deve ser informada.");
    }
}