using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using PayPalHttp;
using Xunit;
using PayoutsSdk.Test;
using System.Threading.Tasks;
using static PayoutsSdk.Test.TestHarness;
using PayoutsSdk.Payouts;
using PayoutsSdk.Core;

namespace PayoutsSdk.Payouts.Test
{
    [Collection("Payouts")]
    public class PayoutsPostTest
    {
        public static CreatePayoutRequest buildRequestBody()
        {
            var request = new CreatePayoutRequest(){

            SenderBatchHeader = new SenderBatchHeader(){
                    EmailMessage = "Congrats on recieving 1$",
                    EmailSubject="You recieved a payout!!"
                },
           Items = new List<PayoutItem>(){
            new PayoutItem(){
                RecipientType="EMAIL",
            
                Amount=new Currency(){
                    CurrencyCode="USD",
                    Value="1",
                 },   
                Receiver="payouts-simulator23@paypal.com",

            }
            }
        };
        return request;
        }
        public static async Task<HttpResponse> TestCreatePayoutRequest(){
            PayoutsPostRequest request = new PayoutsPostRequest();
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            return response;
        }
        [Fact]
        public async void TestPayoutsPostRequest()
        {

            HttpResponse response = await TestCreatePayoutRequest();
            System.out.println("TestPayoutsPostRequest");
            System.out.println((int)response.StatusCode);
            System.out.println(response.Result<CreatePayoutResponse>());

            Assert.Equal(201,(int) response.StatusCode);
            Assert.NotNull(response.Result<CreatePayoutResponse>());

            // Add your own checks here
        }
    }
}
