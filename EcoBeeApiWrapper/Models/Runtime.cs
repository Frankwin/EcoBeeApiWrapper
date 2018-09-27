using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class Runtime
    {
        public string RuntimeRev { get; set; }
        public bool Connected { get; set; }
        public string FirstConnected { get; set; }
        public string ConnectDateTime { get; set; }
        public string DisconnectDateTime { get; set; }
        public string LastModified { get; set; }
        public string LastStatusModified { get; set; }
        public string RuntimeDate { get; set; }
        public int RuntimeInterval { get; set; }
        public int ActualTemperature { get; set; }
        public int ActualHumidity { get; set; }
        public int DesiredHeat { get; set; }
        public int DesiredCool { get; set; }
        public int DesiredHumidity { get; set; }
        public int DesiredDehumidity { get; set; }
        public FanState? DesiredFanMode { get; set; }
        public int[] DesiredHeatRange { get; set; }
        public int[] DesiredCoolRange { get; set; }
    }
}
