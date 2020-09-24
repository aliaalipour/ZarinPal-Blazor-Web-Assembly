### ZarinPal Blazor WebAssembly

### ZarinPal Rest Api And Connet To Blazor WebAssembly

### install packages in Shared Project
	Microsoft.AspNetCore.WebUtilities
	Newtonsoft.Json
	RestSharp

### PaymentRequestAsync
	[HttpPost]
        [Route("PaymentRequestAsync")]
        public async Task<PaymentRequest> PaymentRequestAsync(PaymentRequest model)
        {
            try
            {
                await Task.Delay(100);
                #region Rest Api Request
                var urlStartPay = "https://www.zarinpal.com/pg/StartPay/";

                var client = new RestClient("https://api.zarinpal.com/pg/v4/payment/request.json");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");


                PaymentRequest pr = new PaymentRequest();
                pr.merchant_id = merchant_id;
                pr.amount = model.amount * 10;
                pr.callback_url = "https://localhost:44329/verify/" + model.OrderId;
                pr.description = "توضیحات";


                var serializedData = JsonConvert.SerializeObject(pr);
                request.AddParameter("application/json", serializedData, ParameterType.RequestBody);
                var response = client.Execute(request);
                var deserializeData = JsonConvert.DeserializeObject<PaymentRequest>(response.Content);
                if (deserializeData.data.code == 100)
                {
                    return new PaymentRequest()
                    {
                        Response = new Response(1, "Success For Payment"),
                        Url = urlStartPay + deserializeData.data.authority
                    };
                }
                #endregion


                return new PaymentRequest() { Response = new Response(-1, "عملیات با موفقیت انجام نشد، دوباره تلاش کنید") };
            }
            catch (Exception ex)
            {
                return new PaymentRequest() { Response = new Response(-1, ex.Message) };
            }
        }

### PaymentVerificationAsync
	[HttpPost]
        [Route("PaymentVerificationAsync")]
        public async Task<PaymentVerification> PaymentVerificationAsync(PaymentVerification model)
        {
            try
            {
                await Task.Delay(100);
                #region Rest Api Request

                var client = new RestClient("https://api.zarinpal.com/pg/v4/payment/verify.json");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");


                PaymentVerification pv = new PaymentVerification();
                pv.merchant_id = merchant_id;
                pv.authority = model.authority;
                pv.amount = Convert.ToInt32(model.amount * 10);


                var serializedData = JsonConvert.SerializeObject(pv);
                request.AddParameter("application/json", serializedData, ParameterType.RequestBody);
                var response = client.Execute(request);
                var deserializeData = JsonConvert.DeserializeObject<PaymentVerification>(response.Content);
                if (deserializeData.data.code == 100)
                {
                    //_ctx ==> DatabaseContext

                    // اگر پایگاه داده وجود داشته باشد باید شماره محصول را از جدول مورد نظر پیدا کنی و 
                    //کد رهگیری را در این  قسمت  قرار بدی
                    //   var order = await _ctx.Orders.Where(ord => ord.ID == model.orderid).FirstOrDefaultAsync();
                    //order.CodePeygiri = deserializeData.data.ref_id.ToString();
                    //_ctx.Orders.Update(order);
                    //_ctx.SaveChanges() > 0

                    return new PaymentVerification()
                    {
                        Response = new Response(1, "پرداخت با موفقیت انجام شد"),
                        data=deserializeData.data
                    };
                }
                #endregion
                return new PaymentVerification() { Response = new Response(-1, "عملیات با موفقیت انجام نشد، دوباره تلاش کنید") };
            }
            catch (Exception ex)
            {
                return new PaymentVerification() { Response = new Response(-1, ex.Message) };
            }
        }

