using System;
using System.IO;
using System.Text;
using PayPalHttp;
using Xunit;
using PayoutsSdk.Test;
using System.Runtime.Serialization.Json;


namespace PayoutsSdk.Payouts.Test
{
    [Collection("Payouts")]
    public class PayoutsItemGetTest
    {

        [Fact]
        public async void TestPayoutsItemGetRequest()
        {   
            var response = await PayoutsPostTest.TestCreatePayoutRequest();
            CreatePayoutResponse batch = response.Result<CreatePayoutResponse>();
            PayoutsGetRequest request = new PayoutsGetRequest(batch.BatchHeader.PayoutBatchId);


            HttpResponse getResponse = await TestHarness.client().Execute(request);
            PayoutBatch batchDetails = getResponse.Result<PayoutBatch>();

            PayoutsItemGetRequest itemGetRequest = new PayoutsItemGetRequest(batchDetails.Items[0].PayoutItemId);
            
            HttpResponse itemGetResponse = await TestHarness.client().Execute(itemGetRequest);
            Assert.Equal(200,(int) itemGetResponse.StatusCode);
            Assert.NotNull(itemGetResponse.Result<PayoutItemResponse>());

            // Add your own checks here
        }

         [Fact]
        public async void TestPayoutsItemFailureGetRequest()
        {   
        
            PayoutsItemGetRequest itemGetRequest = new PayoutsItemGetRequest("2349");
            
           try {
               HttpResponse itemGetResponse = await TestHarness.client().Execute(itemGetRequest);
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
