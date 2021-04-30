using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using PayPalHttp;
using Xunit;
using PayoutsSdk.Test;
using static PayoutsSdk.Test.TestHarness;
using PayoutsSdk.Core;
using PayoutsSdk.Payouts;
using System.Runtime.Serialization.Json;

namespace PayoutsSdk.Payouts.Test
{
    [Collection("Payouts")]
    public class PayoutsGetTest
    {

        [Fact]
        public async void TestPayoutsGetRequest()
        {

            var response = await PayoutsPostTest.TestCreatePayoutRequest();
            CreatePayoutResponse batch = response.Result<CreatePayoutResponse>();
            PayoutsGetRequest request = new PayoutsGetRequest(batch.BatchHeader.PayoutBatchId)
                .Page(4)
                .PageSize(2)
                .TotalRequired(true);

            HttpResponse getResponse = await TestHarness.client().Execute(request);

            Console.WriteLine("TestPayoutsGetRequest");
            Console.WriteLine(getResponse.Headers);
            Console.WriteLine((int)getResponse.StatusCode);
          Console.WriteLine("Status: {0}", getResponse.Result<PayoutBatch>().BatchHeader.BatchStatus);
          Console.WriteLine("Item: {0}", getResponse.Result<PayoutBatch>().Items[0].PayoutItemId);
          Console.WriteLine("Batch Id: {0}", getResponse.Result<PayoutBatch>().BatchHeader.PayoutBatchId);

            Console.WriteLine("Links:");
              foreach (LinkDescription link in getResponse.Result<PayoutBatch>().Links)
              {
                Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
              }

            Assert.Equal(200,(int) getResponse.StatusCode);
            Assert.NotNull(getResponse.Result<PayoutBatch>());

            // Add your own checks here
        }

        [Fact]
        public async void TestPayoutsGetFailureRequest()
        {

            PayoutsGetRequest request = new PayoutsGetRequest("123")
                .Page(4)
                .PageSize(2)
                .TotalRequired(true);

            
            try {
                HttpResponse getResponse = await TestHarness.client().Execute(request);
            } catch(HttpException ex){
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
                Assert.Equal("The requested resource ID was not found",deserializedError.Message);
                Assert.Equal("INVALID_RESOURCE_ID", deserializedError.Name);
            }
        }
    }
}
