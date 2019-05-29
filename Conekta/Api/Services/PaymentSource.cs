using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.Api
{
    public class PaymentSource : Client
    {
        public Task<T> All<T>(string orderId)
        {
            Segment = $"/customers/{orderId}/payment_sources";
            return ExecuteAsync(() => Request.GetJsonAsync<T>());
        }

        public Task<T> CreateAsync<T>(string orderId, T data)
        {
            Segment = $"/customers/{orderId}/payment_sources";
            return ExecuteAsync(() => Request.PostJsonAsync(data).ReceiveJson<T>());
        }

        public Task<T> DeleteAsync<T>(string orderId, string id)
        {
            Segment = $"/customers/{orderId}/payment_sources/{id}";
            return ExecuteAsync(() => Request.DeleteAsync().ReceiveJson<T>());
        }

        public Task<T> FindAsync<T>(string orderId, string id)
        {
            Segment = $"/customers/{orderId}/payment_sources/{id}";
            return ExecuteAsync(() => Request.GetJsonAsync<T>());
        }

        public Task<T> UpdateAsync<T>(string orderId, string id, T data)
        {
            Segment = $"/customers/{orderId}/payment_sources/{id}";
            return ExecuteAsync(() => Request.PutJsonAsync(data).ReceiveJson<T>());
        }
    }
}