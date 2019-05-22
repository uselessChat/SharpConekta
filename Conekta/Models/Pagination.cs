using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class Pagination
    {
        [JsonProperty("next_page_url")]
        public string NextPage { get; set; }
        [JsonProperty("previous_page_url")]
        public string PreviousPage { get; set; }
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("data")]
        public IEnumerable Data { get; set; }
    }

    public class Pagination<T> : Pagination
    {
        [JsonProperty("data")]
        public new List<T> Data { get; set; }
    }
}