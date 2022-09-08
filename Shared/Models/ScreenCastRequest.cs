namespace Remotely.Shared.Models
{
    public class ScreenCastRequest
    {
        public bool NotifyUser { get { return false; } set { } }
        public string RequesterName { get; set; }
        public string ViewerID { get; set; }
        public bool UseWebRtc { get; set; }
    }
}
