using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.Api
{
    public class Token : Client
    {
        public Task<TResult> CreateAsync<TEntry, TResult>(TEntry data)
        {
            Segment = $"/tokens";
            return ExecuteAsync(() => Request.PostJsonAsync(new { card = data }).ReceiveJson<TResult>());
        }
    }
}