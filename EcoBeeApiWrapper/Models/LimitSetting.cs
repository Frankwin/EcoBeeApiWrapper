using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class LimitSetting
    {
        public int Limit { get; set; }
        public bool Enabled { get; set; }
        public LimitSettingType Type { get; set; }
        public bool RemindTechnician { get; set; }
    }
}
