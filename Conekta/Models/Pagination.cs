using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class Pagination
    {
        /// <summary>
        /// Next page
        /// </summary>
        [JsonProperty("next_page_url")]
        public string NextPage { get; set; }

        /// <summary>
        /// Previous page
        /// </summary>
        [JsonProperty("previous_page_url")]
        public string PreviousPage { get; set; }

        /// <summary>
        /// True if more pages to retrieve
        /// </summary>
        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// Array with page results
        /// </summary>
        [JsonProperty("data")]
        public IEnumerable Data { get; set; }
    }

    public class Pagination<T> : Pagination
    {
        /// <summary>
        /// Array with page results
        /// </summary>
        [JsonProperty("data")]
        public new List<T> Data { get; set; }
    }
}