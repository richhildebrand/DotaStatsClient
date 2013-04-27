namespace DotaSite.Models
{
    public class MatchPlayerItem
    {
        public long match_id { get; set; }
        public string account_id { get; set; }
        public int player_slot { get; set; }
        public int ItemId { get; set; }
        public int ItemSlot { get; set; }
        public Item item { get; set; }
    }
}