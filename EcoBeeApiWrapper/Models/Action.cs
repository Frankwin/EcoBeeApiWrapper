using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class Action
    {
        public ActionType Type { get; set; }
        public bool SendAlert { get; set; }
        public bool SendUpdate { get; set; }
        public int ActivationDelay { get; set; }
        public int DeactivationDelay { get; set; }
        public int MinActionDuration { get; set; }
        public int HeatAdjustTemp { get; set; }
        public int CoolAdjustTemp { get; set; }
        public string ActivateRelay { get; set; }
        public bool ActivateRelayOpen { get; set; }
    }
}
