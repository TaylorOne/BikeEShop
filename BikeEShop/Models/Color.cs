namespace BikeEShop.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Bike> Bikes { get; set; }
    }
}
