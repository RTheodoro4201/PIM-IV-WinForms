using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using PIM_IV_Forms.Interfaces;
using PIM_IV_Forms.Models;
using PIM_IV_Forms.Properties;
using PIM_IV.Validator;

namespace PIM_IV_Forms.Validator;

public class ClienteValidator : IValidator
{
    public List<Erro> Erros { get; private set; } = new();

    public bool ValidateModel(object model)
    {
        if (ValidateTelefone(model as Cliente) && ValidateDocumento(model as Cliente))
        {
            return true;
        }

        if (!ValidateDocumento(model as Cliente))
        {
            AddError("Documento", "Documento inválido!");
        }

        if (!ValidateTelefone(model as Cliente))
        {
            AddError("Telefone", "Telefone inválido!");
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

    private static bool ValidateTelefone(Cliente cliente)
    {
        return cliente is { Telefone: not null } && Regex.IsMatch(cliente.Telefone, @"^\d{11}$");
    }

    private static bool ValidateDocumento(Cliente cliente)
    {
        if (cliente is { TipoDocumento: "CPF" } && Regex.IsMatch(cliente.Documento, @"^\d{9}$"))
        {
            Console.WriteLine(Resources.CPF_Valido);
            return true;
        }

        if (cliente is { TipoDocumento: "CNPJ" } && Regex.IsMatch(cliente.Documento, @"^\d{14}$"))
        {
            Console.WriteLine(Resources.CNPJ_Valido);
            return true;
        }

        return false;
    }

}