using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class TaxLine
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("amount")]
        public int Amount { get; set; }
        [JsonProperty("metadata")]
        public object Metadata { get; set; }
    }

    public class TaxLine<T> : TaxLine
    {
        [JsonProperty("metadata")]
        public new T Metadata { get; set; }
    }
}