using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class Event
    {
        public EventType Type { get; set; }
        public string Name { get; set; }
        public bool Running { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsCoolOff { get; set; }
        public bool IsHeatOff { get; set; }
        public int CoolHoldTemp { get; set; }
        public int HeatHoldTemp { get; set; }
        public FanState Fan { get; set; }
        public VentilatorMode Vent { get; set; }
        public int VentilatorMinOnTime { get; set; }
        public bool IsOptional { get; set; }
        public bool IsTemperatureRelative { get; set; }
        public int CoolRelativeTemp { get; set; }
        public int HeatRelativeTemp { get; set; }
        public bool IsTemperatureAbsolute { get; set; }
        public int DutyCyclePercentage { get; set; }
        public int FanMinOnTime { get; set; }
        public bool OccupiedSensorActive { get; set; }
        public bool UnoccupiedSensorActive { get; set; }
        public int DrRampUpTemp { get; set; }
        public int DrRampUpTime { get; set; }
        public string LinkRef { get; set; }
        public string HoldClimateRef { get; set; }
    }
}
