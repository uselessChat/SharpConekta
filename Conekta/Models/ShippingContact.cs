using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Models
{
    /// <summary>
    /// Describes the customer's information for the shipment
    /// </summary>
    public class ShippingContact
    {
        /// <summary>
        /// Unique identifier, assigned at random
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Shipping address
        /// </summary>
        [JsonProperty("address")]
        public ShipppingAddress Address { get; set; }

        /// <summary>
        /// (Optional)
        /// Adjacent streets to the shipping address. (optional)
        /// </summary>
        [JsonProperty("between_streets")]
        public string BetweenStreets { get; set; }

        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        /// <summary>
        /// (Readonly)
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; } = "shipping_contact";

        /// <summary>
        /// (Readonly)
        /// Customer || Order
        /// </summary>
        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// Contact's phone number
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// (Optional)
        /// Contact's name.
        /// </summary>
        [JsonProperty("receiver")]
        public string Receiver { get; set; }
    }
}