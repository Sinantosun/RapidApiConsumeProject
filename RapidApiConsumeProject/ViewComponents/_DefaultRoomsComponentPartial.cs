using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsumeProject.Models;

namespace RapidApiConsumeProject.ViewComponents
{
    public class _DefaultRoomsComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?children_number=2&locale=en-gb&children_ages=5%2C0&filter_by_currency=USD&checkin_date=2024-09-14&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&dest_type=city&dest_id=-553173&adults_number=2&checkout_date=2024-09-15&order_by=popularity&include_adjacency=true&room_number=1&page_number=0&units=metric"),
                Headers =
    {
        { "x-rapidapi-key", "rapid api key" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
           {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var resultJson = JsonConvert.DeserializeObject<ResultRoomsViewModel>(body);
                return View(resultJson.results.Take(10).ToList());
            }
        }
    }
}
