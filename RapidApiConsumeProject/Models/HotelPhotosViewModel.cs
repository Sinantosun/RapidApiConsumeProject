namespace RapidApiConsumeProject.Models
{
    public class HotelPhotosViewModel
    {





        public int descriptiontype_id { get; set; }
        public Ml_Tags[] ml_tags { get; set; }
        public int photo_id { get; set; }
        public Tag[] tags { get; set; }
        public string url_square60 { get; set; }
        public string url_max { get; set; }
        public string url_1440 { get; set; }


        public class Ml_Tags
        {
            public int photo_id { get; set; }
            public int tag_id { get; set; }
            public string tag_name { get; set; }
            public string tag_type { get; set; }
            public int confidence { get; set; }
        }

        public class Tag
        {
            public int id { get; set; }
            public string tag { get; set; }
        }

    }
}
