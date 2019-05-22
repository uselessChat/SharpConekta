using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public enum ChargeStatus
    {
        Pending_Payment
    }

    public enum PaymentRange
    {
        For3Months = 3,
        For6Months = 6,
        For9Months = 9,
        For12Months = 12
    }

    public class Charge
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("fee")]
        public int Fee { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        [JsonProperty("monthly_installments")]
        public int PaymentRange { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        public Charge() { }

        public Charge(PaymentRange paymentRange)
        {
            PaymentRange = (int)paymentRange;
        }

        public Charge(ChargeStatus status)
        {
            Status = ((int)status).ToString();
        }

        public Charge(PaymentRange paymentRange, ChargeStatus status)
        {
            PaymentRange = (int)paymentRange;
            Status = ((int)status).ToString();
        }
    }
}