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
            var ClientForDescriptionAPI = new HttpClient();
            var RequestForDescriptionAPI = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/description?hotel_id={id}&locale=en-gb"),
                Headers =
    {
        { "x-rapidapi-key", "rapid api key" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var ResponseForDescriptionAPI = await ClientForDescriptionAPI.SendAsync(RequestForDescriptionAPI))
            {
                ResponseForDescriptionAPI.EnsureSuccessStatusCode();
                var ResponseConentBodyForHotelDescription = await ResponseForDescriptionAPI.Content.ReadAsStringAsync();
                var HotelDescriptionsResult = JsonConvert.DeserializeObject<HotelDescriptionViewModel>(ResponseConentBodyForHotelDescription);
                ViewBag.Desrcipton = HotelDescriptionsResult.description;

            }



            var ClientForHotelImagesAPI = new HttpClient();
            var RequestForImagesAPI = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/photos?hotel_id={id}&locale=en-gb"),
                Headers =
    {
        { "x-rapidapi-key", "rapid api key" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var ResponseForImagesAPI = await ClientForHotelImagesAPI.SendAsync(RequestForImagesAPI))
            {
                ResponseForImagesAPI.EnsureSuccessStatusCode();
                var ResponseContentForHotelImaages = await ResponseForImagesAPI.Content.ReadAsStringAsync();
                var HotelImagesResult = JsonConvert.DeserializeObject<List<HotelPhotosViewModel>>(ResponseContentForHotelImaages);
                List<HotelFiltredViewModel> model = new List<HotelFiltredViewModel>();

                foreach (var item in HotelImagesResult)
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
                var ClientForDefaultPageHotelRoomsAPI = new HttpClient();
                var RequestForDefaultPageHotelRoomAPI = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/details?currency={currency}&locale=en-gb&checkout_date={checkoutdate}&hotel_id={id}&checkin_date={checkindate}"),
                    Headers =
    {
        { "x-rapidapi-key", "rapid api key" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var ResponseForDefaultPageHotelRoomsAPI = await ClientForDefaultPageHotelRoomsAPI.SendAsync(RequestForDefaultPageHotelRoomAPI))
                {
                    ResponseForDefaultPageHotelRoomsAPI.EnsureSuccessStatusCode();
                    var DefaultPageResult = await ResponseForDefaultPageHotelRoomsAPI.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<HotelDetailViewModel>(DefaultPageResult);
                    return View(value);
                }
            }
        }

        public async Task<IActionResult> SearchHotels(SearchHotelViewModel model)
        {
            ViewBag.LocationName = model.Name;
            var ClientForLocationAPI = new HttpClient();
            var RequestForLocationAPI = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={model.Name}&locale=en-gb"),
                Headers =
            {
                { "x-rapidapi-key", "rapid api key" },
                { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
            },
            };
            using (var ResponseForLocationAPI = await ClientForLocationAPI.SendAsync(RequestForLocationAPI))
            {
                ResponseForLocationAPI.EnsureSuccessStatusCode();
                var LocationResult = await ResponseForLocationAPI.Content.ReadAsStringAsync();
                var id = JsonConvert.DeserializeObject<List<GetDestinationViewModel>>(LocationResult);
                string convertCheckInDate = model.CheckInDate.ToString("yyyy-MM-dd");
                string convertCheckOutDate = model.CheckOutDate.ToString("yyyy-MM-dd");

                var ClientForSearchPageAPI = new HttpClient();
                var RequestForSearchPageAPI = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/search?children_number={model.ChildrenCount}&locale=en-gb&children_ages=0&filter_by_currency={model.Currency}&checkin_date={convertCheckInDate}&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&dest_type=city&dest_id={id[0].dest_id}&adults_number={model.AdultCount}&checkout_date={convertCheckOutDate}&order_by=popularity&include_adjacency=true&room_number={model.RoomCount}&page_number=0&units=metric"),
                    Headers =
            {
                { "x-rapidapi-key", "rapid api key" },
                { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
            },
                };
                using (var ResponseForSearchAPI = await ClientForSearchPageAPI.SendAsync(RequestForSearchPageAPI))
                {
                    ResponseForSearchAPI.EnsureSuccessStatusCode();
                    var SearchResult = await ResponseForSearchAPI.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<FilterHotelViewModel>(SearchResult);
                    return View(result.results.ToList());
                }

            }

     
        }


    }
}
