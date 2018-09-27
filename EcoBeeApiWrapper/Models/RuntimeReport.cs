namespace EcoBeeApiWrapper.Models
{
    public class RuntimeReport
    {
        public string ThermostatIdentifier { get; set; }
        public int RowCount { get; set; }
        public string[] RowList { get; set; }
    }
}
