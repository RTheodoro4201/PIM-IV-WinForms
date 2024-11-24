using System;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class ClienteValidator : AbstractValidator<Cliente>
{
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
            .NotEmpty().WithMessage("O rg deve ser informado.")
            .Matches(@"^\d{9}$").WithMessage("O rg deve conter exatamente 9 dígitos!");

        RuleFor(cliente => cliente.Documento)
            .NotEmpty().WithMessage("O cpf deve ser informado.")
            .Matches(@"^\d{11}$").WithMessage("O cpf deve conter exatamente 11 dígitos!");

        RuleFor(cliente => cliente.Email)
            .NotEmpty().WithMessage("O email deve ser informado.")
            .EmailAddress().WithMessage("O email informado não é válido!");

        RuleFor(cliente => cliente.Telefone)
            .NotEmpty().WithMessage("O telefone deve ser informado.")
            .Matches(@"^\d{11}$").WithMessage("O telefone deve conter exatamente 11 dígitos!");

        RuleFor(cliente => cliente.Endereco)
            .NotEmpty().WithMessage("O endereço deve ser informado.");

        RuleFor(cliente => cliente.Data_Inicial)
            .NotEmpty().WithMessage("A data de nascimento deve ser informada.")
            .Must(ValidateDataNascimento).WithMessage("O cliente deve possuir mais de 18 anos!");
    }

    private static bool ValidateDataNascimento(DateTime dataNascimento)
    {
        return dataNascimento < DateTime.Now.AddYears(-18);
    }
}