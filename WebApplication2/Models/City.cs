

namespace WebApplication2.Models
{
    public class City
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string district { get; set; }
        public int population { get; set; }
        public string subject { get; set; }
        public Coords Coords { get; set; }

    }

}
