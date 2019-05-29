using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.Api
{
    public class Subscription : Client
    {
        public Task<T> CreateAsync<T>(string customerId, T data)
        {
            Segment = $"/customers/{customerId}/subscription";
            return ExecuteAsync(() =>  Request.PostJsonAsync(data).ReceiveJson<T>());
        }

        public Task<T> UpdateAsync<T>(string customerId, string id, T data)
        {
            Segment = $"/customers/{customerId}/subscription/{id}";
            return ExecuteAsync(() =>  Request.PutJsonAsync(data).ReceiveJson<T>());
        }

        public Task<T> PauseAsync<T>(string customerId)
        {
            Segment = $"/customers/{customerId}/subscription/pause";
            return ExecuteAsync(() =>  Request.PostJsonAsync(null).ReceiveJson<T>());
        }

        public Task<T> ResumeAsync<T>(string customerId)
        {
            Segment = $"/customers/{customerId}/subscription/resume";
            return ExecuteAsync(() =>  Request.PostJsonAsync(null).ReceiveJson<T>());
        }

        public Task<T> CancelAsync<T>(string customerId)
        {
            Segment = $"/customers/{customerId}/subscription/cancel";
            return ExecuteAsync(() =>  Request.PostJsonAsync(null).ReceiveJson<T>());
        }
    }
}