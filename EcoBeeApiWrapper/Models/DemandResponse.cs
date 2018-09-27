namespace EcoBeeApiWrapper.Models
{
    public class DemandResponse
    {
        public string Name { get; set; }
        public string DemandResponseRef { get; set; }
        public string Comments { get; set; }
        public string Message { get; set; }
        public string DeferredDate { get; set; }
        public string DeferredTime { get; set; }
        public bool ShowIdt { get; set; }
        public bool ShowWeb { get; set; }
        public bool SendEmail { get; set; }
        public bool RandomizeStartTime { get; set; }
        public int RandomStartTimeSeconds { get; set; }
        public bool RandomizedEndTime { get; set; }
        public int RandomEndTimeSeconds { get; set; }
        public Event Event { get; set; }
        public string[] Thermostats { get; set; }
        public string ExternalRef { get; set; }
        public string ExternalRefType { get; set; }
        public long Priority { get; set; }
    }
}
