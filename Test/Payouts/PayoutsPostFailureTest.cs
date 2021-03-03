using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using PayPalHttp;
using Xunit;
using PayoutsSdk.Test;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace PayoutsSdk.Payouts.Test
{
    [Collection("Payouts")]
    public class PayoutsPostTestFailureTest
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
                    Value="1.0.0",
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

            
            try {
                HttpResponse response = await TestCreatePayoutRequest();
            } catch (HttpException ex){
                String errorString = ex.Message;
                var deserializedError = new Error();
                var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(errorString));
                var deserializer = new DataContractJsonSerializer(deserializedError.GetType());
                deserializedError = deserializer.ReadObject(memoryStream) as Error;
                memoryStream.Close();
                
                Assert.NotNull(deserializedError);
                Assert.NotNull(deserializedError.DebugId);
                Assert.NotNull(deserializedError.Details);
                Assert.NotNull(deserializedError.Message);
                Assert.Equal("Invalid request - see details",deserializedError.Message);
                Assert.NotNull(deserializedError.Details[0].Field);
                Assert.NotNull(deserializedError.Details[0].Issue);
                Assert.NotNull(deserializedError.Details[0].Location);
                Assert.Equal("body", deserializedError.Details[0].Location);
                Assert.Equal("VALIDATION_ERROR", deserializedError.Name);

            }

            // Add your own checks here
        }
    }

}
