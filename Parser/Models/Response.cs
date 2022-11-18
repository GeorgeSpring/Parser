namespace Parser.Models
{
    public class Response
    {
        public City[] cities { get; set; }
        public Hotel[] hotels { get; set; }
        public object[] additional_hotel_ids { get; set; }
        public bool isMember { get; set; }
    }
}