namespace RapidApiConsumeProject.Models
{
    public class HotelReviewViewModel
    {
        public Result[] result { get; set; }


        public class Result
        {
            public Stayed_Room_Info stayed_room_info { get; set; }
            public string countrycode { get; set; }
            public float average_score { get; set; }
            public string travel_purpose { get; set; }
            public int hotel_id { get; set; }
            public int is_moderated { get; set; }
            public string hotelier_response { get; set; }
            public int reviewng { get; set; }
            public string pros { get; set; }
            public int hotelier_response_date { get; set; }
            public string hotelier_name { get; set; }
            public string cons { get; set; }
            public string anonymous { get; set; }
            public Reviewer_Photos[] reviewer_photos { get; set; }
            public string title_translated { get; set; }
            public int helpful_vote_count { get; set; }
            public string languagecode { get; set; }
            public object[] tags { get; set; }
            public int is_incentivised { get; set; }
            public Author author { get; set; }
            public string review_hash { get; set; }
            public object[] user_new_badges { get; set; }
            public long review_id { get; set; }
            public string date { get; set; }
            public int is_trivial { get; set; }
            public string cons_translated { get; set; }
            public string title { get; set; }
            public string pros_translated { get; set; }
        }

        public class Stayed_Room_Info
        {
            public Photo photo { get; set; }
            public string checkin { get; set; }
            public int num_nights { get; set; }
            public string checkout { get; set; }
            public string room_name { get; set; }
            public int room_id { get; set; }
        }

        public class Photo
        {
            public string url_max300 { get; set; }
            public string url_original { get; set; }
            public int photo_id { get; set; }
            public string url_640x200 { get; set; }
            public float ratio { get; set; }
            public string url_square60 { get; set; }
        }

        public class Author
        {
            public string name { get; set; }
            public string type_string { get; set; }
            public int nr_reviews { get; set; }
            public string countrycode { get; set; }
            public int helpful_vote_count { get; set; }
            public int user_id { get; set; }
            public string age_group { get; set; }
            public string city { get; set; }
            public string type { get; set; }
            public string avatar { get; set; }
        }

        public class Reviewer_Photos
        {
            public string square90 { get; set; }
            public string max1280x900 { get; set; }
            public string square60_ao { get; set; }
            public string max500_ao { get; set; }
        }

    }
}
