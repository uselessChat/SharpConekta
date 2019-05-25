using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class OrderCustomer
    {
        /// <summary>
        /// Id of the customer. This is required if the other customer_info fields are not sent.
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// It states if the customer is corporate or not, the default value is false. (optional)
        /// </summary>
        [JsonProperty("corporate")]
        public bool Corporate { get; set; }

        /// <summary>
        /// Customer's email. (optional if customer_id is sent)
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Customer's name. (optional if customer_id is sent)
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Customer's phone. (optional if customer_id is sent)
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}