using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class Customer
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("corporate")]
        public bool Corporate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("payment_sources")]
        public Pagination<PaymentSource> PaymentSources { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("shipping_contacts")]
        public Pagination<ShippingContact> ShippingContacts { get; set; }

        [JsonProperty("subscriptions")]
        public IEnumerable<Subscription> Subscriptions { get; set; }
    }
}