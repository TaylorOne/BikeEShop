namespace BikeEShop.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int BikesId { get; set; }
        public int ColorsId { get; set; }
        public int SizesId { get; set; }
        public int? Quantity { get; set; }

        public BikeColor BikeColor { get; set; }
        public BikeSize BikeSize { get; set; }
    }
}
