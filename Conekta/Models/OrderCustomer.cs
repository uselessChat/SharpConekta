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
        /// (Optional)
        /// It states if the customer is corporate or not, the default value is false. 
        /// </summary>
        [JsonProperty("corporate")]
        public bool Corporate { get; set; }

        /// <summary>
        /// (Optional if customer_id is sent)
        /// Customer's email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// (Optional if customer_id is sent)
        /// Customer's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// (Optional if customer_id is sent)
        /// Customer's phone.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}