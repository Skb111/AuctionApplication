namespace AuctionApplication.Models
{
    public class Bid
    {
        public int BidId { get; set; }
        public int AuctionId { get; set; }
        public decimal Amount { get; set; }
        public string Bidder { get; set; }
        public bool IsWinningBid { get; set; }
        public Auction Auction { get; set; }
    }
}
