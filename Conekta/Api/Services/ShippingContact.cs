using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.Api
{
    public class ShippingContact : Client
    {
        public Task<T> AllAsync<T>(string customerId)
        {
            Segment = $"/customers/{customerId}/shipping_contacts";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> CreateAsync<T>(string customerId, T data)
        {
            Segment = $"/customers/{customerId}/shipping_contacts";
            return Request.PostJsonAsync(data).ReceiveJson<T>();
        }

        public Task<T> DeleteAsync<T>(string customerId, string id)
        {
            Segment = $"/customers/{customerId}/shipping_contacts/{id}";
            return Request.DeleteAsync().ReceiveJson<T>();
        }

        public Task<T> FindAsync<T>(string customerId, string id)
        {
            Segment = $"/customers/{customerId}/shipping_contacts/{id}";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> UpdateAsync<T>(string customerId, string id, T data)
        {
            Segment = $"/customers/{customerId}/shipping_contacts/{id}";
            return Request.PutJsonAsync(data).ReceiveJson<T>();
        }
    }
}