using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.Api
{
    public class Customer : Client
    {
        public Task<T> AllAsync<T>()
        {
            Segment = $"/customers";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> CreateAsync<T>(T data)
        {
            Segment = $"/customers";
            return Request.PostJsonAsync(data).ReceiveJson<T>();
        }

        public Task<T> DeleteAsync<T>(string id)
        {
            Segment = $"/customers/{id}";
            return Request.DeleteAsync().ReceiveJson<T>();
        }

        public Task<T> FindAsync<T>(string id)
        {
            Segment = $"/customers/{id}";
            return Request.GetJsonAsync<T>();
        }

        public Task<TResult> UpdateAsync<TEntry, TResult>(string id, TEntry data)
        {
            Segment = $"/customers/{id}";
            return Request.PutJsonAsync(data).ReceiveJson<TResult>();
        }

        public Task<T> FiscalEntitiesAsync<T>(string id)
        {
            Segment = $"/customers/{id}/fiscal_entities";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> PaymentSourcesAsync<T>(string id)
        {
            Segment = $"/customers/{id}/payment_sources";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> ShippingContactsAsync<T>(string id)
        {
            Segment = $"/customers/{id}/shipping_contacts";
            return Request.GetJsonAsync<T>();
        }
    }
}