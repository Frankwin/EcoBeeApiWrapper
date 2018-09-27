using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class Selection
    {
        public SelectionType SelectionType { get; set; }
        public string SelectionMatch { get; set; }
        public bool IncludeRuntime { get; set; }
        public bool IncludeExtendedRuntime { get; set; }
        public bool IncludeElectricity { get; set; }
        public bool IncludeSettings { get; set; }
        public bool IncludeLocation { get; set; }
        public bool IncludeProgram { get; set; }
        public bool IncludeEvents { get; set; }
        public bool IncludeDevice { get; set; }
        public bool IncludeTechnician { get; set; }
        public bool IncludeUtility { get; set; }
        public bool IncludeManagement { get; set; }
        public bool IncludeAlerts { get; set; }
        public bool IncludeReminders { get; set; }
        public bool IncludeWeather { get; set; }
        public bool IncludeHouseDetails { get; set; }
        public bool IncludeOemCfg { get; set; }
        public bool IncludeEquipmentStatus { get; set; }
        public bool IncludeNotificationSettings { get; set; }
        public bool IncludePrivacy { get; set; }
        public bool IncludeVersion { get; set; }
        public bool IncludeSecuritySettings { get; set; }
        public bool IncludeSensors { get; set; }
        public bool IncludeAudio { get; set; }
        public bool IncludeEnergy { get; set; }
    }
}
