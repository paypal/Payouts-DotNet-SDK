using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using PayPalHttp;
using Xunit;
using PayoutsSdk.Test;
using static PayoutsSdk.Test.TestHarness;


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
    }
}
