using System.ComponentModel.DataAnnotations.Schema;
using entityFramework.App.Enum;

namespace entityFramework.App.Entities
{
     public class NinjaEquipment
    {
        public int NinjaEquipmentId { get; set; }
        public string Name { get; set; }
        public EquipmentType EquipmentType { get; set; }

        [ForeignKey("NinjaId")]
        public Ninja Ninja { get; set; }
        public int NinjaId { get; set; }
    }
}