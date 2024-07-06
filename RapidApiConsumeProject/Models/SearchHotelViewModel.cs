namespace RapidApiConsumeProject.Models
{
    public class SearchHotelViewModel
    {

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public int ChildrenCount { get; set; }
        public int AdultCount { get; set; }
        public int RoomCount { get; set; }
        public string Currency { get; set; }
        public string Name { get; set; }


    }
}
