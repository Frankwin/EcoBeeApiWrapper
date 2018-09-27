namespace EcoBeeApiWrapper.Models
{
    public class MeterReport
    {
        public string ThermostatIdentifier { get; set; }
        public MeterReportData[] MeterList { get; set; }
    }
}
