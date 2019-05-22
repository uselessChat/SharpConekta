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
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }
        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }
    }

    public class LineItem<T> : LineItem
    {
        [JsonProperty("metadata")]
        public new T Metadata { get; set; }
    }
}
