using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using PIM_IV_Forms.Interfaces;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class ClienteValidator : IValidator
{
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

    private static bool ValidateDataNascimento(ClienteFisico clienteFisico)
    {
        var dataAtual = DateTime.Now;

        var dataMinima = dataAtual.AddYears(-18);

        return clienteFisico.DataNascimento <= dataMinima;
    }
}