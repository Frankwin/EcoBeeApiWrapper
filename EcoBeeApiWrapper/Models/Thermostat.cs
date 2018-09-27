namespace EcoBeeApiWrapper.Models
{
    public class Thermostat
    {
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string ThermostatRev { get; set; }
        public bool IsRegistered { get; set; }
        public string ModelNumber { get; set; }
        public string Brand { get; set; }
        public string Features { get; set; }
        public string LastModifier { get; set; }
        public string ThermostatTime { get; set; }
        public string UtcTime { get; set; }
        public Audio Audio { get; set; }
        public Alert[] Alerts { get; set; }
        public Settings Settings { get; set; }
        public Runtime Runtime { get; set; }
        public ExtendedRuntime ExtendedRuntime { get; set; }
        public Electricity Electricity { get; set; }
        public Device[] Devices { get; set; }
        public Location Location { get; set; }
        //public Energy Energy { get; set; }
        public Technician Technician { get; set; }
        public Utility Utility { get; set; }
        public Management Management { get; set; }
        public Weather Weather { get; set; }
        public Event[] Events { get; set; }
        public Program Program { get; set; }
        public HouseDetails HouseDetails { get; set; }
        public string EquipmentStatus { get; set; }
        public NotificationSettings NotificationSettings { get; set; }
        public Version Version { get; set; }
        public SecuritySettings SecuritySettings { get; set; }
        public RemoteSensor[] RemoteSensors { get; set; }
    }
}
