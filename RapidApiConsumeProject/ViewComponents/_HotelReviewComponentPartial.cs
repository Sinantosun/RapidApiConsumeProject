using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsumeProject.Models;

namespace RapidApiConsumeProject.ViewComponents
{
    public class _HotelReviewComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client5 = new HttpClient();
            var request5 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/reviews?customer_type=solo_traveller%2Creview_category_group_of_friends&locale=en-gb&sort_type=SORT_MOST_RELEVANT&language_filter=en-gb%2Cde%2Cfr&hotel_id={id}&page_number=0"),
                Headers =
    {
        { "x-rapidapi-key", "rapid api key" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response5 = await client5.SendAsync(request5))
            {
                response5.EnsureSuccessStatusCode();
                var body5 = await response5.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<HotelReviewViewModel>(body5);
             
                return View(value);

            }
         
        }
    }
}
