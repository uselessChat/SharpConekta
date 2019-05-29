
using System;
using System.Collections.Generic;
using Conekta.Enums;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class Order
    {
        /// <summary>
        /// Unique identifier assigned at random.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Amount calculated based on [:line_items, :shipping_lines, :tax_lines, :discount_lines]
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// Amount refunded
        /// </summary>
        [JsonProperty("amount_refunded")]
        public int? AmountRefunded { get; set; }

        [JsonProperty("charges")]
        public Pagination<Charge> Charges { get; set; }

        /// <summary>
        /// Date when the order was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Currency of the charge. A 3-letter code of the International Standard ISO 4217
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer_info")]
        public OrderCustomer Customer { get; set; }

        /// <summary>
        /// (Optional)
        /// List of the discounts applied to the order.
        /// </summary>
        [JsonProperty("discount_lines")]
        public Pagination<DiscountLine> DiscountLines { get; set; }

        /// <summary>
        /// List of the products (line items) being sold in the order. It must contain at least one product.
        /// </summary>
        [JsonProperty("line_items")]
        public Pagination<LineItem> LineItems { get; set; }

        /// <summary>
        /// false: Sandbox Mode. true: Production Mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// (Optional)
        /// Hash containing additional information related to the order.
        /// </summary>
        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// (Readonly)
        /// Object class. In this case, "order".
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; } = "order";

        [JsonProperty("payment_status")]
        public string PaymentStatus { get; set; }

        /// <summary>
        /// Shipping details, mandatory when a shipping_line is included in the order.
        /// If the order is sent without a shipping_contact, the customer's default shipping_contact will be used.
        /// </summary>
        [JsonProperty("shipping_contact")]
        public ShippingContact ShippingContact { get; set; }

        /// <summary>
        /// (Optional by condition)
        /// List of shipping costs. If the online store offers digital products this parameter is optional.
        /// </summary>
        [JsonProperty("shipping_lines")]
        public Pagination<ShippingLine> ShippingLines { get; set; }

        /// <summary>
        /// (Optional)
        /// List of the taxes.
        /// </summary>
        [JsonProperty("tax_lines")]
        public Pagination<TaxLine> TaxLines { get; set; }

        /// <summary>
        /// Date when the order was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }

        public Order() { }

        public Order(OrderPaymentStatus paymentStatus)
        {
            PaymentStatus = paymentStatus.ToString();
        }

        public class Refund
        {
            /// <summary>
            /// Order's id.
            /// </summary>
            [JsonProperty("id")]
            public string Id { get; set; }

            /// <summary>
            /// (Optional)
            /// If you want to partially refund and order.
            /// </summary>
            [JsonProperty("amount")]
            public string Amount { get; set; }

            /// <summary>
            /// Reason for refund.
            /// </summary>
            [JsonProperty("reason")]
            public string Reason { get; set; }

            public Refund(OrderRefundReason reason)
            {
                Reason = reason.ToString();
            }
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
