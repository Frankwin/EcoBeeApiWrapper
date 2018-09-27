namespace EcoBeeApiWrapper.Models
{
    public class Group
    {
        public string GroupRef { get; set; }
        public string GroupName { get; set; }
        public bool SynchronizeAlerts { get; set; }
        public bool SynchronizeSystemMode { get; set; }
        public bool SynchronizeSchedule { get; set; }
        public bool SynchronizeQuickSave { get; set; }
        public bool SynchronizeReminders { get; set; }
        public bool SynchronizeContractorInfo { get; set; }
        public bool SynchronizeUserPreferences { get; set; }
        public bool SynchronizeUtilityInfo { get; set; }
        public bool SynchronizeLocation { get; set; }
        public bool SynchronizeReset { get; set; }
        public bool SynchronizeVacation { get; set; }
        public string[] Thermostats { get; set; }
    }
}
