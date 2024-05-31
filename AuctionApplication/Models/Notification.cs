namespace AuctionApplication.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public string User { get; set; }
        public int AuctionId { get; set; }
    }
}
