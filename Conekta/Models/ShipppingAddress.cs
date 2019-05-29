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
        /// (Optional)
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
}