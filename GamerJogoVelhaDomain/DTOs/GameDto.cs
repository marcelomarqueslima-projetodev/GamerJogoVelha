using GamerJogoVelhaDomain.Enum;

namespace GamerJogoVelhaDomain.DTOs
{
    public class GameDto
    {
        public string UserName { get; set; }
        public RegisterStatusEnum RegisterStatus { get; set; }
    }
}
