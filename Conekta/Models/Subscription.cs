using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public enum SubscriptionStatus
    {
        Active,
        Canceled,
        In_Trial,
        Past_Due,
        Paused
    };

    /// <summary>
    /// Subscriptions bill your client a fixed amount on a recurring basis.
    /// You can change the plan of a subscription, pause, cancel and resume a subscription as you wish.
    /// </summary>
    public class Subscription
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Date of the billing cycle end
        /// </summary>
        [JsonProperty("billing_cycle_end")]
        public long? BillingCycleEndAt { get; set; }

        /// <summary>
        /// Date of the billing cycle start
        /// </summary>
        [JsonProperty("billing_cycle_start")]
        public long? BillingCycleStartAt { get; set; }

        /// <summary>
        /// Date of the subscription cancelation
        /// </summary>
        [JsonProperty("canceled_at")]
        public string CanceledAt { get; set; }

        [JsonProperty("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// Date of the subscription creation
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Date of the subscription pause
        /// </summary>
        [JsonProperty("paused_at")]
        public string PausedAt { get; set; }

        /// <summary>
        /// Id of the plan assigned to the subscription
        /// </summary>
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// Status of the subscription.
        /// Allowed values: [:in_trial, :active, :past_due, :paused, :canceled]
        /// Use constructor when needed
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subscription_start")]
        public long? SubscriptionStartAt { get; set; }

        /// <summary>
        /// Date of the trial end
        /// </summary>
        [JsonProperty("trial_end")]
        public long? TrialEndAt { get; set; }

        /// <summary>
        /// Date of the trial start
        /// </summary>
        [JsonProperty("trial_start")]
        public long? TrialStartAt { get; set; }

        /// <summary>
        /// Object class. For this model, "subscription".
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; } = "subscription";

        public Subscription() { }

        public Subscription(SubscriptionStatus status)
        {
            Status = status.ToString().ToLower();
        }

        public class Create
        {
            /// <summary>
            /// Id of the plan that will be used to create the subscriptio
            /// </summary>
            [JsonProperty("plan")]
            public string PlanId { get; set; }

            /// <summary>
            /// Id of the card that will be used to process the subscription in case
            /// it's different than the primary card.
            /// The card must already be registered in the customer's cards.
            /// </summary>
            [JsonProperty("card")]
            public string CardId { get; set; }
        }

        public class Update : Create { }
    }
}