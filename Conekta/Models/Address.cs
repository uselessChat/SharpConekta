using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class BillingAddress
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("street2")]
        public string InternalNumber { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street1")]
        public string StreetAndNumber { get; set; }

        [JsonProperty("postal_code")]
        public string ZipCode { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }
    }
}