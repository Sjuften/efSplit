using System.Collections.Generic;
using entityFramework.Data.Entities;
using System.Linq;
namespace entityFramework.Data.Databases
{
    public static class MyDbContextExtensions
    {
        public static void EnsureSeedDataForContext(this MyDbContext context)
        {
            if (context.Ninjas.Any()) return;
            var ninjas = new List<Ninja>
            {
                new Ninja()
                {
                    Name = "Peter",
                    NinjaType = NinjaType.Master
                },
                new Ninja()
                {
                    Name = "Johnnes",
                    NinjaType = NinjaType.Student
                }
            };
            context.Ninjas.AddRange(ninjas);
            context.SaveChanges();
        }
    }
}