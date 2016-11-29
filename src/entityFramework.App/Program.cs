using System;
using System.Linq;
using entityFramework.App.Database;
using entityFramework.App.Repositories.NinjaRepositories;
using Microsoft.EntityFrameworkCore;

namespace entityFramework.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new NinjaContext())
            {
                var ninjaRepo = new NinjaRepository(db);
                db.EnsureSeedDataForContext();
//                while (true)
//                {
//                db.Database.ExecuteSqlCommand("CALL sp_delete_ninja({0});",9);
//                    Console.WriteLine("Add(1), Remove(2),Update(3), Print all Ninjas (4)");
//                    var choice = Convert.ToInt32(Console.ReadLine());
//                    inputLoop:
//                    switch (choice)
//                    {
//                        case 1:
//                            Console.WriteLine("Add");
//                            ninjaRepo.Add(new Ninja()
//                            {
//                                Name = "New",
//                                NinjaType = NinjaType.Kunoichi,
//                                ServedInObiwan = true,
//                                Clan = new Clan()
//                                {
//                                    Name = "AddedClan",
//                                },
//                                NinjaEquipments = new List<NinjaEquipment>()
//                                {
//                                    new NinjaEquipment()
//                                    {
//                                        Name = "Added Equip",
//                                        EquipmentType = EquipmentType.Weapon
//                                    }
//                                }
//                            });
//                            ninjaRepo.Save();
//                            Console.WriteLine("Ninja has been saved:");
//                            break;
//                        case 2:
//                            Console.WriteLine("Remove");
//                            ninjaRepo.Delete(3);
//                            ninjaRepo.Save();
//                            Console.WriteLine("Ninja has been deleted");
//                            break;
//                        case 3:
//                            var result = ninjaRepo.Find(4);
//                            result.Name = "Martin";
//                            ninjaRepo.Update(result);
//                            ninjaRepo.Save();
//                            Console.WriteLine("Update to " + result.Name);
//                            break;
//                        case 4:
                            foreach (var ninja in db.Ninjas.AsNoTracking().Include(x => x.NinjaEquipments).AsNoTracking().Include(x => x.Clan))
                            {
                                Console.WriteLine("Name: " + ninja.Name);
                                Console.WriteLine("Type: " + ninja.NinjaType);
                                Console.WriteLine("Equipment:");
                                ninja.NinjaEquipments.ToList().ForEach(x => Console.WriteLine(x.Name));
                                Console.WriteLine("Clan");
                                Console.WriteLine("Clan Name: " + ninja.Clan.Name);
                                Console.WriteLine("Served:" + ninja.ServedInObiwan);
                            }
//                            break;
//                        default:
//                            Console.WriteLine("Enter a number");
//                            choice = Convert.ToInt32(Console.ReadLine());
//                            goto inputLoop;
//                    }
//                }
            }
        }
    }
}