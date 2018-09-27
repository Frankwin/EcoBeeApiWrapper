namespace EcoBeeApiWrapper.Models
{
    public class SecuritySettings
    {
        public string UserAccessCode { get; set; }
        public bool AllUserAccess { get; set; }
        public bool ProgramAccess { get; set; }
        public bool DetailsAccess { get; set; }
        public bool QuickSaveAccess { get; set; }
        public bool VacationAccess { get; set; }
    }
}
