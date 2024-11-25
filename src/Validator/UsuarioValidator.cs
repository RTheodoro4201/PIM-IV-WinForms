using System.Linq;
using System.Text.RegularExpressions;
using FluentValidation;
using PIM_IV_Forms.Models;

namespace PIM_IV_Forms.Validator;

public class UsuarioValidator : AbstractValidator<Usuario>
{
    public UsuarioValidator()
    {
        RuleFor(usuario => usuario.Login)
            .NotEmpty().WithMessage("Informe um login")
            .MinimumLength(3).WithMessage("O Login deve ter no mínimo 3 caracteres.")
            .MaximumLength(50).WithMessage("O Login deve ter no máximo 50 caracteres.");

        RuleFor(usuario => usuario.Senha)
            .NotEmpty().WithMessage("A Senha é obrigatória.")
            .MinimumLength(6).WithMessage("A Senha deve ter no mínimo 6 caracteres.")
            .MaximumLength(50).WithMessage("A Senha deve ter no máximo 50 caracteres.")
            .Must(TerCaractereEspecial).WithMessage("A Senha deve conter pelo menos um caractere especial.")
            .Must(TerNumero).WithMessage("A Senha deve conter pelo menos um número.");
    }

    private static bool TerCaractereEspecial(string senha)
    {
        // Define a expressão regular para validar a presença de caracteres especiais
        var regex = new Regex(@"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]");
        return regex.IsMatch(senha);
    }

    private static bool TerNumero(string senha)
    {
        // Verifica se a senha contém pelo menos um número
        return senha.Any(char.IsDigit);
    }
}