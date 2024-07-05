namespace RapidApiConsumeProject.Models
{
    public class ResultExchangeViewModel
    {

        public Exchange_Rates[] exchange_rates { get; set; }
 


        public class Exchange_Rates
        {
            public string exchange_rate_buy { get; set; }
            public string currency { get; set; }
        }

    }
}
