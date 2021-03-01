using FluentValidation;
using GamerJogoVelhaDomain.Entities;
using System;

namespace GamerJogoVelhaServices.Validator
{
    public class PlayerValidator : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => { throw new ArgumentNullException("Nenhum objeto encontrado"); });
            RuleFor(c => c.PlayerName)
                .NotEmpty().WithMessage("Campo PlayerName em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo PlayerName não pode ser nulo, por favor preencher!");
        }
    }
}
