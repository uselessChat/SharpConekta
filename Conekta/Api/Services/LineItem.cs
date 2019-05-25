using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.Api
{
    public class LineItem : Client
    {
        public Task<T> AllAsync<T>(string orderId)
        {
            Segment = $"/orders/{orderId}/line_items";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> CreateAsync<T>(string orderId, T data)
        {
            Segment = $"/orders/{orderId}/line_items";
            return Request.PostJsonAsync(data).ReceiveJson<T>();
        }

        public Task<T> DeleteAsync<T>(string orderId, string id)
        {
            Segment = $"/orders/{orderId}/line_items/{id}";
            return Request.DeleteAsync().ReceiveJson<T>();
        }

        public Task<T> FindAsync<T>(string orderId, string id)
        {
            Segment = $"/orders/{orderId}/line_items/{id}";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> UpdateAsync<T>(string orderId, string id, T data)
        {
            Segment = $"/orders/{orderId}/line_items/{id}";
            return Request.PutJsonAsync(data).ReceiveJson<T>();
        }
    }
}