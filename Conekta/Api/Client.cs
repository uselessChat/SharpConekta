using System;
using System.Collections.Generic;
using System.Net;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;

namespace Conekta.Api
{
    //public interface IClient
    //{
    //    //string Host { get; set; }
    //    IFlurlRequest Request { get; }
    //}

    public abstract class Client //: IClient
    {
        public static Configuration Configuration { get; private set; }

        private static UserAgent UserAgent { get; set; }

        protected string Segment { get; set; }

        //public string Host { get; set; }

        public IFlurlRequest Request
        {
            get
            {
                var bytesKey = System.Text.Encoding.UTF8.GetBytes(Configuration.Key);
                string token = System.Convert.ToBase64String(bytesKey);
                string userAgent = JsonConvert.SerializeObject(UserAgent);

                return Configuration.Host
                    .AppendPathSegment(Segment)
                    .WithHeaders(new Dictionary<string, string>
                    {
                        { "Accept", $"application/vnd.conekta-v{Configuration.Version}+json" },
                        { "Accept-Language", Configuration.Locale },
                        { "Authorization", $"Basic {token}" },
                        { "UserAgent", $"Conekta/v1 DotNetBindings10/Conekta::{Configuration.Version}" },
                        { "X-Conekta-Client-User-Agent", userAgent }
                    });
            }
        }

        public static void Initialize(Configuration configuration)
        {
            Configuration = configuration;
            UserAgent = UserAgent.Build(configuration.Version);

            FlurlHttp.Configure(settings => {
                var jsonSettings = new JsonSerializerSettings
                {
                    NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
                };
                settings.JsonSerializer = new NewtonsoftJsonSerializer(jsonSettings);
            });
        }
    }
}