using System.Linq;
using entityFramework.Data;
using entityFramework.Data.Databases;
using entityFramework.Data.Entities;

namespace entityFramework.Domain.Entities
{
    public class NinjaService
    {
        private MyDbContext _myDbContext;

        public NinjaService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public Ninja Find(int id)
        {
            return _myDbContext.Ninjas.FirstOrDefault(x => x.NinjaId == id);
        }

        public void Add(Ninja ninja)
        {
            _myDbContext.Ninjas.Add(ninja);
        }

        public void Remove(Ninja ninja)
        {
            _myDbContext.Ninjas.Remove(ninja);
        }

        public bool SaveChanges()
        {
            return _myDbContext.SaveChanges() >= 0;
        }
    }
}