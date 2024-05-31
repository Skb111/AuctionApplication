namespace AuctionApplication.Models
{
    public class Auction
    {
        public int AuctionId { get; set; }
        public string ItemName { get; set; }
        public decimal StartBidding { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string  Status { get; set; }
    }
}
