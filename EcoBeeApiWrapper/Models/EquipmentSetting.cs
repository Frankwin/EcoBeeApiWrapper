using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class EquipmentSetting
    {
        public string FilterLastChanged { get; set; }
        public int FilterLife { get; set; }
        public string FilterLifeUnits { get; set; }
        public string RemindMeDate { get; set; }
        public bool Enabled { get; set; }
        public EquipmentSettingType Type { get; set; }
        public bool RemindTechnician { get; set; }
    }
}
