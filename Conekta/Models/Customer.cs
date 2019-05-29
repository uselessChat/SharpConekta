using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
    /// <summary>
    /// Customers allow you to store payment methods for clients and set up subscriptions
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Customer's unique identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// (Optional)
        /// Indicates whether a user is corporate or not
        /// </summary>
        [JsonProperty("corporate")]
        public bool Corporate { get; set; }

        [JsonProperty("custom_id")]
        public string CustomId { get; set; }

        [JsonProperty("default_shipping_contact_id")]
        public string DefaultShippingContactId { get; set; }

        [JsonProperty("default_payment_source_id")]
        public string DefaultPaymentSourceId { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// Customer's email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// false: test mode; true: production mode
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Customer's name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// (Readonly)
        /// Object class. In this case, "customer"
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; } = "customer";

        /// <summary>
        /// (Optional)
        /// The Source object describes a payment method. Go to Payment Sources for further details
        /// </summary>
        [JsonProperty("payment_sources")]
        public Pagination<PaymentSource> PaymentSources { get; set; }

        /// <summary>
        /// (Optional)
        /// Customer's phone number (international format)
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// (Optional)
        /// Plan secondary id
        /// </summary>
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// (Optional)
        /// A Shipping Contact describes the details for the shipment. Go to Shipping contacts for further details
        /// </summary>
        [JsonProperty("shipping_contacts")]
        public Pagination<ShippingContact> ShippingContacts { get; set; }

        /// <summary>
        /// (Optional)
        /// Subscriptions bill your client a fixed amount on a recurring basis.
        /// You can change the plan of a subscription, pause, cancel and resume a subscription as you wish.
        /// Go to Subscriptions for further details.
        /// </summary>
        [JsonProperty("subscription")]
        public Subscription Subscription { get; set; }
    }

    public class Create : Customer
    {
        /// <summary>
        /// (Optional)
        /// The Source object describes a payment method. Go to Payment Sources for further details
        /// </summary>
        [JsonProperty("payment_sources")]
        public new IEnumerable<PaymentSource> PaymentSources { get; set; }

        /// <summary>
        /// (Optional)
        /// A Shipping Contact describes the details for the shipment. Go to Shipping contacts for further details
        /// </summary>
        [JsonProperty("shipping_contacts")]
        public new IEnumerable<ShippingContact> ShippingContacts { get; set; }
    }

    public class Update : Create { }
}