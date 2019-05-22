using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public enum PaymentMethodType
    {
        Oxxo,
        Oxxo_Cash
    }

    public class PaymentMethod
    {
        [JsonProperty("expires_at")]
        public long ExpiresAt { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("service_name")]
        public string Service { get; set; }

        [JsonProperty("store_name")]
        public string Store { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        public PaymentMethod() { }

        public PaymentMethod(PaymentMethodType type)
        {
            Type = type.ToString().ToLower();
        }
    }

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
