using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Models
{
    public class Token
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// false: test mode; true: production mode
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("used")]
        public bool Used { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
