using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public enum DiscountLineType
    {
        Campaign,
        Coupon,
        Loyalty,
        Sign
    }

    /// <summary>
    /// Describes the discounts to be applied to the order
    /// </summary>
    public class DiscountLine
    {
        /// <summary>
        /// Unique identifier, assigned at random
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The discount's amount, in cents
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Discount line's code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Allowed values: [:loyalty, :campaign, :coupon, :sign]
        /// Use constructor when needed
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        public DiscountLine() { }

        public DiscountLine(DiscountLineType type)
        {
            Type = type.ToString().ToLower();
        }
    }
}