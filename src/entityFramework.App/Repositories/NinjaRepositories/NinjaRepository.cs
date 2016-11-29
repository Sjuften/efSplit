using System.Linq;
using entityFramework.App.Database;
using entityFramework.App.Entities;
using Microsoft.EntityFrameworkCore;

namespace entityFramework.App.Repositories.NinjaRepositories
{
    public class NinjaRepository : IRepository<Ninja>
    {
        private NinjaContext _context;

        public NinjaRepository(NinjaContext context)
        {
            _context = context;
        }


        public void Add(Ninja entity)
        {
            _context.Ninjas.Add(entity);
        }

        public Ninja Find(int id)
        {
            return _context.Ninjas.Find(id);
        }

        public void Delete(int id)
        {
            var entityToDelete = Find(id);
            Delete(entityToDelete);
        }

        public void Delete(Ninja entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                _context.Attach(entity);
            _context.Ninjas.Remove(entity);
        }

        public void Update(Ninja entity)
        {
            _context.Ninjas.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public bool Exist(int id)
        {
            return _context.Ninjas.Any(x => x.NinjaId == id);
        }
    }
}