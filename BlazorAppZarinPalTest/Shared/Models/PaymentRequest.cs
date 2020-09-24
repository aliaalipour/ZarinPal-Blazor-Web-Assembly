using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppZarinPalTest.Shared.Models
{
    public class PaymentRequest
    {

        public PaymentRequest()
        {

        }
        public PaymentRequest(string MerchantID, long Amount, string Callback_url, string Description)
        {
            this.merchant_id = MerchantID;
            this.amount = Amount;
            this.callback_url = Callback_url;
            this.description = Description;
        }

        public string merchant_id { get; set; }
        public string callback_url { get; set; }
        public string description { get; set; }
        public long amount { get; set; }

        #region اختیاری
        public string OrderId { get; set; }
        public string Url { get; set; }
        #endregion

        public DataPaymentRequest data { get; set; }
        public List<Errors> errors { get; set; }
        public Response Response { get; set; }
    }
    public class DataPaymentRequest
    {
        public int code { get; set; }
        public string Message { get; set; }
        public string authority { get; set; }
        public string fee_type { get; set; }
        public int fee { get; set; }
    }
    public class Errors
    {
        public string code { get; set; }
        public string message { get; set; }
    }
}
