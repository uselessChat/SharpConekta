using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class DiscountLine
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("amount")]
        public int Amount { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }

        public DiscountLine()
        {

        }

        public DiscountLine(DiscountLineType type)
        {
            Type = type.ToString().ToLower();
        }
    }

    public enum DiscountLineType
    {
        Campaign,
        Coupon,
        Loyalty,
        Sign
    }
}
