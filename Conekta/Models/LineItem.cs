using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
    /// <summary>
    /// Represents the Line Items in the order
    /// </summary>
    public class LineItem
    {
        /// <summary>
        /// Unique identifier for the line item
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("antifraud_info")]
        public object Antifraud { get; set; }

        /// <summary>
        /// (Optional)
        /// Line item's brand
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// (Optional)
        /// Short description of the item (<250)
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// (Optional)
        /// The Storage Keeping Unit designated by the company
        /// </summary>
        [JsonProperty("sku")]
        public string SKU { get; set; }

        /// <summary>
        /// (Optional)
        /// Hash containing additional information related to the line item
        /// </summary>
        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// Line item's name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// (Readonly)
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; } = "line_item";

        /// <summary>
        /// (Readonly)
        /// </summary>
        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// Line item's quantity for the order
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// (Optional)
        /// Array containing the line item's categories
        /// </summary>
        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// Line item's price in cents
        /// </summary>
        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }
    }

    public class LineItem<T> : LineItem
    {
        /// <summary>
        /// (Optional)
        /// Hash containing additional information related to the line item
        /// </summary>
        [JsonProperty("metadata")]
        public new T Metadata { get; set; }
    }

    public class LineItem<M, A> : LineItem<M>
    {
        [JsonProperty("antifraud_info")]
        public new A Antifraud { get; set; }
    }
}