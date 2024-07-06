namespace RapidApiConsumeProject.Models
{
    public class HotelPhotosViewModel
    {


        public Tag[] tags { get; set; }
        public string url_1440 { get; set; }

        public class Tag
        {
            public int id { get; set; }
            public string tag { get; set; }
        }

    }
}
