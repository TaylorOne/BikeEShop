using Microsoft.EntityFrameworkCore;

namespace BikeEShop.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Precision(7, 2)]
        public decimal Price { get; set; }
        [Precision(4, 2)]
        public decimal Weight { get; set; }
        public string BikeType { get; set; }
        public string Family { get; set; }
        public string FrameMaterial { get; set; }
        public string DescriptionShort { get; set; }
        public string Description { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Color3 { get; set; }
        public string Color1pic { get; set; }
        public string Color1picAlt { get; set; }
        public string Color2pic { get; set; }
        public string Color2picAlt { get; set; }
        public string Color3pic { get; set; }
        public string Color3picAlt { get; set; }
        public int Travel { get; set; }

        public List<Color> Colors { get; set; }
        public List<Size> Sizes { get; set; }
    }
}
