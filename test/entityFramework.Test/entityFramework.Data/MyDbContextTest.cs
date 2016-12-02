using System;
using System.Linq;
using entityFramework.Data.Databases;
using entityFramework.Data.Entities;
using entityFramework.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Abstractions;

namespace entityFramework.Test.entityFramework.Data
{
    public class MyDbContextTest
    {
        [Fact]
        public void SaveNinja()
        {
            var _options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase(databaseName: "SaveNinja")
                .Options;

            var ninja = new Ninja()
            {
                NinjaId = 1,
                Name = "InMemory",
                NinjaType = NinjaType.Master
            };
            using (var context = new MyDbContext(_options))
            {
                var service = new NinjaService(context);
                service.Add(ninja);
                service.SaveChanges();
            }

            // Use a separate instance of the context to verify correct data was saved to database
            using (var context = new MyDbContext(_options))
            {
                Assert.Equal(1, context.Ninjas.ToList().Count);
                Assert.Equal(ninja.NinjaId, context.Ninjas.Single().NinjaId);
            }
        }

        [Fact]
        public void FindNinja()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase(databaseName: "FindNinja")
                .Options;

            var ninja = new Ninja()
            {
                NinjaId = 1,
                Name = "InMemory",
                NinjaType = NinjaType.Master
            };
            using (var context = new MyDbContext(options))
            {
                var service = new NinjaService(context);
                context.Ninjas.Add(ninja);
                service.SaveChanges();
            }
            using (var context = new MyDbContext(options))
            {
                var service = new NinjaService(context);
                var result = service.Find(1);
                Assert.NotNull(result);
            }
        }
    }
}