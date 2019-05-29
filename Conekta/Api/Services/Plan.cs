using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.Api
{
    public class Plan : Client
    {
        public Task<T> AllAsync<T>()
        {
            Segment = $"/plans";
            return ExecuteAsync(() =>  Request.GetJsonAsync<T>());
        }

        public Task<T> CreateAsync<T>(T data)
        {
            Segment = $"/plans";
            return ExecuteAsync(() =>  Request.PostJsonAsync(data).ReceiveJson<T>());
        }

        public Task<T> DeleteAsync<T>(string id)
        {
            Segment = $"/plans/{id}";
            return ExecuteAsync(() =>  Request.DeleteAsync().ReceiveJson<T>());
        }

        public Task<T> FindAsync<T>(string id)
        {
            Segment = $"/plans/{id}";
            return ExecuteAsync(() =>  Request.GetJsonAsync<T>());
        }

        public Task<TResult> UpdateAsync<TEntry, TResult>(string id, TEntry data)
        {
            Segment = $"/plans/{id}";
            return ExecuteAsync(() =>  Request.PutJsonAsync(data).ReceiveJson<TResult>());
        }
    }
}