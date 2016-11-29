using System.Collections.Generic;
using System.Linq;
using entityFramework.App.Entities;
using entityFramework.App.Enum;

namespace entityFramework.App.Database
{
    public static class NinjaContextExtensions
    {
        public static void EnsureSeedDataForContext(this NinjaContext context)
        {
            if (context.Ninjas.Any()) return;


            var ninjas = new List<Ninja>
            {
                new Ninja()
                {
                    Name = "Peter",
                    Clan = new Clan()
                    {
                        Name = "PowerClan",
                    },
                    ServedInObiwan = false,
                    NinjaEquipments = new List<NinjaEquipment>()
                    {
                        new NinjaEquipment()
                        {
                            Name = "PowerTool",
                            EquipmentType = EquipmentType.Tool
                        },
                        new NinjaEquipment()
                        {
                            Name = "PowerWeapon",
                            EquipmentType = EquipmentType.Weapon
                        }
                    },
                    NinjaType = NinjaType.Kunoichi,
                },
                new Ninja()
                {
                    Name = "Johnnes",
                    Clan = new Clan()
                    {
                        Name = "TurtleClan"
                    },
                    ServedInObiwan = false,
                    NinjaType =  NinjaType.Shinobi,
                    NinjaEquipments = new List<NinjaEquipment>()
                    {
                        new NinjaEquipment()
                        {
                            Name = "Outdoor",
                            EquipmentType = EquipmentType.Outwear
                        },
                        new NinjaEquipment()
                        {
                            Name = "ToolForOutdoor",
                            EquipmentType = EquipmentType.Tool,
                        }
                    }
                }
            };
            context.Ninjas.AddRange(ninjas);
            context.SaveChanges();
        }
    }
}