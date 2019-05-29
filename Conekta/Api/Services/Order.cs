using System;
using System.Threading.Tasks;
using Flurl.Http;

namespace Conekta.Api
{
    public class Order : Client
    {
        public Task<T> AllAsync<T>(string id)
        {
            Segment = $"/orders/{id}/";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> FindAsync<T>(string id)
        {
            Segment = $"/orders/{id}";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> CaptureAsync<T>(string id)
        {
            // TODO:
            // * FIX Segment, /capture
            // * FIX Method
            Segment = $"/orders/{id}";
            return Request.PostAsync(null).ReceiveJson<T>();
        }

        public Task<T> ChargesAsync<T>(string id)
        {
            Segment = $"/orders/{id}/charges";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> DiscountLinesAsync<T>(string id)
        {
            Segment = $"/orders/{id}/discount_lines";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> LineItemsAsync<T>(string id)
        {
            Segment = $"/orders/{id}/line_items";
            return Request.GetJsonAsync<T>();
        }

        //orders/:order_id/refund
        public Task<T> RefaundAsync<T>(string id)
        {
            // TODO:
            // * FIX Method
            Segment = $"/orders/{id}/refund";
            return Request.PostAsync(null).ReceiveJson<T>();
        }

        public Task<T> ShippingLinesAsync<T>(string id)
        {
            Segment = $"/orders/{id}/shipping_lines";
            return Request.GetJsonAsync<T>();
        }

        public Task<T> TaxLinesAsync<T>(string id)
        {
            Segment = $"/orders/{id}/tax_lines";
            return Request.GetJsonAsync<T>();
        }
    }
}