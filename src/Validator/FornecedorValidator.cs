using System;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class FornecedorValidator : AbstractValidator<Fornecedor>
{
    private const string CpfOuCnpjRegex = @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$|^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$";
    private const string TelefoneRegex = @"^\(\d{2}\)\s\d{5}-\d{4}$";
    public FornecedorValidator()
    {
        RuleFor(fornecedor => fornecedor.Nome)
            .NotEmpty().WithMessage("O nome do fornecedor deve ser informado.")
            .MinimumLength(3).WithMessage("O nome deve conter ao menos 3 letras.")
            .Must(nome => !string.IsNullOrWhiteSpace(nome)).WithMessage("O nome não pode conter apenas espaços em branco.");

        RuleFor(fornecedor => fornecedor.Documento)
            .NotEmpty().WithMessage("O documento deve ser informado.")
            .Matches(CpfOuCnpjRegex).WithMessage("O documento informado não é válido.");

        RuleFor(fornecedor => fornecedor.Email)
            .NotEmpty().WithMessage("O email deve ser informado.")
            .EmailAddress().WithMessage("O email informado não é válido.");

        RuleFor(fornecedor => fornecedor.Telefone)
            .NotEmpty().WithMessage("O telefone deve ser informado.")
            .Matches(TelefoneRegex).WithMessage("O telefone deve conter exatamente 11 dígitos.");

        RuleFor(fornecedor => fornecedor.Data_Inicial)
            .NotEmpty().WithMessage("A data inicial deve ser informada.");
    }
}