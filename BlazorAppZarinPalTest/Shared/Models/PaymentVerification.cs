using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppZarinPalTest.Shared.Models
{
    public class PaymentVerification
    {

        public PaymentVerification()
        {

        }
        public PaymentVerification(string MerchantID, long Amount, string Authority)
        {
            this.merchant_id = MerchantID;
            this.amount = Amount;
            this.authority = Authority;
        }

        public PaymentVerification(Response response)
        {
            Response = response;
        }

        public string merchant_id { set; get; }
        public long amount { set; get; }
        public string authority { set; get; }

        public Response Response { get; set; }
        public DataPaymentVerification data { get; set; }
        public List<Errors> errors { get; set; }

        public string OrderId { get; set; }

    }

    public class DataPaymentVerification
    {
        public int code { get; set; }
        public string message { get; set; }
        public string card_hash { get; set; }
        public string card_pan { get; set; }
        public long ref_id { get; set; }
        public string fee_type { get; set; }
        public int fee { get; set; }
    }
}
