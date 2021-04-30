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
            Console.WriteLine("TestPayoutsPostRequest");
            Console.WriteLine(response.Headers);
            Console.WriteLine(response.Result<CreatePayoutResponse>().Headers);
            Console.WriteLine((int)response.StatusCode);
            Console.WriteLine("Status: {0}", response.Result<CreatePayoutResponse>().BatchHeader.BatchStatus);
            Console.WriteLine("Batch Id: {0}", response.Result<CreatePayoutResponse>().BatchHeader.PayoutBatchId);

            Console.WriteLine("Links:");
              foreach (LinkDescription link in response.Result<CreatePayoutResponse>().Links)
              {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
              }

            Assert.Equal(201,(int) response.StatusCode);
            Assert.NotNull(response.Result<CreatePayoutResponse>());

            // Add your own checks here
        }
    }
}
