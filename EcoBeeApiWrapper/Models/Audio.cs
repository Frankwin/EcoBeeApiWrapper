namespace EcoBeeApiWrapper.Models
{
    public class Audio
    {
        public int PlaybackVolume { get; set; }
        public bool MicrophoneEnabled { get; set; }
        public int SoundAlertVolume { get; set; }
        public int SoundTickVolume { get; set; }
        public VoiceEngine[] VoiceEngine { get; set; }
    }
}
