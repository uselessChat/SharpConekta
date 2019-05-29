using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.Api
{
    public class Charge : Client
    {
        public Task<T> AllAsync<T>(string orderId)
        {
            Segment = $"/orders/{orderId}/charges";
            return ExecuteAsync(() => Request.GetJsonAsync<T>());
        }

        public Task<T> CreateAsync<T>(string orderId, T data)
        {
            Segment = $"/orders/{orderId}/charges";
            return ExecuteAsync(() => Request.PostJsonAsync(data).ReceiveJson<T>());
        }

        public Task<T> FindAsync<T>(string orderId, string id)
        {
            Segment = $"/orders/{orderId}/charges/{id}";
            return ExecuteAsync(() => Request.GetJsonAsync<T>());
        }
    }
}