namespace EcoBeeApiWrapper.Models
{
    public class ElectricityDevice
    {
        public string Name { get; set; }
        public ElectricityTier[] Tiers { get; set; }
        public string LastUpdate { get; set; }
        public decimal[] Cost { get; set; }
        public decimal[] Consumption { get; set; }
    }
}
