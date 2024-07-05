using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsumeProject.Models;

namespace RapidApiConsumeProject.Controllers
{
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=en-gb&currency=TRY"),
                Headers =
    {
        { "x-rapidapi-key", "26a94699b7mshf92c10fadb7e461p155d6cjsn8e4aae7a4ad2" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ResultExchangeViewModel>(body);
                return View(result);
            }
         
        }
    }
}
