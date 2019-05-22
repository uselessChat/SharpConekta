using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class LineItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sku")]
        public string SKU { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public string OrderId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        //[JsonProperty("tags")]
        //public IEnumerable<string> Tags { get; set; }

        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        [JsonProperty("antifraud_info")]
        public object Antifraud { get; set; }
    }

    public class LineItem<T> : LineItem
    {
        [JsonProperty("metadata")]
        public new T Metadata { get; set; }
    }
}
