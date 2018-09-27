using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class RemoteSensor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public SensorType SensorType { get; set; }
        public string Code { get; set; }
        public bool InUse { get; set; }
        public RemoteSensorCapability[] RemoteSensorCapability { get; set; }
    }
}
