namespace EcoBeeApiWrapper.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Honorific { get; set; }
        public string RegisterDate { get; set; }
        public string RegisterTime { get; set; }
        public string DefaultThermostatIdentifier { get; set; }
        public string ManagementRef { get; set; }
        public string UtilityRef { get; set; }
        public string SupportRef { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsResidential { get; set; }
        public bool IsDeveloper { get; set; }
        public bool IsManagement { get; set; }
        public bool IsUtility { get; set; }
        public bool IsContractor { get; set; }
    }
}
