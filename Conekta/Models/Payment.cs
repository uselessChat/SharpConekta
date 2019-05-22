using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public enum PaymentMethodType
    {
        Oxxo,
        Oxxo_Cash
    }

    public class PaymentMethod
    {
        [JsonProperty("expires_at")]
        public long? ExpiresAt { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("service_name")]
        public string Service { get; set; }

        [JsonProperty("store_name")]
        public string Store { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        public PaymentMethod() { }

        public PaymentMethod(PaymentMethodType type)
        {
            Type = type.ToString().ToLower();
        }
    }

    public enum PaymentSourceType
    {
        Card
    }

    /// <summary>
    /// The Payment Source object describes a payment method.
    /// This can be online (card payments) or offline OXXO and SPEI.
    /// Remember that for offline payments you will need to add a webhook listener.
    /// </summary>
    public class PaymentSource
    {
        /// <summary>
        /// Unique identifier randomly assigned
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Address of the cardholder
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Card's brand
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Date when the payment source was created
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Id of the customer that owns the payment source
        /// </summary>
        [JsonProperty("parent_id")]
        public string CustomerId { get; set; }

        [JsonProperty("default")]
        public bool? Default { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Expiration month of the card
        /// </summary>
        [JsonProperty("exp_month")]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Expiration year of the card
        /// </summary>
        [JsonProperty("exp_year")]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Last 4 digits of the card
        /// </summary>
        [JsonProperty("last4")]
        public string Last4Digits { get; set; }

        /// <summary>
        /// Name of the card holder
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Token id that will be used to create a payment source
        /// </summary>
        [JsonProperty("token_id")]
        public string TokenId { get; set; }

        /// <summary>
        /// Payment source's type. 
        /// Allowed values: [:card]
        /// Use constructor when needed
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Object's class. In this case "payment_source"
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; } = "payment_source";

        public PaymentSource() { }

        public PaymentSource(PaymentSourceType type)
        {
            Type = type.ToString().ToLower();
        }

        /// <summary>
        /// To use this model you must first generate a token_id using the Token model & client
        /// You can use PaymentSource model to create an entry but you must still provide the token_id
        /// </summary>
        public class Create
        {
            /// <summary>
            /// Token id that will be used to create a payment source
            /// </summary>
            [JsonProperty("token_id")]
            public string TokenId { get; set; }

            /// <summary>
            /// Payment source's type. 
            /// Allowed values: [:card]
            /// </summary>
            [JsonProperty("type")]
            public string Type { get; set; }

            private Create() { }

            public Create(PaymentSourceType type)
            {
                Type = type.ToString().ToLower();
            }
        }

        public class Update
        {
            /// <summary>
            /// Name of the card holder
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Expiration month of the card
            /// </summary>
            [JsonProperty("exp_month")]
            public string ExpirationMonth { get; set; }

            /// <summary>
            /// Expiration year of the card
            /// </summary>
            [JsonProperty("exp_year")]
            public string ExpirationYear { get; set; }

            /// <summary>
            /// Address of the cardholder
            /// </summary>
            [JsonProperty("address")]
            public Address Address { get; set; }
        }
    }
}
