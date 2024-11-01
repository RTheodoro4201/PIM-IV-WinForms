using System.Text.RegularExpressions;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class FuncionarioValidator : AbstractValidator<Funcionario>
{
    public FuncionarioValidator()
    {
        RuleFor(funcionario => funcionario.Nome_Completo)
            .NotEmpty().WithMessage("O nome do funcionario deve ser informado.")
            .MinimumLength(3).WithMessage("O nome deve conter ao menos 3 letras!")
            .Matches(@"^[a-zA-Zà-úÀ-Ú\s\-\']+$")
            .WithMessage("O nome deve conter apenas letras, acentos, espaços, hífens e apóstrofos.")
            .Must(nome => !string.IsNullOrWhiteSpace(nome))
            .WithMessage("O nome não pode conter apenas espaços em branco.")
            .Must(nome => char.IsLetter(nome[0])).WithMessage("A primeira letra do nome deve ser uma letra.");

        RuleFor(funcionario => funcionario.Rg)
            .NotEmpty().WithMessage("O rg deve ser informado.")
            .Matches(@"^\d{9}$").WithMessage("O rg deve conter exatamente 9 dígitos!");

        RuleFor(funcionario => funcionario.Cpf)
            .NotEmpty().WithMessage("O cpf deve ser informado.")
            .Matches(@"^\d{11}$").WithMessage("O cpf deve conter exatamente 11 dígitos!");

        RuleFor(funcionario => funcionario.Cargo)
            .NotEmpty().WithMessage("O cargo deve ser informado.")
            .MinimumLength(3).WithMessage("O cargo deve possuir mais de 3 dígitos!");

        RuleFor(funcionario => funcionario.Email)
            .NotEmpty().WithMessage("O email deve ser informado.")
            .EmailAddress().WithMessage("O email informado não é válido!");

        RuleFor(funcionario => funcionario.Telefone)
            .NotEmpty().WithMessage("O telefone deve ser informado.")
            .Matches(@"^\d{11}$").WithMessage("O telefone deve conter exatamente 11 dígitos!");

        RuleFor(funcionario => funcionario.Endereco)
            .NotEmpty().WithMessage("O endereço deve ser informado.");

        RuleFor(funcionario => funcionario.Salario)
            .NotEmpty().WithMessage("O salário deve ser informado.")
            .GreaterThan(0).WithMessage("O salário deve ser maior que zero!")
            .Must(ValidarSalario)
            .WithMessage("O salário informado não está no formato válido! (Apenas duas casas decimais)");

        RuleFor(funcionario => funcionario.Data_Admissao)
            .NotEmpty().WithMessage("A data de admissão deve ser informada.");
    }

    private static bool ValidarSalario(decimal salario)
    {
        var valorString = salario.ToString("C");
        return Regex.IsMatch(valorString, @"^R\$?\d{1,10}(\,\d{1,2})?$");
    }
}