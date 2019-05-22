using System;
using Conekta;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new Conekta.Api.Configuration
            {
                Host = "https://api.conekta.io",
                Version = "2.0.0",
                Locale = "en",
                Key = "key_aLppBKzJAPLxwQuuP5WW5w"
            };
            Conekta.Api.Client.Initialize(config);
            // ord_2kguUQ6HnAx9nkkRc
            var service = new Conekta.Api.Plan();
            var plan = new Conekta.Models.Plan
            {
                Id = "gold-plan",
                Name = "gold-plan",
                Amount = 10000,
                Currency = "MXN",
                Interval = "month",
                Frequency = 1,
                TrialPeriodDays = 15,
                TotalChargesUntilExpiration = 12
            };

            //var rsult = service
            //    .UpdateAsync<Conekta.Models.Plan.Update, Conekta.Models.Plan>("gold-plan", new Conekta.Models.Plan.Update { Name = "Gol Plan 3", Amount = 10003 })
            //    .GetAwaiter().GetResult();

            var rsult = service
                .DeleteAsync<Conekta.Models.Plan>("gold-plan")
                .GetAwaiter().GetResult();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}