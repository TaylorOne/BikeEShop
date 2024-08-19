namespace BikeEShop.Models
{
    public class Size
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public List<Bike> Bikes { get; set; }
    }
}
