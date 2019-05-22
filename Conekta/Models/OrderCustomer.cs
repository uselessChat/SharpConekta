using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class OrderCustomer
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("corporate")]
        public bool Corporate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}