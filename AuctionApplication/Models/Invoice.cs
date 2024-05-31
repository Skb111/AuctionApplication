namespace AuctionApplication.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int AuctionId { get; set; }
        public string Bidder { get; set; }
        public decimal Amount { get; set; }
    }
}
