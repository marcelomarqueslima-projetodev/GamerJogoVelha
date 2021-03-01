using GamerJogoVelhaDomain.Enum;
using GamerJogoVelhaDomain.Shareds;
using System;

namespace GamerJogoVelhaDomain.Entities
{
    public class Game : BaseEntity<long>
    {
        public string GameName { get; set; }
        public RegisterStatusEnum RegisterStatus { get; set; }
        public DateTime RegiterUser { get; set; } = DateTime.UtcNow;
    }
}
