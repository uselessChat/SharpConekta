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
        /// Adjacent streets to the shipping address. (optional)
        /// </summary>
        [JsonProperty("between_streets")]
        public string BetweenStreets { get; set; }

        /// <summary>
        /// Contact's phone number
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Contact's name. (optional)
        /// </summary>
        [JsonProperty("receiver")]
        public string Receiver { get; set; }
    }
}