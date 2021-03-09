using GamerJogoVelhaDomain.Entities;
using GamerJogoVelhaInfraData.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GamerJogoVelhaInfraData.Repositories
{
    public class BaseRepository<T, B> where T : EntityBase<B>
    {
        protected readonly GameContext _context;

        public BaseRepository(GameContext context)
        {
            _context = context;
        }

        protected virtual void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        protected virtual void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        protected virtual void Delete(long id)
        {
            _context.Set<T>().Remove(Select(id));
            _context.SaveChanges();
        }

        protected virtual T Select(long id) => _context.Set<T>().Find(id);

        protected virtual IList<T> Select() => _context.Set<T>().ToList();
    }
}
