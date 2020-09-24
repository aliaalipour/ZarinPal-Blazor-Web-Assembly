using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppZarinPalTest.Client.Interfaces;
using BlazorAppZarinPalTest.Shared.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace BlazorAppZarinPalTest.Client.Services
{
    public class PaymentRequestService : IPayment
    {
        public HttpClient _httpClient { get; }
        public PaymentRequestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<PaymentRequest> PaymentRequestAsync(PaymentRequest model)
        {
            try
            {
                string serializedUser = JsonConvert.SerializeObject(model);
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, "Home/PaymentRequestAsync");
                requestMessage.Content = new StringContent(serializedUser);
                requestMessage.Content.Headers.ContentType
                    = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var response = await _httpClient.SendAsync(requestMessage);
                var responseStatusCode = response.StatusCode;
                var responseBody = await response.Content.ReadAsStringAsync();

                var returnedUser = JsonConvert.DeserializeObject<PaymentRequest>(responseBody);

                return returnedUser;
            }
            catch (Exception ex)
            {
                return new PaymentRequest() { Response = new Response(-1, ex.Message) };
            }
        }

        public async Task<PaymentVerification> PaymentVerificationAsync(PaymentVerification model)
        {
            try
            {
                string serializedUser = JsonConvert.SerializeObject(model);
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, "Home/PaymentVerificationAsync");
                requestMessage.Content = new StringContent(serializedUser);
                requestMessage.Content.Headers.ContentType
                    = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var response = await _httpClient.SendAsync(requestMessage);
                var responseStatusCode = response.StatusCode;
                var responseBody = await response.Content.ReadAsStringAsync();

                var returnedUser = JsonConvert.DeserializeObject<PaymentVerification>(responseBody);

                return returnedUser;
            }
            catch (Exception ex)
            {
                return new PaymentVerification() { Response = new Response(-1, ex.Message) };
            }
        }
    }
}
