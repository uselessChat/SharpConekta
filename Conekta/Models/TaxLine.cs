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
        /// The tax amount to be paid
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Tax code
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// (Readonly)
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; } = "tax_line";

        /// <summary>
        /// (Readonly)
        /// </summary>
        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// (Optional)
        /// Hash containing additional information related to the tax line.
        /// </summary>
        [JsonProperty("metadata")]
        public object Metadata { get; set; }
    }

    public class TaxLine<T> : TaxLine
    {
        /// <summary>
        /// (Optional)
        /// Hash containing additional information related to the tax line.
        /// </summary>
        [JsonProperty("metadata")]
        public new T Metadata { get; set; }
    }
}