namespace EcoBeeApiWrapper.Models
{
    public class HierarchySet
    {
        public string SetName { get; set; }
        public string SetPath { get; set; }
        public HierarchySet[] Children { get; set; }
        public HierarchyPrivilege[] Privileges { get; set; }
        public string[] Thermostats { get; set; }
    }
}
