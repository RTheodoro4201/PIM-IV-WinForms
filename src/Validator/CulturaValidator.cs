using System;
using System.Data;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class CulturaValidator : AbstractValidator<Cultura>
{
    public CulturaValidator()
    {
        RuleFor(cultura => cultura.Nome)
            .NotEmpty().WithMessage("O nome do fornecedor deve ser informado.")
            .MinimumLength(3).WithMessage("O nome deve conter ao menos 3 letras.")
            .Matches(@"^[a-zA-Zà-úÀ-Ú\s\-\']+$")
            .WithMessage("O nome deve conter apenas letras, acentos, espaços, hífens e apóstrofos.")
            .Must(nome => !string.IsNullOrWhiteSpace(nome))
            .WithMessage("O nome não pode conter apenas espaços em branco.")
            .Must(nome => char.IsLetter(nome[0])).WithMessage("A primeira letra do nome deve ser uma letra.");

        RuleFor(cultura => cultura.Data_Plantio)
            .NotEmpty().WithMessage("A data do plantio deve ser informada.");

        RuleFor(cultura => cultura.Data_Colheita)
            .NotEmpty().WithMessage("A data de previsão deve ser informada.")
            .Must(ValidarDataPrevista).WithMessage("A data de previsão não pode ser menor que a data de plantio.");

        RuleFor(cultura => cultura.Area_Plantada)
            .NotEmpty().WithMessage("A área plantada deve ser informada.")
            .GreaterThan(0).WithMessage("A área plantada não pode ser 0 ou negativa.");

        RuleFor(cultura => cultura.Quantidade_Plantada)
            .NotEmpty().WithMessage("A quantidade plantada deve ser informada.")
            .GreaterThan(0).WithMessage("A quantidade plantada não pode ser 0 ou negativa.");

        RuleFor(cultura => cultura.Tipo_Solo)
            .NotEmpty().WithMessage("O tipo de solo deve ser informado.")
            .MinimumLength(4).WithMessage("O tipo de solo deve ter ao menos 4 caracteres.");

        RuleFor(cultura => cultura.Tipo_Irrigacao)
            .NotEmpty().WithMessage("O tipo de irrigação deve ser informado.")
            .MinimumLength(4).WithMessage("O tipo de irrigação deve ter ao menos 4 caracteres.");

        RuleFor(cultura => cultura.Notas)
            .NotEmpty().WithMessage("A descrição da cultura deve ser informada.")
            .MinimumLength(20).WithMessage("A descrição da cultura deve ter ao menos 20 caracteres.");
    }

    private bool ValidarDataPrevista(Cultura cultura, DateTime dataPrevista)
    {
        if (dataPrevista <= cultura.Data_Colheita)
        {
            return true;
        }

        return false;
    }
}