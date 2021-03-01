using GamerJogoVelhaDomain.Enum;
using GamerJogoVelhaDomain.Helpers;
using GamerJogoVelhaDomain.Shareds;
using System;

namespace GamerJogoVelhaDomain.Entities
{
    public class Player : BaseEntity<long>
    {
        public string PlayerName { get; set; }
        public DateTime RegiterUser { get; set; } = DateTime.UtcNow;
        public RegisterStatusEnum RegisterStatus { get; set; } = RegisterStatusEnum.Active;
    }
}
