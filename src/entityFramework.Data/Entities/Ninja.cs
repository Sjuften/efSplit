namespace entityFramework.Data.Entities
{
    public enum NinjaType
    {
        Master = 0,
        Student = 1
    }

    public class Ninja
    {
        public int NinjaId { get; set; }
        public string Name { get; set; }
        public NinjaType NinjaType { get; set; }
    }
}