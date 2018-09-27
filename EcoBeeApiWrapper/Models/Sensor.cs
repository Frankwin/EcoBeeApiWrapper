using System.Collections.Generic;
using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class Sensor
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Zone { get; set; }
        public int SensorId { get; set; }
        public SensorType Type { get; set; }
        public SensorUsage Usage { get; set; }
        public int NumberOfBits { get; set; }
        public int BConstant { get; set; }
        public int ThermistorSize { get; set; }
        public int TempCorrection { get; set; }
        public int Gain { get; set; }
        public int MaxVoltage { get; set; }
        public int Multiplier { get; set; }
        public List<State> States { get; set; }
    }
}
