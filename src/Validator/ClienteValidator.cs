using System;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class ClienteValidator : AbstractValidator<Cliente>
{
    private const string CpfOuCnpjRegex = @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$|^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$";
    private const string TelefoneRegex = @"^\(\d{2}\)\s\d{4,5}-\d{4}$";

    public ClienteValidator()
    {
        RuleFor(cliente => cliente.Nome)
            .NotEmpty().WithMessage("O nome do cliente deve ser informado.")
            .MinimumLength(3).WithMessage("O nome deve conter ao menos 3 letras!")
            .Matches(@"^[a-zA-Zà-úÀ-Ú\s\-\']+$")
            .WithMessage("O nome deve conter apenas letras, acentos, espaços, hífens e apóstrofos.")
            .Must(nome => !string.IsNullOrWhiteSpace(nome))
            .WithMessage("O nome não pode conter apenas espaços em branco.")
            .Must(nome => char.IsLetter(nome[0])).WithMessage("A primeira letra do nome deve ser uma letra.");

        RuleFor(cliente => cliente.Tipo)
            .NotEmpty().WithMessage("O tipo de cliente deve ser informado.")
            .Must(ValidarTipo).WithMessage("O rg deve conter exatamente 9 dígitos!");

        RuleFor(cliente => cliente.Documento)
            .NotEmpty().WithMessage("O cpf deve ser informado.")
            .Matches(CpfOuCnpjRegex).WithMessage("O documento informado não é válido.");

        RuleFor(cliente => cliente.Email)
            .NotEmpty().WithMessage("O email deve ser informado.")
            .EmailAddress().WithMessage("O email informado não é válido!");

        RuleFor(cliente => cliente.Telefone)
            .NotEmpty().WithMessage("O telefone deve ser informado.")
            .Matches(TelefoneRegex).WithMessage("O telefone informado não é válido.");

        RuleFor(cliente => cliente.Endereco)
            .NotEmpty().WithMessage("O endereço deve ser informado.");

        RuleFor(cliente => cliente.Data_Inicial)
            .NotEmpty().WithMessage("A data de nascimento deve ser informada.");
    }

    private static bool ValidarTipo(string tipoCliente)
    {
        if (tipoCliente == "Físico" || tipoCliente == "Jurídico")
        {
            return true;
        }

        return false;
    }
}