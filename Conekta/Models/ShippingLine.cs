using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Models
{
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
        /// (Optional)
        /// Shipping method.
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        /// <summary>
        /// (Readonly)
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; } = "shipping_line";

        /// <summary>
        /// (Readonly)
        /// </summary>
        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// (Optional)
        /// Tracking number provided by the carrier.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string Tracking { get; set; }

        /// <summary>
        /// (Optional)
        /// Hash containing additional information related to the shipping line.
        /// </summary>
        [JsonProperty("metadata")]
        public object Metadata { get; set; }
    }

    public class ShippingLine<T> : ShippingLine
    {
        /// <summary>
        /// (Optional)
        /// Hash containing additional information related to the shipping line.
        /// </summary>
        [JsonProperty("metadata")]
        public new T Metadata { get; set; }
    }
}
