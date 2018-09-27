namespace EcoBeeApiWrapper.Models
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public Sensor[] Sensors { get; set; }
        public Output[] Outputs { get; set; }
    }
}
