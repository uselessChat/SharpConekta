using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
    /// <summary>
    /// Plans are templates for subscriptions.
    /// They allow you to define the amount and frequency with which you would like to bill your clients
    /// </summary>
    public class Plan
    {
        /// <summary>
        /// (Optional)
        /// Unique plan identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Charge's amount in cents
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Timestamp of plan's creation
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Currency of the charge. A 3-letter code of the International Standard ISO 4217
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// (Optional)
        /// The frequency for the charge.
        /// For example, to charge a customer every 2 months, set the interval attribute to month and the frequency to 2.
        /// </summary>
        [JsonProperty("frequency")]
        public int? Frequency { get; set; }

        /// <summary>
        /// (Optional)
        /// The interval for the charge.
        /// For example, to charge a customer every 2 months, set the interval attribute to month and the frequency to 2.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// false: test mode. true: production mode
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Plan's name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// (Readonly)
        /// Object class. For this object "plan"
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; } = "plan";

        /// <summary>
        /// Number of charges that will be made before the subscription expires
        /// </summary>
        [JsonProperty("expiry_count")]
        public int? TotalChargesUntilExpiration { get; set; }

        /// <summary>
        /// Days of the trial's duration
        /// </summary>
        [JsonProperty("trial_period_days")]
        public int? TrialPeriodDays { get; set; }

        public class Update
        {
            [JsonProperty("amount")]
            public int Amount { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}
