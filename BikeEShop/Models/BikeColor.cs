namespace BikeEShop.Models
{
    public class BikeColor
    {
        public int BikesId { get; set; }
        public int ColorsId { get; set; }

        public List<Inventory> Inventory { get; set; }
    }
}
