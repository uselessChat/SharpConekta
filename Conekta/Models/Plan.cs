using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    public class Plan
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiry_count")]
        public int TotalChargesUntilExpiration { get; set; }

        [JsonProperty("trial_period_days")]
        public int TrialPeriodDays { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
