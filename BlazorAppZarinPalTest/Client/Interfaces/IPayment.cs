using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppZarinPalTest.Shared.Models;

namespace BlazorAppZarinPalTest.Client.Interfaces
{
   public interface IPayment
    {
        public Task<PaymentRequest> PaymentRequestAsync(PaymentRequest model);
        public Task<PaymentVerification> PaymentVerificationAsync(PaymentVerification model);
    }
}
