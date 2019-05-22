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

    public class Subscription
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("canceled_at")]
        public string CanceledAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("paused_at")]
        public string PausedAt { get; set; }

        [JsonProperty("billing_cycle_end")]
        public long BillingCycleEndAt { get; set; }

        [JsonProperty("billing_cycle_start")]
        public long BillingCycleStartAt { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("trial_end")]
        public long TrialEndAt { get; set; }

        [JsonProperty("trial_start")]
        public long TrialStartAt { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        public Subscription() { }

        public Subscription(SubscriptionStatus status)
        {
            Status = status.ToString().ToLower();
        }
    }
}