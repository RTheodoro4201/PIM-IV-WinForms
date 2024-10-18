using System;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class ClienteFisicoValidator : AbstractValidator<ClienteFisico>
{
    public ClienteFisicoValidator()
    {
        RuleFor(cliente => cliente.Nome)
            .NotEmpty().WithMessage("O nome do cliente deve ser informado.")
            .MinimumLength(3).WithMessage("O nome deve conter ao menos 3 letras!")
            .Matches(@"^[a-zA-Zà-úÀ-Ú\s\-\']+$").WithMessage("O nome deve conter apenas letras, acentos, espaços, hífens e apóstrofos.")
            .Must(nome => !string.IsNullOrWhiteSpace(nome)).WithMessage("O nome não pode conter apenas espaços em branco.")
            .Must(nome => char.IsLetter(nome[0])).WithMessage("A primeira letra do nome deve ser uma letra.");

        RuleFor(cliente => cliente.Rg)
            .NotEmpty().WithMessage("O rg deve ser informado.")
            .Matches(@"^\d{9}$").WithMessage("O rg deve conter exatamente 9 dígitos!");

        RuleFor(cliente => cliente.Cpf)
            .NotEmpty().WithMessage("O cpf deve ser informado.")
            .Matches(@"^\d{11}$").WithMessage("O cpf deve conter exatamente 11 dígitos!");

        RuleFor(cliente => cliente.Email)
            .NotEmpty().WithMessage("O email deve ser informado.")
            .EmailAddress().WithMessage("O email informado não é válido!");

        RuleFor(cliente => cliente.Telefone)
            .NotEmpty().WithMessage("O telefone deve ser informado.")
            .Matches(@"^\d{11}$").WithMessage("O telefone deve conter exatamente 11 dígitos!");

        RuleFor(cliente => cliente.Endereco)
            .SetValidator(new EnderecoValidator());

        RuleFor(cliente => cliente.DataNascimento)
            .NotEmpty().WithMessage("A data de nascimento deve ser informada.")
            .Must(ValidateDataNascimento).WithMessage("O cliente deve possuir mais de 18 anos!");
    }

    private static bool ValidateDataNascimento(DateTime dataNascimento)
    {
        return dataNascimento < DateTime.Now.AddYears(-18);
    }

    /* Validação pre-FluentValidation
    public List<Erro> Erros { get; } = new();

    public bool ValidateModel(object model)
    {
        var clienteFisico = model as ClienteFisico;

        if (clienteFisico == null)
        {
            AddError("Model", "Modelo inválido.");
            return false;
        }

        if (ValidateTelefone(clienteFisico)
            && ValidateRg(clienteFisico)
            && ValidateCpf(clienteFisico)
            && ValidateEmail(clienteFisico)
            && ValidateTelefone(clienteFisico)
            && ValidateEndereco(clienteFisico)
            && ValidateDataNascimento(clienteFisico))
        {
            return true;
        }

        if (!ValidateRg(clienteFisico))
        {
            AddError("RG", "RG inválido!");
        }

        if (!ValidateCpf(clienteFisico))
        {
            AddError("CPF", "CPF inválido!");
        }

        if (!ValidateEmail(clienteFisico))
        {
            AddError("Email", "Email inválido!");
        }

        if (!ValidateTelefone(clienteFisico))
        {
            AddError("Telefone", "Telefone inválido!");
        }

        if (!ValidateEndereco(clienteFisico))
        {
            AddError("Endereço", "Endereço inválido!");
        }

        if (!ValidateDataNascimento(clienteFisico))
        {
            AddError("Data de Nascimento", "Data de nascimento inválida!");
        }
        return false;
    }

    private void AddError(string nomeCampo, string mensagemErro)
    {
        Erro erro = new()
        {
            NomeCampo = nomeCampo,
            MensagemErro = mensagemErro
        };
        Erros?.Add(erro);
    }

    private static bool ValidateTelefone(ClienteFisico clienteFisico)
    {
        if (string.IsNullOrEmpty(clienteFisico.Telefone))
        {
            return false;
        }

        return clienteFisico is { Telefone: not null } && Regex.IsMatch(clienteFisico.Telefone, @"^\d{11}$");
    }

    private static bool ValidateRg(ClienteFisico clienteFisico)
    {
        if (string.IsNullOrEmpty(clienteFisico.Rg))
        {
            return false;
        }

        return (Regex.IsMatch(clienteFisico.Rg, @"^\d{9}$"));
    }

    private static bool ValidateCpf(ClienteFisico clienteFisico)
    {
        if (string.IsNullOrEmpty(clienteFisico.Cpf))
        {
            return false;
        }

        return (Regex.IsMatch(clienteFisico.Cpf, @"^\d{11}$"));
    }

    private static bool ValidateEmail(ClienteFisico clienteFisico)
    {
        if (string.IsNullOrEmpty(clienteFisico.Email))
        {
            return false;
        }

        return Regex.IsMatch(clienteFisico.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    private static bool ValidateEndereco(ClienteFisico clienteFisico)
    {
        var enderecoValidator = new EnderecoValidator();



        return true;
    }

    */
}