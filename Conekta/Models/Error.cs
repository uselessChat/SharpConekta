using Conekta.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta.Models
{
    public class ConektaException : Exception
    {
        public Event Event { get; set; }

        public int HttpStatusCode => (int)(Event?.Type ?? default(ErrorType));
    }

    public class ErrorDetail
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("debug_message")]
        public string DebugMessage { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("params")]
        public string Params { get; set; }
    }

    public class Event
    {
        [JsonProperty("details")]
        public IEnumerable<ErrorDetail> Details { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("type")]
        public ErrorType Type { get; set; }

        [JsonProperty("log_id")]
        public string LogId { get; set; }
    }
}