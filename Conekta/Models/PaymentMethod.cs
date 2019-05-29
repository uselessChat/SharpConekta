using Conekta.Enums;
using Conekta.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Models
{
    public class PaymentMethod
    {
        [JsonProperty("expires_at")]
        public long? ExpiresAt { get; set; }

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
            Type = type.ToString().ToSnakeCase();
        }
    }
}