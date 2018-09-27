using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class RemoteSensorCapability
    {
        public string Id { get; set; }
        public SensorCapabilityType Type { get; set; }
        public string Value { get; set; }
    }
}
