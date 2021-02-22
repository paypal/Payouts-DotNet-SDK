using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using PayPalHttp;
using Xunit;
using PayoutsSdk.Test;
using static PayoutsSdk.Test.TestHarness;
using System.Threading;
using System.Runtime.Serialization.Json;


namespace PayoutsSdk.Payouts.Test
{
    [Collection("Payouts")]
    public class PayoutsItemCancelTest
    {

        [Fact]
        public async void TestPayoutsItemCancelRequest()

        {   
            var response = await PayoutsPostTest.TestCreatePayoutRequest();
            CreatePayoutResponse batch = response.Result<CreatePayoutResponse>();
            PayoutsGetRequest request = new PayoutsGetRequest(batch.BatchHeader.PayoutBatchId);


            HttpResponse getResponse = await TestHarness.client().Execute(request);
            PayoutBatch batchDetails = getResponse.Result<PayoutBatch>();
            Thread.Sleep(10000);

            PayoutsItemCancelRequest cancelRequest = new PayoutsItemCancelRequest(batchDetails.Items[0].PayoutItemId);

            HttpResponse cancelResponse = await TestHarness.client().Execute(cancelRequest);
            Assert.Equal(200,(int) cancelResponse.StatusCode);
            Assert.NotNull(cancelResponse.Result<PayoutItemResponse>());

            // Add your own checks here
        }

        [Fact]
        public async void TestPayoutsItemCancelRequestFailure()

        {   
           
            PayoutsItemCancelRequest cancelRequest = new PayoutsItemCancelRequest("34234324");

            try {
                HttpResponse cancelResponse = await TestHarness.client().Execute(cancelRequest);
            } catch(Exception ex){
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
