namespace Parser.Models
{
    public class Min_Price_Data
    {
        public int hotel_id { get; set; }
        public int price { get; set; }
        public string currency { get; set; }
        public string _in { get; set; }
        public string _out { get; set; }
        public int has_free { get; set; }
        public string updated { get; set; }
        public string current_price_date { get; set; }
        public int room_id { get; set; }
        public string placement_id { get; set; }
    }
}