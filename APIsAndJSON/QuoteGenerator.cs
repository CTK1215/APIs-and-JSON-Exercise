using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        private readonly HttpClient _client = new HttpClient();

        public string GetKanyeQuote()
        {
            var url = "https://api.kanye.rest";
            var response = _client.GetStringAsync(url).Result;
            var quote = JObject.Parse(response).GetValue("quote").ToString();
            return quote;
        }

        public string GetRonSwansonQuote()
        {
            var url = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var response = _client.GetStringAsync(url).Result;
            var quote = JArray.Parse(response).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            return quote;
        }
    }
}