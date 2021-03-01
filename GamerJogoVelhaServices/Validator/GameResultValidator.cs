using FluentValidation;
using GamerJogoVelhaDomain.Shareds;
using System;

namespace GamerJogoVelhaServices.Validator
{
    public class GameResultValidator : AbstractValidator<GameResult>
    {
        public GameResultValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => { throw new ArgumentNullException("Nenhum objeto encontrado"); });
            RuleFor(c => c.GameId)
                .NotEmpty().WithMessage("Campo GameId em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo GameId não pode ser nulo, por favor preencher!");
            RuleFor(c => c.PlayerId)
                .NotEmpty().WithMessage("Campo PlayerId em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo PlayerId não pode ser nulo, por favor preencher!");
        }
    }
}
