using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RapidApiConsumeProject.Models;

namespace RapidApiConsumeProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> GetHotelDetails(int id, string checkindate, string checkoutdate, string currency, string imageURL)
        {
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/description?hotel_id={id}&locale=en-gb"),
                Headers =
    {
        { "x-rapidapi-key", "26a94699b7mshf92c10fadb7e461p155d6cjsn8e4aae7a4ad2" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var value2 = JsonConvert.DeserializeObject<HotelDescriptionViewModel>(body2);
                ViewBag.Desrcipton = value2.description;

            }



            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/photos?hotel_id={id}&locale=en-gb"),
                Headers =
    {
        { "x-rapidapi-key", "26a94699b7mshf92c10fadb7e461p155d6cjsn8e4aae7a4ad2" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var value2 = JsonConvert.DeserializeObject<List<HotelPhotosViewModel>>(body3);
                List<HotelFiltredViewModel> model = new List<HotelFiltredViewModel>();

                foreach (var item in value2)
                {
                    for (int i = 0; i < item.tags.Count(); i++)
                    {
                        if (item.tags[i].tag.Contains("room"))
                        {
                            var result = model.FirstOrDefault(x => x.Image == item.url_1440);
                            if (result == null)
                            {
                                model.Add(new HotelFiltredViewModel
                                {
                                    Image = item.url_1440,
                                });
                            }


                        }
                    }
                }

                ViewBag.PhotoImages = model.Take(5).ToList();




     




                TempData["imageURL"] = imageURL;
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/details?currency={currency}&locale=en-gb&checkout_date={checkoutdate}&hotel_id={id}&checkin_date={checkindate}"),
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
                    var value = JsonConvert.DeserializeObject<HotelDetailViewModel>(body);
                    return View(value);
                }








            }
        }
    }
}
