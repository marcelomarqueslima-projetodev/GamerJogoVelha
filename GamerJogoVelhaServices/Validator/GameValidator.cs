using FluentValidation;
using GamerJogoVelhaDomain.Entities;
using System;

namespace GamerJogoVelhaServices.Validator
{
    public class GameValidator : AbstractValidator<Game>
    {
        public GameValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => { throw new ArgumentNullException("Nenhum objeto encontrado"); });
            RuleFor(c => c.GameName)
                .NotEmpty().WithMessage("Campo GameName em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo GameName não pode ser nulo, por favor preencher!");
        }
    }
}
