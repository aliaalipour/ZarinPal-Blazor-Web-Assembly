### ZarinPal Blazor WebAssembly
### PaymentRequest

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
Code Blocks (Preformatted text):

    | First Header  | Second Header |
    | ------------- | ------------- |
    | Content Cell  | Content Cell  |
    | Content Cell  | Content Cell  |

