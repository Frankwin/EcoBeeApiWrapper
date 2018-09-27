using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class GeneralSetting
    {
        public bool Enabled { get; set; }
        public GeneralSettingType Type { get; set; }
        public bool RemindTechnician { get; set; }
    }
}
