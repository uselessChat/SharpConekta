using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class ShipppingAddress
    {
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("street2")]
        public string InternalNumber { get; set; }
        [JsonProperty("residential")]
        public bool Residential { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("street1")]
        public string StreetAndNumber { get; set; }
        [JsonProperty("postal_code")]
        public string ZipCode { get; set; }
    }

    public class ShippingContact
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("address")]
        public ShipppingAddress Address { get; set; }
        [JsonProperty("between_streets")]
        public string BetweenStreets { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("receiver")]
        public string Receiver { get; set; }
    }
}