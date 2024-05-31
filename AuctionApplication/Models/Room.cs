namespace AuctionApplication.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int AuctionId { get; set; }
        public List<string> Participants { get; set; }
    }
}
