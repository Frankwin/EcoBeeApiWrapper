namespace EcoBeeApiWrapper.Models
{
    public class HierarchyPrivilege
    {
        public string SetPath { get; set; }
        public string SetName { get; set; }
        public string UserName { get; set; }
        public bool ShowAll { get; set; }
        public bool AllowNone { get; set; }
        public bool AllowView { get; set; }
        public bool AllowProgram { get; set; }
        public bool AllowVacation { get; set; }
        public bool AllowSettings { get; set; }
        public bool AllowDetails { get; set; }
        public bool AllowReport { get; set; }
        public bool AllowSecurity { get; set; }
        public bool AllowHierarchy { get; set; }
        public bool AllowAlerts { get; set; }
        public bool AllowManageAccount { get; set; }
    }
}
