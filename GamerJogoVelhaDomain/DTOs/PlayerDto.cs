using GamerJogoVelhaDomain.Enum;
using System;

namespace GamerJogoVelhaDomain.DTOs
{
    public class PlayerDto
    {
        public string PlayerName { get; set; }
        public DateTime? Birthday { get; set; }
        public RegisterStatusEnum? RegisterStatus { get; set; }
    }
}
