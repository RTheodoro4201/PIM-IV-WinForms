using System;
using System.Linq;
using System.Text.RegularExpressions;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class EnderecoValidator : AbstractValidator<Endereco>
{
    private readonly string[] _prefixosLogradouro =
    [
        "Rua", "Avenida", "Praça", "Travessa", "Beco",
        "Alameda", "Rodovia", "Estrada", "Largo", "Viaduto"
    ];

    private readonly string[] _ufsValidas =
    [
        "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA",
        "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN",
        "RS", "RO", "RR", "SC", "SE", "SP", "TO"
    ];

    public EnderecoValidator()
    {
        RuleFor(endereco => endereco.Logradouro)
            .NotEmpty().WithMessage("Logradouro é obrigatório")
            .MaximumLength(50).WithMessage("O logradouro deve possuir menos de 5 caracteres!")
            .MinimumLength(5).WithMessage("O logradouro deve possuir ao menos 5 caracteres!")
            .Must(ValidatePrefixoLogradouro).WithMessage("Prefixo de logradouro inválido!");

        RuleFor(endereco => endereco.Numero)
            .NotEmpty().WithMessage("Número é obrigatório")
            .MaximumLength(5).WithMessage("O número do endereço deve possuir menos de 5 caracteres!")
            .Must(ValidateNumero).WithMessage("Insira apenas números no campo Nº!");

        RuleFor(endereco => endereco.Complemento)
            .NotEmpty().WithMessage("Complemento é obrigatório")
            .MaximumLength(15).WithMessage("O complemento deve possuir menos de 15 caracteres!")
            .MinimumLength(4).WithMessage("O complemente deve possuir ao menos 4 caracteres!");

        RuleFor(endereco => endereco.Bairro)
            .NotEmpty().WithMessage("Bairro é obrigatório")
            .MaximumLength(50).WithMessage("O bairro deve possuir menos de 50 caracteres!")
            .MinimumLength(6).WithMessage("O bairro deve possuir ao menos 6 caracteres!");

        RuleFor(endereco => endereco.Cidade)
            .NotEmpty().WithMessage("Cidade é obrigatória")
            .MaximumLength(30).WithMessage("A cidade deve possuir menos de 30 caracteres!")
            .MinimumLength(5).WithMessage("A cidade deve possuir ao menos 5 caracteres!");

        RuleFor(endereco => endereco.Uf)
            .NotEmpty().WithMessage("UF é obrigatória")
            .Must(uf => uf.Length == 2).WithMessage("A UF deve possuir exatamente 2 caracteres!")
            .Must(ValidateUf).WithMessage("A UF inserida não é válida!");

        RuleFor(endereco => endereco.Cep)
            .NotEmpty().WithMessage("CEP é obrigatório")
            .Must(ValidateCep).WithMessage("CEP inválido!");
    }

    private static bool ValidateCep(string cep)
    {
        // Verifica se o CEP tem 8 dígitos e se é numérico
        return Regex.IsMatch(cep, @"^\d{8}$");
    }

    private bool ValidateUf(string uf)
    {
        return _ufsValidas.Contains(uf, StringComparer.OrdinalIgnoreCase);
    }

    private static bool ValidateNumero(string numero)
    {
        return int.TryParse(numero, out _);
    }

    private bool ValidatePrefixoLogradouro(string logradouro)
    {
        // Divide a string do logradouro em palavras
        string[] palavras = logradouro.Split(' ');

        // Obtém a primeira palavra (prefixo)
        string primeiroPalavra = palavras[0];

        // Verifica se a primeira palavra está contida no array de prefixos, ignorando maiúsculas e minúsculas
        return _prefixosLogradouro.Contains(primeiroPalavra, StringComparer.OrdinalIgnoreCase);
    }
}