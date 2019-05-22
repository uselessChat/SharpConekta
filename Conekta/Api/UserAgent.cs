using System;
using Newtonsoft.Json;

namespace Conekta.Api
{
    public class UserAgent
    {
        [JsonProperty("bindings_version")]
        public string BindingsVersion { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("lang_version")]
        public string LangVersion { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("uname")]
        public string Environment { get; set; }

        public static UserAgent Build(string apiVersion)
        {
            return new UserAgent
            {
                BindingsVersion = apiVersion,
                Lang = ".net",
                LangVersion = typeof(string).Assembly.ImageRuntimeVersion,
                Publisher = "conekta",
                Environment = $"{System.Environment.OSVersion}"
            };
        }
    }
}
