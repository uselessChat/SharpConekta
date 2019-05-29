using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.Api.Services
{
    public class TaxLine : Client
    {
        public Task<T> AllAsync<T>(string orderId)
        {
            Segment = $"/orders/{orderId}/tax_lines";
            return ExecuteAsync(() =>  Request.GetJsonAsync<T>());
        }

        public Task<T> CreateAsync<T>(string orderId, T data)
        {
            Segment = $"/orders/{orderId}/tax_lines";
            return ExecuteAsync(() =>  Request.PostJsonAsync(data).ReceiveJson<T>());
        }

        public Task<T> DeleteAsync<T>(string orderId, string id)
        {
            Segment = $"/orders/{orderId}/tax_lines/{id}";
            return ExecuteAsync(() =>  Request.DeleteAsync().ReceiveJson<T>());
        }

        public Task<T> FindAsync<T>(string orderId, string id)
        {
            Segment = $"/orders/{orderId}/tax_lines/{id}";
            return ExecuteAsync(() =>  Request.GetJsonAsync<T>());
        }

        public Task<T> UpdateAsync<T>(string orderId, string id, T data)
        {
            Segment = $"/orders/{orderId}/tax_lines/{id}";
            return ExecuteAsync(() =>  Request.PutJsonAsync(data).ReceiveJson<T>());
        }
    }
}