

using FluentValidation;
using LojaDoSeuManoel.Application.DTOs.Request;
using LojaDoSeuManoel.Domain.Entities;

namespace LojaDoSeuManoel.Application.Validator
{
    public class RegisterValidator: AbstractValidator<RequestUserRegister>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email é obrigatório.")
                .EmailAddress().WithMessage("Email inválido.");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Senha é obrigatória.")
                .MinimumLength(6).WithMessage("Senha deve ter pelo menos 6 caracteres.")
                .Matches(@"[A-Z]").WithMessage("Senha deve conter pelo menos uma letra maiúscula.")
                .Matches(@"[a-z]").WithMessage("Senha deve conter pelo menos uma letra minúscula.")
                .Matches(@"[0-9]").WithMessage("Senha deve conter pelo menos um número.")
                .Matches(@"[\W_]").WithMessage("Senha deve conter pelo menos um caractere especial.");
        }
    }
}
