using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class ShipppingAddress
    {
        /// <summary>
        /// The city for the shipping address
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Destination country, use the two-digit format ISO 3166-1
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The second line for the shipping address.
        /// Usually used for the internal number, suite, residential complex or county.
        /// </summary>
        [JsonProperty("street2")]
        public string InternalNumber { get; set; }

        /// <summary>
        /// Boolean value that indicates whether it is a residential shipping andress.
        /// By default is taken as true 
        /// </summary>
        [JsonProperty("residential")]
        public bool? Residential { get; set; }

        /// <summary>
        /// The state for the shipping address
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The first line for the shipping address.
        /// Usually used for the street and the number
        /// </summary>
        [JsonProperty("street1")]
        public string StreetAndNumber { get; set; }

        /// <summary>
        /// The postal code for the shipping address
        /// </summary>
        [JsonProperty("postal_code")]
        public string ZipCode { get; set; }
    }

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

    /// <summary>
    /// A Shipping Line describes the shipment details for an order such as
    ///  the method, the amount, the carrier and the tracking number.
    /// </summary>
    public class ShippingLine
    {
        /// <summary>
        /// Unique identifier, assigned at random
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The shipping cost, in cents
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Name of the carrier
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Shipping method. (optional)
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        /// <summary>
        /// Tracking number provided by the carrier. (optional)
        /// </summary>
        [JsonProperty("tracking_number")]
        public string Tracking { get; set; }

        /// <summary>
        /// Hash containing additional information related to the shipping line. (optional)
        /// </summary>
        [JsonProperty("metadata")]
        public object Metadata { get; set; }
    }

    public class ShippingLine<T> : ShippingLine
    {
        /// <summary>
        /// Hash containing additional information related to the shipping line. (optional)
        /// </summary>
        [JsonProperty("metadata")]
        public new T Metadata { get; set; }
    }
}