
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public enum OrderPaymentStatus
    {
        Charged_Back,
        Declined,
        Expired,
        Paid,
        Partially_Refunded,
        Pending_Payment,
        Pre_Authorized,
        Refunded,
        Voided
    }

    public class Order
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }

        [JsonProperty("charges")]
        public Pagination<Charge> Charges { get; set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer_info")]
        public OrderCustomer Customer { get; set; }

        [JsonProperty("discount_lines")]
        public Pagination<DiscountLine> DiscountLines { get; set; }

        [JsonProperty("line_items")]
        public Pagination<LineItem> LineItems { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("payment_status")]
        public string PaymentStatus { get; set; }

        [JsonProperty("shipping_contact")]
        public ShippingContact ShippingContact { get; set; }

        [JsonProperty("shipping_lines")]
        public Pagination<ShippingLine> ShippingLines { get; set; }

        [JsonProperty("tax_lines")]
        public IEnumerable<TaxLine> TaxLines { get; set; }

        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        public Order() { }

        public Order(OrderPaymentStatus paymentStatus)
        {
            PaymentStatus = paymentStatus.ToString().ToLower();
        }
    }

    public class Order<M> : Order
    {
        [JsonProperty("metadata")]
        public new M Metadata { get; set; }
    }

    public class Order<L, S, T> : Order
    {
        [JsonProperty("discount_lines")]
        public new IEnumerable<DiscountLine> DiscountLines { get; set; }

        [JsonProperty("line_items")]
        public new IEnumerable<LineItem<L>> LineItems { get; set; }

        [JsonProperty("shipping_lines")]
        public new IEnumerable<ShippingLine<S>> ShippingLines { get; set; }

        [JsonProperty("tax_lines")]
        public new IEnumerable<TaxLine<T>> TaxLines { get; set; }
    }

    public class Order<L, S, T, M> : Order<L, S, T>
    {
        [JsonProperty("metadata")]
        public new M Metadata { get; set; }
    }
}
