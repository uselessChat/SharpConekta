using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    /// <summary>
    /// Describes the taxes of the order
    /// </summary>
    public class TaxLine
    {
        /// <summary>
        /// Unique identifier for the tax
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Tax code
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The tax amount to be paid
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Hash containing additional information related to the tax line. (optional)
        /// </summary>
        [JsonProperty("metadata")]
        public object Metadata { get; set; }
    }

    public class TaxLine<T> : TaxLine
    {
        /// <summary>
        /// Hash containing additional information related to the tax line. (optional)
        /// </summary>
        [JsonProperty("metadata")]
        public new T Metadata { get; set; }
    }
}