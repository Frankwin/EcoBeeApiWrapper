using System.Collections.Generic;

namespace EcoBeeApiWrapper.Models
{
    public class NotificationSettings
    {
        public List<string> EmailAddresses { get; set; }
        public bool EmailNotificationsEnabled { get; set; }
        public EquipmentSetting[] Equipment { get; set; }
        public GeneralSetting[] General { get; set; }
        public LimitSetting[] Limit { get; set; }
    }
}
