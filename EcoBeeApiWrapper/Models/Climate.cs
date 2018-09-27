using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class Climate
    {
        public string Name { get; set; }
        public string ClimateRef { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsOptimized { get; set; }
        public FanState CoolFan { get; set; }
        public FanState HeatFan { get; set; }
        public VentilatorMode Vent { get; set; }
        public int VentilatorMinOnTime { get; set; }
        public ClimateOwner Owner { get; set; }
        public ClimateType Type { get; set; }
        public int Colour { get; set; }
        public int CoolTemp { get; set; }
        public int HeatTemp { get; set; }
        public RemoteSensor[] Sensors { get; set; }
    }
}
