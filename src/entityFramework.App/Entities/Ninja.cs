using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using entityFramework.App.Enum;

namespace entityFramework.App.Entities
{
    public class Ninja
    {
        public int NinjaId { get; set; }
        public string Name { get; set; }
        public bool ServedInObiwan { get; set; }
        public DateTime DateOfBirth { get; set; }

        [ForeignKey("ClanId")]
        public Clan Clan { get; set; }
        public int ClanId { get; set; }

        public NinjaType NinjaType { get; set; }

        public List<NinjaEquipment> NinjaEquipments { get; set; } = new List<NinjaEquipment>();
    }
}