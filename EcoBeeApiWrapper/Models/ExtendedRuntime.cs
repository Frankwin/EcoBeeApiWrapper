using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class ExtendedRuntime
    {
        public string LastReadingTimestamp { get; set; }
        public string RuntimeDate { get; set; }
        public int RuntimeInterval { get; set; }
        public int[] ActualTemperature { get; set; }
        public int[] ActualHumidity { get; set; }
        public int[] DesiredHeat { get; set; }
        public int[] DesiredCool { get; set; }
        public int[] DesiredHumidity { get; set; }
        public int[] DesiredDehumidity { get; set; }
        public int[] DmOffset { get; set; }
        public HvacMode[] HvacMode { get; set; }
        public int[] HeatPump1 { get; set; }
        public int[] HeatPump2 { get; set; }
        public int[] AuxHeat1 { get; set; }
        public int[] AuxHeat2 { get; set; }
        public int[] AuxHeat3 { get; set; }
        public int[] Cool1 { get; set; }
        public int[] Cool2 { get; set; }
        public int[] Fan { get; set; }
        public int[] Humidifier { get; set; }
        public int[] Dehumidifier { get; set; }
        public int[] Ventilator { get; set; }
        public int CurrentElectricityBill { get; set; }
        public int ProjectedElectricityBill { get; set; }
    }
}

