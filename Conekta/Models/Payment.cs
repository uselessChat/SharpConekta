using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public enum PaymentSourceType
    {
        Card
    }

    public class PaymentSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string CustomerId { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }

        [JsonProperty("exp_month")]
        public string ExpirationMonth { get; set; }

        [JsonProperty("exp_year")]
        public string ExpirationYear { get; set; }

        [JsonProperty("last4")]
        public string Last4Digits { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        public PaymentSource() { }

        public PaymentSource(PaymentSourceType type)
        {
            Type = type.ToString().ToLower();
        }
    }

}
