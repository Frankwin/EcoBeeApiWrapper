using EcoBeeApiWrapper.Enums;

namespace EcoBeeApiWrapper.Models
{
    public class Alert
    {
        public string AcknowledgeRef { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Severity Severity { get; set; }
        public int AlertNumber { get; set; }
        public AlertType AlertType { get; set; }
        public bool IsOperatorAlert { get; set; }
        public string Reminder { get; set; }
        public bool ShowIdt { get; set; }
        public bool ShowWeb { get; set; }
        public bool SendEmail { get; set; }
        public AcknowledgementType Acknowledgement { get; set; }
        public bool RemindMeLater { get; set; }
        public string ThermostatIdentifier { get; set; }
        public NotificationType NotificationType { get; set; }
    }
}
