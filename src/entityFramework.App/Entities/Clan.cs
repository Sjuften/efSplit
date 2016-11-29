using System.Collections.Generic;

namespace entityFramework.App.Entities
{
    public class Clan
    {
        public int ClanId { get; set; }
        public string Name { get; set; }
        public List<Ninja> Ninas { get; set; } = new List<Ninja>();
    }
}