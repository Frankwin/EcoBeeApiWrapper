namespace EcoBeeApiWrapper.Models
{
    public class RuntimeSensorReport
    {
        public string ThermostatIdentifier { get; set; }
        public RuntimeSensorMetaData[] Sensors { get; set; }
        public string[] Columns { get; set; }
        public string[] Data { get; set; }
    }
}
