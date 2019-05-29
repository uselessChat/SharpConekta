using System;
using Conekta.Enums;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class Charge
    {
        /// <summary>
        /// Unique identifier, assigned at random
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The charge's amount, in cents
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// Date of the charge's creation.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Currency of the charge. A 3-letter code of the International Standard ISO 4217
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Amount of the fee in cents
        /// </summary>
        [JsonProperty("fee")]
        public int? Fee { get; set; }

        /// <summary>
        /// false: Sandbox Mode. true: Production Mode
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Id of the order that the charge belongs to
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// Payment method of the charge
        /// </summary>
        [JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Monthly installments in which the charge will be divided, with no interest added.
        /// Conekta offers monthly installments of 3, 6, 9 and 12 payments
        /// </summary>
        [JsonProperty("monthly_installments")]
        public int? PaymentRange { get; set; }

        /// <summary>
        /// (Optional)
        /// String containing additional information related to the order
        /// </summary>
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Status of the charge.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// (Readonly)
        /// Object class. In this case, "charge"
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; } = "charge";

        public Charge() { }

        public Charge(PaymentRange paymentRange)
        {
            PaymentRange = (int)paymentRange;
        }

        public Charge(ChargeStatus status)
        {
            Status = status.ToString().ToLower();
        }

        public Charge(PaymentRange paymentRange, ChargeStatus status)
        {
            PaymentRange = (int)paymentRange;
            Status = status.ToString().ToLower();
        }

        public class Create
        {
            /// <summary>
            /// The charge's amount, in cents
            /// </summary>
            [JsonProperty("amount")]
            public int? Amount { get; set; }

            /// <summary>
            /// Payment method of the charge
            /// </summary>
            [JsonProperty("payment_method")]
            public PaymentMethod PaymentMethod { get; set; }

            [JsonProperty("token_id")]
            public string TokenId { get; set; }
        }
    }
}