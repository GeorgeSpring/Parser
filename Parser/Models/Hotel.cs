namespace Parser.Models
{
    public class Hotel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public int status { get; set; }
        public string address { get; set; }
        public int has_debt { get; set; }
        public Times times { get; set; }
        public string in_time { get; set; }
        public int type_id { get; set; }
        public int category_id { get; set; }
        public int[] type_ids { get; set; }
        public int[] category_ids { get; set; }
        public int city_id { get; set; }
        public int region_id { get; set; }
        public string city_name { get; set; }
        public string city_url { get; set; }
        public int country_id { get; set; }
        public string country_url { get; set; }
        public string country_name { get; set; }
        public int district_id { get; set; }
        public int?[] district_ids { get; set; }
        public int stars { get; set; }
        public int breakfast { get; set; }
        public int breakfast_price { get; set; }
        public int half_board { get; set; }
        public int full_board { get; set; }
        public int all_inclusive { get; set; }
        public string url { get; set; }
        public string alt_name { get; set; }
        public int leader { get; set; }
        public int partner { get; set; }
        public int top { get; set; }
        public int partner_by_fee { get; set; }
        public int partner_by_adv { get; set; }
        public int adv { get; set; }
        public int weight { get; set; }
        public int supplier { get; set; }
        public int fixed_quota { get; set; }
        public int sales_closed { get; set; }
        public string type_name { get; set; }
        public string type_accusative { get; set; }
        public int show_type { get; set; }
        public float min_price { get; set; }
        public int position { get; set; }
        public string coords_ya { get; set; }
        public int rooms_num { get; set; }
        public float rating { get; set; }
        public int number_reviews { get; set; }
        public Reviews_Summary reviews_summary { get; set; }
        public string currency { get; set; }
        public int booked { get; set; }
        public int bookable { get; set; }
        public int _readonly { get; set; }
        public int show_phones { get; set; }
        public int opening_date { get; set; }
        public int overhaul_date { get; set; }
        public int opening_or_overhaul_date { get; set; }
        public int floors_num { get; set; }
        public float[] coords { get; set; }
        public Map map { get; set; }
        public float center_distance { get; set; }
        public string panorama_position { get; set; }
        public int show_nearest_panorama { get; set; }
        public int chain_id { get; set; }
        public int state_hotel { get; set; }
        public object[] virtual_tours { get; set; }
        public Image image { get; set; }
        public Image1[] images { get; set; }
        public Image_Pool image_pool { get; set; }
        public object image_winter { get; set; }
        public Facilities facilities { get; set; }
        public Distances distances { get; set; }
        public Facility_Distance facility_distance { get; set; }
        public int[] services { get; set; }
        public int[] service_categories { get; set; }
        public int sea_views { get; set; }
        public object conference_hall { get; set; }
        public int?[] rooms { get; set; }
        public object rooms_amenities { get; set; }
        public int has_rooms_with_bathroom { get; set; }
        public int has_placements_with_breakfast_buffet { get; set; }
        public object[] special_offers { get; set; }
        public int payment { get; set; }
        public int cards { get; set; }
        public int pets { get; set; }
        public int pet_weight { get; set; }
        public int forced_real_phone { get; set; }
        public string[] phones { get; set; }
        public int pageviews { get; set; }
        public int distance_to_sea { get; set; }
        public Area[] areas { get; set; }
        public object sea_distances { get; set; }
        public string[] languages { get; set; }
        public float original_rating { get; set; }
        public Booking_Areas[] booking_areas { get; set; }
        public Displayed_Phones displayed_phones { get; set; }
        public int popular { get; set; }
        public Min_Price_Data min_price_data { get; set; }
        public Category_Index category_index { get; set; }
        public object rel_owner { get; set; }
        public Valid_Filter valid_filter { get; set; }
        public int views { get; set; }
        public int supplier_id { get; set; }
        public int supplier_closed { get; set; }
        public int ad_type { get; set; }
        public int requests_allowed { get; set; }
    }
}