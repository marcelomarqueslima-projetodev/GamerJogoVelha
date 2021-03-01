using System;

namespace GamerJogoVelhaDomain.Shareds
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
