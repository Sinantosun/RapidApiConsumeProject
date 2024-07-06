namespace RapidApiConsumeProject.Models
{
    public class FilterHotelViewModel
    {
        public Result[] results { get; set; }


        public class Result
        {
            public int id { get; set; }
            public string name { get; set; }

            public string photoMainUrl { get; set; }
            public string currency { get; set; }

            public float longitude { get; set; }
            public Pricebreakdown priceBreakdown { get; set; }

            public string checkoutDate { get; set; }
            public string checkinDate { get; set; }
            public float reviewScore { get; set; }
            public string reviewScoreWord { get; set; }
            public int reviewCount { get; set; }
            public class Pricebreakdown
            {
                public Grossprice grossPrice { get; set; }
            }
            public class Grossprice
            {
                public string currency { get; set; }
                public float value { get; set; }
            }
        }

    }

}
