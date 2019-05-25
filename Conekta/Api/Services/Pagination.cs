using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conekta.Api
{
    public class Pagination : Client
    {
        public Task<T> SearchPage<T>(string url)
        {
            return url.WithHeaders(Headers).GetJsonAsync<T>();
        }
    }
}