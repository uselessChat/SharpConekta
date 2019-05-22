using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Models
{
    public class Card
    {
        [JsonProperty("device_fingerprint")]
        public string DeviceFingerprint { get; set; }

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
        /// Name of the card holder
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Number of card
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Card Verification Code
        /// </summary>
        [JsonProperty("cvc")]
        public string VerificationCode { get; set; }
    }
}
