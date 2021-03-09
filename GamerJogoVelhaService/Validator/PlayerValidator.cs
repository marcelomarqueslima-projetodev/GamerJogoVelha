using FluentValidation;
using GamerJogoVelhaDomain.Entities;
using System;

namespace GamerJogoVelhaService.Validator
{
    public class PlayerValidator : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => { throw new ArgumentNullException("Nenhum objeto encontrado"); });
            RuleFor(c => c.NamePlayer)
                .NotEmpty().WithMessage("Campo NamePlayer em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo NamePlayer não pode ser nulo, por favor preencher!");
            RuleFor(c => c.SiglaPlayer)
                .NotEmpty().WithMessage("Campo SiglaPlayer em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo SiglaPlayer não pode ser nulo, por favor preencher!");
        }
    }
}
