using FluentValidation;
using GamerJogoVelhaDomain.Entities;
using System;

namespace GamerJogoVelhaService.Validator
{
    public class GameValidator : AbstractValidator<Game>
    {
        public GameValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => { throw new ArgumentNullException("Nenhum objeto encontrado"); });
            RuleFor(c => c.NameGame)
                .NotEmpty().WithMessage("Campo NameGame em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo NameGame não pode ser nulo, por favor preencher!");
            RuleFor(c => c.SiglaGame)
                .NotEmpty().WithMessage("Campo SiglaGame em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo SiglaGame não pode ser nulo, por favor preencher!");
        }
    }
}
