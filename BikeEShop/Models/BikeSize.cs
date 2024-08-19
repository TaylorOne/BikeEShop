namespace BikeEShop.Models
{
    public class BikeSize
    {
        public int BikesId { get; set; }
        public int SizesId { get; set; }

        public List<Inventory> Inventory { get; set; }
    }
}
