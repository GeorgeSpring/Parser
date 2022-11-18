namespace Parser.Models
{
    public class City
    {
        public string id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public string coords_ya { get; set; }
        public string url { get; set; }
        public string genitive { get; set; }
        public string distance { get; set; }
        public string country_name { get; set; }
        public string country_url { get; set; }
        public int hotels_num { get; set; }
        public float[] coords { get; set; }
        public int[] types { get; set; }
        public string local_time { get; set; }
    }
}