namespace Księgarnia.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }

        public string City { get; set; }

        public string RegionId { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }
    }
}
